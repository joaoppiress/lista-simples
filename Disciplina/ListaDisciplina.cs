public class ListaDisciplina
{
    public NoDisciplina inicio;
    public NoDisciplina fim;

    public ListaDisciplina()
    {
        inicio = null;
        fim = null;
    }

    public Boolean estaVazia()
    {
        return inicio == null;
    }

    public void inserirOrdenado(Disciplina disciplina)
    {
        NoDisciplina novoNo = new NoDisciplina(disciplina);

        if (estaVazia())
        {
            inicio = novoNo;
            fim = novoNo;
            return;
        }

        if (string.Compare(
            disciplina.nome,
            inicio.disciplina.nome,
            true) < 0)
        {
            novoNo.prox = inicio;
            inicio = novoNo;
            return;
        }

        NoDisciplina atual = inicio;

        while (
            atual.prox != null &&
            string.Compare(
                disciplina.nome,
                atual.prox.disciplina.nome,
                true) > 0)
        {
            atual = atual.prox;
        }

        novoNo.prox = atual.prox;
        atual.prox = novoNo;

        if (novoNo.prox == null)
        {
            fim = novoNo;
        }
    }

    public Boolean buscar(string nome)
    {
        NoDisciplina atual = inicio;

        while (atual != null)
        {
            if (atual.disciplina.nome.Equals(
                nome,
                StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            atual = atual.prox;
        }

        return false;
    }

    public void remover(string nome)
    {
        if (estaVazia())
        {
            return;
        }

        if (
            inicio.disciplina.nome.Equals(
                nome,
                StringComparison.OrdinalIgnoreCase))
        {
            inicio = inicio.prox;

            if (inicio == null)
            {
                fim = null;
            }

            return;
        }

        NoDisciplina atual = inicio;

        while (
            atual.prox != null &&
            !atual.prox.disciplina.nome.Equals(
                nome,
                StringComparison.OrdinalIgnoreCase))
        {
            atual = atual.prox;
        }

        if (atual.prox != null)
        {
            if (atual.prox == fim)
            {
                fim = atual;
            }

            atual.prox = atual.prox.prox;
        }
    }

    public void percurso()
    {
        NoDisciplina atual = inicio;

        while (atual != null)
        {
            Console.WriteLine("------------------");
            atual.disciplina.imprimir();
            atual = atual.prox;
        }
    }
}