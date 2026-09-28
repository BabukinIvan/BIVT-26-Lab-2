using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            //code here

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

            // code

            answer = 1;
            double a = x;
            for (int i = 1; i <= n; i++)
            {
                answer += (1 / a);
                a *= x;


            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here


            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += factorial;
                factorial *= (i + 1);
                Console.WriteLine(answer);

            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double sum = 0.0;
            int n = 1;
            double xn = x;

            while (true)
            {
                double term = Math.Sin(n * xn);
                if (Math.Abs(term) < E) break;
                sum += term;
                n++;
                xn *= x;
            }
            return sum;
            // end

            return answer; }

        public int Task5(double x)
        {
            int answer = 0;

            // code here
            if (Math.Abs(x) <= 1) { return 0; }

            int n = 1;
            double prev = 1;
            double cur = 1 / x;
            while (Math.Abs(cur - prev) >= E)
            {

                prev = cur;
                cur = cur / x;
                n++;

            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {

            // code here
            int answer = 0;
            int elem = 1;
            int i = 0;
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
            int n = 0;
            // code here
            while (L > Da)
            {
                n++;
                L = L / 2;

            }
            answer = n;
            // end


            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.000000001; x += h)
            {
                double chisl = x;
                double znam = 1;
                double s = 0;
                double term = chisl/znam;
                while (Math.Abs(term) >= E)
                {
                    s += term;
                    chisl = -chisl * x * x;
                    znam += 2;
                    term = chisl / znam;
                }
                s += term;
                SS += s;
                SY += Math.Atan(x);
             }
                // end

                return (SS, SY);
            }
        }
    }