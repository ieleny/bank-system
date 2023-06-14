using byteBank_Alura.Contas;
using byteBank_Alura.Titular;

namespace byteBank_Alura.Repositorios.Contas
{
    public class ContaCorrenteRepositorio : IContaCorrenteRepositorio
    {

        public void CriarContaCorrente()
        {
            Cliente clienteAndre = new Cliente();
            clienteAndre.Nome = "André silva";
            clienteAndre.Cpf = "146548-8848";
            clienteAndre.Profissao = "Contador";

            var contaDoAndre = new ContaCorrente(15, "1010-4");
            contaDoAndre.Titular = clienteAndre;

            contaDoAndre.ExibirDadosDaConta(contaDoAndre);
        }

        public void EditarContaCorrente()
        {

        }

        public void TransferirContaCorrente()
        { }

    }
}
