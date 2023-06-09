using Microsoft.EntityFrameworkCore;
using BarApi.Models;
using System.Text.Json.Serialization;
using NetCoreTestInnovar.DataService;
using NetCoreTestInnovar.BusinessService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("connection_sql"))
);

builder.Services.AddTransient<StudentDataService>();
builder.Services.AddTransient<ScoreDataService>();
builder.Services.AddTransient<CourseDataService>();
builder.Services.AddTransient<StudentBusinessService>();
builder.Services.AddTransient<ScoreBusinessService>();
builder.Services.AddTransient<CourseBusinessService>();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);




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
