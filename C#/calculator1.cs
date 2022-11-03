using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            string a = Convert.ToInt32(Console.ReadLine());
            while(int.TryParse(a, out a))
            {
                Console.Write("try again:");
                string a = Console.ReadLine();
            }
            
            Console.Write("Enter second number:");
            string b = Convert.ToInt32(Console.ReadLine());
        }
         while(int.TryParse(b, out b))
            {
                Console.Write("try again:");
                string b = Console.ReadLine();
    }

    string emeliyat = "+";
            switch (emeliyat)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":  
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                default:
                    Console.WriteLine(a / b);
                    break;


            }
        }
    }
}
}
