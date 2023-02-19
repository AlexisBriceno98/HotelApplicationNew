using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Rooms
{
    public class CreateRoom
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateRoom(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void RoomCreation()
        {
            Console.Clear();
            Console.WriteLine("Please enter the ID of the new room:");
            var roomNumber = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Room type: ");
            Console.WriteLine("1: Twin 24 square meter");
            Console.WriteLine("2: Triple 32 square meter");
            var type = Console.ReadLine();
            var singleRoom = "Twin";
            var doubleRoom = "Triple";
            type = type == "1" ? singleRoom : type == "2" ? doubleRoom : null;

            if (type == null)
            {
                Console.WriteLine("Please use only the options (1) or (2)");
            }

            Console.Clear();
            Console.WriteLine("Room Description?");
            Console.WriteLine("1: Single Room");
            Console.WriteLine("2: Double Room");
            var description = Console.ReadLine();
            string s = "1: Singel Room";
            string b = "2: Double Room";
            description = description == "1" ? s : description == "2" ? b : null;
            if (type == null)
            {
                Console.WriteLine("Please use only the options (1) or (2)");
            }

            Console.Clear();
            Console.WriteLine("Do you wish an extra bed?");
            Console.WriteLine("1: YES");
            Console.WriteLine("2: NO");
            var extraBed = Console.ReadLine();
            var y = "yes";
            var n = "no";
            extraBed = extraBed == "1" ? y : extraBed == "2" ? n : null;
            if (type == null)
            {
                Console.WriteLine("Please use only the options (1) or (2)");
            }

            Console.Clear();
            _dbContext.Rooms.Add(new Room
            {
                RoomId = roomNumber,
                Description = description,
                Type = type,
                ExtraBed = extraBed
            });
            _dbContext.SaveChanges();

            foreach (var room in _dbContext.Rooms)
            {
                Console.WriteLine($"Id: {room.RoomId}");
                Console.WriteLine($"Description: {room.Description}");
                Console.WriteLine($"Type: {room.Type}");
                Console.WriteLine($"Extra bed: {room.ExtraBed}");
                Console.WriteLine("====================");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Room created succesfully!");
            Console.WriteLine("Press any key to continue");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
