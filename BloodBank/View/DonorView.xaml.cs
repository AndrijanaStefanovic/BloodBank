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
            btnCancel.Click += btnCancel_Click;
        }

        private void btnOK_Click(object sender, RoutedEventArgs eventArgs)
        {
            if (!Validate())
            {
                MessageBox.Show("Validation unsuccessful. Please check all fields.", "Validation error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            long id = long.Parse(tbId.Text);

            if (viewModel.CreateDonor(id, tbName.Text, tbLastName.Text, tbEmail.Text, (BloodType)cbBloodType.SelectedValue))
            {
                MessageBox.Show("Successfully added a new donor!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Error while saving donor data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool Validate()
        {
            string id = tbId.Text;
            string name = tbName.Text;
            string lastName = tbLastName.Text;
            string emailAddress = tbEmail.Text;

            if (id.Length == 0 || name.Length == 0 || lastName.Length == 0 || emailAddress.Length == 0)
            {
                return false;
            }

            if (!long.TryParse(id, out long idLong))
            {
                return false;
            }
            return true;
        }
    }
}
