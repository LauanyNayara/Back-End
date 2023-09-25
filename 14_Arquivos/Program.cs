using System.IO;

public class Program
{
    string arquivoTexto = "Arquivo/arquivo.txt";
    public static void Main()
    {
        //Chamando o método GravarArquivo
        //GravarArquivo();
        //Chamando o método LerArquivo
        LerArquivo();


    }

    public static void LerArquivo()
    {
        //Instanciando um objeto de classe StreamReader para ler o arquivo
        try
        {

            // Verificar se o arquivo existe
            if (File.Exists(arquivoTexto) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando 
                //a verificação no if é falsa ou seja o arquivo não existe
                File.Create(arquivoTexto)
            }

            using (StreamReader arquivo = new StreamReader(arquivoTexto))
            {

                string linha;
                //Fazendo o while para ler linha pr linha que contém no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    // Escrevendo no console o conteúdo da linha
                    Console.WriteLine(linha);
                }
            }
            catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}
public static void GravarArquivo()
{
    try
    {
        using (StreamWriter arquivo = new StreamWriter(arquivoTexto, true))
        {
            Console.WriteLine("Digite o texto");
            arquivo.WriteLine(Console.ReadLine());
        }
    }
    catch (Exception erro)
    {
        Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
    }

}
}
