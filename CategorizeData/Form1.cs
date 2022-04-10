using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategorizeData
{
    public partial class Form1 : Form
    {
        List<string> Customer = new List<string>();



        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            Customer acustomer = new Customer();
            acustomer.FirstName = "Tommy";
            acustomer.LastName = "Han";
            acustomer.Email = "TomH@gmail.com";
            acustomer.ContactStatus = true;
            acustomer.CustomerInterest = true;
            acustomer.CustomerType = "ExistingCustomer";

            Customer bcustomer = new Customer();
            bcustomer.FirstName = "Ralph Raven";
            bcustomer.LastName = "Udasco";
            bcustomer.Email = "Rru@gmail.com";

            Customer ccustomer = new Customer();
            ccustomer.FirstName = "Tanzim";
            ccustomer.LastName = "Haque";
            ccustomer.Email = "TZH@gmail.com";

            Customer dcustomer = new Customer();
            dcustomer.FirstName = "Nishey";
            dcustomer.LastName = "Pirzada";
            dcustomer.Email = "ppzada@gmail.com";

            Customer ecustomer = new Customer();
            ecustomer.FirstName = "Rahul";
            ecustomer.LastName = "Taggar";
            ecustomer.Email = "Taggar@gmail.com";

            Customer fcustomer = new Customer();
            fcustomer.FirstName = "Noah";
            fcustomer.LastName = "Waegeli";
            fcustomer.Email = "NoahW@gmail.com";

            lstCustomers.Items.Add(acustomer);
            lstCustomers.Items.Add(bcustomer);
            lstCustomers.Items.Add(ccustomer);
            lstCustomers.Items.Add(dcustomer);
            lstCustomers.Items.Add(ecustomer);
            lstCustomers.Items.Add(fcustomer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            Customer.Sort();
            bs.ResetBindings(false);
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            Customer.Sort();
            Customer.Reverse();
            bs.ResetBindings(false);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem != null)
            {
                    Customer customer = (Customer) lstCustomers.SelectedItem;
                customer.ContactStatus = rdbContacted.Checked;
                customer.CustomerInterest = rdbInterested.Checked;
                string customerType = String.Empty;
                if (rdbPotentialCustomer.Checked)
                {
                    customerType = "Potential Customer";
                } else if (rdbExistingCustomer.Checked)
                {
                    customerType = "Existing Customer";
                } else
                {
                    customerType = "Lead";
                }
                customer.CustomerType = customerType;
                lstSort.Items.Add(customer);
                /*if (rdbContacted.Checked && rdbInterested.Checked && rdbExistingCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("["+rdbExistingCustomer.Text+"]" + txtName + " is " + rdbInterested.Text.ToUpper() + " and has been " + rdbContacted.Text.ToUpper());
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbContacted.Checked && rdbInterested.Checked && rdbPotentialCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("["+rdbPotentialCustomer.Text+"]" + txtName + " is " + rdbInterested.Text.ToUpper() + " and has been "+ rdbContacted.Text.ToUpper());
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbContacted.Checked && rdbInterested.Checked && rdbLead.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[" + rdbLead.Text + "]" + txtName + " is  " + rdbInterested.Text.ToUpper() + "and has been " + rdbContacted.Text.ToUpper());
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                //-----------------------------------------------------------------------------------------------------
                if (rdbContacted.Checked && rdbNotInterested.Checked && rdbExistingCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("["+rdbExistingCustomer.Text+"]" + txtName + " is " +rdbNotInterested.Text.ToUpper() + "and has been " + rdbContacted.Text.ToUpper());
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);

                }
                else
                if (rdbContacted.Checked && rdbNotInterested.Checked && rdbPotentialCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[" + rdbPotentialCustomer.Text+"]" + txtName + " is " + rdbNotInterested.Text.ToUpper() + "and has been " + rdbContacted.Text.ToUpper());
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbContacted.Checked && rdbNotInterested.Checked && rdbLead.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Lead] " + txtName + " is NOT INTERESTED " + "and has been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                //-----------------------------------------------------------------------------------------------------------
                if (rdbNotContacted.Checked && rdbInterested.Checked && rdbExistingCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Existing Customer] " + txtName + " is INTERESTED " + "and has NOT been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbNotContacted.Checked && rdbInterested.Checked && rdbPotentialCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Potential Customer] " + txtName + " is INTERESTED " + "and has NOT been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbNotContacted.Checked && rdbInterested.Checked && rdbExistingCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Existing Customer] " + txtName + " is INTERESTED " + "and has NOTbeen CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                //------------------------------------------------------------------------------------------------------------
                if (rdbNotContacted.Checked && rdbNotInterested.Checked && rdbPotentialCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Potential Customer] " + txtName + " is NOT INTERESTED " + "and has NOT been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbNotContacted.Checked && rdbNotInterested.Checked && rdbLead.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Lead] " + txtName + " is NOT INTERESTED " + "and has NOT been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                else
                if (rdbNotContacted.Checked && rdbNotInterested.Checked && rdbExistingCustomer.Checked)
                {
                    string txtName = lstCustomers.SelectedItem.ToString();
                    lstSort.Items.Add("[Existing Customer] " + txtName + " is NOT INTERESTED " + "and has NOT been CONTACTED ");
                    lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                }
                */
               

                


            

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
