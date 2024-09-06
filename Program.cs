using System;
namespace Targetrp
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("=====/PRIMEIRO EXERCÍCIO/=====");
            Console.Write("Insira um valor e veja se ele pertence a sequência de Fibonacci: ");
            //Sem tratamento de exceções para usuário escrevendo palavras.
            int val = int.Parse(Console.ReadLine());
            FibVal(val);

            Console.WriteLine("=====/SEGUNDO EXERCÍCIO/=====");
            Console.Write("Insira a palavra: ");
            string texto = Console.ReadLine();
            ProcuraA(texto);

            Console.WriteLine("=====/TERCEIRO EXERCÍCIO/=====");
            Ex3();
        }

        static void FibVal(int val){
            int v1 = 0, v2 = 1, v3 = 0;

            while (v3 < val)
            {
                v3 = v1 + v2;
                v1 = v2;
                v2 = v3;
            }

            if (val == v3)
            {
                Console.WriteLine($"O valor {val} pertence a sequência de Fibonacci");
            } else 
            {
                Console.WriteLine($"O valor {val} não pertence a sequência de Fibonacci");
            }
        }

        static void ProcuraA(string texto){
            string info = texto.ToLower();
            char[] c = info.ToArray();
            int n = 0;
            foreach (char letra in c)
            {
                if (letra == 'a')
                {
                    n++;
                }
            }

            Console.WriteLine($"O texto {texto}, contém {n} letras A");
        }

        static void Ex3(){
            int indice = 12, soma = 0, k = 1;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            Console.WriteLine($"O valor da variável soma é de: {soma}");    
        }
    }
}