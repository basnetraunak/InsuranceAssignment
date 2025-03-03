namespace InsuranceWAAssignment
{
    class CommandProcessor
    {
        public static void Procress(string userInput)
        {

            int inputlength = userInput.Length;
            if (inputlength > 6)
            {
                Validate.PlaceCommandchecker(userInput);
                return;
            }
            switch (userInput)
            {
                case "MOVE":

                    Validate.Move();

                    break;
                case "RIGHT":
                    //Validate.Right();
                    Console.WriteLine("right");
                    break;
                case "LEFT":
                    // Validate.Left();
                    Console.WriteLine("Left");
                    break;
                case "REPORT":
                    //Validate.Report();
                    Console.WriteLine("report");
                    break;
                default:
                    Console.WriteLine($"{userInput} is an invalid command.");
                    break;
            }




        }
    }
}
