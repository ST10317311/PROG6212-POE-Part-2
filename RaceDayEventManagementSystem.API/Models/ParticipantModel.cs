namespace RaceDayEventManagementSystem.API.Models
{
    public class ParticipantModel
    {
        public Guid participantID { get; set; }

        public required string participantName { get; set; }

        public required string participantSurname { get; set; }

        public required string participantBirthDate { get; set; } //Was previosuly called "participantAge" in the database schema (database script in part 1)
                                                                  //, but now it is participantBirthDate. This is due to the fact that  birth date can be used
                                                                  // to calculate the age of the participant, and it is more accurate than storing the age directly.

        public required string participantGender { get; set; }

        public required string participantCountryOfBirth { get; set; }

        public required string participantPhoneNumber { get; set; }

        public required string participantEmail { get; set; }

        public required string participantPassword { get; set; }
    }
}
