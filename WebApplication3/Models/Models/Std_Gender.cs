using System.ComponentModel.DataAnnotations;

namespace CrudEntity.Models
{
    public class Std_Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string Gender { get; set; }
    }
}
