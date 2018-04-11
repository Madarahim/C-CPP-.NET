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

namespace Lab5_CustomerMaintenenceWPF.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddModifyPage : Window
    {
      
        public AddModifyPage()
        {

            InitializeComponent();
            LoadComboBox(cboStates);
            Lab5_CustomerMaintenenceWPF.ViewModels.AddModifyWrap selectedAddModifyViewModel = new Lab5_CustomerMaintenenceWPF.ViewModels.AddModifyWrap();
            selectedAddModifyViewModel.test();
            this.DataContext = selectedAddModifyViewModel;

        }

        public ComboBox states()
        { return cboStates; }

        void LoadComboBox(ComboBox model)
        { // Code a query to retrieve the required information from
          // the States table, and sort the results by state name.
          // Bind the State combo box to the query results.
          
            var states = from unitedStates in Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.dbContext.States
                             orderby unitedStates.StateName
                             select new { unitedStates.StateName };

                foreach (var element in states)
                {
                    model.Items.Add(element.StateName);
                }

            
        }
    }
}
