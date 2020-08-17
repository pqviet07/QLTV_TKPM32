using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for AdminHomeWindow.xaml
    /// </summary>
    public partial class AdminWindow : ThemedWindow
    {
        public AdminWindow()
        {
            InitializeComponent();
            ViewUtil.SetProfile(FullNameTextEdit, SexTextEdit, DateOfBirthTextEdit, IdentifyCardNumberTextEdit,
                AddressTextEdit, EmailTextEdit, PhoneNumberTextEdit, UsernameTextEdit);
            PositionTextEdit.Text = "Admin";
        }



        private void RibbonControl_SelectedPageChanged(object sender, RibbonPropertyChangedEventArgs e)
        {
            RibbonControl rc = sender as RibbonControl;
            if (rc.SelectedPageName.ToString().Equals("AdminHomeRibbonPage"))
                AdminTabControl.SelectedItem = AdminHomeTabItem;
            else if (rc.SelectedPageName.ToString().Equals("AdminProfileRibbonPage"))
                AdminTabControl.SelectedItem = AdminProfileTabItem;
            //else if (rc.SelectedPageName.ToString().Equals("ManagementRibbonPage"))

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
