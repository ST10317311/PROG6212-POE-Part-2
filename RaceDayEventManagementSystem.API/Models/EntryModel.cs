namespace RaceDayEventManagementSystem.API.Models
{
    public class EntryModel
    {
        public Guid entryID { get; set; }

        public Guid participantID { get; set; }

        public Guid eventID { get; set; }

        public string? entryDate { get; set; } = null;

    }
}
