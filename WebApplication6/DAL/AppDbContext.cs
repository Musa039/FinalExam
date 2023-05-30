using Microsoft.EntityFrameworkCore;

namespace WebApplication6.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
     


    }
}
