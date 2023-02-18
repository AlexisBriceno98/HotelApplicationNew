using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Guests
{
    public class ReadGuest
    {
        private readonly ApplicationDbContext _dbContext;

        public ReadGuest(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void GuestRead()
        {
            Console.WriteLine("All Guests:");
            foreach (Guest guest in _dbContext.Guests)
            {
                Console.WriteLine($"Guest ID: {guest.GuestId}, Full Name: {guest.Name}, Age: {guest.Age}");
            }
        }
    }
}
