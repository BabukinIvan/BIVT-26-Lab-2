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

            double term = 1;
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                term /= x;
                answer += term;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long fact = 1;
            answer = 1;
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

            double power = 1;
            int i = 1;
            while (true)
            {
                power *= x;
                double term = Math.Sin(i * power);
                if (Math.Abs(term) < E) break;
                answer += term;
                i++;
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here

            double pr = 1;
            double cu = 1 / x;
            answer = 1;
            while (Math.Abs(cu - pr) >= E)
            {
                pr = cu;
                cu /= x;
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

            int steps = (int)((b - a) / h + E);
            for (int k = 0; k <= steps; k++)
            {
                double x = a + k * h;
                double power = x;
                int sign = 1;
                int i = 0;
                double term;
                do
                {
                    term = sign * power / (2 * i + 1);
                    SS += term;
                    power *= x * x;
                    sign = -sign;
                    i++;
                } while (Math.Abs(term) >= E);
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}