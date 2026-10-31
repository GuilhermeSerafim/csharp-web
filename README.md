# ScreenSound — estudos em C#

Etapa de estudo da formação Alura em C#/ASP.NET, conforme a descrição do repositório. O código é uma **aplicação de console**.

## Organização

- `ScreenSound/Program.cs`: menu para registrar artistas e músicas e listar os registros.
- `ScreenSound/Menus/`: operações acessíveis pelo menu.
- `ScreenSound/Banco/`: classes de acesso a dados e contexto Entity Framework Core.
- `ScreenSound/Modelos/`: modelos de artista e música.
- `ScreenSound.sln`: solução; `ScreenSound/ScreenSound.csproj`: executável com alvo .NET 8.

O manifesto referencia `Microsoft.EntityFrameworkCore.SqlServer` 9.0.2 e `System.Data.SqlClient` 4.9.0. `ScreenSoundContext` aponta para SQL Server LocalDB, banco ScreenSound, com autenticação integrada.

## Reprodução e limites

Antes de executar, confira a instalação do SDK, compatibilidade das dependências, disponibilidade do LocalDB e preparação do banco/schema em ambiente de desenvolvimento. O menu oferece registro e listagem de artistas e músicas; o projeto não inclui uma API HTTP ou interface web.
