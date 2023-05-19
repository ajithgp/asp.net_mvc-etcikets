using System.ComponentModel.DataAnnotations;

namespace etcikets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string CinemaName { get; set; }
        public string Description { get; set; }

        //relationship
        public List<Movie> MovieList { get; set; }
    }
}
