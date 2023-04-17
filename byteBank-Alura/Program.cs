using byteBank_Alura.Contas;
using byteBank_Alura.Funcionarios;
using byteBank_Alura.Parceria;
using byteBank_Alura.SistemaInterno;
using byteBank_Alura.Titular;
using byteBank_Alura.Utilitario;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Tipo do objeto(ContaCorrente)
            Cliente clienteAndre = new Cliente();
            clienteAndre.Nome = "André silva";
            clienteAndre.Cpf = "146548-8848";
            clienteAndre.Profissao = "Contador";
            ContaCorrente contaDoAndre = new ContaCorrente(15, "1010-4");
            contaDoAndre.Titular = clienteAndre;
            contaDoAndre.SetSaldo(100);

            contaDoAndre.Depositar(100);

            if (contaDoAndre.Sacar(300) == false)
            {
                Console.WriteLine("Saldo insuficiente para saque \n");
            }

            contaDoAndre.ExibirDadosDaConta(contaDoAndre);

            Cliente clienteMaria = new Cliente();
            clienteMaria.Nome = "Maria Souza";
            clienteMaria.Cpf = "146548-88423";
            clienteMaria.Profissao = "Pedreiro(a)";
            ContaCorrente contaDaMaria = new ContaCorrente(17, "1010-5");
            contaDaMaria.Titular = clienteMaria;
            contaDaMaria.SetSaldo(350);

            contaDoAndre.Transferir(50, contaDaMaria);

            contaDaMaria.ExibirDadosDaConta(contaDaMaria);
            contaDoAndre.ExibirDadosDaConta(contaDoAndre);

            // A conta do pedro não foi definido nenhum valor, por isso irá mostrar os valores padrões de cada tipo (string = null, bool = false, int = 0 ...)
            Cliente clientePedro = new Cliente();
            clientePedro.Nome = "Pedro Silva";
            ContaCorrente contaDoPedro = new ContaCorrente(17, "1010-9");
            contaDoPedro.Titular = clientePedro;
            contaDoPedro.ExibirDadosDaConta(contaDoPedro);

            // Tipo de valor
            // Tipo de referencia

            // Referência nulla
            ContaCorrente contaOsvaldo = new ContaCorrente(18, "1010-10");
            // Não tem como definir os valores, sem definir o new
            //contaOsvaldo.titular.nome = "Osvaldo cruz";
            //contaOsvaldo.titular.cpf = "146548-88423";
            //contaOsvaldo.titular.profissao = "Pedreiro(a)";
            //contaOsvaldo.Numero_agencia = 17;
            //contaOsvaldo.Conta = "1010-5";
            contaOsvaldo.Titular = clientePedro;
            // Controle de valor negativo
            contaOsvaldo.SetSaldo(350);
            contaOsvaldo.ExibirDadosDaConta(contaOsvaldo);

            // Referencia da propriedade de classe
            // Console.WriteLine($"Propriedades da classe: {ContaCorrente.TotalDeContasCriadas}");

            // Criar um menu para adicionar funcionarios, adicionar conta

            #endregion

            #region
            // Funcionarios
            // É uma classe abstrata não funciona
            //Funcionario pedro = new Funcionario("123456789", 2000);
            //pedro.Nome = "Pedro malazartes";
            //pedro.AumentarSalario();
            //pedro.ExibirDados(pedro);

            // Diretor
            Diretor roberta = new Diretor("1237356789");
            roberta.Nome = "Roberta malavazres";
            roberta.AumentarSalario();
            roberta.ExibirDados(roberta);

            // Designer
            Designer ulisses = new Designer("2342325");
            ulisses.Nome = "Roberta malavazres";
            ulisses.AumentarSalario();
            ulisses.ExibirDados(ulisses);

            // Designer
            Auxiliar marcelo = new Auxiliar("2342325");
            marcelo.Nome = "Roberta malavazres";
            marcelo.AumentarSalario();
            marcelo.ExibirDados(marcelo);

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(ulisses);
            gerenciador.Registrar(marcelo);

            Console.WriteLine("Total de bonificações:" + gerenciador.TotalDeBonificacoes);
            #endregion

            #region

            UsarSistema();

            void UsarSistema()
            { 
                SistemaInterno sistema = new SistemaInterno();
                Diretor ingrid = new Diretor("852741");
                ingrid.Nome = "Ingrid Novaes";
                ingrid.Senha = "123";

                GerenteDeContas ursula = new GerenteDeContas("963741");
                ursula.Nome = "Ursula Alcantara";
                ursula.Senha = "321";

                ParceiroComercial caio = new ParceiroComercial();
                caio.Senha = "321";

                sistema.Logar(ingrid, "123");
                sistema.Logar(ursula, "963");
                sistema.Logar(caio, "321");
            }

            #endregion
        }
    }
}
