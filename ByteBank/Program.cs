using System;
//using ByteBank.Contas;
using ByteBank.Funcionarios;
using ByteBank.Utilitario;
//using ByteBank.Titular;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario pedro = new Funcionario("123456789", 2000.0);
            pedro.Nome = "Pedro";
            

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.GetBonificacao());

            Diretor roberta = new Diretor("98745332", 5000.0);
            roberta.Nome = "Roberta Silva";
            

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);

            Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

            pedro.AumentarSalario();
            roberta.AumentarSalario();

            Console.WriteLine(pedro.Salario);
            Console.WriteLine(roberta.Salario);
        }
    }
}