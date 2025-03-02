using InsuranceWAAssignment;
namespace InsuranceofWAAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------- Program Launched ----------------------------------------------------------------------------------------------");

            Console.WriteLine("Please enter a PLACE command \n (FORMAT: PLACE X,Y,FACING):");
            string? userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                CommandProcessor.Procress(userInput);
            }
            else { Console.WriteLine("Sorry, Input cannot be empty!"); }



        }
    }
}
