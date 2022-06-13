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

        string selSchedDate;
        string selDT;
        //bool toggleExistSched;

        public frmDelSched()
        {
            InitializeComponent();
        }

        private void frmDelSched_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            cmbBrgy.Enabled = false;

            lblCompany.Text = Class.GlobalVars.strCompany;

            con.clearTemp();

            dgvLoad();
            dgvSched.DataSource = con.filterDGVSched("", false, false);
            dgvSched.Columns[8].Visible = false;

            cmbLoad();

            dtSchedDate.Value = dtSchedDate.Value.AddDays(1);
        }

        private void cmbDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDT.Text = con.showLblDT(cmbDT.Text);

            //selSchedDate = dtSchedDate.Value.ToString("M/d/yyyy");

            //if (con.checkFillDGVInsert(cmbDT.Text, selSchedDate) == true)
            //{
            //    toggleExistSched = true;

            //    clearDGVInsert();

            //    dgvInsertDel.DataSource = con.fillDGVInsertExist(cmbDT.Text, selSchedDate);
            //}
            //else
            //{
            //    toggleExistSched = false;

            //    clearDGVInsert();

            //                    dgvInsertDel.Columns.Add("shipName", "Ship To");
            //                    dgvInsertDel.Columns.Add("invcNbr", "Invoice #");
            //                    dgvInsertDel.Columns.Add("Amount", "Amount");
            //}
        }

        private void clearDGVInsert()
        {
            dgvInsertDel.DataSource = null;
            dgvInsertDel.Rows.Clear();
            dgvInsertDel.Columns.Clear();
            con.clearTemp();
            updateTotal();
            updateOutletCount();
            updatePerCaseCount();
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

            columnFormat();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvLoad();

            dgvSched.DataSource = con.filterDGVSched("",false,false);
            dgvSched.Columns[8].Visible = false;
            cmbCity.SelectedIndex = -1;
            cmbBrgy.SelectedIndex = -1;

            cmbBrgy.Enabled = false;
            chkbSelectAll.Checked = false;

            columnFormat();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            chkDGV();

            updateOutletCount();
            updatePerCaseCount();

            updateTotal();

            clearCheckedDGv();
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
                        DataGridViewCell cellPerCase = row.Cells[8];

                        row.DefaultCellStyle.BackColor = Color.Red;

                        if (con.insertToTempTbl(cellInvc.Value.ToString(), cellShipID.Value.ToString(), Convert.ToDouble(cellAmt.Value), Int32.Parse(cellPerCase.Value.ToString())) == true)
                        {
                            MessageBox.Show("Invoice - " + cellInvc.Value.ToString().Trim() + " Already added.");
                        }
                        else
                        {
                            //if (toggleExistSched == true)
                            //{
                            //    clearDGVInsert();

                            //    dgvInsertDel.Columns.Add("shipName", "Ship To");
                            //    dgvInsertDel.Columns.Add("invcNbr", "Invoice #");
                            //    dgvInsertDel.Columns.Add("Amount", "Amount");

                            //    dgvInsertDel.Rows.Add(cellShipID.Value, cellInvc.Value, cellAmt.Value);
                            //    dgvInsertDel.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            //    dgvInsertDel.Columns[2].DefaultCellStyle.Format = "N2";

                            //    toggleExistSched = false;
                            //}
                            //else
                            //{
                            dgvInsertDel.Rows.Add(cellShipID.Value, cellInvc.Value, cellAmt.Value);
                            dgvInsertDel.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvInsertDel.Columns[2].DefaultCellStyle.Format = "N2";
                            //}        
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
            dgvSched.DataSource = con.filterDGVSched(cmbCity.Text, true,false);
            dgvSched.Columns[8].Visible = false;
            columnFormat();
            cmbBrgy.Enabled = true;

            cmbBrgy.Items.Clear();
            cmbBrgy.Text = "";
            con.fillCmbBrgy(cmbBrgy, cmbCity.Text);
            cmbBrgy.SelectedIndex = -1;
        }

        private void dgvInsertDel_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInsertDel.SelectedRows)
            {            
                con.deleteTempInvcID(row.Cells[1].Value.ToString());             
            }
        }
        private void dgvInsertDel_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateTotal();
            updateOutletCount();
            updatePerCaseCount();
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
                clearCheckedDGv();
            }
        }

        private void clearCheckedDGv()
        {
            foreach (DataGridViewRow row in this.dgvSched.Rows)
            {
                row.Cells[0].Value = row.Cells[0].Value = false ? true : false;
            }

            chkbSelectAll.Checked = false;
        }

        DataGridViewColumn columnStatus;
        DataGridViewColumn columnCheck;



        private void columnFormat()
        {
            dgvSched.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSched.Columns[4].DefaultCellStyle.Format = "N2";

            columnCheck = dgvSched.Columns[0];
            columnStatus = dgvSched.Columns[5];
            columnCheck.Width = 30;
            columnStatus.Width = 40;
        }

        private void updateTotal()
        {
            double total = dgvInsertDel.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[2].Value));

            lblSum.Text = total.ToString("C2");     
        }

        private void updateOutletCount()
        {
            lblOutCount.Text = con.outletCount().ToString();

            if (Convert.ToInt32(lblOutCount.Text) >= 5)
            {
                lblOutCount.ForeColor = Color.Red;

                //MessageBox.Show("You are exceeding the maximum Outlet Count of 4.", "Warning!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblOutCount.ForeColor = Color.YellowGreen;
            }      
        }

        private void updatePerCaseCount()
        {
            lblPerCase.Text = con.itemPerCaseCount().ToString();
        }


        //insert summary 

        DialogResult countResult;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbDT.Text == "")
            {
                MessageBox.Show("Please Select DT", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dgvInsertDel.Rows.Count == 0)
                {
                    MessageBox.Show("Please Select Customer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (Convert.ToInt32(lblOutCount.Text) >= 5)
                    {
                        countResult = MessageBox.Show("You are exceeding the maximum Outlet Count of 4.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (countResult == DialogResult.OK)
                        {
                            insertSum();
                        }
                    }
                    else
                    {
                        insertSum();
                    }
                }
            }
        }

        private void insertSum()
        {
            selSchedDate = dtSchedDate.Value.ToString("M/d/yyyy");
            selDT = cmbDT.Text;

            foreach (DataGridViewRow row in dgvInsertDel.Rows)
            {
                DataGridViewCell cellInvc = row.Cells[1];
                DataGridViewCell cellShipID = row.Cells[0];
                DataGridViewCell cellAmt = row.Cells[2];


                if (con.insertSummary(selDT, cellInvc.Value.ToString(), cellShipID.Value.ToString(), Convert.ToDouble(cellAmt.Value), selSchedDate) == true)
                {
                    //MessageBox.Show("Invoice - " + cellInvc.Value.ToString().Trim() + " Already Scheduled.");
                    countResult = MessageBox.Show("Invoice - " + cellInvc.Value.ToString().Trim() + " is Already Scheduled on " +
                        selSchedDate + " - " + cellShipID.Value.ToString().Trim() + ". Do you want to update DT?", 
                        "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    
                    if (countResult == DialogResult.Yes)
                    {
                        con.updateSummary(selDT, selSchedDate, cellInvc.Value.ToString());                      
                    }      
                }
                //con.updateSOShipHeader(cellInvc.Value.ToString(), selDT, selSchedDate); //UNCOMMENT FOR LIVE TESTING
            }

            clearCheckedDGv();

            dgvLoad();

            dgvSched.DataSource = con.filterDGVSched("", false,false);
            dgvSched.Columns[8].Visible = false;
            cmbCity.SelectedIndex = -1;
            cmbDT.SelectedIndex = -1;
            cmbBrgy.SelectedIndex = -1;
            cmbBrgy.Enabled = false;

            chkbSelectAll.Checked = false;

            columnFormat();

            dgvInsertDel.Rows.Clear();
            con.clearTemp();
            updateTotal();
            updateOutletCount();
            updatePerCaseCount();

            dgvSched.DefaultCellStyle.BackColor = Color.Empty;

            MessageBox.Show("Schedule Successfully Created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnViewSum_Click(object sender, EventArgs e)
        {
            GUI.frmViewSum form2 = new GUI.frmViewSum();
            form2.ShowDialog();
        }

        private void cmbBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvLoad();
            dgvSched.DataSource = con.filterDGVSched(cmbBrgy.Text, true, true);
            dgvSched.Columns[8].Visible = false;
            columnFormat();
        }
    }
}
