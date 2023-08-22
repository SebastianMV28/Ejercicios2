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

            string w1, w2, w3;
            w1 = w2 = w3 = "This is War";
            Console.WriteLine(w1 + " " + w2+ " "+ w3 );

            float f1, f2;
            f1 = f2 = 2145.02f;
            Console.WriteLine(f1 + " " + f2);
            Console.WriteLine(f1+f2 );
        }
    }
}