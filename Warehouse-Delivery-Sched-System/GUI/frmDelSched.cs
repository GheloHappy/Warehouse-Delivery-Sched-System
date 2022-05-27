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

            con.clearTemp();

            dgvLoad();
            dgvSched.DataSource = con.filterDGVSched("",false);           

            cmbLoad();
        }

        private void cmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDT.Text = con.showLblDT(cmbDT.Text);
        }

        DataGridViewCheckBoxColumn schedCol = new DataGridViewCheckBoxColumn();
        private void dgvLoad()
        {
            dgvSched.DataSource = null;
            dgvSched.Rows.Clear();
            dgvSched.Columns.Clear();       
            dgvSched.Columns.Add(schedCol); 
        }

        private void cmbLoad()
        {
            con.fillcmbCity(cmbCity);
            con.fillcmbDT(cmbDT);

            dgvSched.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSched.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvLoad();

            dgvSched.DataSource = con.filterDGVSched("",false);
            cmbCity.SelectedIndex = -1;

            chkbSelectAll.Checked = false;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            chkDGV();

            updateTotal();

            dgvSched.FirstDisplayedCell = null;
            dgvSched.ClearSelection();
        }
        private void chkDGV()
        {
            foreach (DataGridViewRow row in dgvSched.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;                

                if (cell.Value != null)
                {
                    if(Convert.ToBoolean(cell.Value) == true)
                    {
                        DataGridViewCell cellInvc = row.Cells[1];
                        DataGridViewCell cellShipID = row.Cells[2];
                        DataGridViewCell cellAmt = row.Cells[4];

                        if (con.insertToTempTbl(cellInvc.Value.ToString(), cellShipID.Value.ToString(), Convert.ToDouble(cellAmt.Value)) == true)
                        {
                            MessageBox.Show("Invoice - " + cellInvc.Value.ToString().Trim() + " Already added.");
                        }
                        else
                        {
                            dgvInsertDel.Rows.Add(cellShipID.Value, cellInvc.Value, cellAmt.Value);
                            dgvInsertDel.Columns[2].DefaultCellStyle.Format = "N2";
                        }
                    }                    
                }

            }
        }

        private void frmDelSched_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLoad();
            dgvSched.DataSource = con.filterDGVSched(cmbCity.Text, true);
            dgvSched.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSched.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void dgvInsertDel_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInsertDel.SelectedRows)
            {            
                con.deleteTempInvcID(row.Cells[1].Value.ToString());             
            }
        }

        private void chkbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSelectAll.Checked)
            {
                foreach (DataGridViewRow row in this.dgvSched.Rows)
                {
                    row.Cells[0].Value = row.Cells[0].Value = false ? true : true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in this.dgvSched.Rows)
                {
                    row.Cells[0].Value = row.Cells[0].Value = false ? true : false;
                }
            }
        }

        private void updateTotal()
        {
            double total = dgvInsertDel.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[2].Value));

            lblSum.Text = total.ToString("C2");
        }

        private void dgvInsertDel_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateTotal();
        }
    }
}
