public class ListaFuncionario
{
    public NoFuncionario inicio;
    public NoFuncionario fim;

    public ListaFuncionario()
    {
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia()
    {
        return this.inicio == null && this.fim == null;
    }

    public void inserirInicio(Funcionario funcionario)
    {
        NoFuncionario novoNo = new NoFuncionario(funcionario);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void inserirFim(Funcionario funcionario)
    {
        NoFuncionario novoNo = new NoFuncionario(funcionario);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public Boolean buscarPorNome(string nome)
    {
        NoFuncionario atual = this.inicio;

        while (atual != null)
        {
            if (atual.funcionario.nome == nome)
            {
                return true;
            }

            atual = atual.prox;
        }

        return false;
    }

    public void removerInicio()
    {
        if (this.estaVazia())
        {
            Console.WriteLine("Lista vazia!");
            return;
        }

        if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;
        }
        else
        {
            this.inicio = this.inicio.prox;
        }
    }

    public void removerFim()
    {
        if (this.estaVazia())
        {
            Console.WriteLine("Lista vazia!");
            return;
        }

        if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;
            return;
        }

        NoFuncionario atual = this.inicio;

        while (atual.prox != this.fim)
        {
            atual = atual.prox;
        }

        this.fim = atual;
        this.fim.prox = null;
    }

    public void percurso()
    {
        NoFuncionario atual = this.inicio;

        while (atual != null)
        {
            Console.WriteLine("--------------------");
            atual.funcionario.imprimir();
            atual = atual.prox;
        }
    }
}