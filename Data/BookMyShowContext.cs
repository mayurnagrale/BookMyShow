using BookMyShow.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data
{
    public class BookMyShowContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sql server with connection string from app settings
        //    options.UseSqlServer(Configuration.GetConnectionString("EmployeeConnectionString"));
        //}

        public DbSet<Auditorium>? auditoriams { get; set; }
        public DbSet<City>? citys { get; set; }
        public DbSet<Payment>? payments { get; set; }
        public DbSet<Seat>? seats { get; set; }
        public DbSet<SeatInShow>? seatinshows { get; set; }
        public DbSet<SeatTypeInShow>? seattypeinshows { get; set; }
        public DbSet<Show1>? show1s { get; set; }
        public DbSet<Theatre>? theatres { get; set; }
        public DbSet<Ticket>? tickets { get; set; }
        public DbSet<User>? users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auditorium>().ToTable("Auditorium").HasOne(a => a.show)
            .WithOne(s => s.auditorium)
            .HasForeignKey<Show1>(s =>s.id) // Set the foreign key property in Show1 to establish the relationship.
            .IsRequired(false);
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<Seat>().ToTable("Seat");
            modelBuilder.Entity<SeatInShow>().ToTable("SeatInShow");
            modelBuilder.Entity<SeatTypeInShow>().ToTable("SeatTypeInShow");
            modelBuilder.Entity<Show1>().ToTable("Show1");
            modelBuilder.Entity<Theatre>().ToTable("Theatre");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<User>().ToTable("User");

        }

    }
}
