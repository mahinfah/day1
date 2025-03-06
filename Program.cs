namespace day1
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("It's our first day of C#");
            Console.WriteLine("Hello Please give input:");

            Double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First value is "+s1);

            Double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second value is "+s2);

            Console.WriteLine("PRESS 1 FOR SUM");
            Console.WriteLine("PRESS 2 FOR SUBTRACT");
            Console.WriteLine("PRESS 3 FOR MULTIPICATION");
            Console.WriteLine("PRESS 4 FOR DIVISION");

            string m = Console.ReadLine();


            if(m== "1")
            {
                Console.WriteLine("Sum :" + (s1 + s2));
            }
           
            else if (m == "2")
            {
                Console.WriteLine("subtract :" + (s1 - s2));
            }
           
            else if (m == "3")
         
            {
                Console.WriteLine("Multipication :" + (s1 * s2));
            }
           
            else if (m == "4")
            {
                Console.WriteLine("Dvision :" + (s1 / s2));
            }
            else
            {
                Console.WriteLine("Please enter valid operation");
            }




        }
    }
}
