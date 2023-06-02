using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
