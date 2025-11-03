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
- envia informações (request) para o servidor, e recebe responses que pode ser HTML, JSON...


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


 

## Pesquisar mais

- ASP -> 1996
- .NET standard library e outros TFMs
- IIS Express (lauchSettings)
- logLevel: trace, bebug, information...
- criar funções inline c#
