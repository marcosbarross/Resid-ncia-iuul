using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace lista23
{
    internal class Program
    {
       
        public class curso
        {
            List<curso> cursos = new List<curso>();
            public string nome
            {
                get { return nome; }
                set { nome = value; }

            }

            public class aluno
            {
                Dictionary<int, string> alunos = new Dictionary<int, string>();
                
                int matricula = 0;
                public string nome
                {
                    get { return nome; }
                    set
                    {
                        matricula += 1;
                        
                        nome = value;
                        alunos.Add(matricula, nome);
                        
                    }
                }

                public void matricular(string NOME)
                {
                    this.nome = NOME;
                }
            }

            

            public class turma
            {
                List<turma> turmas = new List<turma>();
            }

            static void Main(string[] args)
            {
                aluno marcos = new aluno();
                marcos.matricular("Marcos");
               
            }
        }
    }
}
