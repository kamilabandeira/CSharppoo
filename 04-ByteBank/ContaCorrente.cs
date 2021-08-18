﻿namespace _04_ByteBank
{
    internal class ContaCorrente
    {
        internal string titular;
        internal int agencia;
        internal int numero;
        internal double saldo = 100;
       
        public bool Sacar(double valor) 
        {
            if(this.saldo < valor) 
            {
                return false;
            }
            
            this.saldo -= valor;
            return true;
            
        }

        public void Depositar(double valor) 
        {
            this.saldo += valor;
        }

        public bool Trasferir(double valor, ContaCorrente contaDestino) 
        {
            if(this.saldo < valor) 
            {
                return false;
            }
            
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
            
        }
    }
}