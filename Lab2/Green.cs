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
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double p = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += p;
                p /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    f *= i;
                }
                answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double p = x;
            double t;
            while (true)
            {
                t = Math.Sin(n * p);
                if (Math.Abs(t) < E)
                    break;
                answer += t;
                n++;
                p *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 2;
            double p = 1 / x;
            double c = p / x;
            while (Math.Abs(c - p) >= E)
            {
                n++;
                p = c;
                c = p / x;
            }
            answer = n;
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
            while (L > Da)
            {
                L /= 2;
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
            int st = (int)((b - a) / h);
            for (int k = 0; k <= st; k++)
            {
                double x = a + k * h;
                double s = 0;
                double p = x;
                double g = 1;
                int i = 0;
                double t = g * p / (2 * i + 1);
                while (Math.Abs(t) >= E / 100 && i < 10000)
                {
                    s += t;
                    i++;
                    g = -g;
                    p *= x * x;
                    t = g * p / (2 * i + 1);
                }
                double y = Math.Atan(x);
                SS += s;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
