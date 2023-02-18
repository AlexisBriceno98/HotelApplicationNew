using HotelApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }


        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=HotelCalifornia;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
    }
}
