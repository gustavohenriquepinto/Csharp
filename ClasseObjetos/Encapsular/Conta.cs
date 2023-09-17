﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Conta
    {
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value!="Gustavo"&& value != "Henrique")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }

        }
        public double Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }

        public void Sacar(double valor)
        {
            valor += _taxa;

            if (_saldo - valor < 0)
            {
                Console.WriteLine("Não é possível realizar a operação, pois você não possui dinheiro o suficiente");
            }
            else
            {
                _saldo-=valor;
            }
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
