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
    public partial class frmViewItems : Form
    {
        Class.Connection con = Class.GlobalVars.con;
        public frmViewItems()
        {
            InitializeComponent();
        }

        private void frmViewItems_Load(object sender, EventArgs e)
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = con.fillItemList();

            dgvItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void frmViewItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.clerTempItems();
        }
    }
}
