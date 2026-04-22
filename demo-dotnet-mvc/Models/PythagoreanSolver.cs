using System.ComponentModel.DataAnnotations;

namespace demo_dotnet_mvc.Models
{
    public class PythagoreanSolver
    {
        [Required] //this line indicates that the SideA property is required and cannot be null. It ensures that when an instance of PythagoreanSolver is created, a value must be provided for SideA. If this validation fails, an error message will be generated.
        [Range(1, int.MaxValue, ErrorMessage = "Side A must be a positive integer.")] //this line ensures that the value of SideA must be a positive integer. The Range attribute specifies that the valid range for SideA is from 1 to the maximum value of an integer (int.MaxValue). If the value provided for SideA is outside this range, an error message will be generated indicating that "Side A must be a positive integer."
        public int? SideA { get; set; }
        [Required] //this line indicates that the SideB property is required and cannot be null. It ensures that when an instance of PythagoreanSolver is created, a value must be provided for SideB. If this validation fails, an error message will be generated.
        [Range(1, int.MaxValue, ErrorMessage = "Side B must be a positive integer.")] //this line ensures that the value of SideB must be a positive integer. The Range attribute specifies that the valid range for SideB is from 1 to the maximum value of an integer (int.MaxValue). If the value provided for SideB is outside this range, an error message will be generated indicating that "Side B must be a positive integer."
        public int? SideB { get; set; }

        public double CalculateHypotenuse()
        {
            return System.Math.Sqrt(System.Convert.ToDouble((SideA * SideA) + (SideB * SideB)));
        }
    }
}
