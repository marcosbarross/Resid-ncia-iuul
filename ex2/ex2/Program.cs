using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    

    public class vertice
    {
        public int x
        {
            get; 
            private set; 
        }

        public int y
        {
            get;
            private set;
        }

        public int distancia(int v1, int v2)
        {
            x = v1;
            y = v2;

            if (x > y) {
                int dist = x - y;
                return dist;
            }
            else
            {
                int dist = y - x;
                return dist;
            }
        }

        public string move(int v1, int v2)
        {
            x = v1;
            y = v2;

            string novoVertice = $"As novas coordenadas são {x} + {y}";

            return novoVertice;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            vertice v = new vertice();
            Console.WriteLine(v.distancia(1, 2));
            
            
        }
    }
}
