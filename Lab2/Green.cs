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
            for (int i = 2; i <= n + 1; i += 2)
            {
                answer = answer + (double)i / (i + 1);

            }


            return answer;
        }

        public double Task2(int n, double x)
        {
            double answer = 0;

            double s = 1.0;
            for (int i = 1; i <= n; i++)
            {
                s += Math.Pow(x, -i);
            }

            return s;
        }


        public long Task3(int n)
        {
            long answer = 0;
            long fact = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    fact *= i;
                }

                answer += fact;
            }

            return answer;
        }

        public double Task4(double x)
        {
            double s = 0;
            double epsilon = 1e-4;
            int n = 1;

            while (true)
            {
                double term = Math.Sin(n * Math.Pow(x, n));
                if (Math.Abs(term) < epsilon) break;

                s += term;
                n++;
            }

            return s;
        }

        public int Task5(double x)
        {
            double epsilon = 1e-4;
            int n = 1;

            while (true)
            {
                double current = 1.0 / Math.Pow(x, n);
                double previous = 1.0 / Math.Pow(x, n - 1);

                if (Math.Abs(current - previous) < epsilon)
                {
                    return n;
                }

                n++;
            }
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
            int count = 0;
            double D = 1e-10;
            while (L > D)
            {
                L /= 2.0;
                count++;
            }

            return count;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0; 
            double SY = 0; 
            double epsilon = 0.0001;

            
            for (double x = a; x <= b + h / 1000; x += h)
            {
                double currentSum = 0; 
                double term;
                int i = 0;

                
                do
                {
                    
                    term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
            
                    currentSum += term;
                    i++;

                } while (Math.Abs(term) >= epsilon); 
                
                double currentY = Math.Atan(x);
                
                SS += currentSum;
                SY += currentY;
            }

            return (SS, SY);
        }
    }
}
