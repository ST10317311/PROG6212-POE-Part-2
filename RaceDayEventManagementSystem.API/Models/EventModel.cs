using System.ComponentModel.DataAnnotations;

namespace RaceDayEventManagementSystem.API.Models
{
    public class EventModel
    {
        [Key]
        public Guid eventID { get; set; }

        public string? eventName { get; set; } = null;

        public Guid? eventTypeID { get; set; } = null;

        public string? eventLocation { get; set; } = null;

        public TimeOnly? eventStartTime { get; set; } = null;

        public TimeOnly? eventEndTime { get; set; } = null;

        public Guid? organiserID { get; set;} = null;
        }
}
