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
                Console.Write("invalid table");
                return;
            }
            X = x;
            Y = y;
            Facing = facing;
            Table = table;
            Console.WriteLine($"Robot placed in({X},{Y}) and face in {Facing}");


        }

    }
}
