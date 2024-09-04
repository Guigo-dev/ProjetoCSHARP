// See https://aka.ms/new-console-template for more information

using System.Runtime;

Dictionary<string, List<float> > dicBandas = new Dictionary<string, List<float>>();
dicBandas.Add("Linkin Park", new List<float>{5f, 10f, 9.6f});
dicBandas.Add("Supercombo", new List<float>());
ExibirOpcoesDoMenu();

void ExibirLogo(){

    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("Seja Bem Vindo");
    
}

void ExibirOpcoesDoMenu(){
    ExibirLogo();

    Console.WriteLine("\n1 - Registrar Banda");
    Console.WriteLine("2 - Mostrar Bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir média das bandas");
    Console.WriteLine("-1 - Sair do Menu");

    Console.Write("Digite sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida){
        case -1: 
            break;
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMediaBanda();
            break;
        default: Console.WriteLine("Opcao invalida");
            break;
    }
}

void RegistrarBanda(){
    Console.Clear();
    ExibirTituloOpcao("Registro de Bandas");

    Console.Write("Digite o nome da banda: ");
    dicBandas.Add(Console.ReadLine()!,new List<float>());
    Console.WriteLine($"A banda {dicBandas.Last().Key} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTituloOpcao("Bandas Registradas");

    foreach(string banda in dicBandas.Keys){
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nDigite uma Tecla Para Voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda(){
    Console.Clear();
    ExibirTituloOpcao("Avaliar Banda");
    Console.Write("Digite o nome da Banda para avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if(dicBandas.ContainsKey(nomeBanda)){
        Console.Write("Digite a sua nota: ");
        float nota = float.Parse(Console.ReadLine()!);
        dicBandas[nomeBanda].Add(nota);

        Console.WriteLine("A nota foi registrada com sucesso");
        Thread.Sleep(2000);
    }
    else{
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada");
        Thread.Sleep(2000);
    }
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirMediaBanda(){
    Console.Clear();
    ExibirTituloOpcao("Medias das Bandas");

    foreach (string banda in dicBandas.Keys){
        float media = 0;
        if(dicBandas[banda].Any()){
            media = dicBandas[banda].Average();
        }
        Console.WriteLine($"A media da {banda} é {media}");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
    
}

void ExibirTituloOpcao(string tituloOpcao){
    int qtdLetras = tituloOpcao.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine(asteriscos + "\n" + tituloOpcao + "\n" + asteriscos + "\n");
    
}
