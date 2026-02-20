const API_BASE = "https://localhost:7063/api";

export const login = async (email: string, password: string) => {
  const response = await fetch(`${API_BASE}/Auth/login`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify({ email, password })
  });

  if (!response.ok) {
    throw new Error("Login failed");
  }

  return response.json();
};

export const getProtectedData = async () => {
  const token = localStorage.getItem("token");

  const response = await fetch(`${API_BASE}/Auth/protected`, {
    headers: {
      Authorization: `Bearer ${token}`
    }
  });

  if (!response.ok) {
    throw new Error("Unauthorized");
  }

  return response.json();
};