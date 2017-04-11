using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stratergy;
namespace ICustomerInterface
{
    public interface IBo // Design pattern :- Composite Pattern
    {
        void Validate();
    }

    public interface ICustomer : IBo
    {
        //IValidationStratergy<ICustomer> ValidationType { get; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }
        ICustomer Clone();
        
    }
}
