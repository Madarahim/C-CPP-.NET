//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5_CustomerMaintenenceWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public string StateCode { get; set; }
        public string StateName { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
