using System.ComponentModel.DataAnnotations;

namespace etcikets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //relationship
        public List<Movie> Movies { get; set; }
    }
}
