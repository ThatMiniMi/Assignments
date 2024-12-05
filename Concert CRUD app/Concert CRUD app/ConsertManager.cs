public class ConcertManager
{
    private List<Concert> concerts = new List<Concert>();
    private int nextId = 1;

    public void AddConcert(string performer, string venue, DateTime date, int capacity, int ticketCount, decimal ticketPrice)
    {
        concerts.Add(new Concert
        {
            Id = nextId++,
            Performer = performer,
            Venue = venue,
            Date = date,
            Capacity = capacity,
            TicketCount = ticketCount,
            TicketPrice = ticketPrice
        });
    }

    public void PurchaseTickets(int id, int quantity)
    {
        var concert = concerts.FirstOrDefault(c => c.Id == id);
        if (concert != null)
        {
            concert.PurchaseTickets(quantity);
        }
        else
        {
            Console.WriteLine("Concert not found.");
        }
    }

    public void ListRevenue()
    {
        foreach (var concert in concerts)
        {
            Console.WriteLine($"Concert ID: {concert.Id}, Performer: {concert.Performer}, Revenue: {concert.CalculateRevenue():C}");
        }
    }
public void ListConcerts()
    {
        if (concerts.Count == 0)
        {
            Console.WriteLine("No concerts available.");
            return;
        }

        foreach (var concert in concerts)
        {
            Console.WriteLine(concert);
        }
    }

    public void EditConcert(int id, string newPerformer, string newVenue, DateTime newDate, int newCapacity)
    {
        var concert = concerts.FirstOrDefault(c => c.Id == id);
        if (concert != null)
        {
            concert.Performer = newPerformer;
            concert.Venue = newVenue;
            concert.Date = newDate;
            concert.Capacity = newCapacity;
            Console.WriteLine("Concert updated successfully.");
        }
        else
        {
            Console.WriteLine("Concert not found.");
        }
    }

    public void DeleteConcert(int id)
    {
        var concert = concerts.FirstOrDefault(c => c.Id == id);
        if (concert != null)
        {
            concerts.Remove(concert);
            Console.WriteLine("Concert deleted successfully.");
        }
        else
        {
            Console.WriteLine("Concert not found.");
        }
    }
}