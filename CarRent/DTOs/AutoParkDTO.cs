using CarRent.Models;

namespace CarRent.DTOs
{
    public class AutoParkDTO
    {
        public int MaxCarCount { get; set; }
        public virtual Address Address { get; set; }

    }
}
