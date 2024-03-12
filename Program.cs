using System;

namespace ConsoleApp3
{
    class Program

    {
        public void implicitConversion()
        {
            byte a = 9;
            short b = a;
            int c = b;
            float d = c;
            double e = d;
            char f = 'a';
            int g = f;
        }

        public void dataTypes() 
        {
            byte a = 1;
            short b = 2;
            int c = 32000;
            float d = 4.458945f;
            double e = 5.562394870948309d;
            long f = 6092384098420948L;
            char g = 'A';
            bool h = true;
            DateTime l = DateTime.Now;
            string m = "'I miss you'";
            object o = new object();
            decimal p = 0.3493487948m;

            Console.WriteLine($"{a} is a byte!");
            Console.WriteLine($"{b} is a short!");
            Console.WriteLine($"{c} is an integer!");
            Console.WriteLine($"{d} is a float!");
            Console.WriteLine($"{e} is a double!");
            Console.WriteLine($"{f} is a long!");
            Console.WriteLine($"{g} is a char!");
            Console.WriteLine($"{h} is a boolean!");
            Console.WriteLine($"{l} is a Date!");
            Console.WriteLine($"{m} is an string!");
            Console.WriteLine($"{o} is an object!");
        }
        static void Main(string[] args)
        {
            //First program
            Console.WriteLine("Hello World!");

            //Write Line 
            Console.Write("This method will not produce a new line");
            Console.WriteLine("This method will produce a new line");

            //Read Lines
            Console.WriteLine("Enter the value to the read line which takes string as input !.");
            Console.ReadLine();

            //Single line comments

            /* This
             * is
             * a
             * muilty
             * line
             * comment
             */

            Program obg = new Program();
            obg.dataTypes();


        }
    }
}
