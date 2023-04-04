namespace Exercicio_aviao_04_04;
class Aeroporto
{
   public Aeroporto(){
    this.Codigo = 0;
    this.Empresa = "Não Informado!";
    this.Entrada = "Não Informado!";
    this.Saida = "Não Informado!";
   }
   public Aeroporto(int codigo, string nome){
    this.Codigo = 0;
    this.Empresa = "Não Informado!";
    this.Entrada = "Não Informado!";
    this.Saida = "Não Informado!";
   }

   private int Codigo{get; set;}
   private string? Empresa{get; set;}
   private string? Entrada{get; set;}
   private string? Saida{get; set;}

   public void AlteraCodigo(int codigo){
    this.Codigo = codigo;
   }

   public void AlteraEmpresa(string empresa){
    this.Empresa = empresa;
   }

   public void AlteraEntrada(string entrada){
    this.Entrada = entrada;
   }

   public void AlteraSaida(string saida){
    this.Saida = saida;
   }

   public void MostraDados(){
    Console.WriteLine("Código: " + this.Codigo);
    Console.WriteLine("Empresa: " + this.Empresa);
    Console.WriteLine("Entrada: " + this.Entrada);
    Console.WriteLine("Saída: " + this.Saida);
   }
}
