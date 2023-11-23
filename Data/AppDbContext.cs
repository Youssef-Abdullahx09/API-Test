using Application.Data.Configurations;
using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Therapist> Therapists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            //modelBuilder.Entity<Client>().HasData(
            //    new Client
            //    {
            //        Id = 1,
            //        ReferanceNumber = 1234567890,
            //    });

            //modelBuilder.Entity<Therapist>().HasData(
            //     new Therapist
            //     {
            //         Id = 1,
            //         Name = "Tester"
            //     });

            //modelBuilder.Entity<Session>().HasData(
            //    new Session
            //    {
            //        Id = 1,
            //        ClientId = 1,
            //        SessionDate = DateTime.UtcNow,
            //        TherapistId = 1,
            //    });
        }
    }
}
