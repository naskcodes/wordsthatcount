using Microsoft.EntityFrameworkCore;
using wordsthatcount.Modelos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var services = new ServiceCollection();

services.AddDbContext<DbContextWordsThatCount>(options => options.UseNpgsql(config.GetConnectionString("WTCDb")));

// Console.WriteLine("Digite seu usuário: ");
// string nomeUsuario = Console.ReadLine()!;
// Console.WriteLine("Digite a quantidade de palavas: ");
// int palavras = int.Parse(Console.ReadLine()!);
// string data = DateTime.Now.ToString();
// Console.WriteLine($"Usuário: {nomeUsuario}\nPalavras: {palavras}\nData: {data}");