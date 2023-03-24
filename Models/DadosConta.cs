using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.Models
{
    public class DadosConta
    {
        public DadosConta(int numeroConta, int numeroAgencia)
        {
            NumeroConta = numeroConta;
            NumeroAgencia = numeroAgencia;
        }
        public int NumeroConta
        {
        
            set
            {
                if(value != 123456){
                    Console.WriteLine("Conta não encontrada");
                }
            }
        }
        public int NumeroAgencia
        { 
            set
            {
                if(value != 1234)
                {
                    Console.WriteLine("Agencia não encontrada");
                }
            } 
        }
        public int Senha{ get; set; }

       
    }
}