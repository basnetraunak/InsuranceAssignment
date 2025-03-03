using System;

namespace InsuranceWAAssignment
{

    class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Directions Facing { get; private set; }
        private Table? Table; // reference to table

        //robot constructor
        public Robot(int x, int y, Directions facing, Table table)
        {
            if (table == null || !Table.IsValidPosition(x, y))
            {
                Console.Write("Invalid table");
                return;
            }
            X = x;
            Y = y;
            Facing = facing;
            Table = table;
            Console.WriteLine($"Robot placed at({X},{Y}) and facing {Facing}");


        }
        public void Move() //move function to move robot
        {
            int moveX = X; //assign current X and y value
            int moveY = Y;

            switch (Facing)
            {
                //west------>East X axis but value of y changes South--------------> North y axis but value of X changes

                case Directions.EAST: //going from west to east value of y is increasing ie, if you start at 0,0 and move east it is 0,1
                    moveY++;
                    break;
                case Directions.WEST: //going from  east to west value of y is decreasing ie, if you start at 0,1 and move east it is 0,0
                    moveY--;
                    break;

                case Directions.NORTH://going from  south to nort value of x is increasing ie, if you start at 0,0 and move north it is 1,0
                    moveX++;
                    break;

                case Directions.SOUTH: //going from  nort to south value of x is decreasing ie, if you start at 0,0 and move north it is 1,0
                    moveX--;
                    break;
            }
            if (Table.IsValidPosition(moveX, moveY)) //if it is valid move update robots X and y location, with update moveX and movey value after switch statement is ran
            {
                X = moveX;
                Y = moveY;
                Console.WriteLine($"Robot moved to ({X}, {Y})");


            }
            else { Console.WriteLine($"Invalid Move ROBOT will fall."); Console.WriteLine($"Enter another command"); return; }

        }
        public void Right() //rotate90 degree clockwise
        {
            switch (Facing)
            {
                case Directions.EAST:
                    Facing = Directions.NORTH; // Rotate clockwise e--->n
                    break;
                case Directions.NORTH:
                    Facing = Directions.WEST; // Rotate clockwise n--->w
                    break;
                case Directions.WEST:
                    Facing = Directions.SOUTH; // Rotate clockwise w---->S
                    break;
                case Directions.SOUTH:
                    Facing = Directions.EAST; // Rotate clockwise S------->E
                    break;
            }
            Console.WriteLine($"ROBOT turned Right===> Now facing {Facing}");


        }
        public void Left() //move function to move robot
        {

            switch (Facing)
            {
                case Directions.EAST:
                    Facing = Directions.SOUTH; // Rotate clockwise e--->n
                    break;
                case Directions.SOUTH:
                    Facing = Directions.WEST; // Rotate clockwise n--->w
                    break;
                case Directions.WEST:
                    Facing = Directions.NORTH; // Rotate clockwise w---->S
                    break;
                case Directions.NORTH:
                    Facing = Directions.EAST; // Rotate clockwise S------->E
                    break;
            }
            Console.WriteLine($"ROBOT turned LEFT! ===> Now facing {Facing}");


        }
        public void Report() //move function to move robot
        {

            Console.WriteLine($"ROBOT is at ({X},{Y}) and Facing {Facing}");

        }


    }
}
