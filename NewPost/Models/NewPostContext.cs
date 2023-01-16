using Microsoft.EntityFrameworkCore;

namespace NewPost.Models
{
    public class NewPostContext:DbContext
    {
        public DbSet<Cell> cells { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductStatus> productStatuses { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }

        public NewPostContext(DbContextOptions<NewPostContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
