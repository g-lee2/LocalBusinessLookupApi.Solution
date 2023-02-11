using System.ComponentModel.DataAnnotations;

namespace BusinessApi.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
    public double Rating { get; set; }
    public string Review { get; set; }
  }
}