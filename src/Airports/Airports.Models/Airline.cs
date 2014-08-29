namespace Airports.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Airlines")]
    public class Airline
    {
        private ICollection<Flight> flights;

        public Airline()
        {
            this.Flights = new HashSet<Flight>();
        }

        [Key]
        public int AirlineId { get; set; }

        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Flight> Flights
        {
            get { return this.flights; }
            set { this.flights = value; }
        }
    }
}