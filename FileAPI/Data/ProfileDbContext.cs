using FileAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileAPI.Data
{
    public class ProfileDbContext:DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<ProfileTeacher> Teachers { get; set; }
    }
}
