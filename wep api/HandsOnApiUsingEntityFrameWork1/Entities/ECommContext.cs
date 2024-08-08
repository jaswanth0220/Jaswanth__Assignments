using Microsoft.EntityFrameworkCore;

namespace HandsOnApiUsingEntityFrameWork.Entities
{
    public class ECommContext:DbContext
    {
        //Entity Set
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4EF3680\\SQLEXPRESS;Initial " +
                "Catalog=EComm;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
