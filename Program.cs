using InsuranceWAAssignment;
namespace InsuranceofWAAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------- Program Launched ----------------------------------------------------------------------------------------------");
            while (!Validate.IsRobotPlaced())
            {

                Console.WriteLine("Please enter a PLACE command \n (FORMAT: PLACE X,Y,FACING):");
                string? userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    CommandProcessor.Procress(userInput);
                }
                else { Console.WriteLine("Sorry, Input cannot be empty!"); }
            }
            Console.WriteLine("<============ Robot successfully placed!!! ===================>");
            Console.WriteLine("Now enter one of the following commands \n MOVE, LEFT, RIGHT, REPORT");
            Console.WriteLine("OR");
            Console.WriteLine("EXIT (to exit the program)");




        }
    }
}
