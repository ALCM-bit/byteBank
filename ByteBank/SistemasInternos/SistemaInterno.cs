using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemasInternos
{
    public class SistemaInterno
    {
        
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Boas vindas ao nosso Sistema. ");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
