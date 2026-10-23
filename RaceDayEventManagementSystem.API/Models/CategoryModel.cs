namespace RaceDayEventManagementSystem.API.Models
{
    public class CategoryModel
    {
        public Guid categoryID { get; set; }
        public string? categoryName { get; set; } = null;
        public Decimal? categoryDistance { get; set; } = null;
        
        public int categoryEntryFee { get; set; } = 0;

        public int categoryMaxParticipants { get; set; } = 0;
    }
}
