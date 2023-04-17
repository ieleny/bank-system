using byteBank_Alura.Funcionarios;

namespace byteBank_Alura.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha) 
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado) 
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");

                return true;
            }


            Console.WriteLine("Senha incorreta");
            return false;
        }
    }
}
