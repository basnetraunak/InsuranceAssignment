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
                    Validate.Right();
                    break;
                case "LEFT":
                    Validate.Left();
                    break;
                case "REPORT":
                    Validate.Report();
                    break;
                default:
                    if (!Validate.IsRobotPlaced() && (userInput.ToUpper() == "MOVE" || userInput.ToUpper() == "LEFT" || userInput.ToUpper() == "RIGHT" || userInput.ToUpper() == "REPORT"))
                    {
                        Console.WriteLine($"Enter PLACE command First");
                        Console.WriteLine("Invalid command.");
                    }
                    Console.WriteLine("Invalid command.");
                    break;
            }




        }
    }
}
