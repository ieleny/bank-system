using byteBank_Alura.Contas;
using byteBank_Alura.Exceptions;
using byteBank_Alura.Funcionarios;
using byteBank_Alura.Parceria;
using byteBank_Alura.SistemaInterno;
using byteBank_Alura.Titular;
using byteBank_Alura.Utilitario;
using System.Reflection.Metadata;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
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


            #region

            try
            {
                // Criar uma conta corrente
                Cliente viniciusCliente = new Cliente();
                viniciusCliente.Nome = "Pedro Silva";
                viniciusCliente.Cpf = "146548-88423";
                viniciusCliente.Profissao = "Pedreiro(a)";

                ContaCorrente vinicius = new ContaCorrente(135, "45-x");
                vinicius.Titular = viniciusCliente;
                vinicius.Sacar(150);
                vinicius.ExibirDadosDaConta(vinicius);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Parametro que está com problema: {ex.ParamName}");
                Console.WriteLine($"{ex.Message}");
            }catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine("Operação negada, saldo insuficiente!");
                Console.WriteLine(ex.Message);
            }

            #endregion
        }
    }
}
