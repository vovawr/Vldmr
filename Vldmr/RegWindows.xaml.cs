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
using Vldmr.DB;
using static Vldmr.DB.Ms_Context;

namespace Vldmr
{
    /// <summary>
    /// Логика взаимодействия для RegWindows.xaml
    /// </summary>
    public partial class RegWindows : Window
    {
           
        public RegWindows()
        {
            InitializeComponent();
        }

        public void Reg_Click(object sender, RoutedEventArgs e)
        {
            //User user = new User();
        
            //user.Name = tbName.Text;
            //user.Password = tbPassword.Text;
          
            

            Ms_Context context = new Ms_Context();
            try
            {
                context.Users.Add(new User { Name = tbName.Text , Password = tbPassword.Text});
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
