using RobotController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Robot
    {
        private Direction direction;
        private int x, y;
        private List<(int x, int y)> path;

        public Robot(int x, int y, string initialDirection)
        {
            this.x = x;
            this.y = y;
            this.direction = new Direction(initialDirection);
            path = new List<(int, int)> { (x, y) };
        }

        public (int x, int y) Position => (x, y);
        public List<(int, int)> Path => path;

        public void MoveTo(int newX, int newY)
        {
            x = newX;
            y = newY;
            path.Add((x, y));
        }

        public void TurnLeft()
        {
            direction.TurnLeft();
        }

        public void TurnRight()
        {
            direction.TurnRight();
        }

        public void MoveForward(Grid grid)
        {
            var (newX, newY) = direction.MoveForward(x, y);
            var obstacle = grid.GetObstacle(newX, newY);

            if (obstacle == null || obstacle.Handle(this))
            {
                x = newX;
                y = newY;
                path.Add((x, y));
            }
        }

        public void ProcessCommand(char command, Grid grid)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'F':
                    MoveForward(grid);
                    break;
            }
        }
    }

}
