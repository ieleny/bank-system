using byteBank_Alura.SistemaInterno;

namespace byteBank_Alura.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public const double SALARIO_BASE = 5000;

        // A classe filha precisa estar com os mesmos parametros, que a classe pai. Para utilizar esses dados utilizam-se
        // A palavra reservada "base"
        public Diretor(string cpf) : base(cpf, SALARIO_BASE)
        {
            
        }

        // Polimorfismo
        public override double GetBonificacao()
        {
            // Base: pega os dados da superClasse
            // return this.Salario + base.GetBonificacao();

            return this.Salario * 0.5;
        }

        // Polimorfismo
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        // Destrutor
        // O metodo destrutor só executa quando o Garbage collector, indentifica qual o melhor momento para fazer isso
        // O CLR (Common Language Runtime), fica responsavel por isso
        ~Diretor()
        {
            Console.WriteLine("Liberando recursos...");
        }

    }
}
