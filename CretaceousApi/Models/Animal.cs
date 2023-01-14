using System.ComponentModel.DataAnnotations;
//^^^^^---with API controller that are marked with the [ApiController] we do not need to update our controllers to check ModelState when using [Required]---^^^^^

namespace CretaceousApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    [Range(0, 200, ErrorMessage ="Age must be between 0 and 200.")]
    public int Age { get; set; }
  }
}
