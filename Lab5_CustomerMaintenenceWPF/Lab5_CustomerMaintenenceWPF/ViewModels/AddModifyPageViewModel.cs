using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Windows;

namespace Lab5_CustomerMaintenenceWPF.ViewModels
{
    class AddModifyPageViewModel
    {
        
        ////////////////////////////////////////////////////////////////////
        
    }
    public class CommandHandler : ICommand
    {
        private Action _action;
        private bool _canExecute;
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
       
        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }

 

    public class AddModifyWrap : INotifyPropertyChanged
    {
  public void test() { Console.WriteLine("TESTING TESTING"); }

        public static int deleted = 0, modified= 1;
        public event PropertyChangedEventHandler PropertyChanged;
        public static AddModifyWrap addModCustomerWrap = new AddModifyWrap();
        public static Customer addModCustomer = new Customer();
        String state;

        public int addModCustomerID
        {
            get { return addModCustomer.CustomerID; }
            set
            {
                addModCustomer.CustomerID = value;
                RaisePropertyChanged("addModCustomer");
            }
        }

        public String addModName
        {
            get { return addModCustomer.Name; }
            set
            {
                addModCustomer.Name = value;
                RaisePropertyChanged("addModName");
            }

        }






        public String addModAddress
        {
            get { return addModCustomer.Address; }
            set
            {
                addModCustomer.Address = value;
                RaisePropertyChanged("addModAddress");
            }

        }

        public String addModCity
        {
            get { return addModCustomer.City; }
            set
            {
                addModCustomer.City = value;
                RaisePropertyChanged("addModCity");
            }

        }

