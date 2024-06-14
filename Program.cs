// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;
using exercicio_contaBancaria;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaPoupanca conta1 = new ContaPoupanca(1500d, 600d);
        ContaCorrente conta2 = new ContaCorrente(3500d, 1000d);
        ContaInvestimento conta3 = new ContaInvestimento(5000d, 2000d);

        Console.WriteLine("Conta Poupança: ");
        conta1.Rendimento();
        conta1.Depositar();
        conta1.Sacar();
        Console.WriteLine("\nConta Corrente: ");
        conta2.Depositar();
        conta2.Sacar();
        Console.WriteLine("\nConta Investimento: ");
        conta3.Rendimento();
        conta3.Depositar();
        conta3.Rendimento();
        conta3.Sacar();
    }
}