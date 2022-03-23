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
using System.Text.Json;
using System.IO;
using CarServiceCenterLibrary;
using DevExpress.XtraGrid;
using Services;

namespace Session_11
{
    public partial class ServiceTaskForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();
        public ServiceTaskForm()
        {
            InitializeComponent();
        }
        #region UI
        private void ServiceTaskForm_Load(object sender, EventArgs e)
        {
            serviceCenter = storageService.GetSeviceCenter();                                    
            bsServiceTasks.DataSource = serviceCenter.ServiceTasks;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData(); 
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            serviceCenter.ServiceTasks = bsServiceTasks.DataSource as List<ServiceTask>;
            storageService.SaveServiceCenter(serviceCenter);
            this.Close();
        }
        private void grdServiceTasks_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void NewData()
        {
            var serviceTask = new ServiceTask();
            var editForm = openF.GetForm<ServiceTaskF>(State.New, serviceTask, bsServiceTasks);
            serviceCenter.ServiceTasks = bsServiceTasks.DataSource as List<ServiceTask>;            
            storageService.SaveServiceCenter(serviceCenter);
            editForm.ShowDialog();
            grvServiceTasks.RefreshData();
        }
        private void DeleteData()
        {
            var result = MessageBox.Show("Are you sure that you want to delete this Service Task?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedServiceTask = GetSelectedServiceTask();
                ((List<ServiceTask>)bsServiceTasks.DataSource).Remove(selectedServiceTask);
                grvServiceTasks.RefreshData();
            }
        }
        private void EditData()
        {
            var customer = GetSelectedServiceTask();
            if (customer != null)
            {
                var editForm = openF.GetForm<ServiceTaskF>(State.Edit, customer, bsServiceTasks);
                editForm.ShowDialog();
                grvServiceTasks.RefreshData();

            }
        }
        private ServiceTask? GetSelectedServiceTask()
        {

            var selectedIndexes = grvServiceTasks.GetSelectedRows();
            if (selectedIndexes is not null)
            {
                return grvServiceTasks.GetRow(selectedIndexes[0]) as ServiceTask;
            }
            else
            {
                return null;
            }
        }


    }
}