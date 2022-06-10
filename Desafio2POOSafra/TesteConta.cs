using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TesteConta
    {
        public static void Main(string[] args)
        {
            Conta c1 = new Conta(new Agencia(1234));

            double pSaldo = 63;

            c1.Deposito(pSaldo);

            Console.WriteLine(" Limite:  " + c1.limite);

            c1 = new Conta(new Agencia(1234));
            c1.numero = 1234;
            c1.saldo = 10000;
            c1.limite = 500;

            Conta c2 = new Conta(new Agencia(1234));
            c2.numero = 5678;
            c2.saldo = 12000;
            c2.limite = 500;

            Console.WriteLine(" Dados da primeira conta ");
            Console.WriteLine(" Número da Conta: " + c1.numero);
            Console.WriteLine(" Saldo da Conta: " + c1.saldo);
            Console.WriteLine(" Limite da Conta: " + c1.limite);

            Console.WriteLine(" ------------------ ");

            Console.WriteLine(" Dados da segunda conta ");
            Console.WriteLine(" Número da Conta: " + c2.numero);
            Console.WriteLine(" Saldo da Conta: " + c2.saldo);
            Console.WriteLine(" Limite da Conta: " + c2.limite);



        }
    }
}
