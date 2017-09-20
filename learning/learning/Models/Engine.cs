using System.ComponentModel.DataAnnotations;

namespace learning.Models
{
    public class Engine
    {
        [Key]
        public int EngineId { get; set; }

        public string engineType { get; set; }
    }
}