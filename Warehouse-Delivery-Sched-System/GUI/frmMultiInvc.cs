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
    public partial class frmMultiInvc : Form
    {
        Class.Connection con = Class.GlobalVars.con;
        public frmMultiInvc()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMultiInvc.Rows)
            {
                DataGridViewCell cellInvc = row.Cells[0];

                if (cellInvc.Value != null)

                    if(con.findInvc(cellInvc.Value.ToString()))
                        MessageBox.Show(cellInvc.Value.ToString() + " Already Added!");
                    else
                        this.Close();
            }
        }
    }
}
