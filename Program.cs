namespace Conditional_Statements_Deliverable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300? ");

            try
            {
                string input = Console.ReadLine();

                int grade = int.Parse(input);



                if (grade >= 90)
                {
                    Console.WriteLine("You will recieve an A");
                    Console.ReadKey(true);
                }
                else if ((grade < 90) && (grade > 79))
                {
                    Console.WriteLine("You will recieve a B");
                    Console.ReadKey(true);
                }
                else if ((grade < 80) && (grade > 69))
                {
                    Console.WriteLine("You will recieve a C");
                    Console.ReadKey(true);
                }
                else if ((grade < 70) && (grade > 59))
                {
                    Console.WriteLine("You will recieve a D");
                    Console.ReadKey(true);
                }
                else if (grade < 60)
                {
                    Console.WriteLine("You will recieve a F");
                    Console.ReadKey(true);
                }

            } // end of try

            catch
            {
                Console.WriteLine("Use a posative int data type for grade");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } // end of catch
        }
    }
}