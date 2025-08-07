using WordsThatCount.Models;

namespace WordsThatCount.Actions;

internal class ActionRegistraRegistro : WordAction
{
    public override void Executar(Dictionary<string, Registro> registrosSalvos)
    {
        base.Executar(registrosSalvos);
        Console.WriteLine("Novo registro");
        Console.WriteLine("Digite o nome do usuário:");
        string usuarioDigitado = Console.ReadLine()!;
        //if ()
        Console.WriteLine("Digite o total de palavras:");
        int quantidadePalavras = Console.Read()!;
    }
}
