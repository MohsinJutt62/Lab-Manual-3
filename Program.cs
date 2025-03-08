using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Q2
{
    class Fraction
    {
        //Q # 2
        public
        double Dividend; double Divisor;
        public Fraction(double dividend, double divisor)
        {
            if (dividend == 0) { Console.WriteLine($"Error: Dividend cant be 0 ...........");
                dividend = 1;
            }

            Dividend=dividend;  Divisor = divisor;
        } 
        public void Display()
        {
            Console.WriteLine($"Fraction : {Dividend} / {Divisor}");
        }

        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(12,2);
            fraction1.Display();
            Fraction fraction2 = new Fraction(34, 4);
            fraction2.Display();
        }
    }
}
