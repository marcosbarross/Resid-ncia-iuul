using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EX7 {

    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nome; 
            Console.WriteLine("Digite seu nome: ");
            nome = (Console.ReadLine());

            while(nome.Length <= 5)
            {
                Console.WriteLine("O nome precisa ter mais que 5 caracteres");
                Console.WriteLine("Digite seu nome: ");
                nome = (Console.ReadLine());
            }

            string cpf;
            Console.WriteLine("digite seu cpf: ");
            cpf = (Console.ReadLine());
            Convert.ToInt64(cpf);

            while(cpf.Length != 11)
            {
                Console.WriteLine("O cpf precisa ter 11 digitos");
                Console.WriteLine("digite seu cpf: ");
                cpf = (Console.ReadLine());
                Convert.ToInt64(cpf);
            }

            string rendaMensal;
            Console.WriteLine("digite sua renda: ");
            rendaMensal = (Console.ReadLine());
            Convert.ToDouble(rendaMensal);

            string estadoCivil;
            Console.WriteLine("Qual seu estado civil? ");
            estadoCivil = (Console.ReadLine());
            bool ok;


            while (ok) {
                if (estadoCivil == "C" || estadoCivil == "c" || estadoCivil == "S" || estadoCivil == "s" || estadoCivil == "v")  || estadoCivil == "V" || estadoCivil == "d" || estadoCivil == "D"){
                    Convert.ToChar(estadoCivil);
                    ok = false;
                }
                else
                {
                    Console.WriteLine("Estado civil inválido ");
                    Console.WriteLine("Qual seu estado civil? ");
                    estadoCivil = (Console.ReadLine());
                }
            }

            string dependentes;
            Console.WriteLine("Você tem quantos dependentes? ");
            dependentes = Console.ReadLine();
            Convert.ToInt32(dependentes);

            while(Convert.ToInt32(dependentes) > 10)
            {
                Console.WriteLine("O valor máximo é 10");
                Console.WriteLine("Você tem quantos dependentes? ");
                dependentes = Console.ReadLine();
                Convert.ToInt32(dependentes);
            }

            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Seu CPF é {cpf}");
            Console.WriteLine($"Sua renda é {rendaMensal}");
            Console.WriteLine($"Seu estado civil é {estadoCivil}");
            Console.WriteLine($"você tem {dependentes} dependentes");
            Console.ReadKey();

            
        }
    }
}
