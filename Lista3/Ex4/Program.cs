using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {

        public class itens
        {
            List<string> list = new List<string>();
            public void RemoveRepetidos()
            {
                List<string> listaSemRepeticao = new List<string>();
                foreach (var item in list)
                {
                    if (list.Contains(item))
                    {
                        return;
                    }
                    else
                    {
                        listaSemRepeticao.Add(item);
                    }
                }
                
                for (int i = 0; i < list.Count(); i++)
                {
                    Console.WriteLine(listaSemRepeticao[i]);
                }
            }

            static void Main(string[] args)
            {
                itens a = new itens();
                a.list.Add("1");
                a.list.Add("1");
                a.list.Add("1");
                a.list.Add("1");
                a.list.Add("2");
                a.list.Add("3");

                a.RemoveRepetidos();

            }
        }
    }
}
