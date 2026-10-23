namespace RaceDayEventManagementSystem.API.Models
{
    public class ResultsModel
    {
        public Guid resultID { get; set; }

        public Guid entryID { get; set; }

        public TimeOnly? startTime { get; set; } = null;

        public TimeOnly? endTime { get; set; } = null;

        public int? position { get; set; } = null;

        public decimal? resultAverageSpeed { get; set; } = null;

        public string? resultStatus { get; set; } = null;
    }
}
