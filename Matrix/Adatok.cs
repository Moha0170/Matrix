using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Adatok
    {
        private int sorok;
        private int oszlopok;
        private int[,] matrix;

        public Adatok(int sorok, int oszlopok)
        {
            this.sorok = sorok;
            this.oszlopok = oszlopok;
            Random r = new Random();
            matrix = new int[sorok,oszlopok];
            for (int i = 0;i < sorok;i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    matrix[i, j] = r.Next(1, 1);
                }
            }
        }

        public int Oszlopok { get => oszlopok; set => oszlopok = value; }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    s+=Convert.ToString(matrix[i,j]);
                    s += " ";
                }
                s+="\n";
            }
            return s;
        }

        public int sorokOsszead(int melyikSor)
        {

            int ossz = 0;
            for (int i = 0; i < oszlopok; i++)
            {
                ossz += matrix[melyikSor, i];
            }
            return ossz;
        }
        public int oszlopOsszead(int melyikOszlop)
        {

            int ossz = 0;
            for (int i = 0; i < sorok; i++)
            {
                ossz += matrix[i, melyikOszlop];
            }
            return ossz;
        }
        public bool huszonot()
        {
            for(int i=0; i<sorok;  i++)
            {
                for(int j=0; j<oszlopok; j++)
                {
                    if (matrix[i,j]%25==0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void legnagyobb()
        {
            int ossz = 0;
            ossz += matrix[0, 0];
            ossz += matrix[1, 0];
            ossz += matrix[0, 1];
            ossz += matrix[1, 1];
            for (int i=1; i<sorok; i++) 
            {
                for(int j=1;j<oszlopok; j++)
                {
                    if (matrix[i + 1, j] > matrix[i,j])
                    {

                    }
                }
            }

            int bfel = 0;
            int bal = 0;
            int jfel = 0;
            int jal = 0;

            

            while(jfel < matrin)

        }

        public bool legnagyobb(int sor,int oszlop)
        {
            if (matrix[sor+1, oszlop]>= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor - 1, oszlop] >= matrix[sor, oszlop])
            {
                return false;
            }
            if(matrix[sor, oszlop + 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor, oszlop - 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor + 1, oszlop + 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor - 1, oszlop - 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor - 1, oszlop + 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            if (matrix[sor + 1, oszlop - 1] >= matrix[sor, oszlop])
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
