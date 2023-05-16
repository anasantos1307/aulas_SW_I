namespace Exercicio_02;
class Program
{
    static void Main(string[] args)
    {
        ContratoPF pf = new ContratoPF();
        ContratoPJ pj = new ContratoPJ();

        pf.Nome = "Anderson";
        pf.Email = "Vanin@gmail.com";
        pf.Tel = "(11) 9876-54321";
        pf.CPF = "123.234.345-90";
        pf.Idade = 40;

        pj.Nome = "Bruno";
        pj.Email = "Bru65@gmail.com";
        pj.Tel = "(11) 1234-56789";
        pj.CNPJ = "00.123.123/0000-90";
        pj.IE = "123456789";
        pj.NomeEmpresa = "SP Produções";

        Console.WriteLine("Pessoa Física: " +pf.Nome + " | " +pf.Email+ " | " +pf.Tel+ " | " +pf.CPF+ " | " +pf.Idade);
        Console.WriteLine("Pessoa Jurídica: " +pj.Nome + " | " +pj.Email+ " | " +pj.Tel+ " | " +pj.CNPJ+ " | " +pj.IE+ " | " +pj.NomeEmpresa);
    }
}