        public String addModState
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                RaisePropertyChanged("addModState");
            }

        }

        public String addModZipCode
        {
            get { return addModCustomer.ZipCode; }
            set
            {
                addModCustomer.ZipCode = value;
                RaisePropertyChanged("addModState");
            }

        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
           
        }


        public static int count = 0;
        public static Dictionary<string, string> states;




        public static void LoadAddModify()
        {
            if (CustomerWrap.addCustomer)
            {

                CustomerWrap.addModifyCustomer.cboStates.SelectedIndex = -1;
                addModCustomerWrap.addModName = "";
                addModCustomerWrap.addModAddress = "";
                addModCustomerWrap.addModCity = "";
                addModCustomerWrap.addModState = "";
                addModCustomerWrap.addModZipCode = "";
            }
            else
            {

                
                addModCustomerWrap.addModName = CustomerWrap.customer.Name;
                addModCustomerWrap.addModAddress = CustomerWrap.customer.Address;
                addModCustomerWrap.addModCity = CustomerWrap.customer.City;
                addModCustomerWrap.addModState = CustomerWrap.selectedWrap.StateNotify;
                //Find State Object
                addModCustomer.State1 = CustomerWrap.customer.State1;

                CustomerWrap.addModifyCustomer.cboStates.SelectedValue = CustomerWrap.selectedWrap.StateNotify;
                addModCustomerWrap.addModZipCode = CustomerWrap.customer.ZipCode;

                // this.DisplayCustomerData();
            }
        }

        private void DisplayCustomerData()
        {
            //if add equals true
         
        }

        private bool IsValidData()
        {/*
            return Validator.IsPresent(txtName) &&
                    Validator.IsPresent(txtAddress) &&
                    Validator.IsPresent(txtCity) &&
                    Validator.IsPresent(cboStates) &&
                    Validator.IsPresent(txtZipCode) &&
                    Validator.IsInt32(txtZipCode);*/
            return true;
        }


        private void PutCustomerData(Customer customer)
        {

            //FIND MAX ID
            var idResult = CustomerWrap.dbContext.Customers.Max(x => x.CustomerID);
            Console.WriteLine("NIGGA: " + idResult);
            //SET ID
            //IF YOU ADD A CUSTOMER THEN YOU CREATE A NEW ID FOR SAID CUSTOMER
            //IF YOU MODIFY A CUSTOMER THEN YOU CAN'T GIVE THEM A NEW ID

            customer.CustomerID = idResult + 1;
            CustomerWrap.selectedWrap.CustomerIDNotify =idResult+1;

            //SET NAME
            customer.Name = addModCustomerWrap.addModName;
            CustomerWrap.selectedWrap.NameNotify = customer.Name;

            //SET ADDRESS
            customer.Address = addModCustomerWrap.addModAddress;
            CustomerWrap.selectedWrap.AddressNotify = customer.Address;

            //SET CITY
            customer.City = addModCustomerWrap.addModCity;
            CustomerWrap.selectedWrap.CityNotify = customer.City;

            //GET NAME OF STATE
            string stateName = CustomerWrap.addModifyCustomer.cboStates.Text;
            CustomerWrap.selectedWrap.StateNotify = stateName;

            //FIND STATE CODE
            var stateAbbreviation = from states in Lab5_CustomerMaintenenceWPF.ViewModels.CustomerWrap.dbContext.States
                                    where states.StateName == stateName
                                    select states;
            //SET STATE OBJECT
            //customer.State = new State();
            //customer.State.StateCode = stateAbbreviation.FirstOrDefault().StateCode;
            //customer.State.StateName = stateName;
            customer.State1 = stateAbbreviation.FirstOrDefault();

            //Console.WriteLine("WTFFFFFFFFFF:        "+customer.State.StateCode+", "+customer.State.StateName);
            //stateAbbreviation = null;
            //SET ZIP CODE
            customer.ZipCode = addModCustomerWrap.addModZipCode;
            CustomerWrap.selectedWrap.ZipCodeNotify = customer.ZipCode;

            Console.WriteLine("ID: " + customer.CustomerID);
            Console.WriteLine("NAME: " + CustomerWrap.selectedWrap.NameNotify);
            Console.WriteLine("ADDRESS: " + CustomerWrap.selectedWrap.AddressNotify);
            Console.WriteLine("CITY: " + CustomerWrap.selectedWrap.CityNotify);
            Console.WriteLine("STATE: " + CustomerWrap.selectedWrap.StateNotify);
            Console.WriteLine("ZIPCODE: " + CustomerWrap.selectedWrap.ZipCodeNotify);
            //Update Database
            updateDatabase(customer);


            var lastRow =  CustomerWrap.dbContext.Customers.Max(x => x.CustomerID);
            var lastCustomer = from people in CustomerWrap.dbContext.Customers
                               where people.CustomerID == lastRow
                               select people;


            CustomerWrap.selectedWrap.CustomerIDNotify =lastCustomer.FirstOrDefault().CustomerID;
        }

        //UPDATE DATABASE SOMEHOW SOMEWAY
        public void updateDatabase(Customer customer)
        {
            try
            {
                if (CustomerWrap.addCustomer)
                {

                    CustomerWrap.dbContext.Customers.Add(customer);
                    CustomerWrap.dbContext.SaveChanges();
                    CustomerWrap.addModifyCustomer.Close();

                }
                else
                {
                    Console.WriteLine("Modifying Database......");
                    CustomerWrap.dbContext.SaveChanges();

                    CustomerWrap.addModifyCustomer.Close();

                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine("DbUpdateConcurrencyException DETECTED!!!!!");
                ex.Entries.Single().Reload();


                MessageBox.Show("Another user has updated " +
                "that customer.", "Concurrency Error");

                CustomerWrap.addModifyCustomer.Close();
                ReloadViewWithCorrectValues(modified);

                // this.DialogResult = DialogResult.Retry;


            }

         
            

        }

        public static void ReloadViewWithCorrectValues(int choice)
        {
            if (choice == modified)
            {
                var results = from people in CustomerWrap.dbContext.Customers
                              where people.CustomerID == CustomerWrap.selectedWrap.CustomerIDNotify
                              select people;

                CustomerWrap.selectedWrap.NameNotify = results.FirstOrDefault().Name;

                CustomerWrap.selectedWrap.AddressNotify = results.FirstOrDefault().Address;

                CustomerWrap.selectedWrap.CityNotify = results.FirstOrDefault().City;


                CustomerWrap.selectedWrap.StateNotify = results.FirstOrDefault().State1.StateName;

                CustomerWrap.selectedWrap.ZipCodeNotify = results.FirstOrDefault().ZipCode;
            }
            else
            {
                CustomerWrap.selectedWrap.CustomerIDNotify = 0;
                CustomerWrap.selectedWrap.NameNotify = "";
                CustomerWrap.selectedWrap.AddressNotify = "";
                CustomerWrap.selectedWrap.CityNotify = "";
                CustomerWrap.selectedWrap.StateNotify = "";
                CustomerWrap.selectedWrap.ZipCodeNotify = "";

            }

        }

        
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private ICommand acceptClickCommand, cancelClickCommand;

        //ACCEPT CLICK COMMAND
        public ICommand AcceptClickCommand
        {
            get
            {
                return acceptClickCommand ?? (acceptClickCommand = new CommandHandler(() => AcceptAction(), true));
            }
        }

        public ICommand CancelClickCommand
        {
            get
            {
                return cancelClickCommand ?? (cancelClickCommand = new CommandHandler(() => CancelAction(), true));
            }
        }


       
        public void AcceptAction()
        {
            Console.WriteLine("ACCEPT ACTION");
            if (IsValidData())
            {
                //IF ADD BUTTON WAS PRESSED IN HOME MENU
                if (CustomerWrap.addCustomer)
                {
                    Console.WriteLine("ACCEPT ACTION");

                    PutCustomerData(addModCustomer);

                    // Add the new vendor to the collection of vendors.

                 //   try
                //    {


                 //       this.DialogResult = DialogResult.OK;
                  //  }
                  //  catch (Exception ex)
                   // {
                    //    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    //}
                }



                //IF MODIFY BUTTON WAS PRESSED IN HOME MENU
                else
                {
                    //this.PutCustomerData(customer);
                    try
                    {

                        var results = from people in CustomerWrap.dbContext.Customers
                                      where people.CustomerID == CustomerWrap.selectedWrap.CustomerIDNotify
                                            select people;
                        var state = from states in CustomerWrap.dbContext.States
                                    where states.StateName == CustomerWrap.addModifyCustomer.cboStates.Text
                                    select states;

                        results.FirstOrDefault().Name = addModCustomer.Name;
                        CustomerWrap.selectedWrap.NameNotify = addModCustomer.Name;

                        results.FirstOrDefault().Address = addModCustomer.Address;
                        CustomerWrap.selectedWrap.AddressNotify = addModCustomer.Address;

                        results.FirstOrDefault().City = addModCustomer.City;
                        CustomerWrap.selectedWrap.CityNotify = addModCustomer.City;


                        results.FirstOrDefault().State1 = state.FirstOrDefault();
                        CustomerWrap.selectedWrap.StateNotify = CustomerWrap.addModifyCustomer.cboStates.Text;

                        results.FirstOrDefault().ZipCode = addModCustomer.ZipCode;
                        CustomerWrap.selectedWrap.ZipCodeNotify = addModCustomer.ZipCode;
                        // Update the database.
                        updateDatabase(addModCustomer);
                        //this.DialogResult = DialogResult.OK;
                    }

                    // Add concurrency error handling.
                    // Place the catch block before the one for a generic exception.

                    catch (NullReferenceException e)
                    {
                        MessageBox.Show("Another user has deleted " +
                              "that customer.", "Concurrency Error");

                        CustomerWrap.addModifyCustomer.Close();
                        ReloadViewWithCorrectValues(deleted);
                    }
                }
            }
        }

        public void CancelAction()
        {
            CustomerWrap.addModifyCustomer.Close();
        }





    }



}
