using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            // code here
            for (int k = 1; k <= n; k++)
            {
                answer += Math.Sin(k * x) / Math.Pow(x, k - 1);
            }
            // end
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double power = 1;   // 5^0
            double fact = 1;    // 0!
            int sign = 1;
            for (int k = 1; k <= n; k++)
            {
                power *= 5;
                fact *= k;
                sign *= -1;
                answer += sign * power / fact;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                int next = a + b;
                a = b;
                b = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long sum = 0;
            int n = 0;
            while (true)
            {
                long nextTerm = a + (long)n * h;
                if (sum + nextTerm <= L)
                {
                    sum += nextTerm;
                    n++;
                }
                else
                {
                    break;
                }
            }
            answer = n;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double s = 0;
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                s += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            answer = s;
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            int time = 0;
            int cells = S;
            while (cells < L)
            {
                cells *= 2;
                time += h;
            }
            answer = time;

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double daily = S;
            for (int n = 1; n <= 7; n++)
            {
                a += daily;
                daily *= (1 + I / 100.0);
            }

            double total = 0;
            daily = S;
            while (total < 100)
            {
                b++;
                total += daily;
                daily *= (1 + I / 100.0);
            }

            daily = S;
            c = 0;
            while (daily <= 42)
            {
                c++;
                daily *= (1 + I / 100.0);
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            int steps = (int)Math.Floor((b - a) / h + 1e-9);
            for (int k = 0; k <= steps; k++)
            {
                double x = a + k * h;
                double xPow = 1;   // x^(2i)
                double fact = 1;   // i!
                double term;
                double s = 0;
                int i = 0;
                do
                {
                    term = (2 * i + 1) * xPow / fact;
                    s += term;
                    i++;
                    xPow *= x * x;
                    fact *= i;
                } while (Math.Abs(term) >= 0.0001);

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}