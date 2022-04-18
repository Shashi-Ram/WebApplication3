using System.ComponentModel.DataAnnotations;

namespace CrudEntity.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string City { get; set; }
        public int State_Id { get; set; }
    }
}
