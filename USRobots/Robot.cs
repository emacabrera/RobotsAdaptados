namespace USRobots
{
    public abstract class Robot : IUsRobots
    {
        public abstract double VelocidadActualEnMillasPorHora { get; set; }

        public abstract void DesactivarPrimeraLeyDeRobotica();

        public abstract void Saltar(double pies);
    }
}
