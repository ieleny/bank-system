using byteBank_Alura.SistemaInterno;

namespace byteBank_Alura.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public const double SALARIO_BASE = 5000;

        public Diretor(string cpf) : base(cpf, SALARIO_BASE)
        {
            
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        ~Diretor()
        {
            Console.WriteLine("Liberando recursos...");
        }

    }
}
