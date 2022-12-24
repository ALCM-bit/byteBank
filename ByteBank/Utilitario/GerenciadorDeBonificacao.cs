using ByteBank.Funcionarios;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonficacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalDeBonficacao += funcionario.GetBonificacao();
        }
    }
}