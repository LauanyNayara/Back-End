class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou pagando pela {i}ª vez no for");
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"variavel sesi vale {sesi}");
        }

        int numero = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{numero} x {cont} = {numero * cont}");
        }

        //Declarando um vetor com 34 posições
        string[] alunos = new string[35];

        //Atribuindo valores ao nosso vetor
        alunos[1] = "Abner";
        alunos[2] = "kaio";
        alunos[3] = "Ana carolina";
        alunos[34] = "Samuel";

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int laura = 0; // soma
        int jorge = 0; //maior
        int bianca = 100;

        foreach (int enzo in cadeiras)
        {
            laura = laura + enzo
            if (enzo > jorge)
                jorge = enzo;
            if (enzo < bianca)
                bianca = enzo;
        }
        Console.WriteLine($"soma: {laura}, Maior");
        Array.Sort(cadeiras);

        for (int x = 0; x < cadeiras.lenght; x++)
        Console.WriteLine($"pos. {x} - valor {cadeiras[x]}");

    }
}
