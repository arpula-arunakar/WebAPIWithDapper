using Microsoft.EntityFrameworkCore;

namespace WebAPIWithDapper.Data
{
    public class AppContext:DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }


    }
}
