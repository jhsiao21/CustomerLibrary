using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICustomerInterface;
using Stratergy;

namespace CustomerLibrary
{
    public abstract class CustomerBase : ICustomer
    {
        private IValidationStratergy<ICustomer> _ValidationType = null;

        public void Validate()
        {
            ValidationType.Validate(this);
        }
                
        public CustomerBase(IValidationStratergy<ICustomer> _Validate)
        {
            _ValidationType = _Validate;
        }

        public IValidationStratergy<ICustomer> ValidationType
        {
            get { return _ValidationType; }
            set { _ValidationType = value; }
        }
                
        public ICustomer Clone()
        {
            return (ICustomer)this.MemberwiseClone();
        }

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
    }

    public class Customer : CustomerBase
    {
        public Customer(IValidationStratergy<ICustomer> obj)
            : base(obj)
        {

        }

    }

    public class Lead : CustomerBase
    {
        public Lead(IValidationStratergy<ICustomer> obj)
            : base(obj)
        {
            
        }
    }
}
