using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using static ex3NumerosDeArmstrong.Program;

namespace ex3NumerosDeArmstrong
{
    internal class Program
    {
        public class na
        {

            public bool IsArmstrong(int numero)
            {
                int n = numero;
                int digito;
                int digitoElevado;
                int tamanhoN = n.ToString().Length;
                int soma = 0;

                while (n > 0)
                {
                    
                    digito = n % 10;

                    digitoElevado = Convert.ToInt32(Math.Pow(digito, tamanhoN));
                    soma = soma + digitoElevado;
                    n = n / 10;

                }

                if (soma == numero) { return true; }
                else { return false; }
            }
        }

        static void Main(string[] args)
        {
            na a = new na();
            

            for (int i = 0; i <= 10000; i++)
            {
                a.IsArmstrong(i);
                if (a.IsArmstrong(i)) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
