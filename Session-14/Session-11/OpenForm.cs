using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using CarServiceCenterLibrary;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using Services;

namespace Session_11
{
    public class OpenForm
    {
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();
        
        
        public OpenForm()
        {

        }
        public void Open<T>() where T : Form, new()
        {
            var form = new T();
            form.Show();
        }
        public T GetForm<T>(params object[] prms) where T : Form
        {
             return (T)Activator.CreateInstance(typeof(T),prms);
        }

        public void SetDataBindingsCustomers(TextEdit name, TextEdit surname, TextEdit phone, TextEdit tin, BindingSource customer)
        {

            name.DataBindings.Add(new Binding("EditValue", customer, "Name", true));
            surname.DataBindings.Add(new Binding("EditValue", customer, "Surname", true));
            phone.DataBindings.Add(new Binding("EditValue", customer, "Phone", true));
            tin.DataBindings.Add(new Binding("EditValue", customer, "TIN", true));

        }

        public void PopulateCustomer(RepositoryItemLookUpEdit lookup)
        {
            
            serviceCenter = storageService.GetSeviceCenter();
            var customer = new List<Customer>();

            foreach (var item in serviceCenter.Customers)
                customer.Add(item);
            lookup.DataSource = customer;
            lookup.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            lookup.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            lookup.DisplayMember = "Surname";
            lookup.ValueMember = "ID";
        }
        public void PopulateCar(RepositoryItemLookUpEdit lookup)
        {
            serviceCenter = storageService.GetSeviceCenter();
            var car = serviceCenter.Cars;
            lookup.DataSource = car;
            lookup.Columns.Add(new LookUpColumnInfo("Brand", "Brand"));
            lookup.Columns.Add(new LookUpColumnInfo("Model", "Model"));
            lookup.DisplayMember = "Brand";
            lookup.ValueMember = "ID";
        }
        public void PopulateManager(RepositoryItemLookUpEdit lookup)
        {
            serviceCenter = storageService.GetSeviceCenter();
            var manager = serviceCenter.Managers;
            lookup.DataSource = manager;
            lookup.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            lookup.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            lookup.DisplayMember = "Surname";
            lookup.ValueMember = "ID";
        }
        
    }
}
