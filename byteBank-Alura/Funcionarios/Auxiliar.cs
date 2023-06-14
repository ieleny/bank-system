namespace byteBank_Alura.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        // Adicionar dependendo do nivel
        // Junior
        // Pleno
        // Senior
        // Especialista

        public override double GetBonificacao()
        {
            return this.Salario + 0.2;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        ~Auxiliar()
        {
            Console.WriteLine("Liberando recursos...");
        }

    }
}
