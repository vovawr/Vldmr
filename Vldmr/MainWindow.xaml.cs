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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vldmr.DB;
using static Vldmr.DB.Ms_Context;
using static Vldmr.RegWindows;
namespace Vldmr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ms_Context context = new Ms_Context();  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbAuth_Click(object sender, RoutedEventArgs e)
        {
            User user = context.Users.ToList().Find(x=>x.Password == tbPassword.Text && x.Name == tbPassword.Text);
            if(user != null)    
            {
                MessageBox.Show("Пользователь найден");
            }
            else
            {
                MessageBox.Show("Пользователь НЕ найден");
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            RegWindows regWindows = new RegWindows();
            regWindows.Show();              
        }
    }
}
