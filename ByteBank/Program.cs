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
            contaDoAndre.Depositar(100);
            Console.WriteLine($"Saldo pós deposito {contaDoAndre.saldo}");

            if(contaDoAndre.Sacar(300)== true)
            {
                Console.WriteLine($"Saldo pós saque {contaDoAndre.saldo}");

            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
            }
            
        }
    }
}