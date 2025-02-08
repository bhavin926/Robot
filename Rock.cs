using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Rock : Obstacle
    {
        public override bool Handle(Robot robot)
        {
            return false; // Robot can't move onto a rock
        }
    }
}
