using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string Name { get; set; }    
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
