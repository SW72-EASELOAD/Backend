using System.ComponentModel.DataAnnotations.Schema;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Models;


public class BookingHistory
{

    public int Id { get; set; }


    public int IdCompany { get; set;}


    public int IdClient { get; set;}

    public string BookingDate { get; set;}


    public int Weight { get; set; }
    

    public string PickupAddress { get; set;}


    public string DestinationAddress { get; set;}


    public string MovingDate {get; set;}

    public string MovingTime {get; set;}


    public string Services { get; set;}
    

    public string Status { get; set;}


    public int Payment { get; set; }


    public IEnumerable<Chat> Chats { get; set; } = new List<Chat>();
 

    [NotMapped]
    public List<int> Workers { get; set; } = new List<int>();

}