using System;

namespace InsuranceWAAssignment
{

    class Table
    {
        private readonly int[,] grid = new int[5, 5]; // defining 2d array int[,]
        public Table() { }
        public static bool IsValidPosition(int? x, int? y)// function to check if in range
        {
            return x >= 0 && x < 5 && y >= 0 && y < 5;
        }

    }
}
