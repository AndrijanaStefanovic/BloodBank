using BloodBank.Model;
using BloodBank.Util;
using BloodBank.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BloodBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BloodSupplyViewModel();
            miAddDonor.Click += miAddDonor_Click;
            System.Diagnostics.Debug.WriteLine(((BloodSupplyViewModel)DataContext).BloodSupply.APos);
            System.Diagnostics.Debug.WriteLine(((BloodSupplyViewModel)DataContext).BloodSupply.BPos);
            System.Diagnostics.Debug.WriteLine(((BloodSupplyViewModel)DataContext).BloodSupply.ABPos);
            System.Diagnostics.Debug.WriteLine(((BloodSupplyViewModel)DataContext).BloodSupply.OPos);
        }

        private void miAddDonor_Click(object sender, RoutedEventArgs routedEventArgs)
        {
            DonorView donorView = new DonorView();
            donorView.Show();
        }
    }
}
