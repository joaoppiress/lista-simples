public class NoDisciplina
{
    public Disciplina disciplina;
    public NoDisciplina prox;

    public NoDisciplina(Disciplina disciplina)
    {
        this.disciplina = disciplina;
        this.prox = null;
    }
}