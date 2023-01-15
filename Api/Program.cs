using Application.Services;
using Infrastructure;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

string origins = "_origins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: origins,
                      policy  =>
                      {
                          policy
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowAnyOrigin();
                      });
});

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/health");

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(origins);

app.MapControllers();

app.Run();
