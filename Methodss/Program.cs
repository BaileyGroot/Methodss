using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            TwoHelTal();
            Console.WriteLine("\n");
            Pyth();
            Console.WriteLine("\n");
            Alder();
            Console.WriteLine("\n");
            Løkke();
            Console.WriteLine("\n");
            MyArray();
            Console.WriteLine("\n");
            ListeB();
            Console.WriteLine("\n");
            LottoArray();
            Console.WriteLine("\n");
            GuessNr();
            Console.WriteLine(SelfDefinedFunctionAndMethod());
            Console.WriteLine(SelfDefinedFunctionAndMethodOne());
            Console.WriteLine(SelfDefinedFunctionAndMethodTwo());
            Console.WriteLine("\n");
            Console.WriteLine(Checklist());
            Console.WriteLine("\n");
            Console.WriteLine(Bool());
            Console.WriteLine("\n");
            Average();
            Console.WriteLine("\n");
            Console.WriteLine(IsItSorted());





            Console.ReadKey();
        }

        static void TwoHelTal()
        {
            // Numre brugt

            int a = 2;
            int b = 4;

            // Adder

            int c = a + b;
            double d = a / b;

            // Undersøg hvor mange gange.

            for (int i = 2; i < b; i++)
            {
                Console.WriteLine(i++);
            }

            // Opløft

            double first = Math.Pow(a, b);

            Console.WriteLine(first);

        }

        static void Pyth()
        {
            Console.WriteLine("Første nummer: ");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Anden nummer: ");

            double b = double.Parse(Console.ReadLine());

            double first = Math.Pow(a, 2);
            double second = Math.Pow(b, 2);


            // Udskriver result
            Console.WriteLine("\n");
            Console.WriteLine(first + second);
            Console.WriteLine("\n");

            // If Statements

            if (first > second)
            {
                Console.WriteLine("Første nummer er størst.");
            }
            else
            {
                Console.WriteLine("Anden nummer er størst.");
            }


            // Prevents the program from closing.

        }

        static void Alder()
        {
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());



            if (age < 3)

            {

                Console.WriteLine(userName + ", du må gå med ble");

            }

            else if (age < 15)

            {

                Console.WriteLine(userName + ", du må ingenting");

            }

            else if (age < 18)

            {

                Console.WriteLine(userName + ", du må drikke");

            }

            else

            {

                Console.WriteLine(userName + ", du må stemme og køre bil");

            }
        }

        static void Løkke()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            int t = Convert.ToInt32(Console.ReadLine());
            int tx = t;
            int ix = 32;

            for (int i = 0; i < 1; i++)
            {
                tx = t + ix;
                int res = tx - 16;

                Console.WriteLine(res);
            }


        }

        static void MyArray()
        {
            int[] numbers = new int[9];

            for (int i = 0; i < 9; i++)
            {
                numbers[i] = i + 1;
                if (i == 5)
                {
                    numbers[i] = numbers[i - 1] * 2;
                }
            }

            foreach (int tal in numbers)
            {
                Console.WriteLine(tal);
            }
        }

        static void ListeB()
        {
            List<int> listeB = new List<int>();

            for (int i = 2; i <= 20; i = i + 2)
            {
                listeB.Add(i);
            }
            PrintList(listeB, "Just created the list");

            int index = 0;
            while (true)
            {
                if (listeB[index] % 3 == 0)
                {
                    listeB.RemoveAt(index);
                }
                else
                {
                    index++;
                }
                if (index >= listeB.Count) break;
            }

            PrintList(listeB, "After removing those that mod 3");
            listeB[3] = 17;

            PrintList(listeB, "After changing pos 4");


            listeB.Reverse();

            PrintList(listeB, "After Reverse");
            Console.ReadLine();
        }

        static void PrintList(List<int> list, string label)
        {
            Console.WriteLine(label);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void LottoArray()
        {
            int[] lottotal = new int[7];
            int[] usernumbers = new int[7];

            Random random = new Random();
            Console.WriteLine("Choose 7 numbers between 1-20");

            for (int i = 0; i < lottotal.Length; i++)
            {
                while (true)
                {
                    int tal = random.Next(1, 21);
                    if (Array.IndexOf(lottotal, tal) == -1)
                    {
                        lottotal[i] = tal;
                        break;
                    }
                }
                while (true)
                {
                    int tal = Convert.ToInt32(Console.ReadLine());
                    if (Array.IndexOf(usernumbers, tal) == -1)
                    {
                        usernumbers[i] = tal;
                        break;
                    }
                }
            }

            Array.Sort(lottotal);
            Array.Sort(usernumbers);

            int count = 0;

            for (int i = 0; i < usernumbers.Length; i++)
            {
                for (int j = 0; j < lottotal.Length; j++)
                {
                    if (usernumbers[i] == lottotal[j])
                    {
                        count++;
                    }
                }
            }


            Console.Write("Udtrukne lottotal: ");
            for (int i = 0; i < lottotal.Length; i++)
            {
                Console.Write(lottotal[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Brugerens lottotal: ");
            for (int i = 0; i < usernumbers.Length; i++)
            {
                Console.Write(usernumbers[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Rigtige: " + count);

            if (count == 2)
            {
                Console.WriteLine("Congrats on winning 100$");
            }
            else if (count == 3)
            {
                Console.WriteLine("Congrats on winning 500$");
            }
            else if (count == 4)
            {
                Console.WriteLine("Congrats on winning 1000$");
            }
            else if (count == 5)
            {
                Console.WriteLine("Congrats on winning 2500$");
            }
            else if (count == 6)
            {
                Console.WriteLine("Congrats on winning 5000$");
            }
            else if (count == 7)
            {
                Console.WriteLine("Congrats on winning our grand price on 10000$");
            }
            else
            {
                Console.WriteLine("Sorry you didn't win anything.");
            };
        }

        static void GuessNr()
        {
            Random random = new Random();

            int randomnumber = random.Next(1, 11);



            Console.WriteLine("Write your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + " to Guess a number!");

            Console.WriteLine("Guess a number between 1-10.");

            Console.WriteLine("You have 3 tries.");

            Console.WriteLine("Round 1");

            Console.WriteLine("Enter a number: ");

            double guess1 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess1 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess1);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower" + " than: " + guess1);

            }



            Console.WriteLine("Round 2");



            Console.WriteLine("Enter a number: ");

            double guess2 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("System: You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess2 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess2);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower than: " + guess2);

            }



            Console.WriteLine("Round 3");



            Console.WriteLine("Enter a number: ");

            double guess3 = double.Parse(Console.ReadLine());



            if (guess1 == randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You guessed the correct number! Congrats on winning the game.");

            }

            else if (guess3 < randomnumber)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were higher than: " + guess3);

            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You guessed wrong! The number were lower than: " + guess3);

            }
        }

        public static int SelfDefinedFunctionAndMethod()
        {
            int a = 2;
            int b = 4;

            int c = a + b;

            return c;

        }

        public static double SelfDefinedFunctionAndMethodOne()
        {
            int a = 12;
            int b = 6;

            double c = a / b;

            return c;


        }

        public static int SelfDefinedFunctionAndMethodTwo()
        {
            int tal1 = 4;
            int tal2 = 41;

            int c = tal2 / tal1;

            return c;

        }

        public static int Checklist()
        {

            var res = new List<int>() { 1, 3, 2 };
            var max = res.Max();

            return max;


        }

        public static bool Bool()
        {
            var x = new List<string>() { "x", "y", "z" };

            x.Contains("x");

            bool res = true & x.Contains("x");

            return res;



        }

        public static int Average()
        {
            var av = new List<int>() { 1, 2, 11, 12, 21, 22, 31, 32 };
            int one = av[0];
            int two = av[1];
            int three = av[2];
            int four = av[3];
            int five = av[4];
            int six = av[5];
            int seven = av[6];
            int eight = av[7];

            int div = one + two + three + four + five + six + seven + eight;
            int res = div / 8;

            Console.WriteLine(res);

            return res;
        }

        public static bool IsItSorted()
        {
            var av = new List<int>() { 1, 2, 11, 12, 21, 22, 31, 32 };

            av.Sort();

            bool res = true & av[0] == 1;

            if (res == true)
            {
                Console.WriteLine("Its sorted.");
            }
            else
            {
                Console.WriteLine("Its not sorted.");
            }

            return res;
        }

    }
}
