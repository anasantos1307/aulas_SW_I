namespace Exercicio_01;
class Animal
{
    public string? Especie{get; set;}

    public virtual string Fala(){
        return (" | diz: ");
    }
}
