using System.ComponentModel.DataAnnotations;

namespace Myboutique.Models
{
    public class Myboutiques
    {

        public int id { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string description { get; set; }
        public int cost { get; set; }

        // public Myboutiques(int ids, string types, string descriptions, int costs)
        // {
        //     id = id;
        //     types = type;
        //     descriptions = description;
        //     costs = cost;

        // }

    }
}
