using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Rooms
{
    public class ManageRooms
    {
        private readonly ApplicationDbContext _dbContext;

        public ManageRooms(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RoomsManager()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Manage Rooms");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a new Room");
                Console.WriteLine("2. Read Rooms");
                Console.WriteLine("3. Update a Room");
                Console.WriteLine("4. Delete a Room");
                Console.WriteLine("5. Back to Main Menu");

                var input = Console.ReadLine();
                var option = 0;
                Int32.TryParse(input, out option);

                switch (option)
                {
                    case 1:
                        var createroom = new CreateRoom(_dbContext);
                        createroom.RoomCreation();
                        Console.Clear();
                        break;
                    case 2:
                        var readRoom = new ReadRoom(_dbContext);
                        readRoom.ReadRooms();
                        break;
                    case 3:
                        var roomupdate = new UpdateRoom(_dbContext);
                        roomupdate.RoomUpdate();
                        Console.Clear();
                        break;
                    case 4:
                        var roomDelete = new DeleteRoom(_dbContext);
                        roomDelete.RoomDelete();
                        break;
                    case 5:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
