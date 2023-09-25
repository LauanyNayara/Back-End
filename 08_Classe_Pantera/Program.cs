using Animal.Model;

class Program
{
    public static void Main()
    {
        var pantera1 = new Animal();
        pantera1.tamanho = 2.5M;
        pantera1.peso = 150;
        pantera1.cor = "preto";
        pantera1.especie = "negra";
        pantera1.alimentacao = "carnes";
        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();

    }
}