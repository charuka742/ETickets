using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public string CinemaLogo { get; set; }
        public string Description { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
