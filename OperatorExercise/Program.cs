namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)

            // int is explicit typing
            // var is inferred typing
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            if (a == 17 && b == 4)

                // Concatination
                // Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);

                // String Interpolation
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            
            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();
            
            var radius = double.Parse(userInput);

            Console.WriteLine($"The area of a circle with a radius of {userInput} is {AreaOfCircle(radius)}");


        }

            public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

    }
}
