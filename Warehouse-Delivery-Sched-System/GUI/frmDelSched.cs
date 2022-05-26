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

            lblCompany.Text = Class.GlobalVars.strCompany;

            dgvLoad();
            cmbLoad();
        }

        private void cmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDT.Text = con.showLblDT(cmbDT.Text);
        }

        private void dgvLoad()
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            dgvSched.Columns.Add(col);
            dgvSched.DataSource = con.fillDGVSched();
            dgvSched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbLoad()
        {
            con.fillcmbCity(cmbCity);
            con.fillcmbDT(cmbDT);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvSched.DataSource = con.filterDGVSched(cmbCity.Text);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            chkDGV();
            double total = dgvInsertDel.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[2].Value));

            lblSum.Text = total.ToString("C2");

            dgvSched.FirstDisplayedCell = null;
            dgvSched.ClearSelection();
        }
        private void chkDGV()
        {
            foreach (DataGridViewRow row in dgvSched.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                DataGridViewCell cellInvc = row.Cells[1];
                DataGridViewCell cellShipID = row.Cells[4];
                DataGridViewCell cellAmt = row.Cells[7];

                if (cell.Value != null)
                {
                    //if (dgvInsertDel.Rows.Count == 0)
                    //{
                        dgvInsertDel.Rows.Add(cellShipID.Value, cellInvc.Value, cellAmt.Value);
                    //}
                    //else
                    //{
                        //Need to change to sql for proper checking
                        //foreach (DataGridViewRow rowIns in dgvInsertDel.Rows)
                        //{
                        //    DataGridViewCell cellInsInvc = rowIns.Cells[1];

                        //    if (cellInsInvc.Value != cellInvc.Value)
                        //    {   
                        //        dgvInsertDel.Rows.Add(cellShipID.Value, cellInvc.Value, cellAmt.Value);
                        //    }

                        //}
                    //}                
                }

            }
        }

        private void frmDelSched_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
