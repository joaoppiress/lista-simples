public class NoFuncionario
{
    public Funcionario funcionario;
    public NoFuncionario prox;

    public NoFuncionario(Funcionario funcionario)
    {
        this.funcionario = funcionario;
        this.prox = null;
    }
}