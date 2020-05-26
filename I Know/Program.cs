using System;

namespace I_Know
{
    class Program
    {
         static void Main(string[] args)
        {
            int cislo = 3;
            //float desatcislo = 1.2;           neviem niečo ako double 7 čisiel
            double desatcislopresne = 1.23;     // desatinne čislo 16 čisiel
            char charakter = 'a';               // jeden charakter
            bool pravda = true;                 // pravda a napravda
            string text = "ahoj";               // text
            var automat = "text";               //automaticke rospoznanie
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            const int nezmenitelne = 48;        //nezmenitelná hodnota (int,double,float)

            /* matematicke funkcie:
             * + spočita
             * - odpočita
             * * násobí
             * / delí
             * % zvyšok  */

            // j += 2 > j = j + 2
            // j++  > j = j + j
            // j = ++i   zmení i a potom j
            // j = i++   zmení j a potom i

            /* &&  operacia a zaroven   alt c
             * ||  operacia alebo       alt w
             * !   operacia negovanie 
             */

            int i = 10;
            int x = 6;

            Console.WriteLine("Stlač Enter a zistiš");
            Console.ReadLine();                 //string meno = Console.ReadLine(); zapiše čo si napisal
            Console.WriteLine("Gergel je kok");
            //int hodnota = Convert.ToInt32(Console.ReadLine());              //premeni text na hodnotu (iba čisla)
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (i < x)          //podmienka (ak) , vždy na konci= else
            {
                Console.WriteLine("i je menšie ako x");
            }
            else if (i > x)
            {
                Console.WriteLine("i je vačšie ako x");
            }
            else if (i <= x)
            {
                Console.WriteLine("i je vačšie rovné ako x");
            }
            else if (i >= x)
            {
                Console.WriteLine("i je vačšie rovné ako x");
            }
            else if (i == x)
            {
                Console.WriteLine("i je rovné ako x");
            }
            else if (i != x)
            {
                Console.WriteLine("i je nerovné ako x");
            }
            else
            {
                Console.WriteLine("ani jedno neni spravne");
            }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            switch (i)              // Vyberá z možností (case) 
            { 
                case 1:
                    Console.WriteLine("1");
                 break;
                case 2:
                    Console.WriteLine("2");
                 break;
                case 10:
                    Console.WriteLine("10");
                 break;
                default:
                    Console.WriteLine("ani jedno neni spravne");
                 break;
            }
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int num = 3;            
            while(num < 6)          //kým podminka platí
            {
                Console.WriteLine(num);
                num++;
            }
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int a = 0;          //ako while ale najprv spravi rozkaz a potom skontroluje podmienku
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 5);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int y = 5; y < 10; y++)        //pokial podmienka platí tak sa opakuje
            {
                Console.WriteLine("čislo y je {0}", y);         //{0} je poradie za "
            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int q = 0; q < 100; q++)        
            {
                if (q<10)
                    { 
                        continue;                       //preskoči koniec slučky a ide od začiatku podla podmienky
                    }
                if (q>=70)
                    {
                        break;                          //skončí slučku podla podmienky
                    }
                Console.Write("  {0}", q); 
            }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if(3 < 5 && 3>4)
            {
                Console.WriteLine("ahoj");
            }
            if (3 < 5 || 3 > 4)
            {
                Console.WriteLine("ahoj");
            }
            if (3 < 5 && 3 > 4)
            {
                Console.WriteLine("ahoj");
            }
            if (!(3 < 5 && 3 > 4))
            {
                Console.WriteLine("ahoj");
            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            do
            {
                Console.WriteLine("x=");
                string str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }
                int c = Convert.ToInt32(str);
                Console.WriteLine("y=");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}" ,c, v, v + c);
            }
            while(true) ;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

             
        }
    }
}
