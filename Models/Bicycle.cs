using System.ComponentModel.DataAnnotations;

namespace BikeRent_Back_End.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        [Required]
        public string BicycleName { get; set; }
        [Required]
        public string BikeType { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
