using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Notification> ListNotifications { get; set; }
        public bool ChangePassword() { return true; }
        public Account(LibrarySystem libSystem)
        {
            libSystem.attach(this);
        }
        public Account() { }
        public void Update(Notification notification)
        {
            ListNotifications.Add(notification);
        }
    }
}
