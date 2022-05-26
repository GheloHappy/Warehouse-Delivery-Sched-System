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
    public partial class frmDelSched : Form
    {
        Class.Connection con = Class.GlobalVars.con;
        public frmDelSched()
        {
            InitializeComponent();
        }

        private void frmDelSched_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            con.fillDGVSched(this);
            con.fillcmbDT(this); //to change to best practice use arrray

            //this.dgvSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmDelSched_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
