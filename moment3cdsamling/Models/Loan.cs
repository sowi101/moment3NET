using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace moment3cdsamling.Models
{
    public class Loan
    {

        public int Id { get; set; }

        [Required]
        public int AlbumId { get; set; }
        public Album? Album { get; set; }

        [Required]
        public int PersonId { get; set; }
        public Person? Person { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Datum för utlåning")]
        public DateTime? BorrowedDate { get; set; }
    }
}
