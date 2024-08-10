using System.ComponentModel.DataAnnotations;

namespace MusicCatalog.Models
{
    public class Music
    {
        public int Id { get; set; }

        [StringLength(100)]
        public required string Title { get; set; }

        [StringLength(100)]
        public required string Artist { get; set; }

        public required DateOnly ReleaseDate { get; set; }

        [StringLength(50)]
        public required string Genre { get; set; }
    }
}