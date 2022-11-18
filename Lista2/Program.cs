using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Lista2;

namespace Lista2
{
    public class clienteNome
    {
        private string NOME;
        public string nome
        {
            get
            {
                return NOME;
            }
            set
            {
                if (value.Length > 4)
                {
                    this.NOME = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("O nome precisa ter mais de 5 caracteres!");
                }

            }
        }
    }

    public class clienteCPF
    {
        long[] cpfsInvalidos = new long[]
        { 00000000000, 11111111111, 22222222222, 33333333333, 44444444444, 55555555555, 66666666666, 77777777777, 88888888888, 99999999999};

        private long CPF;
        public long cpf
        {
            get
            {
                return CPF;
            }

            set
            {
                if (value.ToString().Length == 11) //Garante que a entrada terá 11 dígitos
                {
             
                    for (int i = 0; i < cpfsInvalidos.Length; i++) //Impossibilita a entrada de um cpf com todos os dígitos iguais e utiliza o array "cpfsInvalidos" para fazer a validação
                    {
                        if (cpfsInvalidos[i] == value)
                        {
                            throw new IndexOutOfRangeException("O cpf não pode ter todos os números iguais");
                        }
                        else
                        {
                            String cpfString = value.ToString(); //transforma o value da propriedade em String para se utilizar do método Substring()
                            int[] cortesCpf = new int[9] ; // cria array para armazenar as slices da variável cpfcrop e testar dentro do For

                                for (int j = 0; j <= 9; j++)
                                {
                                    String cpfCrop = cpfString.Substring(j, 1); //cria as slices algarismo a algarismo

                                    int intCpfCrop = int.Parse(cpfCrop);

                                    cortesCpf[j] = intCpfCrop; //transforma de volta o a variável cpfCrop em Int para entrar no Array



                                    Console.WriteLine(cortesCpf[j]);
                                }
                            }
           
                            
                            this.CPF = value;

                        }
                    }
                else
                {
                        throw new IndexOutOfRangeException("O cpf precisa ter 11 números");
                }

                }
    

            }
        }
    }


    public class clienteNascimento
    {
        public DateTime dataNascimento
        {
            get;
            set;
        }

    }

    public class clienteRenda
    {
        private float RENDAMENSAL; //PRECISA RESOLVER A QUESTÃO DA CASA DECIMAL

        public float rendaMensal
        {

            get
            {
                return RENDAMENSAL;
            }
            set
            {
                if (value >= 0)
                {
                    RENDAMENSAL = value;
                }


                else
                {
                    throw new ArgumentOutOfRangeException("O valor da renda mensal precisa ser maior ou igual a 0!");
                }
            }

        }
    }


    public class clienteEstado
    {
        public char estadoCivil { get; set; }

        public int DEPENDENTES;
        public int dependentes
        {

            get
            {
                return DEPENDENTES;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    DEPENDENTES = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("O número de dependentes precisa estar contido entre 0 e 10!");
                }
            }

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            var c = new clienteCPF();
            c.cpf = 13634164484;
            

            


        }
    }

}

