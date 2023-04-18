using App.Dating.WebApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();
app.UseCors(builder =>
    builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200")
);

app.MapControllers();

app.Run();
