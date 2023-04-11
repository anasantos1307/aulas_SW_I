namespace proj_agregacao;
class Program
{
    static void Main(string[] args)
    {
        Cartao cdc = new Cartao();
        Cliente cli = new Cliente();

        cli.Nome = "Ana Clara M.";

        cdc.Numero = "456782390";
        cdc.DataValidade = "07/2025";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);
    }
}
