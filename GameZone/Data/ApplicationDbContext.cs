using GameZone.Models;
using Microsoft.EntityFrameworkCore;

namespace GameZone.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<GameDevice> GameDevices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                [
                    new() {Id = 1, Name = "Sports"},
                    new() {Id = 2, Name = "Action"},
                    new() {Id = 3, Name = "Adventure"},
                    new() {Id = 4, Name = "Racing"},
                    new() {Id = 5, Name = "Fighting"},
                    new() {Id = 6, Name = "Film"}
                ]);

            modelBuilder.Entity<Device>()
                .HasData(
                [
                    new() { Id = 1, Name = "PlayStation", Icon = "bi bi-playstation" },
                    new() { Id = 2, Name = "xbox", Icon = "bi bi-xbox" },
                    new() { Id = 3, Name = "Nintendo Switch", Icon = "bi bi-nintendo-switch" },
                    new() { Id = 4, Name = "PC", Icon = "bi bi-pc-display" }
                ]);

            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.GameId, e.DeviceId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
