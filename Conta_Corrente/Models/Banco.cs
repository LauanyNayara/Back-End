namespace Models
{

    public class ContaCorrente
    {
        // Atributos da nossa classe pessoa
        private string nome { get; set; }
        private decimal saldo { get; set; }

        // Método construtor da classe Pessoa


        public ContaCorrente(string nomePessoa)
        {
            this.nome = nomePessoa;
        }

        // Métodos da Classe pessoa
        public void ConsultarSaldo()
        {
            Console.WriteLine($" seu saldo é {saldo} ");
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            if (valor > 0) ;

        }

        public void Sacar(decimal retirarValor)
        {+
                saldo -= retirarValor;
            else
            {
                Console.WriteLine($"Seu saldo é insuficiente para retirar esse valor");
            }
        }


    }
}