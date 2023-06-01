using ETickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class Movie
    {
        [Key] 
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCatergory MovieCatergory { get; set; }
        public string ImageUrl { get; set; }

    }
}
