// Exercicio 001 Calculando a média de 3 notas de um aluno

// Receber o nome do aluno e armazenar em uma váriavel do tipo string

//Receber nota 1, converter e armazenar em uma váriavel int

//Receber nota 2, converter e armazenar em uma váriavel int

//Receber nota 3, converter e armazenar em uma váriavel int

//Declarar uma váriavel do tipo int, para receber a média das notas 
//(nota 1 + nota 2 + nota 3) / 3

//Exibir uma mensagem se o aluno está aprovado conciderando nota acima de 7

Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();

Console.WriteLine("Digite nota 1");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite nota 2");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite nota 3");
int nota3 = int.Parse(Console.ReadLine());

int soma = nota1 + nota2 + nota3;
int media = soma / 3;

if (media >= 7)
{
  Console.WriteLine($"O aluno {nome} passou com média {media}");
}
else
{
  Console.WriteLine($"O aluno {nome} não passou, ficou com a  média {media}");
}

/* string aprovacao = (media >= 7) ? "aprovado" : "reprovado" ;
   Console.WriteLine()*/