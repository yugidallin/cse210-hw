using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Address instances
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701");
        Address address2 = new Address("456 Elm St", "Boston", "MA", "02110");
        Address address3 = new Address("789 Oak St", "Denver", "CO", "80203");

        // Creating Event instances
        Event lecture = new Lecture("Tech Talk", "An interesting lecture on technology.", new DateTime(2024, 7, 25), new DateTime(2024, 7, 25, 18, 0, 0), address1, "Dr. Smith", 100);
        Event reception = new Reception("Wedding Reception", "Join us for a beautiful wedding reception.", new DateTime(2024, 8, 15), new DateTime(2024, 8, 15, 17, 0, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic.", new DateTime(2024, 9, 10), new DateTime(2024, 9, 10, 11, 0, 0), address3, "Sunny");

        // Displaying Marketing Messages
        Console.WriteLine("Lecture Standard Details:\n" + lecture.GetStandardDetails());
        Console.WriteLine("\nLecture Full Details:\n" + lecture.GetFullDetails());
        Console.WriteLine("\nLecture Short Description:\n" + lecture.GetShortDescription());

        Console.WriteLine("\nReception Standard Details:\n" + reception.GetStandardDetails());
        Console.WriteLine("\nReception Full Details:\n" + reception.GetFullDetails());
        Console.WriteLine("\nReception Short Description:\n" + reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Standard Details:\n" + outdoorGathering.GetStandardDetails());
        Console.WriteLine("\nOutdoor Gathering Full Details:\n" + outdoorGathering.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering Short Description:\n" + outdoorGathering.GetShortDescription());
    }
}