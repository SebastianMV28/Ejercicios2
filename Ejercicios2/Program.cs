namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double porcent = 2.99;
            int n1, n2;
            double result;
            Console.WriteLine("Enter first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            n2 = int.Parse(Console.ReadLine());

            result = (n1*n2)*porcent;
            Console.WriteLine("The result of your count is " + result);

        }
    }
}