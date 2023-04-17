using byteBank_Alura.SistemaInterno;

namespace byteBank_Alura.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public  bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
