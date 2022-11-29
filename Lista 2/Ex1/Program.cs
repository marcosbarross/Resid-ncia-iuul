using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        int[] restosValidos = new int[] {2, 3 , 4, 5, 6, 7, 8, 9, 10};

        private long CPF;
        private int digitoJ;
        private int digitoK;
        private int digito1;
        private int digito2;

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
                    bool cpfValido = true;

                    for (int i = 0; i < cpfsInvalidos.Length; i++) //Impossibilita a entrada de um cpf com todos os dígitos iguais e utiliza o array "cpfsInvalidos" para fazer a validação
                    {
                        if (cpfsInvalidos[i] == value)
                        {
                            cpfValido = false;
                            throw new IndexOutOfRangeException("O cpf não pode ter todos os números iguais");
                        }
                    }

                    if (cpfValido)
                    {
                        String cpfString = value.ToString(); //transforma o value da propriedade em String para se utilizar do método Substring()
                        int[] cortesCpf = new int[9]; // cria array para armazenar as slices da variável cpfcrop e testar dentro do For

                        for (int j = 0; j < 9; j++)
                        {
                            String cpfCrop = cpfString.Substring(j, 1); //cria as slices algarismo a algarismo

                            int intCpfCrop = int.Parse(cpfCrop);

                            cortesCpf[j] = intCpfCrop; //transforma de volta o a variável cpfCrop em Int para entrar no Array

                        }

                        int somaDigito1;


                        for (int i = 0; i <= cortesCpf.Length; i++)
                        {
                            int subResto = 10 - i;
                            somaDigito1 = cortesCpf[i] * subResto;

                            this.digito1 += somaDigito1;

                        }

                        if (digito1 % 11 == 0 || somaDigito1 % 11 == 1)
                        {
                            digitoJ = 0;
                        }


                        
                        if (restosValidos.Contains(digito1 % 11))
                        {
                            digitoJ = 11 - (digito1 % 11);
                        }
                        
                        else
                        {
                            Console.Write(digitoJ);
                            throw new Exception("CPF inválido");
                        }

                        foreach (int i in cortesCpf)
                        {
                            int somaDigito2 = cortesCpf[i] * (11 - i) + digitoJ * 2;

                            this.digito2 += somaDigito2;
                            if (digito2 % 11 == 0 || digito2 % 11 == 1)
                            {
                                digitoK = 0;
                            }
                            else if (restosValidos.Contains(digito2 % 11))
                            {
                                digitoK = 11 - (digito2 % 11);
                            }
                            else
                            {
                                throw new Exception("CPF inválido");
                            }

                        }

                    }
                    
                    Console.WriteLine(digitoJ);
                    Console.WriteLine(digitoK);
                    
                    this.CPF = value;

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
    string[] estadosValidos = new string[]
        { "C", "c", "V", "v", "D", "d"};
    public char ESTADOCIVIL;
    public char estadoCivil {
        get
        {
            return ESTADOCIVIL;
        }
        set
        {
            if (estadosValidos.Contains(value.ToString()){
                estadoCivil = value;
            }
            else
            {
                throw Exception("estado civil inválido");
            }
        } 
    }
}

public class clienteDependentes
{
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




    }
}