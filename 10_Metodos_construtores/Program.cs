using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da Classe pessoa
        //Instanciando sem um métodp construtor

        /*  Pessoa pessoa1 = new Pessoa();
         pessoa1.nome = "Lauany";
         pessoa1.idade = 16;
         pessoa1.Cantar();

         //Alternativa para criação de um objeto sem construtor
         Pessoa pessoa2 = new Pessoa
         {
             nome = "Laura",
             idade = 16
         };
         pessoa2.Cantar();*/

        Pessoa pessoa1 = new Pessoa("Lauany", 16, "lauany.almeida@portalsesisp.org.br");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("laura", 16, "lauraalmeida@portalsesisp.org.br");
        pessoa2.Cantar();
        pessoa2.Informacoes();

        Pessoa pessoa3 = new Pessoa("larissa", 19, "larissamayara@hotmail.com.br");
        pessoa3.Cantar();
        pessoa3.Informacoes();
    }
}