var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("", () => "Hello World!");
app.MapGet("/hello/{name}", (string name) => $"Hello {name}!");

app.UseHttpsRedirection();

app.Run();
