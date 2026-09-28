namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            Green green = new Green();
            Console.WriteLine(green.Task1(6));
            Console.WriteLine(green.Task2(4, 2.0));
            Console.WriteLine(green.Task3(7));
            Console.WriteLine(green.Task4(0.5));
            Console.WriteLine(green.Task5(2.0));
            Console.WriteLine(green.Task6(100));
            Console.WriteLine(green.Task7(5.0));
            Console.WriteLine(green.Task8(0.1, 0.5, 0.1));
        }
    }
}
