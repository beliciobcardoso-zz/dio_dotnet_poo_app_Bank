using System;

namespace Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorSaque)
        {
            this.Saldo += valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTranferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTranferencia))
            {
                contaDestino.Depositar(valorTranferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta: " + this.TipoConta + " - ";
            retorno += "Nome: " + this.Nome + " - ";
            retorno += "Saldo: " + this.Saldo + " - ";
            retorno += "Crédito: " + this.Credito;
            return retorno;
        }

    }
}