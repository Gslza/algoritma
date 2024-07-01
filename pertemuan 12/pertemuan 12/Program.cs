using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[1000000];
            Random rnd = new Random();

            //isi data
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(0,10);

            }

            // Tampilan Data
            Console.WriteLine("Data Sebelum Terurut :");
            foreach (int i in data)
            { 
            Console.Write(i + " ");
            }
            Console.WriteLine();

            //proses pengurutan
            Console.WriteLine("Tekan ENTER untuk " + "proses pembuatan...");
            Console.ReadKey();

            //Bubble sort
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            for (int p = 0; p < data.Length - 1; p++)
            {
                for (int j = p + 1; j < data.Length; j++)
                {
                    if (data[p] > data[j])
                    {
                        //proses tukar posisi
                        int c;
                        c = data[p];
                        data[p] = data[j];
                        data[j] = c;
                    }
                }
            }
            sw.Stop();
            // menampilkan data
            Console.WriteLine("Data Sesudah Terurut :");
            foreach (int i in data)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Lama Pross : " + sw.Elapsed.ToString());

            Console.ReadKey();
        }
    }
}
