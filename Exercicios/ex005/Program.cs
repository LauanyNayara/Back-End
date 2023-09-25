class Program
{
    public static void Main()
    {

        listaDoChurrasco();

    }

    public static void listaDoChurrasco()
    {
        //Declarar o vetor com 6 posições tipo string
        string[] compra = new string[6];

        //receber os produtos que precisam ser comprados
        for (int i = 0; i < 6; i++)
        {
            //Console para informar o produto a comprar 
            Console.WriteLine($"Digite o produto que vamos comprar");
            // Declarar uma variavel produto para receber o que eu escrevo no ReadLine
            var produto = Console.ReadLine();
            //Atribuir no meu vetor o produto que eu digitei pela posição
            compra[i] = produto;
        }

        //Ordenar meu vetor
        Array.Sort(compra);
        //Para cada item na lista imprimir o produto
        foreach (string item in compra)
        {
            Console.WriteLine(item);
        }
    }

    public static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o seu {i} sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Digite o valor do {i}° sonho");
            decimal valor = decimal.Parse(Console.ReadLine());

            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores)
        {
            total = total + val;
        }
        Console.WriteLine($"Seus sonhos custarão aprox. R${total}");


    }


}



