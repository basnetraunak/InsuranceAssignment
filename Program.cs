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


            while (true)
            {
                string? UserInstructions = Console.ReadLine();
                if (UserInstructions == null)
                {
                    Console.WriteLine("Input cannot be null. Please enter a valid command.");
                    continue;
                }
                string UserInputUpper = UserInstructions.ToUpper();
                if (UserInputUpper == "EXIT")
                {
                    Console.WriteLine(">>>>>>>>>>>>>>> PROGRAM EXITED >>>>>>>>>>>>>>>");
                    break;
                }
                else if (UserInputUpper == "MOVE" || UserInputUpper == "LEFT" || UserInputUpper == "RIGHT" || UserInputUpper == "REPORT") { CommandProcessor.Procress(UserInputUpper); }
                else if (UserInputUpper.Length > 6 && !Validate.IsRobotPlaced()) { CommandProcessor.Procress(UserInputUpper); } //incase robot is not placed and length is more then 6 go via place command route
                else if (UserInputUpper.Length > 6 && Validate.IsRobotPlaced()) { Console.WriteLine("Robot is Already Placed"); } //check if again length is more than 6 and robot is placed
                else { Console.WriteLine("Enter a valid command"); }


            }


        }
    }
}
