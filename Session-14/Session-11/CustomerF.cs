using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CarServiceCenterLibrary;
using System.IO;
using System.Text.Json;
using Services;

namespace Session_11
{
    public partial class CustomerF : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        Customer _customer;
        State _state;
        BindingSource _bindingSource;
        public CustomerF(State state, Customer customer, BindingSource bindingSource)
        {
            
            _state = state;
            _bindingSource = bindingSource;
            _customer = new Customer()
            {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                TIN = customer.TIN
            };
            InitializeComponent();


        }

        private void CustomerF_Load(object sender, EventArgs e)
        {
            bsCustomers.DataSource = _customer;
            openF.SetDataBindingsCustomers(ctrlName, ctrlSurname, ctrlPhone, ctrlTIN, bsCustomers);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveCustomer()
        {
            if (_state == State.New)
            {
                ((List<Customer>)_bindingSource.DataSource).Add(_customer);
            }
            else
            {
                var editedItemIndex = ((List<Customer>)_bindingSource.DataSource).FindIndex(x => x.ID == _customer.ID);
                ((List<Customer>)_bindingSource.DataSource)[editedItemIndex] = _customer;
            }
        }
    }
}