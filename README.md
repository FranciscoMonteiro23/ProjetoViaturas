# StandAutomoveis2

## Descrição

StandAutomoveis2 é uma aplicação web desenvolvida em **ASP.NET Core Razor Pages** para a administração de viaturas de um stand. Permite gerir viaturas, adicionando novos veículos, editando, apagando, visualizando detalhes e filtrando por loja. Cada veículo possui também um campo **Tipo** que classifica como **Citadino, Familiar ou Desportivo**.

---

## Funcionalidades

- CRUD completo de viaturas (Create, Read, Update, Delete)
- Filtro por **Loja** com opção de mostrar todas
- Adição de novos veículos com campos obrigatórios:
  - Marca (até 20 caracteres)
  - Ano
  - Loja (até 20 caracteres)
  - Tipo (Citadino, Familiar, Desportivo)
- Visualização de detalhes das viaturas
- Interface moderna com **Bootstrap**
- Dados iniciais carregados automaticamente:
  - Fiat 2016 Aveiro / Lisboa / Porto
  - Opel 2017 Aveiro / 2018 Porto / 2018 Lisboa
  - Ferrari 2017 Porto

---

## Estrutura do projeto
StandAutomoveis2/
│
├─ Program.cs
├─ appsettings.json
├─ StandAutomoveis2.csproj
├─ Models/
│   └─ Viatura.cs
├─ Data/
│   └─ ViaturaContext.cs
└─ Pages/
├─ Viaturas/
│   ├─ Index.cshtml
│   ├─ Index.cshtml.cs
│   ├─ Create.cshtml
│   ├─ Create.cshtml.cs
│   ├─ Edit.cshtml
│   ├─ Edit.cshtml.cs
│   ├─ Delete.cshtml
│   ├─ Delete.cshtml.cs
│   ├─ Details.cshtml
│   └─ Details.cshtml.cs
└─ Shared/
└─ _Layout.cshtml

---

## Tecnologias utilizadas

- .NET 6 / 7
- ASP.NET Core Razor Pages
- Entity Framework Core (SQLite)
- Bootstrap 5
- C#

---

## Pré-requisitos

- [.NET SDK 6 ou superior](https://dotnet.microsoft.com/download)
- Visual Studio Code (ou outro IDE de preferência)
- SQLite (opcional, mas já incluído na aplicação)
