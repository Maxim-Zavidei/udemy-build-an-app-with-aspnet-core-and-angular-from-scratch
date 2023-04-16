using App.Dating.WebApi.Data;
using App.Dating.WebApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Dating.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataDbContext dataDbContext;

    public UsersController(DataDbContext dataDbContext)
    {
        this.dataDbContext = dataDbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        var users = await dataDbContext.Users.ToListAsync();
        return users;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        return await dataDbContext.Users.FindAsync(id);
    }
}
