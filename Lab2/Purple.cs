using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            for (int i = 0; i < n; i += 1)
            {
                double s = (p + i * h)*(p + i * h);
                
                answer +=  Convert.ToInt32(s);

                


            }

            return answer;
        }
            public (int quotient, int remainder)  Task2(int a, int b)
            {
                int quotient = 0;
                int remainder = 0;

                // code here
               
                while ((a >= b) && (b > 0))
                {
                        
                    a = a-b;
                    quotient+=1;
                        
                        
                    
                }
                remainder = a;

                // end

                return (quotient, remainder);
            }
        public double Task3()
        {
            double answer = 0;

            // code here

            double E = 0.0001;
            double c1 = 1;
            double c2 = 2;
            double z1 = 1;
            double z2 = 1;
            
            double dr1 = c1 / z1;
            double dr2 = c2 / z2;
            while (Math.Abs(dr2 - dr1) >= E)
            {
                double c3 = c1 + c2;
                double z3 = z1 + z2;
                c1 = c2;
                z1 = z2;
                c2 = c3;
                z2 = z3;
                dr1 = dr2;
                dr2 = c2 / z2;


            }

            answer = dr2;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double E = 0.0001;
            for (int n = 0; ; n++)
            {
                double ans = b * Math.Pow(q, n-1);
                if (Math.Abs(ans) < E)
                {
                    answer = n;
                    break;
                }
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            long number = a;
            
            while(b>0)
            {
                number *= b;
                b--;
            }

            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            
            
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            int count = 1;
            double zerno = 1;
            double allzerno = 0;
            while (count <= 64)
            {
                allzerno+= zerno;
                zerno*= 2;
                count++;
            }

            double vesgr = allzerno / 15;
            double ton = vesgr / 1_000_000;
            answer = (long)ton;
            
            
                
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            int months = 0;
            double snach = S;
            double s2 = S * 2;
            double monthlyAdd = 0;

            if (S > 0 && d > 0)
            {
                while (snach < s2)
                {
                    if (months % 12 == 0)
                    {
                        monthlyAdd = snach * d / 1200.0;
                    }
                    snach += monthlyAdd;
                    months++;
                }
                answer = months;
            }
                    
            else return 0;
            
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double E = 0.0001;
            int n = (int)((b - a)/h);
            for (int i = 0; i <= n; i++)
            {
                double x = a + (i * h);
                double s = 0;
                double t = 1;
                int j = 0;
                while (Math.Abs(t) >= E)
                {
                    s += t;
                    j++;
                    t = -1*t*x*x/((2*j-1)*(2*j));
                    

                }

                SS += s;
                SY += Math.Cos(x);
            }
            
            
            
            // end

            return (SS, SY);
        }
    }
}
