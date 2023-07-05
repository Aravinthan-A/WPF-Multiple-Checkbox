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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace virat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (chkindia.IsChecked == true)
            {
                lblprint.Content = chkindia.Content.ToString();
            }
            else
            {
                lblprint.Content = ("");
            }
        }

        private void Chkothers_Checked(object sender, RoutedEventArgs e)
        {
            if (Chkothers.IsChecked == true)
            {
                lblprint.Content = Chkothers.Content.ToString();
            }
            else
            {
                lblprint.Content = ("");
            }
        }


        private void Chkfive_Checked(object sender, RoutedEventArgs e)
        {
            if (Chkfive.IsChecked == true)
            {
                lblexp.Content = Chkfive.Content.ToString();
                Chkfive.IsChecked = false;
            }

        }

        private void Chkten_Checked(object sender, RoutedEventArgs e)
        {
            if (Chkten.IsChecked == true)
            {
                lblexp.Content = "EXPERIENCED ONLY";
            }
            else
            {
                lblexp.Content = ("");
            }
        }
        private void CheckBox_checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (Chkjava.IsChecked == true)
            {
                lblbest.Content = Chkjava.Content.ToString();
            }
            if (Chkcsharp.IsChecked == true)
            {
                lblbest.Content = Chkcsharp.Content.ToString();
            }
            if (Chkesharp.IsChecked == true)
            {
                lblbest.Content = Chkesharp.Content.ToString();
            }
            if (Chkjava.IsChecked == true && Chkcsharp.IsChecked == true)
            {
                lblbest.Content = Chkjava.Content.ToString() + "," + Chkcsharp.Content.ToString();
            }
            if (Chkcsharp.IsChecked == true && Chkesharp.IsChecked == true)
            {
                lblbest.Content = Chkcsharp.Content.ToString() + "," + Chkesharp.Content.ToString();
            }
            if (Chkjava.IsChecked == true && Chkcsharp.IsChecked == true)
            {
                lblbest.Content = Chkjava.Content.ToString() + "," + Chkcsharp.Content.ToString();
            }
            if (Chkjava.IsChecked == true && Chkcsharp.IsChecked == true && Chkesharp.IsChecked == true)
            {
                lblbest.Content =  Chkjava.Content.ToString()+","+Chkcsharp.Content.ToString() + "," + Chkesharp.Content.ToString();
            }
            if ( Chkjava.IsChecked == false && Chkcsharp.IsChecked == false && Chkesharp.IsChecked == false)
            {
                lblbest.Content = ("");
            }
        }
    }













    //else
    //{
    //    lblskill.Content = ("");
    //}
    //if(Chkcsharp.IsChecked == true)
    //{
    //    lblskill.Content = Chkcsharp.Content.ToString();
    //}
    //else
    //{
    //    lblskill.Content = ("");
    //}
    //if (Chkesharp.IsChecked == true)
    //{
    //    lblskill.Content = Chkesharp.Content.ToString();
    //}
    //{
    //    lblskill.Content = ("");
    //}



}


//    if (Chkjava.IsChecked == true && Chkcsharp.IsChecked == true)
//    {
//        lblskill.Content = Chkcsharp.Content.ToString() + "," + Chkjava.Content.ToString();
//    }
//    else
//    {
//        lblskill.Content = ("");
//    }
//    if(Chkcsharp.IsChecked == true && Chkesharp.IsChecked == true)
//    {
//        lblskill.Content = Chkesharp.Content.ToString()+","+Chkcsharp.Content.ToString();
//    }
//    else
//    {
//        lblskill.Content = ("");
//    }
//    if (Chkesharp.IsChecked == true && Chkcsharp.IsChecked == true)
//    {
//        lblskill.Content = Chkcsharp.Content.ToString() + "," + Chkesharp.Content.ToString();
//    }

//} } }




