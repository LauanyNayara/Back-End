Console.WriteLine("Digite um número");
int mes = int.Parse(Console.ReadLine());

switch (mes) {
    case 1:
    Console.WriteLine("Janeiro,31 dias!");
    break;
    case 2:
    Console.WriteLine("Fevereiro,28 ou 29 dias!");
    break;
    case 3:
    Console.WriteLine("Março,31 dias!");
    break;
    case 4:
    Console.WriteLine("Abril,30 dias!");
    break;
    case 5:
    Console.WriteLine("Maio,31 dias!");
    break;
    case 6:
    Console.WriteLine("Junho,30 dias!");
    break;
    case 7:
    Console.WriteLine("Julho, 31 dias!");
    break;
    case 8:
    Console.WriteLine("Agosto,31 dias!");
    break;
    case 9:
    Console.WriteLine("Setembro,30 dias!");
    break;
    case 10:
    Console.WriteLine("Outubro,31 dias!");
    break;
    case 11:
    Console.WriteLine("Novembro,30 dias!");
    break;
    case 12:
    Console.WriteLine("Dezembro,31 dias!");
    break;
    default:
    Console.WriteLine("Não existe este mes");
    break;
}
