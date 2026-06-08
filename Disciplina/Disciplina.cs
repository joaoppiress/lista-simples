public class Disciplina
{
    public string nome;
    public int periodo;
    public int cargaHoraria;
    public string professorResponsavel;

    public Disciplina(
        string nome,
        int periodo,
        int cargaHoraria,
        string professorResponsavel)
    {
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.professorResponsavel = professorResponsavel;
    }

    public void imprimir()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Período: {periodo}");
        Console.WriteLine($"Carga Horária: {cargaHoraria}");
        Console.WriteLine($"Professor: {professorResponsavel}");
    }
}