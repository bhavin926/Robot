using RobotProgramming;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRobotMovement()
        {
            var grid = new Grid(5, 5);
            var robot = new Robot(0, 0, "N");
            var processor = new CommandProcessor(robot, grid);
            string commands = "FFFRFF";
            var (finalX, finalY, path) = processor.ExecuteCommands(commands);
            Assert.AreEqual((2, -3), (finalX, finalY));
        }
        [TestMethod]
        public void TestRobotWithObstacles()
        {
            var grid = new Grid(5, 5);
            grid.AddObstacle(1, 1, new Rock());
            grid.AddObstacle(3, 3, new Hole(0, 0));
            var robot = new Robot(0, 0, "N");
            var processor = new CommandProcessor(robot, grid);
            string commands = "FFFRFF";
            var (finalX, finalY, path) = processor.ExecuteCommands(commands);
            Assert.AreEqual((2, -3), (finalX, finalY)); 
        }
    }
}