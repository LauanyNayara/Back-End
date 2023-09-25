class Program
{
    public static void Main()
    {
        MostrarMensagem("Digite um número para descobrir o dobro");
        int multiplicacao = Dobro(int.Parse(Console.ReadLine()));
        Console.WriteLine($"o dobro é {multiplicacao} ");
        MostrarMensagem("Digite um número para descobrir a metade");
        int divisao = Metade(int.Parse(Console.ReadLine()));
        Console.WriteLine($"a metade é {divisao} ");
        MostrarMensagem("Digite um número para saber sua tabuada");

        Tabuada(int.Parse(Console.ReadLine()));
        Soma();

    }

    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
    public static int Dobro(int valor)
    {
        int resultado = valor * 2;
        return resultado;
    }
    public static int Metade(int meio)
    {

        int resultado = meio / 2;
        return resultado;
    }


    public static void Tabuada(int n)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"A tabuada de {n} x {contador} é {n * contador}");
            contador++;

        }

    }

    public static void Soma()
    {
        int soma = 0;
        int menor = 10000;
        int maior = 0;
        int num = 0;

        do
        {  
            Console.WriteLine("Digite o número:");
            num = int.Parse(Console.ReadLine());
             if(num > 0)
            soma += num;// soma = soma + num;

            if (num > maior)
                maior = num;

            if (num < menor && num > 0)
                menor = num;

           

        } while (num > 0);

        Console.WriteLine($"o maior número digitado é {maior} o menor é {menor} e a soma é {soma} ");

    }
}
