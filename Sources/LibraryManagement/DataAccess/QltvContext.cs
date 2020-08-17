using Model;
using System.Data.Entity;
namespace DataAccess
{
    public class QltvContext : DbContext
    {
        public QltvContext() : base("name=MyConnectionString")
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<LibraryCard> LibraryCards { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BookLending> BookLendings { get; set; }
        public virtual DbSet<BookReturning> BookReturnings { get; set; }
        public virtual DbSet<BookLendingDetail> BookLendingDetails { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

            builder.Entity<BookItem>()
                .HasIndex(b => b.Barcode)
                .IsUnique();

            builder.Entity<BookItem>()
                .Property(b => b.Barcode)
                .HasMaxLength(32).IsRequired();

            builder.Entity<Account>()
                .HasIndex(a => a.Username)
                .IsUnique();


        }

    }
}
