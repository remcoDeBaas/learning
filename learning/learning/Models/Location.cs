using System.ComponentModel.DataAnnotations;

namespace learning.Models

{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string locationName { get; set; }
    }
}