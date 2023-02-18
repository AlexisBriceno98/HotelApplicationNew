using HotelApplication.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelApplication.Guests
{
    public class CreateGuest
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateGuest(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void GuestCreate()
        {
            Console.WriteLine("Please Enter the details of the new guest:");
            Console.WriteLine("ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Full Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Guest newGuest = new Guest { GuestId = id, Name = name, Age = age};
            _dbContext.Guests.Add(newGuest);
            _dbContext.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Guest created successfully.");
            Console.WriteLine("Press Any Key to continue.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
