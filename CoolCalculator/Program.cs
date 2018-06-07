using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Which cool calculation do you wish to make?");
            Console.WriteLine("1. Pythagorean Theorem");

            CALCCHOICE:
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                PythagMenu();
            }
            else
            {
                Console.WriteLine("Please enter a correct number!");
                goto CALCCHOICE;
            }
        }

        static void PythagMenu()
        {
            Console.Clear();
            Console.WriteLine("a² + b² = c²");

            A_ENTER:
            Console.WriteLine();
            Console.WriteLine("Enter variable a: ");
            string aChoiceStr = Console.ReadLine();

            if (!double.TryParse(aChoiceStr, out double aChoice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                goto A_ENTER;
            }

            B_ENTER:
            Console.WriteLine();
            Console.WriteLine("Enter variable b: ");
            string bChoiceStr = Console.ReadLine();

            if (!double.TryParse(bChoiceStr, out double bChoice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                goto B_ENTER;
            }

            Console.WriteLine();
            Console.Write("Therefore, c is equal to ");
            Console.Write(Pythag(aChoice, bChoice));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            Menu();
        }

        static double Pythag(double a, double b)
        {
            double aSqr = a * a;
            double bSqr = b * b;
            double cSqr = aSqr + bSqr;

            double c = Math.Sqrt(cSqr);

            return c;
        }
    }
}
