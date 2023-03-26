using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Banco.Models
{

    public class Operacoes
    {
        public string? Ag{ 
            set
            {
                if(value != "123456")
                {
                    Console.WriteLine("Agência não encontrada");
                }
            }
            }
        public string? Conta{ 
            set
            {
                if(value != "1234")
                {
                    Console.WriteLine("Conta não encontrada");
                }
            }
        }
        public int Saldo{ get; set; }

        public void Login()
        {
            Console.WriteLine("Seja bem vindo!");

            Console.WriteLine("Digite o número da agência");
            Ag = Console.ReadLine();

            Console.WriteLine("Digite o número da conta");
            Conta = Console.ReadLine();
        }

         public void Op()
        {
            Console.WriteLine("Selecione a opção desejada!");
            Console.WriteLine(" Opção 1 - Consulta saldo");
            Console.WriteLine(" Opção 2 - Saque");
            Console.WriteLine(" Opção 3 - Depósito");
            Console.WriteLine(" Opção 4 - Sair");

            string selecao = Console.ReadLine();

            switch(selecao)
            {
                case "1":
                Console.WriteLine($"Seu saldo é: {Saldo}");
                break;

                case "2":
                Console.WriteLine("Realizar saque");
                break;

                case "3":
                Console.WriteLine("Realizar depósito");
                break;

                case "4":
                Console.WriteLine("Obrigado!");
                break;

                default:
                Console.WriteLine("Opção inválida");
                break;
            }

        }

        public void MostrarSaldo()
        {

        }
    }
}