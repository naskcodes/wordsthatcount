using WordsThatCount.Actions;
using WordsThatCount.Models;

Usuario usuarioInicial = new("praxidikai");
Registro registroTeste1 = new Registro(usuarioInicial, 280, new DateTime(2025, 8, 5));
Dictionary<string, Registro> registrosSalvos = new();
registrosSalvos.Add(usuarioInicial.Nome, registroTeste1);

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
    Console.WriteLine("Digite 2 para listar registros de um usuário");
    Console.WriteLine("Digite 3 para cadastrar um usuário");
    Console.WriteLine("Digite -1 para sair");
    Console.WriteLine("\nDigite sua opção:");

    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    switch (opcaoNumerica)
    {
        case 1:
            //Console.WriteLine("Registro de Palavras\n");
            //RegistrarPalavras();
            //Registro registroNovo = new();
            break;
        case 2:
            RegistroListar listagem = new();
            listagem.ListarRegistrosUsuarios(registrosSalvos);
            break;
        case 3:
            //Console.WriteLine("Cadastro de Usuário!\n");
            //CadastrarUsuário();
            break;
        case -1:
            Console.WriteLine("Obrigada!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMenu();