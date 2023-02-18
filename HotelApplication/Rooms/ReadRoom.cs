using HotelApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Rooms
{
    public class ReadRoom
    {
        private readonly ApplicationDbContext _dbContext;

        public ReadRoom(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ReadRooms()
        {

            foreach (Room room in _dbContext.Rooms)
            {
                Console.WriteLine($"Room ID: {room.RoomId}, Type: {room.Type}, Description: {room.Description}, Extra bed: {room.ExtraBed}");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Any Key to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
