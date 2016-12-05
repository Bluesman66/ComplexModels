using System.Data.Entity;

namespace ComplexModels.Models
{
	public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Company> Companies { get; set; }
	}
}