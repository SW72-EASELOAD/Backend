using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Models
{
    public class BookingHistory
    {
        // Unique identifier for the booking
        public int Id { get; set; }

        // Identifier for the company associated with the booking
        public int IdCompany { get; set; }

        // Identifier for the client who made the booking
        public int IdClient { get; set; }

        // Date when the booking was made
        public string BookingDate { get; set; }

        // Weight of the items to be moved
        public int Weight { get; set; }

        // Address where the items will be picked up
        public string PickupAddress { get; set; }

        // Address where the items will be delivered
        public string DestinationAddress { get; set; }

        // Date when the items will be moved
        public string MovingDate { get; set; }

        // Time when the items will be moved
        public string MovingTime { get; set; }

        // Services requested for the booking
        public string Services { get; set; }

        // Current status of the booking
        public string Status { get; set; }

        // Payment amount for the booking
        public int Payment { get; set; }

        // Chats associated with the booking
        public IEnumerable<Chat> Chats { get; set; } = new List<Chat>();

        // Workers assigned to the booking (Not mapped to the database)
        [NotMapped]
        public List<int> Workers { get; set; } = new List<int>();
    }
}