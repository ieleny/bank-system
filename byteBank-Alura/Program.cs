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
