using Dashboard_webAPI.Core.Interfaces;
using Dashboard_webAPI.Core.Models;
using Dashboard_webAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DashboardContext>(options =>
{

    options.UseSqlServer("Server=PEDRO-DESKTOP;Database=DASHBOARD_API;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();



var app = builder.Build();

// Configure the HTTP request pipelinif (app.Environment.IsDevelopment())
{
    //app.UseCors();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseCors(x=>x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

app.Run();
