# Iniciando ASP.NET CORE

## Teoria

- .NET -> plataforma de desenvolvimento, e é multiplataforma
- Pode desenvolver aplicações para: Web, Mobile, Desktop, Microsserviços, Cloud, M.L, Games, IoT
- ASP.NET é um componente do .NET usado para desenvolver apps e páginas Web.
- ASP.NET 7M de requisições/seg. Plataforma web mais rápida.
- open-source
- O ASP.NET entrega diversos tipos de aplicação Web atendendo todas as necessidades.
- ASP (Active Server Pages) -> 1996
- APP.NET CORE -> subistituiu o ASP.NET Framework (rodava só em windows). É possível criar APIs, sites, SPAs, Blazor apps e microsserviços
- TFM (Target Framework Moniker) indica qual versão do .NET o projeto está usando


## Organização do ASP.NET

- O ASP.NET entrega sites (razor) e serviços de integração
- RAZOR incorpora código c# em páginas HTML (.cshtml)
- IDENTITY -> usado para autorização e autenticação
  <img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/bf5236c2-f8b4-4df0-a65e-3d860fbe1b9c" />


## Como funciona

- roda do lado do servidor
- envia informações (request) para o servidor, e recebe responses que podem ser HTML, JSON...
- pode criar, compilar... projetos com o .NET CLI (Command Line Interface)


### Versionamento

- Major -> versão principal (breaking change)
- Minor -> features novas (not breaking)
- Patch -> correções de bugs.. (not breaking)


## Gerenciando versões

```diff
  dotnet --info
  dotnet --list-sdks
  dotnet --version
```
- global.json ("força" uma versão específica):
```json
{
  "projects": ["src"],
  "sdk": {
      "version": "^6.0.201"
  }
}
```


## Middleware/Pipeline de requisições

- componentes que manipulam dados entre os requests (chega do cliente) e responses (vai voltar ao cliente)
- pode trabalhar lado a lado com outros middlewares
```csharp
  // context contém os dados da requisição (headers, path, user...)
  app.Use(async (context, next) =>
  {
      Console.WriteLine("Antes do próximo middleware");
      await next(); // chama o próximo middleware
      Console.WriteLine("Depois do próximo middleware");
  });
```
- request -> middlewares (middleware 1, middleware 2, middleware 3...) -> response (a orderm dos middlewares importam)
- ordem em que adiciona os middlewares define o comportamento do pipeline
- pipeline é a sequência de middlewares executados na requisição
- exemplo de pipeline (a requisição passa por uma sequência ordenada):
```csharp
  app.UseRouting();
  // se UseAuthorization vier antes de UseAuthentication, dá erro, pois o usuário precisa estar autenticado
  app.UseAuthentication();
  app.UseAuthorization();
  app.UseEndpoints(...);
```
- a imagem abaixo mostra o fluxo que uma requisição HTTP percorre dentro da aplicação ASP.NET:
<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/dda18ebe-7329-4b11-b535-06a123db241b" />

```csharp
  app.UseExceptionHandler();
  app.UseHsts();
  app.UseHttpsRedirection();
  app.UseStaticFiles();
  app.UseRouting();
  app.UseCors();
  app.UseAuthentication();
  app.UseAuthorization();
  app.MapControllers(); // ou MapGet(), MapRazorPages(), etc.
```
- a maioria dos middlewares começam com 'Use', mas também existem os middlewares 'Map' (para criar rotas) e 'Run' (que encerra o pipeline)
```csharp
  app.UseLogTempo();

  app.MapGet("/", () => "Hello World!");

  app.Run();
```
- MVC Middleware ->	Invoca controllers e retorna views ou JSON
- Identity Middleware ->	Faz autenticação/autorização
- Logging Middleware ->	Registra requisições e exceções


## Perfis de Execução

- launchSettings -> define como iniciar o servidor e o ambiente
- appsettings -> define quais configurações serão usadas
```csharp
  // appsettings.Development.json
  // configurações apenas para o ambiente de desenvolvimento e não de produção
  {
    "Logging": {
      "LogLevel": {
        "Default": "Debug" // Trace, Debug, Information
      }
    }
  }

```
- Program.cs -> define comportamento e pipeline


## Servidores WEB (IIS Express, Kestrel, Nginx)

- IIS Express -> servidor web leve, nativo do windows, usado no Visual Studio durante o desenvolvimento
- Kestrel -> servidor web interno do ASP.NET Core, cross-platform. É obrigatório usá-lo em todas as aplicações ASP.NET Core, mesmo se existir outros servidores (IIS e Nginx)
- Nginx -> servidor nativo no Linux

## Hosting

- host -> ambiente que executa a aplicação
- criação do host no program.cs:
```csharp
  var builder = WebApplication.CreateBuilder(args);
  var app = builder.Build();
  app.Run();
```



 



