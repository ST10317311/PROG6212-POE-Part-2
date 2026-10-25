using System.ComponentModel.DataAnnotations;

namespace RaceDayEventManagementSystem.API.Models
{
    public class OrganiserModel
    {
        [Key]
        public Guid organiserID { get; set; }

        public required string organiserName { get; set; } = null;

        public required string? organiserSurname { get; set; } = null;

        public string? organiserAge { get; set; } = null;

        public string? organiserEmail { get; set; } = null;
        public string? organiserPhoneNumber { get; set; } = null;
    }
}
