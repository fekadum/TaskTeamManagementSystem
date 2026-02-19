using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WorkFlowPro.Domain.Entities;

namespace WorkFlowPro.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<TaskItem> TaskItems { get; set; }
}