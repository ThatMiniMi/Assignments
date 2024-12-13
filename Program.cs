using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var concerts = new List<Concert>();

app.MapPost("/addconcert", async (HttpRequest request) =>
{
    var form = await request.ReadFormAsync();
    var concert = new Concert
    {
        Artist = form["Artist"],
        Location = form["Location"],
        Date = DateTime.TryParse(form["Date"], out var date) ? date : DateTime.Today,
        Tickets = int.TryParse(form["Tickets"], out var tickets) ? tickets : 0,
        Pricing = decimal.TryParse(form["Pricing"], out var pricing) ? pricing : 0
    };
    concerts.Add(concert);

    return Results.Ok(new
    {
        Message = $"Concert added successfully!",
        Concert = concert
    });
});
app.MapGet("/concerts", () => Results.Ok(concerts));

app.Run();

record Concert
{
    public string Artist { get; init; }
    public string Location { get; init; }
    public DateTime Date { get; init; }
    public int Tickets { get; init; }
    public decimal Pricing { get; init; }
}
