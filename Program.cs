using System;

namespace ConsoleApp3
{
    class Program

    {

        public void loopingStatements()
        {
            int k = 0;
            int i = 9;
            int j = 0;

            //while loop
            while (k<i)
            {
                Console.WriteLine(k++);
            }

            //do-while loop
            do
            { 
                Console.WriteLine("do-while will be exicuted irrespective of the condition being true or false");
            }while (false);

            //for loop

            for (int y = 0; y < j; y++)
            { 
                Console.WriteLine($"{y} times for loop executed!");
            }

            //for each loop
            foreach (var item in "abcd")
            {
                Console.WriteLine(item);
            }
        }
        public void ConditionsStatements()

        {
            //if statement
            if (true)
            {
                Console.WriteLine("if statement");
            }


            //if - else statement
            if (false)
            {
                Console.WriteLine("if block in if-else statement");
            }
            else
            {
                Console.WriteLine("else block in if-else statement");

            }

            //else-if ladder
            if (false)
            {
                Console.WriteLine("if block in if-else ladder statement");
            }
            else if (false)
            {
                Console.WriteLine("else if block in if-else ladder statement");
            }
            else if (false)
            {
                Console.WriteLine("else if block in if-else ladder statement");
            }
            else if (true)
            {
                Console.WriteLine("else if block in if-else ladder statement");
            }
            else
            {
                Console.WriteLine("else block in if-else ladder statement");

            }

            //nested if - else condtion

            if (true)
            {
                Console.WriteLine("Outer if block");
                if (false)
                {
                    Console.WriteLine("Inner if block");

                }
                else
                {
                    Console.WriteLine("Inner else block");
                }

            }
            else
            {
                Console.WriteLine("Outer else block");
            }

            //switch statement

            int age = 16;
            switch (age)
            {
                case 10: 
                    Console.WriteLine("You are ten");
                    break;
                case 18:
                    Console.WriteLine("You are eightteen");
                    break;
                default: 
                    Console.WriteLine($"Your age is{age}");
                    break;
            }

        }
        public void arthematicOperations(int a , int b) 
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
        public void AssignmentOperations(int a, int b)
        {
            Console.WriteLine($"{a} += {b} = {a += b}");
            Console.WriteLine($"{a} -= {b} = {a -= b}");
            Console.WriteLine($"{a} *= {b} = {a *= b}");
            Console.WriteLine($"{a} /= {b} = {a /= b}");
        }

        public void LogicalOperations(bool a, bool b)
        {
           Console.WriteLine($"{a} || {b} = {a||b} ");
           Console.WriteLine($"{a} && {b} = {a && b} ");
           Console.WriteLine($"Not(!) of {a} = {!a} ");
        }
        public void BitwiseOperations(int a,int b)
        { 
            Console.WriteLine($"{a} | {b} = {a|b}");
            Console.WriteLine($"{a} & {b} = {a | b}");
        }
        public void ComparisionOperations(int a,int b)
        {
            Console.WriteLine($"{a} > {b} = {a > b}");
            Console.WriteLine($"{a} < {b} = {a < b}");
            Console.WriteLine($"{a} >= {b} = {a >= b}");
            Console.WriteLine($"{a} <= {b} = {a <= b}");
            Console.WriteLine($"{a} != {b} = {a != b}");
            Console.WriteLine($"{a} == {b} = {a == b}");

        }
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

        public void ExplicitConversion()
        {

            int a = 112;
            char b = (char)a;
            byte c = (byte)a;
            short d = (short)a;
            long e = 6878757657657657;
            int f = (int)e;
            double g = 234423.234234432432;
            float h = (float)g;
            string i = "3344";

            //To String methode
            string j = e.ToString();

            //Parsing
            int k = int.Parse(i);
            float l = float.Parse(j);

            //Convert class
            double m = Convert.ToDouble(l);
            int n = Convert.ToInt32(m);
            float o = Convert.ToSingle(n);
            long p = Convert.ToInt64(o);
            string q = Convert.ToString(p);


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
            obg.arthematicOperations(100, 25);
            obg.AssignmentOperations(100, 25);
            obg.LogicalOperations(true,false);
            obg.BitwiseOperations(100,25);
            obg.ComparisionOperations(100,25);
            Console.ReadLine() ;


        }
    }
}
