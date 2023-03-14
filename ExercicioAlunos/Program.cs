namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        Alunos aluno1 = new Alunos();
        aluno1.nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota do aluno: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());

        aluno1.mensagem();
    }
}
