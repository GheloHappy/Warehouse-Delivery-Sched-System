using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Delivery_Sched_System.GUI
{
    public partial class frmViewSum : Form
    {
        Class.Connection con = Class.GlobalVars.con;
        public frmViewSum()
        {
            InitializeComponent();
        }

        private void frmViewSum_Load(object sender, EventArgs e)
        {
            dgvSum.DataSource = con.fillDGVSum();

            dgvSum.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            con.fillCmbFilter(cmbFilter, cmbMainFilter.Text);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSum.DataSource = null;

            dgvSum.DataSource = con.filterDGVSum(cmbFilter.Text);

            dgvSum.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSum.Columns[3].DefaultCellStyle.Format = "N2";
        }
    }
}
