using System.ComponentModel.DataAnnotations;
namespace CrudEntity.Models.ViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please First Name")]
        public string FirstName { get; set; }
        //[Required]
        //[StringLength(10)]
        //[RegularExpression("(0|91)?[7-9][0-9]{9}", ErrorMessage = "Invalid Mobile Number.")]
        public int MobileNumber { get; set; }

        //[Required(ErrorMessage = "Please Select State")]
        public string State { get; set; }

        //[Required(ErrorMessage = "Please Select City")]
        public string City { get; set; }
        public string Gender { get; set; }
        //public string csharp { get; set; }

        //public string android { get; set; }
        //public string python { get; set; }
        //public string java { get; set; }


    }
}
