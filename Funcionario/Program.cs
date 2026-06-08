ListaFuncionario lista = new ListaFuncionario();

int opcao;

do
{
    Console.WriteLine("\n===== MENU FUNCIONÁRIOS =====");
    Console.WriteLine("1 - Inserir no início");
    Console.WriteLine("2 - Inserir no fim");
    Console.WriteLine("3 - Buscar por nome");
    Console.WriteLine("4 - Remover início");
    Console.WriteLine("5 - Remover fim");
    Console.WriteLine("6 - Percorrer lista");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1 || opcao == 2)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine());

        Funcionario funcionario = new Funcionario(nome, idade, telefone, salario);

        if (opcao == 1)
        {
            lista.inserirInicio(funcionario);
        }
        else
        {
            lista.inserirFim(funcionario);
        }
    }
    else if (opcao == 3)
    {
        Console.Write("Digite o nome para buscar: ");
        string nome = Console.ReadLine();

        if (lista.buscarPorNome(nome))
        {
            Console.WriteLine("Funcionário encontrado!");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado!");
        }
    }
    else if (opcao == 4)
    {
        lista.removerInicio();
    }
    else if (opcao == 5)
    {
        lista.removerFim();
    }
    else if (opcao == 6)
    {
        lista.percurso();
    }

} while (opcao != 0);