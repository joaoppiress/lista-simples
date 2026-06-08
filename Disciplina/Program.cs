ListaDisciplina lista = new ListaDisciplina();

int opcao;

do
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Inserir disciplina");
    Console.WriteLine("2 - Buscar disciplina");
    Console.WriteLine("3 - Remover disciplina");
    Console.WriteLine("4 - Listar disciplinas");
    Console.WriteLine("0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Período: ");
            int periodo = int.Parse(Console.ReadLine());

            Console.Write("Carga Horária: ");
            int carga = int.Parse(Console.ReadLine());

            Console.Write("Professor: ");
            string professor = Console.ReadLine();

            Disciplina disciplina = new Disciplina(
                nome,
                periodo,
                carga,
                professor);

            lista.inserirOrdenado(disciplina);

            break;

        case 2:

            Console.Write("Nome da disciplina: ");
            nome = Console.ReadLine();

            if (lista.buscar(nome))
                Console.WriteLine("Disciplina encontrada!");
            else
                Console.WriteLine("Disciplina não encontrada!");

            break;

        case 3:

            Console.Write("Nome da disciplina: ");
            nome = Console.ReadLine();

            lista.remover(nome);

            break;

        case 4:

            lista.percurso();

            break;
    }

} while (opcao != 0);