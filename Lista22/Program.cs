using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista22
{

    public class turma
    {

        
        public string nome { get; set; }
        public int p1 { get; set; }
        public int p2 { get; set; }
        private int NFs;
        public int NF
        {
            get {
                NFs = (p1 + p2) / 2;
                return NFs; 
            }
            set { NFs = (p1 + p2) / 2; }

        }
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<turma> listaAlunos = new List<turma>();

            turma aluno = new turma();
            aluno.nome = "Marcos";
            aluno.p1 = 10;
            aluno.p2 = 9;
            listaAlunos.Add(aluno);

            turma aluno1 = new turma();
            aluno1.nome = "Larissa";
            aluno1.p1 = 8;
            aluno1.p2 = 5;
            listaAlunos.Add(aluno1);

            turma aluno2 = new turma();
            aluno2.nome = "Deborah";
            aluno2.p1 = 4;
            aluno2.p2 = 8;
            listaAlunos.Add(aluno2);

            List<turma> listaAlunosOrdenados = listaAlunos.OrderBy(t => t.nome).ToList();

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                Console.WriteLine($"A média do aluno {listaAlunosOrdenados[i].nome} foi {listaAlunosOrdenados[i].NF}");
            }

            
        }
    } 
}
