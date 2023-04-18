namespace Banco18_04;
class Conta
{
    public int Numero {get; set;}
    private double Saldo {get;  set;}
    public double Limite {get; private set;}

    public double ValorEmprestimo {get; set;}
    public double Prazo {get; set;}

    public double ValorJuros {get; set;}


    public void AjustarLimite(double valor){
        this.Limite = valor;
    }

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public void Sacar(double valor){
        if (valor <- this.Saldo + this.Limite){
        this.Saldo -= valor;
        }else{
            Console.WriteLine("Você não possui saldo/limite suficiente para este saque");
            Console.WriteLine("Saque não realizado!");
        }
    }

   public double MostrarSaldo(){
    return this.Saldo + this.Limite;
   
   }

   public string soma(int n1, int n2){
        this.ValorEmprestimo = n1;
        this.Prazo = n2;
        double soma = this.ValorEmprestimo / this.Prazo;
        string resultado = "O valor da sua parcela sem juros é de: " + soma;

        return resultado;
    }

    public void imprime(string texto){
        Console.WriteLine(texto);
    }

    public string juros(int n1, double n3){
        this.ValorEmprestimo = n1;
        this.ValorJuros = n3;
        double juros = n1 * n3;
        string TotalJuros = "O valor do juros é de: " + juros; 

        return TotalJuros;
    }
}
