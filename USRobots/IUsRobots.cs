namespace USRobots
{
    public interface IUsRobots
    {
        public double VelocidadActualEnMillasPorHora { get; set; }

        public void Saltar(double pies);
        public void DesactivarPrimeraLeyDeRobotica();
    }
}
