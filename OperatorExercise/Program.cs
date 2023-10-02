namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);

            //if (a == 17 && b == 4) ;


            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

           

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder} ");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area} ");

        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
            
        }
    }
}
 