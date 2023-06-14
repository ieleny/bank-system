using byteBank_Alura.SistemaInterno;

namespace byteBank_Alura.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario + 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.5;
        }

    }
}
