namespace Exercicio_aviao_04_04;
class Program
{
    static void Main(string[] args)
    {
        Aeroporto a1 = new Aeroporto();
        a1.AlteraCodigo(1);
        a1.AlteraEmpresa("Rajaram Airlines");
        //a1.AlteraEntrada("Itália");
        //a1.AlteraSaida("Dinamarca");
        a1.MostraDados();
    }
}
