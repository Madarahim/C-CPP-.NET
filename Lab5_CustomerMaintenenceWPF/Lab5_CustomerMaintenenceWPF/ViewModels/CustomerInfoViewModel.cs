using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Data;

namespace Lab5_CustomerMaintenenceWPF.ViewModels
{
    class CustomerInfoViewModel
    {

    }






    public class CustomerWrap : INotifyPropertyChanged
    {
        public static MMABooksEntities1 dbContext = new MMABooksEntities1();
        public static bool addCustomer, modifyCustomer;
        public static Customer customer =new Customer();
        public static Customer selectedCustomer=new Customer();
       
        public static CustomerWrap selectedWrap;
        public static Lab5_CustomerMaintenenceWPF.Views.AddModifyPage addModifyCustomer;
        public event PropertyChangedEventHandler PropertyChanged;
        int ID;
        String stateName;

        public int CustomerIDNotify
        {
            get { return ID; }
            set
            {
                ID = value;
                RaisePropertyChanged("CustomerIDNotify");
            }
        }
        
        public String NameNotify
        {
            get { return customer.Name; }
            set
            {
                customer.Name = value;
                RaisePropertyChanged("NameNotify");
            }

        }
        public String AddressNotify
        {
            get { return customer.Address; }
            set
            {
                customer.Address = value;
                RaisePropertyChanged("AddressNotify");
            }

        }

        public String CityNotify
        {
            get { return customer.City; }
            set
            {
                customer.City = value;
                RaisePropertyChanged("CityNotify");
            }

        }
        
        public String StateNotify
        {
            get {
                return stateName; }
            set
            {
                stateName = value;
                RaisePropertyChanged("StateNotify");
            }

        }
        
        public String ZipCodeNotify
        {
            get { return customer.ZipCode; }
            set
            {
                customer.ZipCode = value;
                RaisePropertyChanged("ZipCodeNotify");
            }

        }


        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        //Buttons
        /////////////////////////////////////////////////////////////////////////////////////////////
        private ICommand getCustomerClickCommand,addClickCommand, modifyClickCommand, deleteClickCommand, exitClickCommand;



        //GET CUSTOMER CLICK COMMAND
        public ICommand GetCustomerClickCommand
        {
               get
                {
                return getCustomerClickCommand ?? (getCustomerClickCommand = new CommandHandler(() => GetCustomerAction(), _canExecute));
                }
        }

    //ADD CLICK COMMAND
    public ICommand AddClickCommand
        {
            get
            {
                return addClickCommand ?? (addClickCommand = new CommandHandler(() => AddAction(), _canExecute));
            }
        }

        //MODIFY CLICK COMMAND
        public ICommand ModifyClickCommand
        {
            get
            {
                return modifyClickCommand ?? (modifyClickCommand = new CommandHandler(() => ModifyAction(), _canExecute));
            }
        }

        //DELETE CLICK COMMAND
        public ICommand DeleteClickCommand
        {
            get
            {

                return deleteClickCommand ?? (deleteClickCommand = new CommandHandler(() => DeleteAction(), _canExecute));
            }
        }

        //EXIT CLICK COMMAND
        public ICommand ExitClickCommand
        {
            get
            {
                return exitClickCommand ?? (exitClickCommand = new CommandHandler(() => ExitAction(), _canExecute));
            }
        }


        //Boolean if can execute
        private bool _canExecute = true;



        //BUTTON ACTIONS
        //Get a customer
        public void GetCustomerAction() {
            int customerID = this.ID;
            this.GetCustomer(customerID);
        }
        private void GetCustomer(int CustomerID)
        {
           
                // Code a query to retrieve the selected customer
                // and store the Customer object in the class variable.
                Console.WriteLine("THE ID IS THISSSSS:   " + ID);
            try
            {
                RetrieveCustomer(CustomerID);


                //  If the customer is found, add code to the GetCustomer method that checks if the State object
                // has been loaded and that loads if it hasn't.

                this.DisplayCustomer();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message.ToString());
                MessageBox.Show( "Customer Does Not Exist", "Error");
            }

        }



