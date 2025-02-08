using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Spinner : Obstacle
    {
        public int Rotation { get; }

        public Spinner(int rotation)
        {
            Rotation = rotation; // Rotation in 90 degree increments
        }

        public override bool Handle(Robot robot)
        {
            for (int i = 0; i < Rotation / 90; i++)
            {
                robot.TurnRight();
            }
            return true;
        }
    }
}
