using BloodBank.Model;
using BloodBank.Viewmodel;
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

namespace BloodBank.View
{
    /// <summary>
    /// Interaction logic for DonorView.xaml
    /// </summary>
    public partial class DonorView : Window
    {
        private DonorViewModel viewModel;

        public DonorView()
        {
            InitializeComponent();
            viewModel = new DonorViewModel();
            this.DataContext = viewModel;
            btnOK.Click += btnOK_Click;
        }

        private void btnOK_Click(object sender, RoutedEventArgs eventArgs)
        {
            if (!Validate())
            {
                MessageBox.Show("Empty fields");
                return;
            }
            viewModel.CreateDonor(tbName.Text, tbLastName.Text, tbEmail.Text, tbPassword.Password, BloodType.A);
        }

        private bool Validate()
        {
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            string emailAddress = tbEmail.Text;
            string password = tbPassword.Password;

            if (name.Length == 0 || lastName.Length == 0 || emailAddress.Length == 0 || password.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
