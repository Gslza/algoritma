using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 3, 4, 1};
            Console.Write("Data Sebelum Terurut");
            foreach (int g in data)
            {
                Console.Write( g + " ");

            }

            Console.WriteLine();
            for (int g = 0; g < data.Length-1; g++)
            {
                Console.WriteLine("Langkah : " + (g+1));
                Console.WriteLine("Pivot : " + g);
                int baris = 1;
                for (int h = g + 1; h < data.Length; h++)
                {
                    if (baris == 1)
                    {
                        Console.Write("   ");
                        foreach (int k in data)
                        {
                            Console.Write(k + " ");
                        }
                        Console.WriteLine();
                        Console.CursorLeft = (2 * g) + 3;
                        Console.WriteLine("P");
                    }

                    Console.Write(baris + " .");
                    //Proses Perbandngan 
                    if (data[g] > data[h])
                    {
                        //Proses tukar posisi
                        int j;
                        j = data[g];
                        data[g] = data[h];
                        data[h] = j;
                    }
                    foreach (int k in data)
                    {
                        Console.Write(k + " ");

                    }
                    Console.WriteLine();

                    baris++;
                }

            }
            Console.ReadKey();
        }
    }
}
