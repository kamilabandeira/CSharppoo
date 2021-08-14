using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.tituar = "Gabriela";
            conta.saldo = 200;

            Console.WriteLine(conta.tituar);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);

            Console.WriteLine();
        }
    }
}
