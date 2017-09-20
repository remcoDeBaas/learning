using System.ComponentModel.DataAnnotations;

namespace learning.Models
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }

        public string brandName { get; set; }
    }
}