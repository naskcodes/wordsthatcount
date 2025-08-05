using WordsThatCount.Models;

namespace WordsThatCount.Actions;

internal class RegistroListar
{
    public void ListarRegistrosUsuarios(Dictionary<string, Registro> registrosSalvos)
    {
        Console.Clear();
        Console.WriteLine("Digite o usuário cujos registros você deseja ver");
        string usuarioDigitado = Console.ReadLine()!;
        if (registrosSalvos.ContainsKey(usuarioDigitado))
        {
            Registro registro = registrosSalvos[usuarioDigitado];
            Console.WriteLine($"Usuário: {usuarioDigitado}\nPalavras: {registro.Palavras}\nData: {registro.DataRegistro}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        } else {
            Console.WriteLine($"O usuário {usuarioDigitado} não foi encontrado.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }   
}