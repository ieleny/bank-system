using byteBank_Alura.Contas;
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

            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(opcaoEscolhida);
        }

        private void CriarContaCorrente()
        {
            Cliente clienteAndre = new Cliente();
            clienteAndre.Nome = "André silva";
            clienteAndre.Cpf = "146548-8848";
            clienteAndre.Profissao = "Contador";

            var contaDoAndre = new ContaCorrente(15, "1010-4");
            contaDoAndre.Titular = clienteAndre;

            contaDoAndre.ExibirDadosDaConta(contaDoAndre);
        }

    }
}
