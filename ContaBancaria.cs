using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_contaBancaria
{
    public abstract class ContaBancaria
    {
        private double Saldo {get; set;}
        public double Valor {get; set;}

        public ContaBancaria(double saldo, double valor){
            Saldo = saldo;
            Valor = valor;
        }

        public abstract void Depositar();

        public abstract void Sacar();
    }
}