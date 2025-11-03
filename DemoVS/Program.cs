// Configuração Builder

var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline

//Middlewares
//Services

//Configuração da App

var app = builder.Build();

// Configuração de comportamentos da App

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Isso é um teste");

app.Run();
