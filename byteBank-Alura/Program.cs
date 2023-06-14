using byteBank_Alura.Contas;
using byteBank_Alura.Funcionarios;
using byteBank_Alura.Parceria;
using byteBank_Alura.SistemaInterno;
using byteBank_Alura.Titular;
using byteBank_Alura.Utilitario;

using byteBank_Alura.Painel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var painelBanco = new PainelBanco();
            painelBanco.Painel();
        }
    }
}
