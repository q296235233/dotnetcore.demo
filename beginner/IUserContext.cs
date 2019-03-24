using Microsoft.EntityFrameworkCore;

namespace beginner
{
   public class IUserContext:DbContext
    {
        public IUserContext(DbContextOptions<IUserContext> options)//上下文选项
          : base(options)
        { }


        public DbSet<User> Users { get; set; }
    }
}