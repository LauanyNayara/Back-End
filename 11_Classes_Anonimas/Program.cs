public class Program
{
    public static void Main()
    {
        // Criando uma classe anomima(classe sem definição inicial)

        var pessoa1 = new
        {
            nome = "joão",
            idade = 17
        };
        var pessoa2 = new{
            nome = "maria",
            email = "maria@aluno.senai.br",
        };

        Console.WriteLine($"a pessoa1 chama {pessoa1.nome} e tem {pessoa1.idade} anos.");
        Console.WriteLine($"a pessoa2 chama {pessoa2.nome} e tem o email {pessoa2.email}");

       // pessoa1.nome = "Douglas";

        // criar 2 objetos de classe anonima de carro
        var carro1 = new{
            marca = "hyundai",
            modelo = "Creta",
            ano = 2020

        };

        var carro2 = new{
            marca = "Land rover",
            modelo = "Range rover",
            ano = 2019

        };

        Console.WriteLine($"A marca {carro1.marca} fez o modelo {carro1.modelo} em {carro1.ano}");
        Console.WriteLine($"A marca {carro2.marca} fez o modelo {carro2.modelo} em {carro2.ano}");
    }
}
