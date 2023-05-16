namespace Exercicio_01;
class Program
{
    static void Main(string[] args)
    {
        Homem H = new Homem();
        Gato G = new Gato();
        Cachorro C = new Cachorro();

        H.Especie = "Homem";
        G.Especie = "Gato";
        C.Especie = "Cachorro";

        Console.WriteLine("Animal: " + H.Especie + (H.Fala()));
        Console.WriteLine("Animal: " + G.Especie + (G.Fala()));
        Console.WriteLine("Animal: " + C.Especie + (C.Fala()));
    }
}
