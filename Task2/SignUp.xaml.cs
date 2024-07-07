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

namespace Task2
{
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string surname = SurName.Text;
            string age = Age.Text;
            string login = Login.Text;
            string password = Password.Text;
            string confirmPass = ConfirmPass.Text;
            
            if (!(name.Length == 0))
            {
                if(!(surname.Length == 0))
                {

                }
            }
        }
    }
}
