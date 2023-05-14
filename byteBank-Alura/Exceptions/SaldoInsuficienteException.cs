﻿
namespace byteBank_Alura.Exceptions
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {

        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, Exception inner): base(message, inner) { }

    }
}
