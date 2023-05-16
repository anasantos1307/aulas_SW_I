namespace Exercicio_01;
class Homem:Animal
{
    public override string Fala()
    {
        return base.Fala() + ("A Terra é plana");
    }
}
