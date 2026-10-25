using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RaceDayEventManagementSystem.API.Models
{
    public class CategoryModel
    {
        [Key]
        public Guid categoryID { get; set; }
        public string? categoryName { get; set; } = null;

        [Precision(5,2)]
        public decimal? categoryDistance { get; set; } = null;
        
        public int categoryEntryFee { get; set; } = 0;

        public int categoryMaxParticipants { get; set; } = 0;
    }
}
