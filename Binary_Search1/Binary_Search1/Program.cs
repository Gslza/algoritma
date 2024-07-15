using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 4, 7, 10, 12, };
            int aw = 0;
            int ak = data.Length - 1;
            int cari;
            int th;
            bool ketemu = false;

            Console.Write("Input Nilai yang Dicari : ");
            cari = int.Parse (Console.ReadLine());

            Console.WriteLine("aw = " + aw);
            Console.WriteLine("ak = " + ak);
            Console.WriteLine("cari = " + cari);

            //proses pencarian
            int langkah = 1;
            while (ketemu == false && aw <= ak ) 
            {
                Console.WriteLine();
                Console.WriteLine("langkah " + langkah);
                th = ( aw + ak  ) / 2;
                Console.WriteLine("th = " + th);
                Console.WriteLine("Nilai index " + th + "=" + data[th]);
                if (data[th] == cari )
                {
                    Console.WriteLine(data[th] + "=" + cari );
                    ketemu = true;
                }
               else if (data[th] < cari )
                {
                    Console.WriteLine(data[th]+ "<" + cari);
                    aw = th + 1;
                    Console.WriteLine("aw berubah = " + aw);
                    Console.WriteLine("ak tetap   = " + ak);

                }
                else if (data[th] > cari )
                {
                    Console.WriteLine(data[th] + ">");
                    ak = th - 1;
                    Console.WriteLine("aw tetap     =" + aw);
                    Console.WriteLine("ak berubah   =" + ak);
                }
                langkah++;
                
            }
            if (ketemu)
            {
                Console.WriteLine("Data Ditemukan..");

            }
            else
            {
                Console.WriteLine("Data Tidak Ditemukan..");
            }
            Console.ReadKey();
        }
    }
}
