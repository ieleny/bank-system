using System;
using System.Collections.Generic;

namespace byteBank_Alura.Painel
{

    class Contexto
    {
        private IStrategy _strategy;

        public Contexto()
        { }

        public Contexto(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void AcessarPainelEstrategico()
        {
            this._strategy.AcessarPainelEstrategico();
        }
    }

}