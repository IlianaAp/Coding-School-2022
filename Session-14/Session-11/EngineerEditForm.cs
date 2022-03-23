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
    public partial class EngineerEditForm : DevExpress.XtraEditors.XtraForm
    {        
        public readonly StorageService storageService = new StorageService();
        public ServiceCenter ServiceCenter;
        private Engineer _engineer;
        private Engineer _engineerBackup;
        private bool pressedNew = false;

        public EngineerEditForm()
        {
            InitializeComponent();
        }

        public EngineerEditForm(ServiceCenter listOfEngineers)
        {
            ServiceCenter = listOfEngineers;                 
            InitializeComponent();
        }

        public EngineerEditForm(ServiceCenter listOfEngineers, Engineer engineer)
        {
            _engineer = engineer;
            ServiceCenter = listOfEngineers;            
            InitializeComponent();
        }

        private void EngineerEditForm_Load(object sender, EventArgs e)
        {
            if (_engineer != null)
            {
                _engineerBackup = new Engineer
                {
                    ID = _engineer.ID,
                    Name = _engineer.Name,
                    Surname = _engineer.Surname,
                    ManagerID = _engineer.ManagerID,
                    SallaryPerMonth = _engineer.SallaryPerMonth,
                };                
            }
            
            PopulateEngineers();
            SetDataBindings();
            
        }                                      

        private void btnSave_Click(object sender, EventArgs e)
        {
            storageService.SaveServiceCenter(ServiceCenter);            
            DialogResult = DialogResult.OK;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pressedNew)
            {
                ServiceCenter.Engineers.Remove(_engineer);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                int index = ServiceCenter.Engineers.IndexOf(_engineer);

                ServiceCenter.Engineers.RemoveAt(index);
                ServiceCenter.Engineers.Insert(index, _engineerBackup);

                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void PopulateEngineers()
        {
            SetCtrlManager();

            if (_engineer == null)
            {
                pressedNew = true;
                _engineer = new Engineer();
                ServiceCenter.Engineers.Add(_engineer);
                bsEngineers.DataSource = _engineer;
            }
            bsEngineers.DataSource = _engineer;
        }

        private void SetCtrlManager()
        {
            ctrlManager.Properties.DataSource = ServiceCenter.Managers;
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlManager.Properties.DisplayMember = "Name";
            ctrlManager.Properties.ValueMember = "ID";
        }

        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsEngineers, "Name", true));
            ctrlSurname.DataBindings.Add(new Binding("EditValue", bsEngineers, "Surname", true));
            ctrlManager.DataBindings.Add(new Binding("EditValue", bsEngineers, "ManagerID", true));
            ctrlSallary.DataBindings.Add(new Binding("EditValue", bsEngineers, "SallaryPerMonth", true));
        }
    }
}