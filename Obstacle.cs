using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public abstract class Obstacle
    {
        public abstract bool Handle(Robot robot);
    }
}
