using System.ComponentModel.DataAnnotations;

namespace moment3cdsamling.Models
{
    public class Person
    {
        //Properties

        public int PersonId { get; set; }

        [Display(Name = "Namn")]
        public string? Name { get; set; }

        [Display(Name = "Telefonnummer")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "E-post")]
        public string? Email { get; set; }


        public List<Loan>? Loans { get; set; }
    }
}
