using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Session_11
{
    public partial class CarForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();

        public CarForm()
        {
            InitializeComponent();      
        }
        private void CarForm_Load(object sender, EventArgs e)
        {
            serviceCenter = storageService.GetSeviceCenter();
            bsCar.DataSource = serviceCenter.Cars;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
            
        }

        private void NewData()
        {

            var car = new Car();
            var editForm = openF.GetForm<CarF>(State.New, car, bsCar);
            serviceCenter.Cars = bsCar.DataSource as List<Car>;
            storageService.SaveServiceCenter(serviceCenter);

            editForm.ShowDialog();
            grvCars.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            
        }

        private void DeleteData()
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Car?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                var selectedCar = GetSelectedCar();
                ((List<Car>)bsCar.DataSource).Remove(selectedCar);
                grvCars.RefreshData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditaData();
        }

        private void EditaData()
        {
            var car = GetSelectedCar();
            if (car != null)
            {
                var editForm = openF.GetForm<CarF>(State.Edit, car, bsCar);
                editForm.ShowDialog();
                grvCars.RefreshData();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serviceCenter.Cars = bsCar.DataSource as List<Car>;
            storageService.SaveServiceCenter(serviceCenter);
            this.Close();
        }
        private void EditData()
        {
            var car = GetSelectedCar();
            if (car != null)
            {
                var editForm = openF.GetForm<CarF>(State.Edit, car, bsCar);
                editForm.ShowDialog();
                grvCars.RefreshData();

            }
        }
        private Car? GetSelectedCar()
        {
            var selectedIndexes = grvCars.GetSelectedRows();
            if (selectedIndexes != null)
            {
                return grvCars.GetRow(selectedIndexes[0]) as Car;
            }
            else { return null; }   
               
        }



    }
}