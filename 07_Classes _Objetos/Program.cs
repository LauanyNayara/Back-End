//sempre que formos utilizar bibliotecas ou classes ja criadas
//importarmos ela com using
using Sesi.Model;


class Program
{
    public static void Main()
    {
        //criando uma varivel aluno1 e instanciando da classe aluno
        //ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
       
        aluno1.nome = "Laura Almeida";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";
        //chamando o metodo da classe aluno
        aluno1.Apresentar();


         var aluno2 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
       
        aluno2.nome = "Joao";
        aluno2.idade = 18;
        aluno2.turma = "Direito";
        //chamando o metodo da classe aluno
        aluno2.Apresentar();

    }
}
