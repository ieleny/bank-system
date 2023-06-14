
namespace byteBank_Alura.Exceptions
{
    public class OperacaoFinanceiraException : Exception
    {
        // InnerException
        // Dependendo se for usuário ou cliente, irá informar execeções diferentes.
        public OperacaoFinanceiraException(string message) : base(message) { }
        public OperacaoFinanceiraException(string message, Exception excecaoInterna) : base(message, excecaoInterna) { }
    }
}
