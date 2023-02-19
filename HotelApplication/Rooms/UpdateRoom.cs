using HotelApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication.Rooms
{
    public class UpdateRoom
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateRoom(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void RoomUpdate()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Availble ID's: ");
                Console.WriteLine("================");
                var readRooms = new ReadRoom(_dbContext);
                readRooms.ReadRooms();
                Console.WriteLine("Please Enter the ID of the room you want to update: ");
                var id = Console.ReadLine();
                Room roomToUpdate = _dbContext.Rooms.Find(id);
                if (roomToUpdate == null)
                {
                    Console.WriteLine("Room not found.");
                    Console.WriteLine("Press Any Key to try again.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();
                Console.WriteLine("UPDATE TYPE");
                Console.WriteLine("Please choose a new room type between: (1)Twin or (2)Triple");
                Console.WriteLine("New Type (leave blank to keep the existing value): ");
                var typeString = Console.ReadLine();
                var twin = "Twin";
                var triple = "Triple";
                typeString = typeString == "1" ? twin : typeString == "2" ? triple : null;
                if (!string.IsNullOrWhiteSpace(typeString))
                {
                    roomToUpdate.Type = (typeString);
                }

                Console.Clear();
                Console.WriteLine("UPDATE DESCRIPTION");
                Console.WriteLine("Please choose a new room description between: (1)Single Room or (2)Double Room");
                Console.WriteLine("New Description (leave blank to keep the existing value): ");
                var descriptionString = Console.ReadLine();
                var singleRoom = "Single Room";
                var doubleRoom = "Double Room";
                descriptionString = descriptionString == "1" ? singleRoom : descriptionString == "2" ? doubleRoom : null;
                if (!string.IsNullOrWhiteSpace(descriptionString))
                {
                    roomToUpdate.Description = (descriptionString);
                }

                Console.Clear();
                Console.WriteLine("UPDATE BED AMOUNT");
                Console.WriteLine("Does the room have an extra bed? (1)Yes or (2)No (leave blank to keep the existing value): ");
                var bedString = Console.ReadLine();
                var yes = "yes";
                var no = "no";
                bedString = bedString == "1" ? yes : bedString == "2" ? no : null;
                if (!string.IsNullOrWhiteSpace(bedString))
                {
                    roomToUpdate.ExtraBed = (bedString);
                }

                _dbContext.SaveChanges();

                Console.WriteLine("Room updated successfully.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press Any Key to continue...");
                Console.ResetColor();
                Console.ReadKey();
                break;
            }
        }
    }
}
