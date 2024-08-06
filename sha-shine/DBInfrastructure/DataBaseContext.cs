using Microsoft.EntityFrameworkCore;
using sha_shine.Models;

namespace sha_shine.DBInfrastructure
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> option):base(option)
        {
            
        }

        public DbSet<AdminModal> adminModals { get; set; }


    }
}
