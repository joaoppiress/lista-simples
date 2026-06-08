public class Funcionario
{
    public string nome;
    public int idade;
    public string telefone;
    public double salario;
    public Funcionario(string nome, int idade, string telefone, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.telefone = telefone;
        this.salario = salario;
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Idade: " + this.idade);
        Console.WriteLine("Telefone: " + this.telefone);
        Console.WriteLine("Salário: " + this.salario);
    }
}