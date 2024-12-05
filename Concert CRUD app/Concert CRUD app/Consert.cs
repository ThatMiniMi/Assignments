public class Concert
{
    public int Id { get; set; }
    public string Performer { get; set; }
    public string Venue { get; set; }
    public DateTime Date { get; set; }
    public int Capacity { get; set; }
    public int TicketCount { get; set; }
    public int TicketsPurchased { get; private set; }
    public decimal TicketPrice { get; set; }

    public void PurchaseTickets(int quantity)
    {
        if (TicketsPurchased + quantity > TicketCount)
        {
            Console.WriteLine($"Not enough tickets available. Only {TicketCount - TicketsPurchased} left.");
        }
        else
        {
            TicketsPurchased += quantity;
            Console.WriteLine($"{quantity} ticket(s) purchased successfully!");
        }
    }

    public decimal CalculateRevenue()
    {
        return TicketsPurchased * TicketPrice;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Performer: {Performer}, Venue: {Venue}, Date: {Date:yyyy-MM-dd HH:mm}, Capacity: {Capacity}, Tickets Available: {TicketCount - TicketsPurchased}, Ticket Price: {TicketPrice:C}";
    }
}