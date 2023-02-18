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

        }
    }
}
