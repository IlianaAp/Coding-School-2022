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
    public partial class CarF : DevExpress.XtraEditors.XtraForm
    {

        State _state;
        Car _car;
        BindingSource _bindingSource;

        #region UI

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();

        }

        #endregion



        public CarF(State state, Car car, BindingSource bindingSource)
        {
            _state = state;
            _bindingSource = bindingSource;
            _car = new Car()
            {
                ID = car.ID,
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNumber = car.RegistrationNumber,
            };
            InitializeComponent();
        }

        private void CarF_Load(object sender, EventArgs e)
        {
            populateControls();
            bsCar.DataSource = _car;
            SetDataBindings();

        }


        private void populateControls()
        {
            comboBrand.Properties.Items.Add(Brands.Audi);
            comboBrand.Properties.Items.Add(Brands.Reanult);
            comboBrand.Properties.Items.Add(Brands.Honda);
            comboBrand.Properties.Items.Add(Brands.Mercedes);
            comboBrand.Properties.Items.Add(Brands.Reanult);
            comboBrand.Properties.Items.Add(Brands.Citroen);
            comboBrand.Properties.Items.Add(Brands.Volvo);
            comboBrand.Properties.Items.Add(Brands.Ferrari);
            comboBrand.Properties.Items.Add(Brands.Saab);
            comboBrand.Properties.Items.Add(Brands.Lamborgini);
            comboBrand.Properties.Items.Add(Brands.Mazda);

        }
        private void SetDataBindings()
        {
            ctrlRegNum.DataBindings.Add(new Binding("EditValue", bsCar, "RegistrationNumber", true));
            ctrlModel.DataBindings.Add(new Binding("EditValue", bsCar, "Model", true));
            comboBrand.DataBindings.Add(new Binding("EditValue", bsCar, "Brand", true));
        }
        private void Save()
        {
            if (_state == State.New)
            {
                ((List<Car>)_bindingSource.DataSource).Add(_car);

            }
            else
            {
                var editedItemIndex = ((List<Car>)_bindingSource.DataSource).FindIndex(x => x.ID == _car.ID);
                ((List<Car>)_bindingSource.DataSource)[editedItemIndex] = _car;
            }

        }
    }



}
