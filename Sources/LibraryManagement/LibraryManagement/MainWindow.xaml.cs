using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            using (var context = new QltvContext())
            {
                context.Database.CreateIfNotExists();
            }
            //InitializeComponent();
            
        }


        private void signInRibbonPage_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("sign in");
        }

        private void signUpRibbonPage_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("sign up");
        }



        private void RibbonControl_SelectedPageChanged(object sender, RibbonPropertyChangedEventArgs e)
        {
            RibbonControl rc = sender as RibbonControl;
            if (rc.SelectedPageName.ToString().Equals("signInRibbonPage"))
                MessageBox.Show("sign in");
            else if (rc.SelectedPageName.ToString().Equals("signUpRibbonPage"))
                MessageBox.Show("sign up");
        }

        

    }
}
