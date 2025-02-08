using RobotProgramming;
using System;
using System.Collections.Generic;

namespace RobotController
{
    class Program
    {
        static void Main()
        {
            // Create a 5x5 grid
            var grid = new Grid(5, 5);

            // Add obstacles: Rock, Hole, Spinner
            grid.AddObstacle(1, 1, new Rock());
            grid.AddObstacle(3, 3, new Hole(0, 0)); // Hole connected to (0, 0)
            grid.AddObstacle(2, 2, new Spinner(90)); // Spinner with 90 degree rotation

            // Create a robot at (0, 0), facing North
            var robot = new Robot(0, 0, "N");

            // Define the movement commands
            string commands = "LFFFRFFLFFFFRLFFFR";

            // Create the command processor
            var processor = new CommandProcessor(robot, grid);

            // Execute the commands
            var (finalX, finalY, path) = processor.ExecuteCommands(commands);

            // Print the result
            Console.WriteLine($"Final Position: ({finalX}, {finalY})");
            Console.WriteLine("Traversal Path:");
            foreach (var location in path)
            {
                Console.WriteLine($"({location.Item1}, {location.Item2})");
            }
        }
    }
}
