namespace demo_dotnet_mvc.Models
{
    public class TriangleAreaSolver
    {
        public int Height { get; set; }
        public int Base { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

    }
}
