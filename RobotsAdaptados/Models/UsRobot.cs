using USRobots;

namespace RobotsAdaptados.Models
{
    public class UsRobot : Robot
    {
        private bool PrimeraLeyActivada = true;

        public override double VelocidadActualEnMillasPorHora { get; set; }

        public override void DesactivarPrimeraLeyDeRobotica()
        {
            PrimeraLeyActivada = false;
            Console.WriteLine("La primera ley fue desactivada");
        }

        public override void Saltar(double pies)
        {
            Console.WriteLine($"El robot ha saltado {pies} pies!");
        }
    }
}
