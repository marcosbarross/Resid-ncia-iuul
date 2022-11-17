using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{

    public class piramide
    {

        private int n;

        public int N
        {
            get { return n; }
            set
            {
                if (N > 0)
                {
                    n = value;
                }

                else 
                {
                    throw new ArgumentOutOfRangeException("N precisa ser maior ou igual a 1");
                    
                }
            }

        }

        public void Desenha() //algoritmo visto na aula do dia 16/11
        {
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i - 1 ; j >= i; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                piramide p = new piramide();
                p.N = 3;
                p.Desenha();
            }
        }
    }
}
