using MovieAPI.Models;

namespace MovieAPI.Entities
{
    public class Address : BaseEntity
    {
        public string Road { get; set; }
        public string District { get; set; }
        public int Number { get; set; }
    }
}
