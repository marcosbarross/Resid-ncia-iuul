using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Lista3.Program;

namespace Lista3
{
    internal class Program
    {
        public class IndiceRemissivo
        {
            List<string> list = new List<string>();
            List<string> imprimir = new List<string>();

            
            public void indice(string pathTXT)
            {
                var contents = File.ReadAllLines(pathTXT);
                
                for (int i = 0; i < contents.Length; i++)
                {
                    string linha = contents[i].ToString();
                    string[] palavras = linha.Split(' ');

                    foreach (var palavra in palavras)
                    {
                        list.Add(palavra);
                    }

                    foreach (var palavra in palavras)
                    {

                        if(palavra.Length > 1 && imprimir.Contains(palavra) == false)
                        {
                            imprimir.Add($"{palavra.ToUpper()}, {list.IndexOf(palavra)}, {i}");
                        }
                    }

                }



                imprimir.Sort();
            }

            public void Imprime(string outFile)
            {
                File.WriteAllLines(outFile, imprimir);
            }
        }


        static void Main(string[] args)
        {
            IndiceRemissivo i = new IndiceRemissivo();
            i.indice(@"C:\Users\marco\Downloads\Unidade 1 - Exercicios - Parte 3\texto.txt");
            i.Imprime(@"C:\Users\marco\Downloads\Unidade 1 - Exercicios - Parte 3\someOutFile.txt");
        }

    }
        
}