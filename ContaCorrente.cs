using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_contaBancaria{
    public class ContaCorrente : ContaBancaria{
        public double Saldo {get; set;} = 0;
        public ContaCorrente(double saldo, double valor) 
        : base(saldo, valor){
            Saldo = saldo;
        }

        public override void Depositar(){
            Saldo += Valor;
            Console.WriteLine("Depósito efetuado com sucesso! \nSaldo atual: " + Saldo);
        }

        public override void Sacar()
        {
            if(Saldo >= Valor){
                Saldo -= Valor;
                Console.WriteLine("Saque efetuado com sucesso! \nSaldo atual: " + Saldo);
            }else{
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}