namespace Exercicio_01;
class Cachorro:Animal
{
    public override string Fala()
    {
        return base.Fala() + ("Au Au");
    }
}
