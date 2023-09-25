public class Program
{
    public static void Main()
    {
        /* O try serve para tratar um erro e não parar a execução do programa 
            se occorer qualquer erro dentro do bloco try, o sistema imterrompe
            a execussao do bloco e vai para o catch */
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voc~e digitou o número {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O Resultado é: {resultado}");
        }
        //Tratando exceção de overflow (estouro de campo)
        catch (OverflowException)
        {
            Console.WriteLine($"Esse numero é maior que o suportado")
        }
        /* Tratando exceção de erro de formato */
        catch (FormatException)
        {
            Console.WriteLine($"Erro: digite um número inteiro");
        }
        /* Catch é o tratamento do erro, normalmente colocamos as mensagens de acordo 
            com o tipo do erro, para melhor compreensão do usuário */
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
        /* O finally é um bloco executado independentemente se ocorrer erro ou não */
        finally
        {
            Console.WriteLine($"Entrando no finally");
        }
    }
}
