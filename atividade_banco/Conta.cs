namespace atividade_banco;
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

   public string Emprestimo(double emprestimo, int prazo){
        this.ValorEmprestimo = emprestimo;
        this.Prazo = prazo;
        double parcelaSemJuros = this.ValorEmprestimo / this.Prazo;
        double Juros = this.ValorEmprestimo * 0.06;
        double ParcelaJuros = parcelaSemJuros + Juros;
        double Total = ParcelaJuros * this.Prazo;
        string resultado = "O valor do seu empréstimo total é de: " + Total;

        return resultado;
    }

    public void imprime(string texto){
        Console.WriteLine(texto);
    }
    
}