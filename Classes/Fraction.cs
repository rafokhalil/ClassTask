using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Fraction
    {
        private double _denominator;
        public double nominator { get; set; }
        public double denominator
        {
            set
            {
                if (value == 0) throw new ArgumentException("denominator can not be zero!");
                this._denominator = value;
            }
            get { return this._denominator; }
        }
        public static double gcd(double a, double b) { return (b == 0) ? a : gcd(b, a % b); }
        public static double lcd(double a, double b) { return (a * b) / gcd(a, b); }
        public Fraction(double a = 0, double b = 1)
        {
            nominator = a;
            denominator = b;
        }
        public static Fraction reduce(double a, double b)
        {
            double n = gcd(a, b);
            return new Fraction(a /= n, b /= n);
        }

        public override string ToString()
        {
            return nominator + "/" + denominator;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if ((a.nominator / a.denominator) > (b.nominator / b.denominator))
                return true;
            else
                return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if ((a.nominator / a.denominator) < (b.nominator / b.denominator))
                return true;
            else
                return false;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            Fraction x = reduce(a.nominator, a.denominator);
            Fraction y = reduce(b.nominator, b.denominator);
            if (x.nominator == y.nominator && x.denominator == y.denominator)
                return true;
            else
                return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if ((a == b) == false) return true;
            else return false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            Fraction x = reduce(a.nominator, a.denominator);
            Fraction y = reduce(b.nominator, b.denominator);
            if (((a.nominator / a.denominator) < (b.nominator / b.denominator)) || x == y)
                return true;
            else
                return false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            Fraction x = reduce(a.nominator, a.denominator);
            Fraction y = reduce(b.nominator, b.denominator);
            if (((a.nominator / a.denominator) > (b.nominator / b.denominator)) || x == y)
                return true;
            else
                return false;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            double an = a.nominator, ad = a.denominator, bn = b.nominator, bd = b.denominator;
            if (ad == bd)
            {
                return new Fraction(an + bn, ad);
            }

            return reduce((an * bd) + (bn * ad), ad * bd);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            double an = a.nominator, ad = a.denominator, bn = b.nominator, bd = b.denominator;
            if (ad == bd)
            {
                return new Fraction(an - bn, ad);
            }

            return reduce((an * bd) - (bn * ad), ad * bd);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            double x = a.nominator, y = a.denominator, x1 = b.nominator, y1 = b.denominator;
            return reduce(x * x1, y * y1);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            double x = a.nominator, y = a.denominator, x1 = b.nominator, y1 = b.denominator;
            return reduce(x * y1, y * x1);
        }
        public static implicit operator double(Fraction x)
        {
            return ((double)x.nominator / x.denominator);
        }
        public void Show()
        {
            Console.WriteLine($"{nominator} / {denominator}");
        }
    }
}
