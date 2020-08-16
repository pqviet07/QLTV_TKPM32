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
