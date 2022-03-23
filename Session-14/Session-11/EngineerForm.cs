using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class EngineerForm : DevExpress.XtraEditors.XtraForm
    {
        ServiceCenter ServiceCenter = new ServiceCenter();        
        public readonly StorageService storageService = new StorageService();
        public EngineerForm()
        {
            InitializeComponent();
        }
        private void EngineerForm_Load(object sender, EventArgs e)
        {
            LoadData();            
            PopulateControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();                      
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var listOfEngineers = bsServiceCenter.Current as ServiceCenter;
            EngineerEditForm editForm = new EngineerEditForm(listOfEngineers);            
            editForm.ShowDialog();
            grvEngineers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Engineer?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var engineer = bsEngineers.Current as Engineer;
            bsEngineers.Remove(engineer);
            
            SaveData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var listOfEngineers = bsServiceCenter.Current as ServiceCenter;
            var engineer = bsEngineers.Current as Engineer;
            EngineerEditForm editForm = new EngineerEditForm(listOfEngineers, engineer);            
            editForm.ShowDialog();            
            grvEngineers.RefreshData();
        }
        
        private void PopulateControls()
        {
            SetRepManager();

            bsServiceCenter.DataSource = ServiceCenter;
            bsEngineers.DataSource = bsServiceCenter;
            bsEngineers.DataMember = "Engineers";

            grdEngineers.DataSource = bsEngineers;
            
            grvEngineers.RefreshData();            
        }

        private void SetRepManager()
        {
            repManager.DataSource = ServiceCenter.Managers;                        
            repManager.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            
            repManager.DisplayMember = "Name";
            repManager.ValueMember = "ID";            
        }

        private void LoadData()
        {            
            ServiceCenter = storageService.GetSeviceCenter();
        }
        private void SaveData()
        {            
            storageService.SaveServiceCenter(ServiceCenter);
        }
    }
}