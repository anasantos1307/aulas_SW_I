namespace Banco18_04;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Banco Etec MCM!");
        Conta c = new Conta();
        //c.Saldo = 1000;
        c.Depositar(1000);
        c.Sacar(800);
        //c.Limite = 500;
        c.AjustarLimite(500);

        double valorTotal = c.MostrarSaldo();

        //Console.WriteLine("Seu saldo é de: " + c.Saldo + " com limite de: " + c.Limite);

        Console.WriteLine("Seu saldo total é de " + valorTotal);
        //Console.WriteLine("Seu saldo total é de " + c.Saldo);
        
        c.imprime(c.soma(1000,12));
        c.imprime(c.juros(1000, 0.06));
        
    

    }
}