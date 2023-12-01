using System;
using System.Numerics;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is Important for debugging do not remove this
            // this is a commit
            /*
             * this 
             * is 
             * a multiline 
             * comment spanning multiple lines
             */
            // Data types in c#
            /*
             *Intger - int shashi;
             *Float - float shashi;
             *Character - char a = 'shashi''
             *Boolean -  bool a = true;
             *String -  string a = "Shashi";
             */
            /*
            //integer variable
            string a = "shashi";
            Console.WriteLine("\thello world");
            Console.WriteLine("hello\nShashi");
            Console.WriteLine("hello C#");
            Console.WriteLine("Hello India");
            // Console.WriteLine("The age ="+age);
            Console.WriteLine(a);
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age = " + age);
            Console.WriteLine("hello" + name);
            */

            //Operators
            //int friends = 10;
            //friends = friends + 1;
            //friends += 2;

            //friends = friends - 1;
            //friends = friends * 2;
            //friends = friends / 2;


            /*
            Console.WriteLine(100>200);
            Console.WriteLine(100<200);
            Console.WriteLine(100>=200);
            Console.WriteLine(100<=200);
            Console.WriteLine(100!=200);
            */

            //Logical operators
            /*
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);
            */


            //Maths in c#
            /*            double x = 5;
            double y = 10;


            double z = Math.Max(x, y);
            Console.WriteLine(z);

            */
            //Generate the random number
            /*
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(100, 200);
            int num3 = rnd.Next(200, 300);
            //double num = rnd.NextDouble();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            */
            //Hypotenuse of a number
            /*
            Console.WriteLine("Enter the side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a*a) + (b*b));
            Console.WriteLine("The Hypotenus is : "+c);
            */
            // String methods
            /*
            string name = "Shashikant";
            string phone = "123-456-789";
            name = name.ToUpper();
            Console.WriteLine(name);

            name = name.ToLower();
            Console.WriteLine(name);

            phone = phone.Replace("-", "/");
            Console.WriteLine(phone);
            */
            //If else statement
            /*
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18) 
            {
                Console.WriteLine("Your age is eligible for driving");

            }
            else if( age > 70)
            {
                Console.WriteLine("You are too old to drive a car");
            }
            else if(age <= 0)
            {
                Console.WriteLine("Please enter valid age");
            }
            else
            {

                Console.WriteLine("Your age must be 18+ to driving");
            }


            */
            //Switch Case 
            /*
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                 default: Console.WriteLine("Please enter valid number");
                    break;
            }
            */
            //for loop runs for finite number of times
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */
            /*
            for(int i = 10; i>0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy new year");
            */

            //array
            /*
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            */
            //methods are the section of code it come in use when it calles in programme
            //we can also say that methods are the fuctions
            //we can use same code multiple times without writing multiple times
            //happy();
            //happy();

            //Exception handling in c#
            /*
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            */
            //multidimensional array
            /*
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */
            //interface  = defines a contract that all the classes inheriitng should follow
            /*
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
            */
            /*
             * 
             * Lists in c#
            List<string> food = new List<string>();

            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Hamburger");
            food.Add("Egg rolls");
            food.Remove("Egg rolls");

            Console.WriteLine(food[0]);

            foreach (string item in food) 
            {
                
                Console.WriteLine(item);
            
            }
            */

            //Multithreading
            // Thread = an execution path of pragrame we can use multiple threads to perform different task at samw time
            //Count up and countdown by using thread
            /*
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
               
            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + "is completed");
            */



            Console.ReadKey();
   
        }
        /*
        public static void CountDown()
        {
            for (int i = 10; i>=0; i--)
            {
                Console.WriteLine("Timer #1:"+i+"seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer no #1 is completed");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2:" + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer no #2 is completed");
        }
        */
        /*
        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit: IPrey
        {
             public void Flee()
             {
            Console.WriteLine("The rabbit runs away");
             }
        }
        class Hawk:IPredator
        {
           public void Hunt()
            {
                Console.WriteLine("The Hawk is searching for food");
            }
        }
        class Fish :IPrey,IPredator
        {

            public void Flee()
            {
                Console.WriteLine("The fish swim away");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is searching for small fish");
            }

        }*/






        /*
        static void happy() 
        {
            Console.WriteLine("happy bday");
            Console.WriteLine("happy bday");
            Console.WriteLine("happy bday");
            Console.WriteLine("happy bday");
            Console.WriteLine("happy bday");
        }
        */
    }
}
