using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerLibrary;
using ICustomerInterface;
using FactoryCustomer;

namespace WindowsCustomerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            /*
            ICustomer icust = null;
            ICustomer icustnew = null;
            icust = Factory<ICustomer>.Create("Lead");

            icust.CustomerName = "Shiv";
            icust.Address = txtAddress.Text;
            icust.PhoneNumber = txtPhoneNumber.Text;
            icust.Validate();
            icustnew = Factory<ICustomer>.Create("Lead"); //如果什麼都不做，執行後跟icust會一樣，因此使用MemberwiseClone();
            //icust.BillDate = Convert.ToDateTime(txtBillingDate.Text);
            //icust.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
            */
            try
            {
                ICustomer icust = null;
                icust = Factory<ICustomer>.Create(cmbCustomerType.Text);

                // Set all values
                icust.CustomerName = txtCustomerName.Text;
                icust.Address = txtAddress.Text;
                icust.PhoneNumber = txtPhoneNumber.Text;
                icust.BillDate = Convert.ToDateTime(txtBillingDate.Text);
                icust.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
                
                // Call validate method
                icust.Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
