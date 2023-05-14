using byteBank_Alura.Contas;
using byteBank_Alura.Titular;

namespace byteBank_Alura.Painel
{
    public class PainelBanco
    {

        public void Painel() 
        {
            Console.WriteLine("Tela de inicialização do banco");
            Console.WriteLine("1 - Adicionar conta corrente");
            Console.WriteLine("2 - Acessar conta corrente");
            Console.WriteLine("3 - Área Administrador");

            Console.WriteLine("Digite o numero aqui:");

            this.DigitarOpcao();
        }

        private void DigitarOpcao()
        {
            int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            this.RedirecionamentoPainel(opcaoEscolhida);
        }

        public void RedirecionamentoPainel(int menuOpcao)
        {
            switch (menuOpcao)
            {
                case 1:
                    this.CriarContaCorrente();
                    break;
            }
        }


        private void CriarContaCorrente()
        {
            Cliente clienteAndre = new Cliente();
            clienteAndre.Nome = "André silva";
            clienteAndre.Cpf = "146548-8848";
            clienteAndre.Profissao = "Contador";

            ContaCorrente contaDoAndre = new ContaCorrente(15, "1010-4");
            contaDoAndre.Titular = clienteAndre;

            contaDoAndre.ExibirDadosDaConta(contaDoAndre);
        }

    }
}
