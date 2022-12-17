using System.ComponentModel.DataAnnotations.Schema;

namespace Devcamp.API.Models
{
  public class Module
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public String Name { get; set; }
  }
}