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
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            GuessTabControl.SelectedItem = GuestSignInTabItem;
        }

        private void RibbonControl_SelectedPageChanged(object sender, RibbonPropertyChangedEventArgs e)
        {
            RibbonControl rc = sender as RibbonControl;
            if (rc.SelectedPageName.ToString().Equals("SignInRibbonPage"))
                GuessTabControl.SelectedItem = GuestSignInTabItem;
            else if (rc.SelectedPageName.ToString().Equals("SignUpRibbonPage"))
                GuessTabControl.SelectedItem = GuestSignUpTabItem;

        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // dang ky thanh cong
            //MessageBox.Show("Sign in successfully");

            // dang ky that bai
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            // nếu đăng nhập thành công
            // điều kiện là admin
            AdminWindow AdminWindow = new AdminWindow();
            AdminWindow.Show();

            // điều kiện là librarian
            //LibrarianWindow LibrarianWindow = new LibrarianWindow();
            //LibrarianWindow.Show();

            // nếu đăng nhập thất bại
            //MessageBox.Show("Sign in unsuccessfully");
        }





    }
}
