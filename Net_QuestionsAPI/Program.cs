using Microsoft.EntityFrameworkCore;
using Questions_NET.DataAccess;
using Questions_NET.DataAccess.Repository.IRepository;
using Questions_NET.DataAccess.Repository;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins("https://silksharp.com") 
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials();
        });
});
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


app.UseHttpsRedirection();
app.UseCors("AllowReactApp");
app.UseAuthorization();

app.MapControllers();
 app.Run();
