using System.Collections.Generic;
using System.Numerics;

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

            for (double i = 2; i <= n; i += 2)
            {
                answer += i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double term = 1;
            for (int i = 0;i <= n; i++)
            {
                answer += term;
                term = term / x;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;
            answer += factorial;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                answer += factorial;
            }

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;
            double power = 1;
            power *= x;
            double term  = Math.Sin(n * power);
            while (Math.Abs(term) >= E)
            {
                answer += term;
                n += 1;
                power *= x;
                term = Math.Sin(n * power);
            }


                // end

                return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double previous = 1; 
            double current = previous / x; 
            int n = 1;
            while (Math.Abs(current - previous) >= E)
            {
                previous = current;
                current = previous / x;
                n += 1;
            }
            answer = n;

            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            for(int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            int count = 0;
            while (L > Da)
            {
                L = L / 2;
                count ++;
            }
            answer = count;

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
                double S = 0;
                double term = x;
                int i = 0;
                while (Math.Abs(term) >= E)
                {
                    S += term;
                    term *= -x * x;
                    term *= (2.0 * i + 1) / (2.0 * i + 3);
                    i++;
                }
                S += term;
                SS += S;
                SY += Math.Atan(x);
            }
                // end

                return (SS, SY);
        }
    }
}
