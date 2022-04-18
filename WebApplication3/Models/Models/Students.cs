using System.ComponentModel.DataAnnotations;
namespace CrudEntity.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

     //   [Required(ErrorMessage = "Please Enter Mobile Number")]
        public int MobileNumber { get; set; }

    //    [Required(ErrorMessage = "Please Select State")]
        public int StateId { get; set; }

      //  [Required(ErrorMessage = "Please Select City")]
        public int CityId { get; set; }
        //public int GenderId { get; set; }
        //public int TechnologyId { get; set; }

        public bool Csharp { get; set; }
        public bool Android { get; set; }
        public bool Python { get; set; }
        public bool Java { get; set; }
        public int Gender_Id { get; set; }





    }
}
