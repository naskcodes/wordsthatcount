using System;

Console.WriteLine("Digite seu usuário: ");
string username = Console.ReadLine()!;
Console.WriteLine("Digite a quantidade de palavas: ");
int palavras = int.Parse(Console.ReadLine()!);
string data = DateTime.Now.ToString();
Console.WriteLine($"Usuário: {username}\nPalavras: {palavras}\nData: {data}");