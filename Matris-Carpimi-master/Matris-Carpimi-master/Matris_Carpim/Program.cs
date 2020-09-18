using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Carpim
{
    class Program
    {
        static void MatrisOlustur(int a, int b)
        {
            int[,] first = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    first[i,j] = random.Next(10);
                    Console.Write(first[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int MatrisCarp(int[,] a, int[,] b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        product[i, j] += 
                    }
                }
            }
            return 
        }

        static void Main(string[] args)
        {
            Console.Write("Kaç Satır Olsun :");
            int column1 = int.Parse(Console.ReadLine());
            Console.Write("Kaç Sütun Olsun :");
            int row1 = int.Parse(Console.ReadLine());

            Console.Write("Kaç Satır Olsun :");
            int column2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaç Sütun Olsun :");
            int row2 = int.Parse(Console.ReadLine());
            int[,] first = new int[column1, row1];
            int[,] second = new int[column2, row2];
            if (row1 == column2)
            {
            Console.WriteLine("**********************");
            Console.WriteLine("      1. Matris");
            Console.WriteLine("**********************");
            MatrisOlustur(column1, row1);

            Console.WriteLine("**********************");
            Console.WriteLine("      2. Matris");
            Console.WriteLine("**********************");
            MatrisOlustur(column2, row2);

            Console.WriteLine("**********************");
            Console.WriteLine(" Matrislerin Çarpımı");
            Console.WriteLine("**********************");
            MatrisCarp(first, second);
            }
            else
            {
                Console.WriteLine("Birinci Matrisin Sütunu İle İkinci Satırın Sutunu Birbirine Eşit Olmak Zorundadır !");
            }

            Console.Read();
        }
    }
}
