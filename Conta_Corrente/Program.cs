using Models;


public class Program
{



    public static void Main()
    {
        Console.WriteLine($"Digite o seu nome");

        Menu();
    }


    public static void Menu()
    {

        ContaCorrente pessoa1 = new ContaCorrente(Console.ReadLine());

        string opcao = "";
        do
        {
            Console.WriteLine("############ Menu #########");
            Console.WriteLine(" 1 - Consultar Saldo ");
            Console.WriteLine(" 2 -  Depositar");
            Console.WriteLine(" 3 - Sacar ");
            Console.WriteLine(" 0 - Sair ");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado,volte sempre!!!");
                    System.Threading.Thread.Sleep(1000); //Espera de 1s
                    break;
                case "1":
                    pessoa1.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine($"Digite o valor que deseja depositar ");
                    decimal valorDepositado = decimal.Parse(Console.ReadLine());
                    pessoa1.Depositar(valorDepositado);
                    break;
                case "3":
                    Console.WriteLine($"Digite o valor que deseja retirar ");
                    decimal retirarValor = decimal.Parse(Console.ReadLine());
                    pessoa1.Sacar(retirarValor);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (opcao != "0");
    }

}

