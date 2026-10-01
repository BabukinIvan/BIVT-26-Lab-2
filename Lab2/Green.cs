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

            for (int i = 2; i <= n; i += 2)
            {
                answer += (1.0*i) / (i + 1);
            }
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1.0;
            double t = 1.0;
            for (int i = 1; i <= n; i++)
            {
                t /= x;
                s += t;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;
            long c = 1;
            for (int i = 1;i<=n ;i++)
            {
                c *= i;
                answer += c;
            }

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double p = x;
            for (int i = 1; Math.Abs(Math.Sin(i * p)) >= 1e-4; i += 1)
            {
                answer += Math.Sin(i * p);
                p *= x;
            }

            

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double e = 1e-4;
            double c = 1.0 / x;
            double p = 1.0;
            while (Math.Abs(c - p) >= e)
            {
                n++;
                p = c;
                c /= x;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            while (L > Da)
            {
                L /= 2.0;
                answer += 1;
            }
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
    }
}
