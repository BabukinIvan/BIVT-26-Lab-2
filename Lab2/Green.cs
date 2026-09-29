using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int k = 2; k <= n; k += 2)
            {
                answer += (double)k / (k + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += term;
                term /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            answer = fact;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                answer += fact;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double xpow = x;
            while (true)
            {
                double term = Math.Sin(i * xpow);
                answer += term;
                if (Math.Abs(term) < E)
                {
                    break;
                }
                i++;
                xpow *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            answer = 1;
            double val1 = 1;
            double val2 = val1 / x;
            while ( Math.Abs(val2 - val1) >= E)
            {
                val1 = val2;
                val2 = val2 / x;
                answer++;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double len = L;
            while (len > Da)
            {
                len /= 2;
                answer++;
            }
            // end

            return answer;
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
                int i = 0;
                double xpow = x;
                double term = xpow;
                double sign = 1;
                double s = 0;
                int stop = 0;
                while (true)
                {
                    s += sign * term;
                    stop++;
                    if (Math.Abs(term) < E || stop > 100000)
                    {
                        break;
                    }
                    i++;
                    sign = -sign;
                    xpow *= x * x;
                    term = xpow / (2 * i + 1);
                }
                SS += s;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}