using System;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaDoAndre = new ContaCorrente();
            contaDoAndre.titular = "André Silva";
            contaDoAndre.agencia = 15;
            contaDoAndre.conta = "1010-X";
            contaDoAndre.saldo = 100;

            

            Console.WriteLine(contaDoAndre.titular);
            Console.WriteLine(contaDoAndre.agencia);
            Console.WriteLine(contaDoAndre.conta);
            Console.WriteLine(contaDoAndre.saldo);

            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "Maria Souza";
            contaDaMaria.agencia = 17;
            contaDaMaria.conta = "1010-5";
            contaDaMaria.saldo = 350.0;

            Console.WriteLine(contaDaMaria.titular);
            Console.WriteLine(contaDaMaria.agencia);
            Console.WriteLine(contaDaMaria.conta);
            Console.WriteLine(contaDaMaria.saldo);

            contaDoAndre.Transferir(50, contaDaMaria);

            Console.WriteLine($"Andre saldo {contaDoAndre.saldo}");
            Console.WriteLine($"Maria saldo {contaDaMaria.saldo}");

        }
    }
}