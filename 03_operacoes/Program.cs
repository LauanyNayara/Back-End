﻿Console.WriteLine("Digite o valor de x:");
int x = int.Parse( Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

/* Exemplos de operadores aritméticos */

int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y ;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; /* Calculando o resto da divisão de x / 2 */
int restoYDiv2 = y % 2;

/* Console para exibir na tela as variaveis em cada linha
    soma: 15 */

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"subtracao: {subtracao}");
Console.WriteLine($"multiplicacao: {multiplicacao}");
Console.WriteLine($"divisao: {divisao}");
Console.WriteLine($"resto: {resto}");

if (restoDiv2 == 0){
    Console.WriteLine($"O número {x} é par");
}
else
{
    Console.WriteLine($"O número {x} é impar");
}

if (restoYDiv2 == 0){
    Console.WriteLine($"O número {y} é par");
}
else
{
    Console.WriteLine($"O número {y} é impar");
}

/* Operador ternário
    condição ? se verdade : senão  */
string resultado = (restoYDiv2 == 0) ? $"O número {y} é par": $"O número {y} é impar";
Console.WriteLine(resultado); 

int diaSemana = 3;
/* Aprendendo o Swich Case */
switch (diaSemana) {
    case 1:
    Console.WriteLine("hoje é domingo!");
    break;
    case 2:
    Console.WriteLine("hoje é segunda!");
    break;
    case 3:
    Console.WriteLine("hoje é terça!");
    break;
    case 4:
    Console.WriteLine("hoje é quarta!");
    break;
    case 5:
    Console.WriteLine("hoje é quinta!");
    break;
    case 6:
    Console.WriteLine("hoje é sexta!");
    break;
    case 7:
    Console.WriteLine("hoje é sabado!");
    break;
    default:Console.WriteLine("Dia inválido");
    break;
}
