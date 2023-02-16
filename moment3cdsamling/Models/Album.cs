using Microsoft.Extensions.Hosting;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace moment3cdsamling.Models
{
    public class Album
    {
        // Properties
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett namn på albumet.")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett lanseringår för albumet.")]
        [Display(Name = "Release")]
        public int? Release { get; set; }


            // Relation to Artist model
        [Required(ErrorMessage = "Du måste fylla i artist/grupp för albumet.")]
        [Display(Name = "Artist/grupp")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }

            // Relation to Loan model
        public List<Loan>? Loans { get; set; }
    }
}



