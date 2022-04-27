using DotNetPocAPI;
using DotNetPocModels.Models;

var builder = WebApplication.CreateBuilder(args);

//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ElementDatabaseSettings>(
    builder.Configuration.GetSection("ElementDatabase"));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.RegisterServices();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
