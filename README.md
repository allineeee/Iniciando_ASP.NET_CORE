# Iniciando ASP.NET CORE

## Teoria

- .NET -> plataforma de desenvolvimento, e é multiplataforma
- Pode desenvolver aplicações para: Web, Mobile, Desktop, Microsserviços, Cloud, M.L, Games, IoT
- ASP.NET é um componente do .NET usado para desenvolver apps e páginas Web.
- ASP.NET 7M de requisições/seg. Plataforma web mais rápida.
- open-source


## Organização do ASP.NET

- O ASP.NET entrega sites (razor) e serviços de integração
- RAZOR incorpora código c# em páginas HTML
- IDENTITY -> usado para autorização e autenticação
  <img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/bf5236c2-f8b4-4df0-a65e-3d860fbe1b9c" />


## Como funciona

- roda do lado do servidor
- envia informações (request) para o servidor, e recebe responses que podem ser HTML, JSON...


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


## Middleware

- componentes que manipulam dados entre os requests e responses
- pode trabalhar lado a lado com outros middlewares
- request -> middlewares -> response (a orderm dos middlewares importam)


## Hosting


## Pipeline

<img width="500" height="500" alt="image" src="https://github.com/user-attachments/assets/dda18ebe-7329-4b11-b535-06a123db241b" />

 

## Pesquisar mais

- ASP -> 1996
- asp.net core o que é
- .NET standard library e outros TFMs
- IIS Express (lauchSettings)
- logLevel: trace, bebug, information...
- criar funções inline c#
- perfis de execução, launchSettings, appsettings
- pipeline, middleware (mvc middleware, identity middleware, logging middleware)
- primary constructor
- middleware, hosting, kestrel
- in-process hosting, out-of-process hosting, nginx
- pipeline do asp.net
- extesions metodos c#
- package manager console: add-migration Alunos -> update-database
- blazor não usa javascript???
- blazor -> dom, blazon usa dom por isso a tela não pisca (refresh)? comunicação signalIR
- blazor server x blazor webassembly
