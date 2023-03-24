using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Models
{
    public class Operacoes
    {
         public void Op()
        {
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("Selecione a opção desejada!");
            Console.WriteLine(" Opção 1 - Consulta saldo");
            Console.WriteLine(" Opção 2 - Saque");
            Console.WriteLine(" Opção 3 - Depósito");

            string selecao = Console.ReadLine();

            switch(selecao)
            {
                case "1":
                Console.WriteLine("Mostrar saldo");
                break;

                case "2":
                Console.WriteLine("Realizar saque");
                break;

                case "3":
                Console.WriteLine("Realizar depósito");
                break;

                default:
                Console.WriteLine("Opção inválida");
                break;
            }

        }
    }
}