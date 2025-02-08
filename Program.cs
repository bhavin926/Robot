using RobotProgramming;
using System;
using System.Collections.Generic;

namespace RobotController
{
    class Program
    {
        static void Main()
        {
            var grid = new Grid(5, 5);

            grid.AddObstacle(1, 1, new Rock());
            grid.AddObstacle(3, 3, new Hole(0, 0)); 
            grid.AddObstacle(2, 2, new Spinner(90)); 

            var robot = new Robot(0, 0, "N");


            string commands = "LFFFRFFLFFFFRLFFFR";

            var processor = new CommandProcessor(robot, grid);

            var (finalX, finalY, path) = processor.ExecuteCommands(commands);


            Console.WriteLine($"Final Position: ({finalX}, {finalY})");
            Console.WriteLine("Traversal Path:");
            foreach (var location in path)
            {
                Console.WriteLine($"({location.Item1}, {location.Item2})");
            }
        }
    }
}
