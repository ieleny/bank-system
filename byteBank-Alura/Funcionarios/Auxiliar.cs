namespace byteBank_Alura.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        // A classe filha precisa estar com os mesmos parametros, que a classe pai. Para utilizar esses dados utilizam-se
        // A palavra reservada "base"
        public Auxiliar(string cpf) : base(cpf, 2000)
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
            return this.Salario + 0.2;
        }

        // Polimorfismo
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        // Destrutor
        // O metodo destrutor só executa quando o Garbage collector, indentifica qual o melhor momento para fazer isso
        // O CLR (Common Language Runtime), fica responsavel por isso
        ~Auxiliar()
        {
            Console.WriteLine("Liberando recursos...");
        }

    }
}
