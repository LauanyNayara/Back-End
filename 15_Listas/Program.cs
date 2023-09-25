using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista
        listaNumeros.Add(10);  //posição [0]
        listaNumeros.Add(20);  //posição [1]
        listaNumeros.Add(45);  //posição [2]

        //Acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[2]);

        //Contagem de elementos
        Console.WriteLine($"Nesse momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); ////posição [3]
        Console.WriteLine($"Nesse momento temos {listaNumeros.Count} elementos");

        List<string> listaNomes = new List<string>();

        //Adicionando elementos a lista
        listaNomes.Add("Lauany");  //posição [0]
        listaNomes.Add("Laura");  //posição [1]
        listaNomes.Add("Larissa");  //posição [2]

        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Nesse momento temos {listaNomes.Count} elementos");

        //Criando uma lista de números ja atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };

        Console.WriteLine($"Quantidades de elementos na lista números: {numeros.Count}");
        numeros.Remove(2); //Removendo o elemento 2
        numeros.RemoveAt(1); //Removendo o elemento no indice 1
        numeros.RemoveRange(2, 2); //Removendo 2 elementos a aprtir do indice 2 

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);

        }

        foreach (string nome in listaNomes)
        {
            Console.WriteLine(nome);

        }

        //Criando uma lista com objetos de classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista ded alunos
        Console.WriteLine("Lista Alunos:");


        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno : {item.nome} tem {item.idade} anos");

        }

        //Criando uma nova lista, ordenando por nome
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade = 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
             Console.WriteLine(aluno);
        }
           
        //LINQ utilizando sintaxe de método
        var consulta = listaAlunos
                            .where(aluno => aluno.idade == 17)
                            .orderby (aluno => aluno.nome );
        foreach(var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }


    }
}
