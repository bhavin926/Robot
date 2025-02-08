using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProgramming
{
    public class Grid
    {
        private Obstacle[,] grid;

        public int Width { get; }
        public int Height { get; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            grid = new Obstacle[height, width];
        }

        public void AddObstacle(int x, int y, Obstacle obstacle)
        {
            if (IsValidPosition(x, y))
            {
                grid[y, x] = obstacle;
            }
        }

        public Obstacle GetObstacle(int x, int y)
        {
            return IsValidPosition(x, y) ? grid[y, x] : null;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
