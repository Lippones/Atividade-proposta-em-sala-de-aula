using System;

namespace Desafio2S1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte entre para gerar os valores aleatorios");
            Console.ReadKey();
            int[] v1 = random();
            int[] v2 = random();
            Console.WriteLine("Os números foram gerador de forma aleatoria");
            mostrar(v1, v2);
            Console.WriteLine("Aperte Enter para continuar...");
            Console.ReadKey();
            Console.Clear();
            funcao(ref v1, v2);
            Console.WriteLine($"Números aleatórios após a chamada da função");
            mostrar(v1, v2);
            Console.WriteLine("Aperte Enter Encerrar o programa...");
            Console.ReadKey();


        }

        static void funcao (ref int [] v1 , int [] v2 )
        {
            int[] soma = new int[10];
            for(int i = 0; i < v1.Length; i++)
            {
               v1[i] += v2[i];
            }
        }

        static int[] random()
        {
            int[] num = new int[10];
            Random gerador = new Random();
            for(int i = 0; i< num.Length; i++)
            {
                num[i] = gerador.Next(1, 10);
            }
            return num;
        }

        static void mostrar(int [] v1, int [] v2)
        {
            for(int i = 0; i < v1.Length; i++)
            {
                Console.WriteLine($"Primeiro parametro = {v1[i]}      |       Segundo parametro = {v2[i]}");
            }
        }
    }
}
