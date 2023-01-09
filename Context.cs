using Microsoft.EntityFrameworkCore;
namespace SonDeneme
{
    public class AppContext :DbContext
    {

        public AppContext(DbContextOptions<AppContext>options)
                :base(options) 
        {
        }

        public object Employees { get; internal set; }
    }


}
