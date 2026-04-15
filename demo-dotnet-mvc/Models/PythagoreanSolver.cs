namespace demo_dotnet_mvc.Models
{
    public class PythagoreanSolver
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public double CalculateHypotenuse()
        {
            return Math.Sqrt(SideA * SideA + SideB * SideB);
        }
    }
}
