using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Direction
    {
        private static readonly string[] Directions = { "N", "E", "S", "W" };

        public string CurrentDirection { get; private set; }

        public Direction(string direction)
        {
            if (Array.IndexOf(Directions, direction) == -1)
                throw new ArgumentException("Invalid direction.");
            CurrentDirection = direction;
        }

        public void TurnLeft()
        {
            int index = Array.IndexOf(Directions, CurrentDirection);
            CurrentDirection = Directions[(index - 1 + 4) % 4];
        }

        public void TurnRight()
        {
            int index = Array.IndexOf(Directions, CurrentDirection);
            CurrentDirection = Directions[(index + 1) % 4];
        }

        public (int x, int y) MoveForward(int x, int y)
        {
            switch (CurrentDirection)
            {
                case "N": return (x, y - 1);
                case "E": return (x + 1, y);
                case "S": return (x, y + 1);
                case "W": return (x - 1, y);
                default: throw new InvalidOperationException("Unknown direction");
            }
        }
    }
}
