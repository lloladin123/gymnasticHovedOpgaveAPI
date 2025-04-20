using Microsoft.EntityFrameworkCore;
using gymnasticHovedOpgave.Models;
using gymnasticHovedOpgave.Interfaces;

namespace gymnasticHovedOpgave.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PlanningEvent> PlanningEvents { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding dummy data for PlanningEvent
            modelBuilder.Entity<PlanningEvent>().HasData(
                new PlanningEvent
                {
                    Id = 1,
                    CreatorId = 1,
                    Name = "Gymnastics Training",
                    TeamId = 1,
                    InstructorsId = new List<int> { 1, 2 },
                    CategoryId = 1,
                    Description = "Training session for all teams.",
                    Date = new DateTime(2022, 12, 1, 17, 30, 0), // Replace with valid ticks
                    VenueId = 1
                },
                new PlanningEvent
                {
                    Id = 2,
                    CreatorId = 2,
                    Name = "Annual Gymnastics Championship",
                    TeamId = 2,
                    InstructorsId = new List<int> { 3, 4 },
                    CategoryId = 2,
                    Description = "Annual competition for all teams.",
                    Date = new DateTime(2022, 12, 15, 14, 0, 0),// Replace with valid ticks
                    VenueId = 2
                }
            );
        }
    }
}
