using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloops
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //övning1
            int x = 0;
            while (x++<100)
            {
                Console.WriteLine(x);

            }
            Console.ReadLine(); 
                
            //övning2
            string l = "";
            while (l != "alfred123")
            {
                Console.WriteLine("lösenord?");
                l = Console.ReadLine();
                
            }
            Console.WriteLine("rätt");
           

            //övning3
            while (true)
            {
                Console.WriteLine("yassin är fett ful ");
            }
            

            //övvning4
            int x = 29;
            int y = 0;
            int z = 1;

           
            while(true)
            {
                Console.WriteLine("gissa ett tal mellan 1-100 ");
                string inmatat = Console.ReadLine();
                int inmatat2 = int.Parse(inmatat);
                
                if (inmatat2 > x)
                {
                    Console.WriteLine("för högt");
                    z++;
                }
                else if (inmatat2 == x)
                {
                    Console.WriteLine("rätt svar antal gissningar : " + z );
                        break;
                }
                else
                {
                    Console.WriteLine("för lågt");
                    z++;
                }

            }
            Console.ReadLine(); 
            */
            //övning 5
            int n1 = 0;
            int n2 = 1;



            Console.Write(n1);
            Console.Write(n2);

            while (n2 + n1 <= 1000000)
            {
                int fn = n1 + n2;

                Console.Write(fn + " ");

                n1 = n2;
                n2 = fn;
               
            }
            Console.Read();
            /*
            //övning 6 
            Console.WriteLine("ange saldo på konto: ");
            string i = Console.ReadLine();
            int x = int.Parse(i);

            Console.WriteLine("ange ränta: ");
            string j = Console.ReadLine();
            int y = int.Parse(j);

            Console.WriteLine("ange mål: ");
            string h = Console.ReadLine();
            int z = int.Parse(h);

            int a = 1;

            while (z >= x * (y / 100) + x * a)
            {
                a++;
            }
            Console.WriteLine("det tar " + a + " år innan når " + (y^a * x) );
            Console.Read();

    */
        }
    }
}