        private void RetrieveCustomer(int customerID)
        {
            selectedCustomer = new Customer();

            var results = from customers in Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.dbContext.Customers
                          where customers.CustomerID == customerID
                          select customers;

            //STORE NAME
            selectedCustomer.Name = results.FirstOrDefault().Name;

            //STORE ADDRESS
            selectedCustomer.Address = results.FirstOrDefault().Address;

            //STORE CITY
            selectedCustomer.City = results.FirstOrDefault().City;

            //STORE STATE
            selectedCustomer.State1 = results.FirstOrDefault().State1;

            //STORE ZIPCODE
            selectedCustomer.ZipCode = results.FirstOrDefault().ZipCode;

            //Check if working properly
            Console.WriteLine("NAME: " + selectedCustomer.Name);
            Console.WriteLine("ADDRESS: " + selectedCustomer.Address);
            Console.WriteLine("CITY: " + selectedCustomer.City);
            Console.WriteLine("STATE: " + selectedCustomer.State1.StateName);
            Console.WriteLine("ZIPCODE: " + selectedCustomer.ZipCode);

        }

        private void DisplayCustomer()
        {
            selectedWrap.NameNotify = selectedCustomer.Name;
            selectedWrap.AddressNotify = selectedCustomer.Address;
            selectedWrap.CityNotify = selectedCustomer.City;
            selectedWrap.StateNotify = selectedCustomer.State1.StateName;
            customer.State1 = selectedCustomer.State1;
            selectedWrap.ZipCodeNotify = selectedCustomer.ZipCode;
            
        }


        //Add customer
        public void AddAction()
        {
            addCustomer = true;
            addModifyCustomer = new Lab5_CustomerMaintenenceWPF.Views.AddModifyPage();
            AddModifyWrap.LoadAddModify();
            addModifyCustomer.Show();
           
           // selectedWrap.NameNotify = "JORDAN";
            Console.WriteLine("YOU CAN'T ADD ANTHING!");

            //addCustomer = false;
        }

        //Modify customer
        public void ModifyAction()
        {
            Console.WriteLine("Tryin To Modify.......");
            addCustomer = false;
            addModifyCustomer = new Lab5_CustomerMaintenenceWPF.Views.AddModifyPage();
            AddModifyWrap.LoadAddModify();
            addModifyCustomer.Show();
            Console.WriteLine("YOU CAN'T ADD ANTHING!");

            
        }

        //Delete customer
        public void DeleteAction()
        {
            Console.WriteLine("WHY YOU TRYING TO DELETE WHEN NOTHING IS THERE!!!!!!!");
            try
            {
                var results = from customers in Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.dbContext.Customers
                              where customers.CustomerID == this.CustomerIDNotify
                              select customers;
                // Mark the row for deletion.
                // Update the database.
                this.deleteFromDatabase(results.FirstOrDefault());

            }
            // Add concurrency error handling.
            // Place the catch block before the one for a generic exception.
            catch (Exception e) { }
           

        }

        public void deleteFromDatabase(Customer customer)
        {
          
                try
                {
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();
                    this.ClearControls();

            }
            catch (DbUpdateConcurrencyException ex)
                {
                    ex.Entries.Single().Reload();
                        MessageBox.Show("Another user has updated " + "that customer.", "Concurrency Error");
                        AddModifyWrap.ReloadViewWithCorrectValues(AddModifyWrap.modified);
                    
                }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Another user has deleted " +
                  "that customer.", "Concurrency Error");

                this.ClearControls();
            }



        }
        public void ClearControls() {
            customer = new Customer();
            this.CustomerIDNotify = 0;
            this.NameNotify = "";
            this.AddressNotify = "";
            this.CityNotify = "";
            this.StateNotify = "";
            this.ZipCodeNotify = "";

        }
        //Exit program
        public void ExitAction()
        {
            Console.WriteLine("BUH-BYEEEEE!!!! YO MAMA");
            Environment.Exit(0);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////


        public void AddCustomerTest()
        {
            _canExecute = true;

        }

        public String SelectedCustomerName
        {
            get { return selectedWrap.NameNotify; }

        }

        public String SelectedCustomerAddress
        {

            get { return selectedCustomer.Address; }

        }

        public String SelectedCustomerCity
        {

            get { return selectedCustomer.City; }

        }

        /*public String SelectedCustomerState
        {

            get { return selectedCustomer.State1.StateName; }

        }*/

        public String SelectedCustomerZipCode
        {

            get { return selectedCustomer.ZipCode; }
        }
        //////////////////////////////////////////////////////////
         
    }
}
