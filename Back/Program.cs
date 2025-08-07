using WordsThatCount.Actions;
using WordsThatCount.Models;

Usuario usuarioInicial = new("praxidikai");
Registro registroTeste1 = new Registro(usuarioInicial, 280, new DateTime(2025, 8, 5));
Registro registroTeste2 = new Registro(usuarioInicial, 200, new DateTime(2025, 8, 7));

//Dictionary<string, Registro> registrosSalvos = new();
//registrosSalvos.Add(usuarioInicial.Nome, registroTeste1);

Dictionary<int, WordAction> opcoes = new();
opcoes.Add(3, new ActionRegistroListar());

void ExibirLogo()
{
    Console.WriteLine(@"
█░█░█ █▀█ █▀█ █▀▄ █▀   ▀█▀ █░█ ▄▀█ ▀█▀   █▀▀ █▀█ █░█ █▄░█ ▀█▀
▀▄▀▄▀ █▄█ █▀▄ █▄▀ ▄█   ░█░ █▀█ █▀█ ░█░   █▄▄ █▄█ █▄█ █░▀█ ░█░");
    Console.WriteLine("Versão: 0.2.1");
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para cadastrar sua quantidade de palavras");
    Console.WriteLine("Digite 2 para cadastrar um usuário");
    Console.WriteLine("Digite 3 para listar registros de um usuário");
    Console.WriteLine("Digite -1 para sair");
    Console.WriteLine("\nDigite sua opção:");

    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    if (opcoes.ContainsKey(opcaoNumerica))
    {
        WordAction exibir = opcoes[opcaoNumerica];
        exibir.Executar(registrosSalvos);
        if (opcaoNumerica > 0)
        {
            ExibirMenu();
        }
    }
}

ExibirMenu();