namespace CircleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius = 0;
            bool goOn = true;

            Console.WriteLine("Welcome to the circle creator");
            Console.WriteLine("Please enter a radius");
            try
            {
                radius = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please try again, only numbers please");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, lets try again");
            }
            do
            {
                Circle circe = new Circle(radius);
                Console.WriteLine("Diameter: " + circe.Diameter);
                Console.WriteLine("Circumference: " + circe.Circumference);
                Console.WriteLine("Area: " + circe.Area);
                goOn = Grow();
                if (goOn == true)
                {
                    radius = circe.Growth;
                }
                else
                {
                    Console.WriteLine("Goodbye, final radius was: " + radius);
                }

            }
            while (true);
            {
                
            }

                


        }
        public static bool Grow()
        {
            Console.WriteLine("Would you like the circle to grow?  y/n ");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Type \"y\" to grow the circle, type \"n\" to stop");
                return Grow();
            }
        }

    }
}