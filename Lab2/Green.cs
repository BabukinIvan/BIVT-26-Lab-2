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

            double S = 0;
            for (int i = 2; i <= n; i += 2)
                S += (double)i / (i + 1);

            // end
            answer = S;
            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double S = 1.0;
            double curlen = 1.0;

            for (int i = 1; i <= n; i++)
            {
                S = S / x;
                curlen = curlen + S;

            }


            // end
            answer = curlen;
            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            long S = 1;
            for (int i = 0; i<=n;i++ )
            {
                
                answer += S;
                S *= i + 1;
            }

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double eps = 0.0001;
            double curlen = x;
            int i = 1;

            while (true)
            {
                double curtem = Math.Sin(i * curlen);

                if (Math.Abs(curtem) < eps)
                {
                    break;
                }

                answer += curtem;
                i++;
                curlen = curlen * x;
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 1;

            double eps = 0.0001;
            

            
            double prev = 1.0;
            double cur = 1.0 / x;

            while (true)
            {
                
                if (Math.Abs(cur - prev) < eps)
                {
                    return answer;
                }

                answer++;
                
                prev = cur;
                cur /= x; 
            }
        



        

            // end

            
        }
        public int Task6(int limit)
        {
            int answer = 0;

            int elem = 1;
            int i = 0;

            while (elem < limit)
            {
                elem = elem * 2;
                answer = answer + elem;
                i++;
            }

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            int count = 0;

            while (L > Da)
            {
                L = L / 2.0;
                count++;
            }
            answer = count;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            double eps = 0.0001;

            
            for (int k = 0; a + k * h <= b + 0.000001; k++)
            {
                double x = a + k * h;
                double stoppls = 0;
                double pomogite = x;
                int i = 0;

                while (true)
                {
                    
                    stoppls += pomogite;

                    
                    if (Math.Abs(pomogite) < eps)
                    {
                        break; 
                    }

                    
                    i++;
                    pomogite = pomogite * (-1) * x * x * (2 * i - 1) / (2 * i + 1);
                }

                SS += stoppls;
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}
