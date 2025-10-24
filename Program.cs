using Microsoft.EntityFrameworkCore;
using StandAutomoveis.Data;
using StandAutomoveis.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// SQLite
builder.Services.AddDbContext<ViaturaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ViaturaContext") 
        ?? "Data Source=viaturas.db"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();

// Inicializar BD com dados
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ViaturaContext>();
    context.Database.EnsureCreated();

    if (!context.Viaturas.Any())
    {
        context.Viaturas.AddRange(
            new Viatura { Marca = "Fiat", Ano = 2016, Loja = "Aveiro", Tipo = "Citadino" },
            new Viatura { Marca = "Fiat", Ano = 2016, Loja = "Lisboa", Tipo = "Citadino" },
            new Viatura { Marca = "Fiat", Ano = 2018, Loja = "Porto", Tipo = "Familiar" },
            new Viatura { Marca = "Opel", Ano = 2017, Loja = "Aveiro", Tipo = "Familiar" },
            new Viatura { Marca = "Opel", Ano = 2018, Loja = "Porto", Tipo = "Familiar" },
            new Viatura { Marca = "Opel", Ano = 2018, Loja = "Lisboa", Tipo = "Familiar" },
            new Viatura { Marca = "Ferrari", Ano = 2017, Loja = "Porto", Tipo = "Desportivo" }
        );
        context.SaveChanges();
    }
}

app.Run();