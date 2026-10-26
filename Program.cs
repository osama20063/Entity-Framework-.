namespace Entity_Framework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Entities
            //public class Book
            //        {
            //            public int Id { get; set; }
            //            public string Title { get; set; }
            //            public string ISBN { get; set; }
            //            public decimal Price { get; set; }
            //            public int Pages { get; set; }
            //            public int PublishedYear { get; set; }
            //            public bool IsInStock { get; set; }
            //        }

            //        public class Author
            //        {
            //            public int Id { get; set; }
            //            public string FirstName { get; set; }
            //            public string LastName { get; set; }
            //            public string Email { get; set; }
            //            public string Biography { get; set; }
            //            public DateTime DateOfBirth { get; set; }
            //        }

            //        public class Category
            //        {
            //            public int Id { get; set; }
            //            public string Name { get; set; }
            //            public string Description { get; set; }
            //            public bool IsActive { get; set; }
            //        }
            #endregion


            #region AppDbContext
//            using Microsoft.EntityFrameworkCore;

//public class BookstoreDbContext : DbContext
//        {
//            public DbSet<Book> Books { get; set; }
//            public DbSet<Author> Authors { get; set; }
//            public DbSet<Category> Categories { get; set; }

//            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            {
//                // استبدل ضع اسم السيرفر الخاص بك هنا (Server Name)
//                optionsBuilder.UseSqlServer("Server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True;");
//            }
//        }
            #endregion
    }
}
}
