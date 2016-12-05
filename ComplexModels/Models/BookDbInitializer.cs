using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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

            base.Seed(db);
        }
    }
}