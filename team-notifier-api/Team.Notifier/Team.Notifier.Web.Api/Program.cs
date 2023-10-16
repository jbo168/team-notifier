using Microsoft.EntityFrameworkCore;
using Team.Notifier.Core;
using Team.Notifier.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITeamService, TeamService>();
builder.Services.AddTransient<ITeamRepository, TeamRepository>();
builder.Services.AddDbContextPool<TeamNotifierDbContext>(d => 
    d.UseSqlServer("Server=localhost\\sql2014;Database=TeamNotifier;Trusted_Connection=True;TrustServerCertificate=true;Encrypt=False;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();