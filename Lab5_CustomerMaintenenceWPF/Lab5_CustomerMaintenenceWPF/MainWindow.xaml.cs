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

namespace Lab5_CustomerMaintenenceWPF
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

        private void CustomerInfoViewControl_Loaded(object sender, RoutedEventArgs e)
        {
          Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.selectedCustomer = new Lab5_CustomerMaintenenceWPF.Customer();

            Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.selectedWrap = new Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap();
            //Lab5_CustomerMaintenenceWPF.ViewModels.CustomerInfoViewModel selectedCutomerViewModelObject = new Lab5_CustomerMaintenenceWPF.ViewModels.CustomerInfoViewModel();
            //selectedCutomerViewModelObject.AddCustomerTest();

            CustomerInfoViewControl.DataContext = Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.selectedWrap;
            
           
            
        }
    }
}
