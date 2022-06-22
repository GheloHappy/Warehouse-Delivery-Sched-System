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

        DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();

        private void frmViewSum_Load(object sender, EventArgs e)
        {
            dgvSum.Columns.Add(checkCol);
            dgvSumLoad();

            con.fillcmbDT(cmbDT);
            cmbTag.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilter.Text = "";
            cmbFilter.Items.Clear();
            con.fillCmbFilter(cmbFilter, cmbMainFilter.Text);       
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSum.DataSource = null;

            dgvSum.DataSource = con.filterDGVSum(cmbFilter.Text);

            dgvSum.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSum.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateSum();
        }
        string selSchedDate;
        string selDT;

        private void updateSum()
        {
            selSchedDate = dtSchedDate.Value.ToString("M/d/yyyy");
            selDT = cmbDT.Text;

            foreach (DataGridViewRow row in dgvSum.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;


                if (cell.Value != null)
                {
                    if (Convert.ToBoolean(cell.Value) == true)
                    {
                        DataGridViewCell cellInvc = row.Cells[2];

                        con.updateSummary(selDT, selSchedDate, cellInvc.Value.ToString());

                        con.updateSOShipHeader(cellInvc.Value.ToString(), selDT, selSchedDate, cmbTag.Text); //UNCOMMENT FOR LIVE TESTING

                        con.insertLogs("UPDATE:" + selDT + " : " + cellInvc.Value.ToString() + " : " + selSchedDate, DateTime.Now.ToString());
                    }
                }
            }


            dgvSumLoad();

            cmbDT.SelectedIndex = -1;

            MessageBox.Show("Successfully Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvSumLoad()
        {
            dgvSum.DataSource = null;
             
            //dgvSum.Columns.Add(checkCol);
            dgvSum.DataSource = con.fillDGVSum();

            dgvSum.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSum.Columns[4].DefaultCellStyle.Format = "N2";
        }

    }
}
