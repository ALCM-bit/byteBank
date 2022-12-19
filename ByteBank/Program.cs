using System;
using ByteBank.Contas;
using ByteBank.Titular;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ContaCorrente contaDoAndre = new ContaCorrente();
            //contaDoAndre.titular = "André Silva";
            //contaDoAndre.agencia = 15;
            //contaDoAndre.conta = "1010-X";
            //contaDoAndre.saldo = 100;



            //Console.WriteLine(contaDoAndre.titular);
            //Console.WriteLine(contaDoAndre.agencia);
            //Console.WriteLine(contaDoAndre.conta);
            //Console.WriteLine(contaDoAndre.saldo);

            //ContaCorrente contaDaMaria = new ContaCorrente();
            //contaDaMaria.titular = "Maria Souza";
            //contaDaMaria.agencia = 17;
            //contaDaMaria.conta = "1010-5";
            //contaDaMaria.saldo = 350.0;

            //Console.WriteLine(contaDaMaria.titular);
            //Console.WriteLine(contaDaMaria.agencia);
            //Console.WriteLine(contaDaMaria.conta);
            //Console.WriteLine(contaDaMaria.saldo);

            //contaDoAndre.Transferir(50, contaDaMaria);

            //Console.WriteLine($"Andre saldo {contaDoAndre.saldo}");
            //Console.WriteLine($"Maria saldo {contaDaMaria.saldo}");

            //ContaCorrente contaDoPedro = new ContaCorrente();
            //Console.WriteLine(contaDoPedro.saldo);

            //Cliente cliente = new Cliente();
            //cliente.nome = "Andre Silva";
            //cliente.cpf = "123456789";
            //cliente.profissao = "Analista";

            //ContaCorrente conta = new ContaCorrente();
            //conta.titular = cliente;
            //conta.conta = "1010-X";
            //conta.agencia = 15;
            //conta.saldo = 100;

            //Console.WriteLine("Titular = " + conta.titular.nome);

            //ContaCorrente conta3 = new ContaCorrente();
            //conta3.SetSaldo(200);
            //conta3.Agencia = 19;
            //Console.WriteLine(conta3.GetSaldo());
            //Console.WriteLine(conta3.Agencia);
            //conta3.Conta = "1011-H";
            //Console.WriteLine(conta3.Conta);

            //ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
            //conta4.SetSaldo(500);
            //conta4.Titular = new Cliente();
            //conta4.Titular.Nome = "Felipe";

            //Console.WriteLine(conta4.GetSaldo());
            //Console.WriteLine(conta4.Agencia);
            //Console.WriteLine(conta4.Titular.Nome);

            ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta6 = new ContaCorrente(345, "1345-X");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}