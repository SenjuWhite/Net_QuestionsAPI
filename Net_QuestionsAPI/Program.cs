using Microsoft.EntityFrameworkCore;
using Questions_NET.DataAccess;
using Questions_NET.DataAccess.Repository.IRepository;
using Questions_NET.DataAccess.Repository;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("SQLAZURECONNSTR_connectionString") ?? throw new InvalidOperationException("Connection string 'SQLAZURECONNSTR_connectionString' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Configuration.AddEnvironmentVariables();
var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
Console.WriteLine("test");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
 app.Run();
