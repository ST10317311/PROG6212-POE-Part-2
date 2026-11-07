using RaceDayEventManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace RaceDayEventManagementSystem.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> CategoryModel { get; set; }

        public DbSet<EntryModel> EntryModel { get; set; }

        public DbSet<EventModel> EventModel { get; set; }

        public DbSet<EventTypeModel> EventTypeModel { get; set; }

        public DbSet<OrganiserModel> OrganiserModel { get; set; }

        public DbSet<ParticipantModel> ParticipantsModel { get; set; }

        public DbSet<ResultsModel> ResultsModel { get; set; }
    }
}
