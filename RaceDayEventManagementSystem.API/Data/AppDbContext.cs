using RaceDayEventManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace RaceDayEventManagementSystem.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }

        public DbSet<EntryModel> Entries { get; set; }

        public DbSet<EventModel> Events { get; set; }

        public DbSet<EventTypeModel> EventTypes { get; set; }

        public DbSet<OrganiserModel> Organisers { get; set; }

        public DbSet<ParticipantModel> Participants { get; set; }

        public DbSet<ResultsModel> Results { get; set; }
    }
}
