using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;


            // code here
            double xi = 1;
            for(int i = 1;i<=n;i++)
            {
                answer += Math.Sin(i * x) / xi;
                xi *= x;
            }
           

            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int s = -1;
            long fact = 1;
            double five = 5;
            for (int i = 1; i<=n;i++)
            {
                answer += s * five / fact;
                s *= -1;
                fact *= (i + 1);
                five *= 5;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0;
            long b = 1;
            for ( int i=0;i<n;i++)
            {
                answer+=a;
                (a, b) = (b, a + b);
            }
          
            
          
            
            

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            
            double sum = 0;
            double perv = a;
            while(sum+perv<=L)
            {
                sum += perv;
                perv += h;
                answer++;
            }
            
           

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);



            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            do
            {
                S *= 2;
                answer += h;
            } while (S <= L);

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {

            double a = 0;
            int b = 0;
            int c = 0;
            // code here
            double prog = 1 + (I / 100.0);
            double putA = S;
            double allA = 0;
            double putB = S;
            double allB = 0;
            double putC = S;
            for (int t = 1; t <= 7;t++)
            {
                allA += putA;
                putA *= prog;
            }
            a = allA;
            while (allB<100)
            {
                ++b;
                allB += putB;
                putB *= prog;

            }
            if (S > 42)
                c = 0;
            else
            {
                while (putC<=42)
                {
                    putC *= prog;
                    c++;
                }
            }

           


            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while(x<=b+0.0000001)
            {
                double s = 0;
                double t = 1;
                double fact = 1;
                double st = 1;
                int i = 0;
                while (Math.Abs(t) >= E)
                {
                    t = (2 * i + 1) * st / fact;
                    s += t;
                    i++;
                    fact *= i;
                    st = st * x * x;
                }
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;
                x += h;

            }


            // end

            return (SS, SY);
        }
    }
}
