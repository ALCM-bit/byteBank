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
            Funcionario pedro = new Funcionario();
            pedro.Nome = "Pedro";
            pedro.Cpf = "123456789";
            pedro.Salario = 2000.0;

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.GetBonificacao());

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta Silva";
            roberta.Cpf = "98745332";
            roberta.Salario = 5000;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
        }
    }
}