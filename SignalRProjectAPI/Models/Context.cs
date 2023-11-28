using Microsoft.EntityFrameworkCore;

namespace SignalRProjectAPI.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MM84V2T\\SQLEXPRESS;initial catalog=DbSignalR;integrated security=true");
        }
        DbSet<User> Users { get; set; }
        DbSet<Room> Rooms { get; set; }
    }
}
