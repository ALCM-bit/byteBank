using System;
//using ByteBank.Contas;
using ByteBank.Funcionarios;

using ByteBank.SistemasInternos;
using ByteBank.Utilitario;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region
            //Funcionario pedro = new Funcionario("123456789", 2000.0);
            //pedro.Nome = "Pedro";


            //Console.WriteLine(pedro.Nome);
            //Console.WriteLine(pedro.GetBonificacao());

            //Diretor roberta = new Diretor("98745332");
            //roberta.Nome = "Roberta Silva";


            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            //gerenciador.Registrar(pedro);
            //gerenciador.Registrar(roberta);

            //Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);

            //Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

            //pedro.AumentarSalario();
            //roberta.AumentarSalario();

            //Console.WriteLine(pedro.Salario);
            //Console.WriteLine(roberta.Salario);
            #endregion

            //CalcularBonificacao();
            UsarSistema();
            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                Designer ulisses = new Designer("123456");
                ulisses.Nome = "Ulisses Souza";

                Diretor paula = new Diretor("987456");
                paula.Nome = "Paula Souza";

                Auxiliar igor = new Auxiliar("74581");
                igor.Nome = "Igor Dias";

                GerenteDeContas camila = new GerenteDeContas("852963");
                camila.Nome = "Camila Oliveira";

                gerenciador.Registrar(camila);
                gerenciador.Registrar(igor);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(ulisses);

                Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonficacao);

                //Funcionario pedro = new Funcionario("123456",852);
            }

            void UsarSistema()
            {
                SistemaInterno sistemaInterno = new SistemaInterno();

                Diretor ingrid = new Diretor("2334532131123");
                ingrid.Nome = "Ingrid Novaes";
                ingrid.Senha = "123";

                GerenteDeContas ursula = new GerenteDeContas("21334421");
                ursula.Nome = "Ursula Alcantara";
                ursula.Senha = "321";

                
                sistemaInterno.Logar(ingrid, "123");
                sistemaInterno.Logar(ursula, "123");
                
            }
        }
    }
}