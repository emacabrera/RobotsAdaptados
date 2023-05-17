namespace RobotsAdaptados.Models
{   
    public class ArgRobot
    {
        public double VelocidadActualEnKmPorHora { get; set; }

        public static void Saltar(double metros)
        {
            if (metros > 0)
            {
                metros = Math.Round(metros, 2);
                Console.WriteLine($"El robot ha saltado {metros} metros!");
            }
        }
    }
}
