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
            answer = 1;
            double t = 1;
            for (int i = 1; i <= n; i++)
            { 
                t /= x;
                answer += t;
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
                answer += f;
                f *= (i + 1);
            }
                // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double xp = x;
            int i = 1;
            double t = Math.Sin(i * xp);
            while (Math.Abs(t) >= 1e-4)
            {
                answer += t;
                i++;
                xp *= x;
                t = Math.Sin(i * xp);
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double p = 1.0 / x;
            double c = 1.0 / (x * x);
            int n = 2;
            while (Math.Abs(c - p) >= 1e-4)
            {
                p = c;
                c = p / x;
                n++;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int e = 1;
            int i = 0;
            while (e < limit)    
            {
                e *= 2;
                answer += e;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int c = 0;
            double l = L;
            while (l > Da)
            {
                l /= 2;
                c++;
            }
            answer = c;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                double S = 0;
                double i = 0;
                double ch1 = 1;
                double ch2 = x;
                double zn = 1;
                double add = ch1 * ch2 / zn;

                while (Math.Abs(add) >= 0.0001)
                {
                    S += add;
                    i += 1;
                    ch1 *= -1;
                    ch2 *= x * x;
                    zn = 2 * i + 1;
                    add = ch1 * ch2 / zn;
                }
                S += add;

                SS += S;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
}
