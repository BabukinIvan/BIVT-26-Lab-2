using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                answer += (p + h * i) * (p + h * i);
            }
            return answer;
        }
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            while (a >= b)
            {
                a -= b;
                quotient += 1;
            }
            remainder = a;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            double n1 = 1, d1 = 1, n2 = 2, d2 = 1;

            double a1 = n1 / d1;
            double a2 = n2 / d2;

            while (Math.Abs(a2 - a1) >= E)
            {
                double n3 = n1 + n2;
                double d3 = d1 + d2;
                double a3 = n3 / d3;
                n1 = n2;
                d1 = d2;
                a1 = a2;
                n2 = n3;
                d2 = d3;
                a2 = a3;
            }

            answer = a2;
            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            double s = b;
            answer += 1;
            for (int i = 0; ; i++)
            {
                if (Math.Abs(s) < E)
                {
                    break;
                }
                s *= q;
                answer += 1;
            }

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }

            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            double a = 0;
            double p = 1;

            for (int i = 0; i < 64; i++)
            {
                a += p;
                p *= 2;
            }
            double grams = a / 15.0;
            answer = (long)Math.Floor(grams / 1000000);
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            double c = 2 * S;
            double start = S;
            while (S < c)
            {
                S += ((start * d) / 100.0) / 12.0;
                answer += 1;
                if (answer % 12 == 0)
                    start = S;
            }

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 0.0001; x += h)
            {
                double r = 1.0;
                double s = 0;
                int i = 0;
                do
                {
                    s += r;
                    i++;
                    r = r * (-1) * x * x / ((2 * i - 1) * (2 * i));
                } 
                while (Math.Abs(r) > E);

                SS += s;
                SY += Math.Cos(x);
            }

            return (SS, SY);
        }
    }
}
