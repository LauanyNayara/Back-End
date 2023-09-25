namespace Models
{

    public class Pessoa
    {
        // Atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        private string email { get; set; }

        private int anoNascimento { get; set; }
        // Método construtor da classe Pessoa


        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }

        // Métodos da Classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($" {nome} tem o email {email}, tem {idade} anos e nasceu em {anoNascimento} ");
            
        }
    }
}