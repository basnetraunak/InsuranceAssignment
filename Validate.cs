namespace InsuranceWAAssignment
{

    class Validate
    {
        private static bool isplaced = false;// variable for checking if is placed before
        private static Robot? robot;//Define a variable robot of type Robot
        private static Table? table;//define a table variable of type Table

        public static void PlaceCommandchecker(string userInput)
        {

            string[] SplitInputArrayInTwo = userInput.Split(new char[] { ' ' }, 2); // split the input into 2 parts as an array, new char[] { ' ' } is used as delimiter which looks for space in the string and then splits into two part, " " is simply not used as this was complaning that  cannot convert int to char

            bool isPLACECommand = SplitInputArrayInTwo[0].ToUpper() == "PLACE";
            if (!isPLACECommand || SplitInputArrayInTwo.Length < 2)
            {
                Console.WriteLine("Invalid input! PLACE command was not executed.Required format is Place x,y,face, Place command not provided");
                return;

            }
            string[] RestInputArrayForPlacing = SplitInputArrayInTwo[1].Split(','); //if first command is Place split the second array created above now creating array of rest input based on ',' and procress X and y

            if (RestInputArrayForPlacing.Length != 3) // since RestInputArrayForPlacing has X,Y,Face value its size is to be exact 3 if less or more then is not a valid input
            {
                Console.WriteLine("Invalid input! \nPLACE command was not executed.Required format is (Place x,y,face)\n You provided more data or less data ");
                return;
            }

            int x = CheckerForXORYValue(RestInputArrayForPlacing[0]);
            int y = CheckerForXORYValue(RestInputArrayForPlacing[1]);
            bool isInteger = int.TryParse(RestInputArrayForPlacing[2], out int stringexpected);
            if (isInteger) { Console.WriteLine($"{stringexpected} is an invalid input, enter a string insted of number."); }
            Directions facing = ValidFacingChecker(RestInputArrayForPlacing[2]);//converting input for facing in uppar case
            if (x == -1 || y == -1 || facing == Directions.Invalid)
            {
                Console.WriteLine($"Invalid input! PLACE command was not executed. ");
                return;
            }

            table ??= new Table();// if table is null create table at first the table is null creating table
            robot ??= new Robot(x, y, facing, table);// robot object is created with x,y and facing and passing this table
            isplaced = true;


        }
        public static bool IsRobotPlaced()//robot place or not checker function
        {

            return isplaced; // Returns `true` if robot is placed, `false` otherwise
        }
        public static void Move()// function to validate if robot is place before moving it then calls robot.Move
        {
            if (!isplaced)
            {
                Console.WriteLine("Robot not placed yet. Use PLACE X,Y,FACING first.");
                return;
            }

            robot?.Move(); // Call Move function from Robot.cs
        }
        public static void Right()// function to validate if robot is place before moving it then calls robot.Move
        {
            if (!isplaced)
            {
                Console.WriteLine("Robot not placed yet. Use PLACE X,Y,FACING first.");
                return;
            }

            robot?.Right(); // Call right function from Robot.cs clockwise
        }
        public static void Report()// function to validate if robot is place before moving it then calls robot.Move
        {
            if (!isplaced)
            {
                Console.WriteLine("Robot not placed yet. Use PLACE X,Y,FACING first.");
                return;
            }

            robot?.Report(); // Call left function from Robot.cs anticlockwise
        }

        public static void Left()// function to validate if robot is place before moving it then calls robot.Move
        {
            if (!isplaced)
            {
                Console.WriteLine("Robot not placed yet. Use PLACE X,Y,FACING first.");
                return;
            }

            robot?.Left(); // Call left function from Robot.cs anticlockwise
        }

        public static int CheckerForXORYValue(string InputToProcressForGridLocation) //command to check valid  x and y valye if valid return value else pass -1
        {
            bool isInteger = int.TryParse(InputToProcressForGridLocation, out int number); //if sucess number is the value converted an isint a bool with true


            if (isInteger && number >= 0 && number <= 4)
                return number; // Return valid number



            Console.WriteLine($" <<-----   \"{InputToProcressForGridLocation}\"     -------> *****enter a valid number in a range of [0-4] inclusive******");
            return -1;
        }
        public static Directions ValidFacingChecker(string InputFacing) //Directions is enum, here we are checking if it is correct text for directions or not
        {

            bool isvalidFace = Enum.TryParse(InputFacing.ToUpper(), out Directions facing); //facing is a variable 



            if (isvalidFace)// check if correct face
            {
                return facing; // return value

            }

            Console.WriteLine($"<<--------    \"{InputFacing}\"      -------> ********* An invalid Face, Enter either of (NORTH,SOUTH,EAST,WEST)*************");

            return Directions.Invalid;

        }




    }
}

