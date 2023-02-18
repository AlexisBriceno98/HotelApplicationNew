using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Rooms
{
    public class DeleteRoom
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteRoom(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void RoomDelete()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Availble ID's: ");
                Console.WriteLine("================");
                var readRoom = new ReadRoom(_dbContext);
                readRoom.ReadRooms();
                Console.WriteLine("Enter the ID of the room you want to delete: ");
                var id = Console.ReadLine();
                Room roomToDelete = _dbContext.Rooms.Find(id);
                if (roomToDelete == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Room not found.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Any Key to continue...");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                _dbContext.Rooms.Remove(roomToDelete);
                _dbContext.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Room deleted successfully.");
                Console.WriteLine("Press Any Key to continue...");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
