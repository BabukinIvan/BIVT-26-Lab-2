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
            int dp = p;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = p + i * h;
                sum += a * a;
            }

            answer = sum;
            

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            int count = 0;

            while (a >= b)
            {
                a = a - b;
                count++;
            }

            quotient = count;
            remainder = a;

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;
            double zn1 = 1;
            double zn2 = 1;
            double ch1 = 1;
            double ch2 = 2;

            for (int i = 0; i < 100000; i++)
            {
                double res1 = ch1 / zn1;
                double res2 = ch2 / zn2;

                if (Math.Abs(res2 - res1) < E)
                {
                    answer = res2;
                    break;
                }

                double nextch = ch1 + ch2;
                double nextzn = zn1 + zn2;

                ch1 = ch2;
                ch2 = nextch;
                zn1 = zn2;
                zn2 = nextzn;
            }
            
            

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;
            int n = 1;

            while (Math.Abs(b) >= E)
            {
                b = b * q;
                n++;

            }

            answer = n;
            

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
            double vsego = 0;
            int count = 1;
            double zerno = 1;
            
            while (count <= 64)
            {
                vsego += zerno;
                zerno = zerno * 2;
                count++;
            }

            double ves = vsego / 15;
            double ton = ves / 1_000_000;
            long res = (long)ton;

            answer = res;

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            double dp = d / 1200;
            double goal = S * 2;
            int count = 0;
            double yearS = S;

            while (S < goal)
            {
                S += yearS * dp;
                count++;
                if (count % 12 == 0)
                {
                    yearS = S;
                }
            }

            answer = count;

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 0.0001; x += h)
            {
                double sum = 0;
                double term = 1;
                double i = 0;

                while (Math.Abs(term) > E)
                {
                    sum += term;
                    i++;

                    term = term * (-x * x) / ((2 * i - 1) * (2 * i));
                }

                SS += sum;
                SY += Math.Cos(x);
            }
            

            return (SS, SY);
        }
    }
}