using RobotsAdaptados.Models;

UsRobot usRobot = new();
usRobot.DesactivarPrimeraLeyDeRobotica();
usRobot.Saltar(32.84);

Console.WriteLine();

ArgRobotAdapter argRobotAdapter = new();
argRobotAdapter.DesactivarPrimeraLeyDeRobotica();
argRobotAdapter.Saltar(32.84);

Console.ReadLine();