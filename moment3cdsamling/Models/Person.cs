using System.ComponentModel.DataAnnotations;

namespace moment3cdsamling.Models
{
    public class Person
    {
        //Properties
        public int PersonId { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett namn för kontakten.")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett telefonnummer till kontakten.")]
        [Display(Name = "Telefonnummer")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Du måste fylla i en e-postadress till kontakten.")]
        [Display(Name = "E-post")]
        public string? Email { get; set; }

            // Relation to Loan model
        public List<Loan>? Loans { get; set; }
    }
}
