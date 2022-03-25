using System;
namespace hello_world 
{
    class hello_world
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Declaring variables and constants
            const string name = "Gandalf";
            string age = "50";                //Single quotes indicate a charachter literal.
            Console.WriteLine("My name is " + name + " and I\'m at least " + age + ".");

            //Declaring multiple variables at the same time
            string a; string b; string c;
            a = b = c = "The same thing. ";
            Console.WriteLine(a + b + c);

            //User input
            Console.WriteLine("What is thy name traveller?");
            string user_input = Console.ReadLine();     //User input is type string by default. A function is required to convert it into an int
            Console.WriteLine("And thy age?");
            int user_input_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thou shalt die within "+Convert.ToString(user_input_2)+" weeks, "+user_input+".");

            //String manipulation
            string check_length = "abcdefg";
            Console.WriteLine(check_length.Length);
            Console.WriteLine(check_length.ToUpper());  
            Console.WriteLine(check_length.ToLower());
            Console.WriteLine(check_length[0]);

            //Switch case blocks
            int case_eg = 5;
            switch(case_eg)
            {
                case 4:
                    Console.WriteLine("The number is 4.");
                    break;   //This is required.
                case 5:
                    Console.WriteLine("The number is 5.");
                    break;
                    
            }

            //Arrays
            int[] array_1 = { 1, 2, 3, 4 };
            Console.WriteLine(array_1.Length);

            //For each loops
            foreach(int i in array_1)
            {
                continue;
            };


            //Calling methods
            do_something();
            static void do_something()
            {
                Console.WriteLine("Something.");
            }

        }
    }
}