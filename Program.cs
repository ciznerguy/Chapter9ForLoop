using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9ForLoop
{
    internal class Program
    {
        // יש לכתוב תוכנית המדפיסה את כל המספרים מ 1 עד 100
        public static void No_1()
        {

           for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        // יש לכתוב תכנית המדפיסה את כל המספרים הזוגיים מ-1 עד 100
        public static void No_2_V1()
        {

           for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void No_2_V2()
        {
            for (int i = 2; i <= 100; i += 2) //כמו לכתוב i = i + 2
            {
                Console.WriteLine(i);
            }
        }
        // עמוד 117 תרגיל 11

        public static void Targil11Page111()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"enter {i + 1} number");
                int num = int.Parse(Console.ReadLine());
                int d1 = num % 10;
                int d10 = num / 10 % 10;
                int d100 = num / 100;
                if (d1 != d10 && d10 != d100 && d1 != d100)
                {
                    Console.WriteLine(num);
                }
            }
        }
        // עמוד 117 תרגיל 13
        // עמוד 118 תרגיל 15

        // עמוד 118 תרגיל 17

        // תבנית מונה

        public static void TavnitMone()
        {
            int count = 0; // משתנה שאחראי לספירה חובה להגדיר מחוץ ללולאה
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0) //אם התנאי מתקיים הוסף 1 למונה
                {
                    count++;
                }
            }
        }

            
            //עמוד 124 תרגיל 22
        public static void Exc_22()
        {
            int counter = 0;
            for (int i  = 1; i <= 300; i++)
            {
                double sqr = Math.Sqrt(i);
                if ((int)(sqr) == sqr)
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} numbers");
        }

        //עמוד 124 תרגיל 24

        static void Main(string[] args)
        {
            //Exc_11();
            //Tavnit_Mone();
            Exc_22();
        }
    }
}
