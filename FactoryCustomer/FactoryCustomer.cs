using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICustomerInterface;
using CustomerLibrary;
using Microsoft.Practices.Unity;
using ValidationStratergy;

namespace FactoryCustomer
{
    public static class Factory<AnyType>
    {
        //private static List<ICustomer> customers = null;
        static IUnityContainer container = null;
        
        private static void LoadCustomers()
        {
            /*
            customers = new List<ICustomer>();
            customers.Add(new Lead());
            customers.Add(new Customer());
            */

            container = new UnityContainer();
            container.RegisterType<ICustomer, Customer>("Customer", new InjectionConstructor(new CustomerAllValidation()));
            container.RegisterType<ICustomer, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
        }
                
        public static AnyType Create(string Type)
        {
            /*
            if (customers == null)
            {
                LoadCustomers();
            }
            return customers[CustomerType].Clone();
             * */

            if (container == null)
            {
                LoadCustomers();
            }
            return container.Resolve<AnyType>(Type);
        }

        /*
        public ICustomer Create(int CustomerType)
        {
            if (CustomerType == 0)
            {
                return new Lead();
            }
            else
            {
                return new Customer();
            }
        }
         */
    }
}
