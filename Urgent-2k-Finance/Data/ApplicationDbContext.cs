using Microsoft.EntityFrameworkCore;

namespace Urgent_2k_Finance.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions option) :base(option) { }
      
    }
}
