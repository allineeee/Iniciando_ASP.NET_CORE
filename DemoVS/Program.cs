using DemoVS;


// Configuração Builder

var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline

builder.AddSerilog();
builder.Services.AddControllersWithViews();

//Middlewares
//Services

//Configuração da App

var app = builder.Build();

app.UseLogTempo();

app.UseMiddleware<LogTempoMiddleware>();


// Configuração de comportamentos da App

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Isso é um teste";
});

app.Run();
