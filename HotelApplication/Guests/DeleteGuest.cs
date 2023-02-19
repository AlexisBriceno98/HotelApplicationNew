using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Guests
{
    public class DeleteGuest
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteGuest(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void GuestDelete()
        {
            Console.Clear();
            var guestRead = new ReadGuest(_dbContext);
            guestRead.GuestRead();
            Console.WriteLine("Enter the ID of the guest you want to delete: ");
            var id = Console.ReadLine();

            Guest guestToDelete = _dbContext.Guests.Find(id);
            if (guestToDelete == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Guest not found.");
                Console.ResetColor();
                return;
            }

            _dbContext.Guests.Remove(guestToDelete);
            _dbContext.SaveChanges();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Guest deleted successfully.");
            Console.WriteLine("Press Any Key to continue");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
