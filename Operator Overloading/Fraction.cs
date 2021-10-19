using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("The denominator cannot be 0!");
            }

            _numerator = num;
            _denominator = den;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }
   
        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            int num = (f1._numerator * f2._denominator) + (f2._numerator * f1._denominator);
            int den = (f1._denominator * f2._denominator) + (f2._denominator * f1._denominator);
            Fraction total = new(num, den);

            return total;
        }
    }
}
