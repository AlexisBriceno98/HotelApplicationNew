using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Guests
{
    public class UpdateGuest
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateGuest(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void GuestUpdate()
        {
            while (true)
            {
                Console.Write("Enter the ID of the guest you want to update: ");
                var id = Console.ReadLine();
                Guest guestToUpdate = _dbContext.Guests.Find(id);
                if (guestToUpdate == null)
                {
                    Console.WriteLine("Guest not found.");
                    Console.WriteLine("Press Any Key to continue.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("New Full Name (leave blank to keep the existing value): ");
                var name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    guestToUpdate.Name = name;
                }

                Console.WriteLine("New Age (leave blank to keep the existing value): ");
                string age = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(age))
                {
                    int ageValue;
                    if (Int32.TryParse(age, out ageValue))
                    {
                        guestToUpdate.Age = ageValue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid age format.");
                        Console.ResetColor();
                        return;
                    }
                }

                _dbContext.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Guest updated successfully.");
                Console.WriteLine("Press Any Key to continue");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
