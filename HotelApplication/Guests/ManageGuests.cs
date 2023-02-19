using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Guests
{
    public class ManageGuests
    {
        private readonly ApplicationDbContext _dbContext;

        public ManageGuests(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void GuestsManager()
        {
            while (true)
            {
                Console.WriteLine("Manage Guests");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a new Guest");
                Console.WriteLine("2. Read Guests");
                Console.WriteLine("3. Update a Guest");
                Console.WriteLine("4. Delete a Guest");
                Console.WriteLine("5. Back to Main Menu");

                var input = Console.ReadLine();
                var option = 0;
                Int32.TryParse(input, out option);

                switch (option)
                {
                    case 1:
                        var guestCreate = new CreateGuest(_dbContext);
                        guestCreate.GuestCreate();
                        break;
                    case 2:
                        var guestRead = new ReadGuest(_dbContext);
                        guestRead.GuestRead();
                        break;
                    case 3:
                        var guestUpdate = new UpdateGuest(_dbContext);
                        guestUpdate.GuestUpdate();
                        break;
                    case 4:
                        var deleteGuest = new DeleteGuest(_dbContext);
                        deleteGuest.GuestDelete();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
