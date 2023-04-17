using byteBank_Alura.SistemaInterno;

namespace byteBank_Alura.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
     
        // A classe filha precisa estar com os mesmos parametros, que a classe pai. Para utilizar esses dados utilizam-se
        // A palavra reservada "base"
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        // Adicionar dependendo do nivel
        // Junior
        // Pleno
        // Senior
        // Especialista

        // Polimorfismo
        public override double GetBonificacao()
        {
            // Base: pega os dados da superClasse
            return this.Salario + 0.25;
        }

        // Polimorfismo
        public override void AumentarSalario()
        {
            this.Salario *= 0.5;
        }

    }
}
