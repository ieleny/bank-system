using byteBank_Alura.Titular;
using System.Data;

namespace byteBank_Alura.Contas
{
    //Visibilidade
    //Nome da classe, propriedades,enumeradores,interfaces,records e estruturas precisa ser em PascalCase
    public class ContaCorrente
    {
        // Modificadores de acesso: public, private, protected, internal, protected internal

        // CamelCase: Quando for nomear variaveis que definem campos e parametros de metodos, os campos private ou internal com o prefixo _
        // CamelCase: Metodos
        private int numero_agencia;
        // Propriedades
        public int Numero_agencia 
        {
            get { return this.numero_agencia; }
            // Só será visivel dentro da classe
            private set { 
                if (value > 0) 
                { 
                    numero_agencia = value; 
                } 
            }
        }

        // Propriedade autoimplementada
        public string Conta { get; set; }

        private double saldo = 100;

        // Encapsulamento
        public void SetSaldo(double valor)
        {
            if (valor <= 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public Cliente Titular { get; set; }

        // Quando utiliza o static é uma Propriedade da classe
        // Essa propriedade é salva no codigo fonte do projeto, então cuidado ao utilizar por causa da performance
        public static int TotalDeContasCriadas { get; private set; }
        public static float TaxaOperacao { get; private set; }

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = conta;
            TotalDeContasCriadas++;

            if (numero_agencia <= 0)
            {

                throw new ArgumentException("Numero da agencia menor igual a zero!", nameof(numero_agencia)); 
            }

            try {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Ocorreu um erro! Não é possivel fazer um divisão por zero.");
            }
            
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;

                return true;
            }

            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo > valor)
            {
                Sacar(valor);
                destino.Depositar(valor);

                return true;
            }

            return false;
        }

        public void ExibirDadosDaConta(ContaCorrente dadosConta)
        {
            Console.WriteLine($"Titular da conta: {dadosConta.Titular.Nome}");
            Console.WriteLine($"CPF da conta: {dadosConta.Titular.Cpf}");
            Console.WriteLine($"Profissão da conta: {dadosConta.Titular.Profissao}");
            Console.WriteLine($"Número da conta: {dadosConta.Conta}");
            Console.WriteLine($"Agência: {dadosConta.numero_agencia}");
            Console.WriteLine($"Saldo R$ {string.Format("{0:0.00} \n", dadosConta.saldo)}");
            Console.WriteLine($"Total de contas criadas: {TotalDeContasCriadas}");
            Console.WriteLine($"Total de operacao: {TaxaOperacao}");
        }

    }
}
