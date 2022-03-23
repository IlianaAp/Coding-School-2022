using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public enum State { New, Edit }
    public partial class ManagerEditForm : DevExpress.XtraEditors.XtraForm
    {
        Manager _manager;
        State _state;
        BindingSource _bindingSource;
        public ManagerEditForm(State state, Manager manager, BindingSource bindingSource)
        {
            _state = state;
            _bindingSource = bindingSource;
            _manager = new Manager()
            {
                ID = manager.ID,
                Name = manager.Name,
                Surname = manager.Surname,
                SallaryPerMonth = manager.SallaryPerMonth,
            };

            InitializeComponent();
        }

        private void ManagerEditForm_Load(object sender, EventArgs e)
        {
            managerBindingSource.DataSource = _manager;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveManager();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveManager()
        {
            if (_state == State.New)
            {
                ((List<Manager>)_bindingSource.DataSource).Add(_manager);

            }
            else
            {
                var editedItemIndex = ((List<Manager>)_bindingSource.DataSource).FindIndex(x => x.ID == _manager.ID);
                ((List<Manager>)_bindingSource.DataSource)[editedItemIndex] = _manager;
            }

        }

    }
}