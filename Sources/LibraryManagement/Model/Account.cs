using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public abstract class Account
    {
        public int Id { get; set; }
        [Required]
        [StringLength(32)]
        public string Username { get; set; }
        [Required]
        [StringLength(32)]
        public string Password { get; private set; }
        [Required]
        public AccountStatus Status { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public ICollection<BookReturning> BookReturnings { get; set; }
        public ICollection<BookLending> BookLendings { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public bool ChangePassword() { return true; }
        public Account()
        {
            LibrarySystem.attach(this);
            this.Notifications = new HashSet<Notification>();

            this.BookLendings = new HashSet<BookLending>();
            this.BookReturnings = new HashSet<BookReturning>();
        }
        public void Update(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}
