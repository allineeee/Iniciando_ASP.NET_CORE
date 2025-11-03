using DemoVS;
// Configuração Builder

var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline

//Middlewares
//Services

//Configuração da App

var app = builder.Build();

app.UseMiddleware<LogTempoMiddleware>();


// Configuração de comportamentos da App

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Isso é um teste";
});

app.Run();
