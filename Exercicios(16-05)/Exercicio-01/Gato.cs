namespace Exercicio_01;
class Gato:Animal
{
    public override string Fala()
    {
        return base.Fala() + ("Miau");
    }
}
