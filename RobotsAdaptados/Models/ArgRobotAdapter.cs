using USRobots;

namespace RobotsAdaptados.Models
{
    public class ArgRobotAdapter : Robot
    {
        private readonly ArgRobot _argRobot = new();

        public override double VelocidadActualEnMillasPorHora
        {
            get
            {
                return _argRobot.VelocidadActualEnKmPorHora;
            }
            set
            {
                _argRobot.VelocidadActualEnKmPorHora = (value * 1.60934);
            }
        }

        public override void DesactivarPrimeraLeyDeRobotica()
        {
            Console.WriteLine("No se puede desactivar la primera ley");
            return;
        }

        public override void Saltar(double pies)
        {
            ArgRobot.Saltar(pies * 0.3048);
        }
    }
}
