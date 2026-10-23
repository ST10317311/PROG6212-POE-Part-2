namespace RaceDayEventManagementSystem.API.Models
{
    public class EventTypeModel
    {
        public Guid eventTypeID { get; set; }
        public string? eventTypeName { get; set; } = null;
        public string? eventTypeDescription { get; set; } = null;
        // This is an additional property to hold the count of events associated with this event type OR to hold the general description/infromation of each event.
    }
}
