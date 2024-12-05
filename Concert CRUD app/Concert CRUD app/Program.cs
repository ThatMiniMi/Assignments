using System;

class Program
{
    static void Main(string[] args)
    {
        ConcertManager manager = new ConcertManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nConcert Management System");
            Console.WriteLine("1. Add Concert");
            Console.WriteLine("2. List All Concerts");
            Console.WriteLine("3. Edit Concert");
            Console.WriteLine("4. Delete Concert");
            Console.WriteLine("5. Purchase Tickets");
            Console.WriteLine("6. View Revenue");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Performer: ");
                    string performer = Console.ReadLine();

                    Console.Write("Enter Venue: ");
                    string venue = Console.ReadLine();

                    Console.Write("Enter Date (yyyy-MM-dd HH:mm): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter Capacity: ");
                    int capacity = int.Parse(Console.ReadLine());

                    Console.Write("Enter Number of Tickets: ");
                    int ticketCount = int.Parse(Console.ReadLine());

                    Console.Write("Enter Ticket Price: ");
                    decimal ticketPrice = decimal.Parse(Console.ReadLine());

                    manager.AddConcert(performer, venue, date, capacity, ticketCount, ticketPrice);
                    Console.WriteLine("Concert added successfully.");
                    break;

                case "2":
                    manager.ListConcerts();
                    break;

                case "3":
                    Console.Write("Enter Concert ID to edit: ");
                    int editId = int.Parse(Console.ReadLine());

                    Console.Write("Enter New Performer: ");
                    string newPerformer = Console.ReadLine();

                    Console.Write("Enter New Venue: ");
                    string newVenue = Console.ReadLine();

                    Console.Write("Enter New Date (yyyy-MM-dd HH:mm): ");
                    DateTime newDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter New Capacity: ");
                    int newCapacity = int.Parse(Console.ReadLine());

                    manager.EditConcert(editId, newPerformer, newVenue, newDate, newCapacity);
                    break;

                case "4":
                    Console.Write("Enter Concert ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    manager.DeleteConcert(deleteId);
                    break;

                case "5":
                    Console.Write("Enter Concert ID to purchase tickets for: ");
                    int purchaseId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Number of Tickets: ");
                    int quantity = int.Parse(Console.ReadLine());

                    manager.PurchaseTickets(purchaseId, quantity);
                    break;

                case "6":
                    manager.ListRevenue();
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}