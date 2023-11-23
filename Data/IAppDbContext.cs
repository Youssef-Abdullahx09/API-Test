using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public interface IAppDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Rating> Ratings { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<Therapist> Therapists { get; set; }
    }
}