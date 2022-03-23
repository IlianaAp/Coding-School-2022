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

namespace Session_11
{
    public partial class MonthlyLedgerForm : DevExpress.XtraEditors.XtraForm
    {
        public MonthlyLedgerForm()
        {
            InitializeComponent();
        }

        private void MonthlyLedgerForm_Load(object sender, EventArgs e)
        {
            PopulateYear();
            PopulateMonth();
        }
        private void PopulateYear()
        {
            comboYear.Properties.Items.Add(2021);
            comboYear.Properties.Items.Add(2022);
            comboYear.Properties.Items.Add(2023);
            comboYear.Properties.Items.Add(2024);
            comboYear.Properties.Items.Add(2025);
            
        }
        private void PopulateMonth()
        {
            comboMonth.Properties.Items.Add(Month.January);
            comboMonth.Properties.Items.Add(Month.February);
            comboMonth.Properties.Items.Add(Month.March);
            comboMonth.Properties.Items.Add(Month.April);
            comboMonth.Properties.Items.Add(Month.May);
            comboMonth.Properties.Items.Add(Month.June);
            comboMonth.Properties.Items.Add(Month.July);
            comboMonth.Properties.Items.Add(Month.August);
            comboMonth.Properties.Items.Add(Month.September);
            comboMonth.Properties.Items.Add(Month.October);
            comboMonth.Properties.Items.Add(Month.November);
            comboMonth.Properties.Items.Add(Month.December);

        }
    }
}