using System.ComponentModel.DataAnnotations;

namespace demo_dotnet_mvc.Models
{
    public class PythagoreanSolver
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Side A must be a positive integer.")]
        public int? SideA { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Side B must be a positive integer.")]
        public int? SideB { get; set; }

        public double CalculateHypotenuse()
        {
            return System.Math.Sqrt(System.Convert.ToDouble((SideA * SideA) + (SideB * SideB)));
        }
    }
}
