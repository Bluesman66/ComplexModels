using System.Data.Entity;

namespace ComplexModels.Models
{
	public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Id = 1, Name = "Война и мир", AuthorId = 2 });
            db.Books.Add(new Book { Id = 2, Name = "Отцы и дети", AuthorId = 1 });
            db.Books.Add(new Book { Id = 3, Name = "Чайка", AuthorId = 3 });
			
            db.Authors.Add(new Author { Id = 1, Name = "Тургенев И.С." });
            db.Authors.Add(new Author { Id = 2, Name = "Толстой Л.Н." });
            db.Authors.Add(new Author { Id = 3, Name = "Чехов А.П." });

			db.Users.Add(new User { Id = 1, Name = "John", Age = 40 });
			db.Users.Add(new User { Id = 2, Name = "Paul", Age = 74 });
			db.Users.Add(new User { Id = 3, Name = "George", Age = 58 });
			db.Users.Add(new User { Id = 3, Name = "Ringo", Age = 76 });

			db.Companies.Add(new Company { Id = 1, Name = "Рога и Копыта" });

			base.Seed(db);
        }
    }
}