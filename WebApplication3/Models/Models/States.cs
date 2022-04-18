using System.ComponentModel.DataAnnotations;

namespace CrudEntity.Models
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string State { get; set; }
    }
}
