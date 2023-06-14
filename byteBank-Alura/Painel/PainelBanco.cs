using byteBank_Alura.Contas;
using byteBank_Alura.Titular;

namespace byteBank_Alura.Painel
{
    public class PainelBanco
    {

        public void Painel() 
        {
            Console.WriteLine("Tela de inicialização do banco");
            Console.WriteLine("1 - Gerenciar conta corrente");
            Console.WriteLine("2 - Área Administrador");

            Console.WriteLine("Digite o numero aqui:");

            DigitarOpcao();
        }

        private void DigitarOpcao()
        {
            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            RedirecionamentoPainel(opcaoEscolhida);
        }

        public void RedirecionamentoPainel(int menuOpcao)
        {
            var contexto = new Contexto();

            switch (menuOpcao)
            {
                case 1:
                    contexto.SetStrategy(new ContaCorrenteStrategy());
                    contexto.AcessarPainelEstrategico();
                    break;
            }
        }

    }
}
