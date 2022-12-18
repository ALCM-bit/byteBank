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

            ContaCorrente conta3 = new ContaCorrente();
            conta3.SetSaldo(200);

            Console.WriteLine(conta3.GetSaldo());
        }
    }
}