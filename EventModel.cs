//Models/EventModel.cs

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set;}
        public string Name { get; set;} = string.Empty; // Default empty string
        public DateTime Date { get; set;} 
        public string Location { get; set;} = string.Empty; // Default empty string
        public string Description {get; set;} = string.Empty; // Default empty string
        // add other relevant properties later (eg, organizer, attendees, etc.)

    }
}   