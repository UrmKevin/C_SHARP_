using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_
{
    class Kordused_Massiivid
    {
        static void Main(string[] args)
        {
            int[] arvudd = new int[5];
            int a=0;
            int k=0;
            do
            {
                try
                {
                    Console.WriteLine("Sisesta arv");
                    a = int.Parse(Console.ReadLine());
                    arvudd[k] = a;
                    k++;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                    
                }
            } while (k<5);
            int summa = 0;
            int korr = 1;
            foreach (int arv in arvudd)
            {
                summa += arv;
                korr *= arv;
            }
            Console.WriteLine($" Summa= {summa}");
            Console.WriteLine($" Korrutis= {korr}");
            Console.WriteLine($" Keskmine= {summa / arvudd.Length,4}");

            Console.ReadKey();
            //Random rnd = new Random();
            //int N = rnd.Next(1,100);
            //int M = rnd.Next(1,100);

            //Console.WriteLine(N);
            //Console.WriteLine(M);

            //if (N >= M)
            //{
            //    int abi = N;
            //    N = M;
            //    M = abi;
            //}
            //int[] N_M = new int[M-N+1];
            //int j = 0;
            //for (int i = N; i < M+1; i++)
            //{
            //    N_M[j] = i*i;
            //    j++;
            //}
            //foreach (int n_m in N_M)
            //{
            //    Console.Write($"{n_m,6}");
            //}

            //char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            //Console.WriteLine($"Esimine täht on {Tahed[0]}");

            //foreach (char taht in Tahed)
            //{
            //    Console.Write($"{taht, 2}");
            //}
            //Console.WriteLine();
            //Random rnd = new Random();
            //int[] arvud = new int[10];
            //for (int i = 0; i < arvud.Length; i++)
            //{
            //    arvud[i] = rnd.Next(0, 10);
            //}
            //foreach (int arv in arvud)
            //{
            //    Console.Write($"{arv,2}");
            //}
            //Console.WriteLine();
            //int[,] tabel = new int[5, 10];
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.Write($"rida {i}: ");
            //    for (int ii = 1; ii < 11; ii++)
            //    {
            //        Console.Write($"koht {ii}");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
