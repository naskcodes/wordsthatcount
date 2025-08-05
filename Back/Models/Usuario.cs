namespace WordsThatCount.Models;

internal class Usuario
{
    private List<Registro> registros = new();
    
    public Usuario(string nome)
    {
        Nome = nome;
    }
    
    public string Nome { get; }
    public List<Registro> Registros => registros;
    public int TotalPalavras => registros.Sum(r => r.Palavras);

    public void AdicionarRegistro(Registro registro)
    {
        registros.Add(registro);
    }

    public void ListarRegistrosUsuarios()
    {
        Console.WriteLine($"Registros de {Nome}:");
        foreach (Registro registro in registros)
        {
            Console.WriteLine($"{registro}");
        }
    }
}
