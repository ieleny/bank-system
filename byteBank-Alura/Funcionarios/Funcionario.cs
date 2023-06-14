using byteBank_Alura.Contas;

namespace byteBank_Alura.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf; 
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

        public void ExibirDados(Funcionario funcionario)
        {
            Console.WriteLine($"Nome do funcionario: {funcionario.Nome}");
            Console.WriteLine($"CPF do funcionario: {funcionario.Cpf}");
            Console.WriteLine($"Salario R$ {string.Format("{0:0.00}", funcionario.Salario)}");
            Console.WriteLine($"Bonificação R$ {string.Format("{0:0.00}", funcionario.GetBonificacao())}");
            Console.WriteLine($"Total de funcionarios: {TotalDeFuncionarios} \n");
        }

    }
}
