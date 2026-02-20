using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlowPro.Application.ModelsDTO;
using WorkFlowPro.Domain.Entities;
using WorkFlowPro.Infrastructure.Persistence;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkFlowPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskDto dto)
        {
            var task = new WorkTask
            {
                Title = dto.Title,
                Description = dto.Description,
                UserId = dto.UserId
            };

            _context.WorkTasks.Add(task);
            await _context.SaveChangesAsync();

            return Ok(task);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _context.WorkTasks
                .Include(t => t.User)
                .ToListAsync();

            return Ok(tasks);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateTaskDto dto)
        {
            var task = await _context.WorkTasks.FindAsync(id);
            if (task == null) return NotFound();

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.Status = dto.Status;

            await _context.SaveChangesAsync();
            return Ok(task);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.WorkTasks.FindAsync(id);
            if (task == null) return NotFound();

            _context.WorkTasks.Remove(task);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
