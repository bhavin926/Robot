using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class CommandProcessor
    {
        private Robot robot;
        private Grid grid;

        public CommandProcessor(Robot robot, Grid grid)
        {
            this.robot = robot;
            this.grid = grid;
        }

        public (int x, int y, List<(int, int)> path) ExecuteCommands(string commands)
        {
            foreach (var command in commands)
            {
                robot.ProcessCommand(command, grid);
            }
            return (robot.Position.x, robot.Position.y, robot.Path);
        }
    }
}
