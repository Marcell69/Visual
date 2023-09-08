using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            a = 4;
            if(a > 2)
            {
                Console.WriteLine("nagyobb");
            }
            else if(a<2) 
            {
                Console.WriteLine("kisebb");
            }
            else if(a%2==0)
            {
                Console.WriteLine("nagyobb");
            }
            else
            {
                Console.WriteLine("egyenlő");
            }


            switch(a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("kettő");
                    break;
                case 3:
                    Console.WriteLine("három");
                    break;
                case 4:
                    Console.WriteLine("négy");
                    break;
            }

            double szamok = 1;
            while(szamok<5)
            {
                Console.WriteLine(szamok);
                szamok += .1;
            }

            do
            {
                szamok -= .2;
                Console.WriteLine(szamok);
            }
            while (szamok > 2);

            char betu = 'a';
            while (betu<= 'z')
            {
                Console.Write(betu);
                betu = (char)(betu + 1);
            }
            Console.WriteLine();

            int szamz = 32;
            while (szamz <= 255)
            {
                Console.Write((char)szamz + "  ");
                if (szamz % 8 == 7)
                {
                    Console.WriteLine();
                }
                szamz++;
            }

            Console.WriteLine();
            /*
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
            */
            int szamol = 0;
            for(int i=100;i<1000;i++)
            {
                szamol += i;
            }
            Console.WriteLine(szamol);

            for (int i = 9; i>=0; i--)
            {
                Console.WriteLine(9-i);
            }
            



        }
    }
}
