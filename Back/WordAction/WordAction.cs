using WordsThatCount.Models;

namespace WordsThatCount.Actions;

internal class WordAction
{
    public virtual void Executar(Dictionary<string, Registro> registrosSalvos)
    {
        Console.Clear();
    }
}
