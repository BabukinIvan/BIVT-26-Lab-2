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

            // code here
            int s = p*p;
            for (int I=1;I<n;I++)
                s += (p+I*h)*(p+I*h);
                
            answer = s;

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            remainder = a;

            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double a = 1;
            double b = 2;
            double c = 1;
            double d = 2;

            while (Math.Abs(d - c) >= E)
            {
                double x = a + b;

                a = b;
                b = x;
                c = d;
                d = b / a;
            }

            answer = d;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double x = b;
            answer = 1;

            while (Math.Abs(x) >= E)
            {
                 x = x * q;
                 answer++;
            }

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            int n = a;

            while (b > 0)
            {
                n = n * b;
                b--;
            }

            while (n >= 10)
            {
                n = n / 10;
                answer++;
            }

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            decimal x = 1;
            decimal s = 0;

            for (int i = 1; i <= 64; i++)
            {
                s = s + x;
                x = x * 2;
            }

            answer = (long)(s / 15 / 1000000);

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double S1 = S;
            double n = 0;
            int o = 0;
            int y = 0;

            while (n < S1)
            {
                 n += S * (d / 100) / 12;
                 o++;

                 if (o == 12)
                 {
                     y += 12;
                     o = 0;
                     S = S * (1 + d / 100);
                }
            }

            y += o;
            answer = y;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                double s = 0;
                double t = 1;
                int i = 0;

                while (true)
                {
                    s += t;

                    if (Math.Abs(t) < E)
                        break;

                    i++;

                    t = t * (-x * x) / ((2 * i - 1) * (2 * i));
                }

                SS += s;
                SY += Math.Cos(x);
            }

            // end

            return (SS, SY);
        }
    }
}
