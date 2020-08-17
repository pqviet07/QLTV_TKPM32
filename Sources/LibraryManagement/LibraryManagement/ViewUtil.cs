using DevExpress.Xpf.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class ViewUtil
    {
        public static void SetProfile(TextEdit FullNameTextEdit, TextEdit SexTextEdit, TextEdit DateOfBirthTextEdit, 
            TextEdit IdentifyCardNumberTextEdit, TextEdit AddressTextEdit, TextEdit EmailTextEdit,
            TextEdit PhoneNumberTextEdit, TextEdit UsernameTextEdit)
        {
            string FullName = "Nguyễn Văn A";
            string Sex = "Male";
            string DateOfBirth = "01-01-2020";
            string IdentifyCardNumber = "025123456";
            string Address = "TPHCM";
            string Email = "abc@gmail.com";
            string PhoneNumber = "0123456789";
            string Username = "abc";
            FullNameTextEdit.Text = FullName;
            SexTextEdit.Text = Sex;
            DateOfBirthTextEdit.Text = DateOfBirth;
            IdentifyCardNumberTextEdit.Text = IdentifyCardNumber;
            AddressTextEdit.Text = Address;
            EmailTextEdit.Text = Email;
            PhoneNumberTextEdit.Text = PhoneNumber;
            UsernameTextEdit.Text = Username;
        }
    }
}
