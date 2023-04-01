using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationshipps

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
