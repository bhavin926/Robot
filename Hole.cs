using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Hole : Obstacle
    {
        public (int x, int y) ConnectedLocation { get; }

        public Hole(int x, int y)
        {
            ConnectedLocation = (x, y);
        }

        public override bool Handle(Robot robot)
        {
            robot.MoveTo(ConnectedLocation.x, ConnectedLocation.y);
            return true;
        }
    }
}
