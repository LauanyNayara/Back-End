/* Somente declarando variavel do tipo inteira e sem valor */
  //int num1;

/*Declarando uma variavel do tipo inteiro e atribuindo valor 5  */
  // int num2 = 5;

/* Declarando variavel string */
  //string nomeAluno = "Paulo";

/* Variavel do tipo lógico (true ou false) */
  //bool resultado = true;

/* variavel do tipo doble valor com várias casas decimais */
//double coordenada = 1.803645628;

/* variavel do tipo decimal - utilizada para valores */
  // decimal valor = 1.80M;

int idade = 16;
string meuNome = "Lauany";  
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

Console.WriteLine("");

Console.WriteLine("Em qual cidade você nasceu?");
  /* readline serve apenas para que eu receba uma informação do usuário 
  e armazeno em uma variavel */
string nomecidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomecidade}");