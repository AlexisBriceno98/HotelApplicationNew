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

        }
    }
}
