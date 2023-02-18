using HotelApplication.Guests;
using HotelApplication.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Application
    {

        public void Run()
        {
            var ProjectBuilder = new Builder();
            var dbContext = ProjectBuilder.BuildApp();

            while (true)
            {
                Console.WriteLine("Welcome to the Hotel California.");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Manage Rooms");
                Console.WriteLine("2. Manage Guests");
                Console.WriteLine("3. Exit");

                var input = Console.ReadLine();
                var option = 0;
                Int32.TryParse(input, out option);

                switch (option)
                {
                    case 1:
                        var manageRooms = new ManageRooms(dbContext);
                        manageRooms.RoomsManager();
                        break;
                    case 2:
                        var manageGuests = new ManageGuests(dbContext);
                        manageGuests.GuestsManager();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for visiting the Hotel California...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}

