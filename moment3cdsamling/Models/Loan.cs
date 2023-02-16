using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace moment3cdsamling.Models
{
    public class Loan
    {
        // Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett datum för lånet.")]
        [DataType(DataType.Date)]
        [Display(Name = "Datum för utlåning")]
        public DateTime? BorrowedDate { get; set; }

        // Relation to Album model
        [Required(ErrorMessage = "Du måste fylla i vilket album som lånas.")]
        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        public Album? Album { get; set; }

        // Relation to Person model        
        [Required(ErrorMessage = "Du måste fylla i vem som lånar albumet.")]
        [Display(Name = "Utlånad till")]
        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
