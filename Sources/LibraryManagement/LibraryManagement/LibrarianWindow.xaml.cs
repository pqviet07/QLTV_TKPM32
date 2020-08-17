using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for LibrarianWindow.xaml
    /// </summary>
    public partial class LibrarianWindow : ThemedWindow
    {
        public LibrarianWindow()
        {
            InitializeComponent();
            AdminWindow a = new AdminWindow();
            ViewUtil.SetProfile(FullNameTextEdit, SexTextEdit, DateOfBirthTextEdit, IdentifyCardNumberTextEdit,
                AddressTextEdit, EmailTextEdit, PhoneNumberTextEdit, UsernameTextEdit);
        }

        private void RibbonControl_SelectedPageChanged(object sender, RibbonPropertyChangedEventArgs e)
        {
            RibbonControl rc = sender as RibbonControl;
            if (rc.SelectedPageName.ToString().Equals("LibrarianHomeRibbonPage"))
                LibrarianTabControl.SelectedItem = LibrarianHomeTabItem;
            else if (rc.SelectedPageName.ToString().Equals("LibrarianProfileRibbonPage"))
                LibrarianTabControl.SelectedItem = LibrarianProfileTabItem;
        }

        private void SelectMale(object sender, RoutedEventArgs e)
        {
            SexTextEdit.Text = "Male";
            SelectSexDropDownButton.IsPopupOpen = false;
        }
        private void SelectFemale(object sender, RoutedEventArgs e)
        {
            SexTextEdit.Text = "Female";
            SelectSexDropDownButton.IsPopupOpen = false;
        }

        private void UpdateProfileButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
