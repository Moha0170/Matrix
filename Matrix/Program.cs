using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int sorokSzama = 10;
            int oszlopokSzama = 7;
            int[,] matrix = new int[sorokSzama,oszlopokSzama];

            Console.WriteLine($"Az első elem feltöltése előtt: { matrix[0,0]}");

            Random r = new Random();
            Console.WriteLine($"A mátrix hossza: {matrix.Length}");
            for(int i=0; i<sorokSzama; i++)
            {
                for(int j=0; j<oszlopokSzama;j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            }
            for(int i=0; i<sorokSzama; i++)
            {
                for(int j=0; j<oszlopokSzama; j++)
                {
                    Console.WriteLine($"{ matrix[i, j], 4}");

                }
                Console.WriteLine();
            }
            int ossz = 0;
            for(int i=0; i<oszlopokSzama; i++)
            {
                ossz += matrix[2,i];
            }
            Console.WriteLine($"3. sor elemének az összege: {ossz}");

            ossz = 0;
            for(int i=0; i<sorokSzama; i++)
            {
                ossz+= matrix[i,2];
            }
            Console.WriteLine($"3. oszlop elemeinek az összege: {ossz}");

            */

            // kitotunk a matrixbol  Top G-k leszunk





            Adatok a = new Adatok(4,6);
            Console.WriteLine(a.ToString());

            Console.WriteLine("Adja meg hogy melyik sor összegét szeretné megkapni: ");
            Console.WriteLine(a.sorokOsszead(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Adja meg hogy melyik oszlop összegét szeretné megkapni: ");
            Console.WriteLine(a.oszlopOsszead(Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey(); 
        }
    }
}
