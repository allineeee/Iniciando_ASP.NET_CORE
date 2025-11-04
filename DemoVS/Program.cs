//Importa o namespace do projeto, onde está o middleware personalizado (LogTempoMiddleware)
using DemoVS;


/* Configuração Builder */

// Cria o "builder", que é o objeto de configuração principal da aplicação.
// Ele carrega configurações (appsettings.json), registra serviços e middlewares.
var builder = WebApplication.CreateBuilder(args);


/* Configuração do Pipeline e Serviços */

//Adiciona o Serilog, um sistema de logging para registrar eventos e requisições no console ou em arquivo.
builder.AddSerilog();

// Adiciona suporte ao padrão MVC (Model-View-Controller).
// Mesmo que você ainda não tenha controllers, isso registra os serviços necessários
// para usar controllers e views futuramente.
builder.Services.AddControllersWithViews();


/* Configuração da Aplicação */

// Cria (constrói) a aplicação ASP.NET Core final, pronta para configurar os middlewares e endpoints.
var app = builder.Build();


/* MIDDLEWARES PERSONALIZADOS */

// Forma 1: usando método de extensão
app.UseLogTempo();
// Adiciona um middleware customizado que mede o tempo de execução de cada requisição.
// Esse método é uma extensão que internamente chama UseMiddleware<LogTempoMiddleware>().

// Forma 2: diretamente com UseMiddleware<>
app.UseMiddleware<LogTempoMiddleware>();
// Faz a mesma coisa que a linha acima, mas de forma explícita.
// Ambas as linhas adicionam o middleware LogTempoMiddleware ao pipeline.


/* Configuração de comportamentos da App endpoints (rotas HTTP) */

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Isso é um teste";
});


/* execução final */

// Inicia o servidor web Kestrel.
// A partir daqui, o app começa a escutar requisições HTTP.
// Fluxo completo:
// Request -> LogTempoMiddleware -> Endpoint ("/" ou "/teste") -> Response -> Middleware registra tempo
app.Run();






