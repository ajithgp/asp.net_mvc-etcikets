using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace etcikets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        
        //relationship
        public List<Actor_Movies> Movies { get; set; }

    }
}
