namespace byteBank_Alura.Funcionarios
{
    public class Designer : Funcionario
    {
        // A classe filha precisa estar com os mesmos parametros, que a classe pai. Para utilizar esses dados utilizam-se
        // A palavra reservada "base"
        public Designer(string cpf) : base(cpf, 3000)
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
            return this.Salario + 0.17;
        }

        // Polimorfismo
        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

    }
}
