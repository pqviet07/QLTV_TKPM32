using System.Collections.Generic;

namespace Model
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; private set; }
        public AccountStatus Status { get; set; }
        public string UserType { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public bool ChangePassword() { return true; }
        public Account(LibrarySystem libSystem)
        {
            libSystem.attach(this);
        }
        public Account() { this.Notifications = new HashSet<Notification>(); }
        public void Update(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}
