using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Data
{
    public class DataInitializer
    {

            public void MigrateAndSeed(ApplicationDbContext dbContext)
            {
                dbContext.Database.Migrate();
                SeedRooms(dbContext);
                SeedGuests(dbContext);
                dbContext.SaveChanges();
            }

            private void SeedRooms(ApplicationDbContext dbContext)
            {
                if (!dbContext.Rooms.Any(c => c.RoomId == "A"))
                {
                    dbContext.Rooms.Add(new Room
                    {
                        RoomId = "A",
                        Description = "Single Room",
                        Type = "Twin",
                        ExtraBed = "no"

                    });
                }
                if (!dbContext.Rooms.Any(c => c.RoomId == "B"))
                {
                    dbContext.Rooms.Add(new Room
                    {
                        RoomId = "B",
                        Description = "Single Room",
                        Type = "Twin",
                        ExtraBed = "no"

                    });
                }
                if (!dbContext.Rooms.Any(c => c.RoomId == "C"))
                {
                    dbContext.Rooms.Add(new Room
                    {
                        RoomId = "C",
                        Description = "Double Room",
                        Type = "Triple",
                        ExtraBed = "yes"

                    });
                }
                if (!dbContext.Rooms.Any(c => c.RoomId == "D"))
                {
                    dbContext.Rooms.Add(new Room
                    {
                        RoomId = "D",
                        Description = "Double Room",
                        Type = "Triple",
                        ExtraBed = "no"

                    });
                }

            }

            private void SeedGuests(ApplicationDbContext dbContext)
            {
                if (!dbContext.Guests.Any(c => c.GuestId == "AndersE"))
                {
                    dbContext.Guests.Add(new Guest
                    {
                        GuestId = "AndersE",
                        Name = "Anders Eriksson",
                        Age = 39,

                    });
                }
                if (!dbContext.Guests.Any(c => c.GuestId == "EdwardN"))
                {
                    dbContext.Guests.Add(new Guest
                    {
                        GuestId = "EdwardN",
                        Name = "Edward Norton",
                        Age = 25,

                    });
                }
                if (!dbContext.Guests.Any(c => c.GuestId == "JamesZ"))
                {
                    dbContext.Guests.Add(new Guest
                    {
                        GuestId = "JamesZ",
                        Name = "James Zuniga",
                        Age = 37,

                    });
                }
                if (!dbContext.Guests.Any(c => c.GuestId == "PeterB"))
                {
                    dbContext.Guests.Add(new Guest
                    {
                        GuestId = "PeterB",
                        Name = "Peter Berg",
                        Age = 46,

                    });
                }
            }
    }
}
