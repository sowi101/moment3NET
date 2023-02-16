using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace moment3cdsamling.Models
{
    public class Artist
    {
        // Properties
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Du måste fylla i ett namn på artisten/gruppen.")]
        [Display(Name = "Namn på artist/grupp")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Du måste fylla i information om artisten/gruppen.")]
        [Display(Name = "Information om artisten/gruppen")]
        public string? Information { get; set; }

            // Relation to Album model
        public List<Album>? Albums { get; set; }
    }
}
