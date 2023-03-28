using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        private double saldo = 100;

        public Cliente titular;

        public void DemostrativoContaCorrente(ContaCorrente nome)
        {
            Console.WriteLine($"Titular da conta: {nome.titular.nome}");
            Console.WriteLine($"Número da conta: {nome.conta}");
            Console.WriteLine($"Agência: {nome.numero_agencia}");
            Console.WriteLine($"Saldo R$ {string.Format("{0:0.00}", nome.saldo)}" + "\n" + "\n");
        }
        public void Depositar(double valor, ContaCorrente destino)
        {
            saldo += valor;
            Console.WriteLine("Valor do depósito na conte de " + destino.titular + $" R$ {string.Format("{0:0.00}", valor)}");
            Console.WriteLine($"Saldo após o deposito é: R$ {string.Format("{0:0.00}", destino.saldo)}" + "\n");
        }

        public void Sacar(double valor, ContaCorrente origem)
        {

            if (valor <= saldo)
            {
                Console.WriteLine("Valor para saque na conta de " + origem.titular + $" é R$ {string.Format("{0:0.00}", valor)}");
                saldo -= valor;
                Console.WriteLine("Saldo após último saque na conta de " + origem.titular + $" R$ {string.Format("{0:0.00}", saldo)}" + "\n");
            }
            else
                Console.WriteLine("Saldo insuficiênte");
        }

        public void Transferir(double valor, ContaCorrente origem, ContaCorrente destino)
        {
            if (saldo >= valor)
            {
                Sacar(valor, origem);
                destino.Depositar(valor, destino);

                Console.WriteLine("Valor da transferência na conta de " + origem.titular + $" é R$ {string.Format("{0:0.00}", valor)}");
                Console.WriteLine("Saldo após transfência " + destino.titular + $" R$ {string.Format("{0:0.00}", destino.saldo)}" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "O saldo de " + origem.titular + " insuficênte para transferência");
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
