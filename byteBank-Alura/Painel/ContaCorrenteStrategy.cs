using byteBank_Alura.Contas;
using byteBank_Alura.Repositorios.Contas;
using byteBank_Alura.Titular;
using System;

namespace byteBank_Alura.Painel
{
    public class ContaCorrenteStrategy : IStrategy
    {

        public void AcessarPainelEstrategico() 
        {
            Console.WriteLine("Painel Conta corrente");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Transferir");

            Console.WriteLine("Digite o numero aqui:");
            DigitarOpcao();
        }

        private void DigitarOpcao()
        {
            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            RedirecionamentoPainel(opcaoEscolhida);
        }

        private void RedirecionamentoPainel(int menuOpcao)
        {
            var contexto = new ContaCorrenteRepositorio();

            switch (menuOpcao)
            {
                case 1:
                    contexto.CriarContaCorrente();
                    break;
                case 2:
                    contexto.EditarContaCorrente();
                    break;
                case 3:
                    contexto.TransferirContaCorrente();
                    break;
            }
        }

    }
}
