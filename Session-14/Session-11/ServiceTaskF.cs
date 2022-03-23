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


namespace Session_11
{
    public partial class ServiceTaskF : DevExpress.XtraEditors.XtraForm
    {
        ServiceTask _serviceTask;
        State _state;
        BindingSource _bindingSource;
        
        public ServiceTaskF(State state, ServiceTask serviceTask, BindingSource bindingSource)
        {
            _state = state;
            _bindingSource = bindingSource;
            _serviceTask = serviceTask;
            //{
            //    Code = serviceTask.Code,
            //    Description = serviceTask.Description,
            //    Hours = serviceTask.Hours
            //};
            InitializeComponent();
        }

        private void ServiceTaskF_Load(object sender, EventArgs e)
        {
            bsServiceTasks.DataSource = _serviceTask;
            
            SetDataBindings();
        }
        private void SetDataBindings() {
            ctrlCode.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Code", true));
            ctrlDescription.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Description", true));
            ctrlHours.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Hours", true));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            this.Close();
        }
        private void SaveCustomer()
        {
            if (_state == State.New)
            {
                ((List<ServiceTask>)_bindingSource.DataSource).Add(_serviceTask);

            }
            else
            {
                var editedItemIndex = ((List<ServiceTask>)_bindingSource.DataSource).FindIndex(x => x.ID == _serviceTask.ID);
                ((List<ServiceTask>)_bindingSource.DataSource)[editedItemIndex] = _serviceTask;
            }

        }

    }
}