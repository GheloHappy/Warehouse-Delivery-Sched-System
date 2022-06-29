using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Delivery_Sched_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Class.Connection con = new Class.Connection();

        Class.Connection con = Class.GlobalVars.con;

        int X, Y;
        System.Drawing.Point newPoint = new System.Drawing.Point();


        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            txtUsrName.Text = "username";
            txtUsrName.ForeColor = Color.DarkGray;
            txtPass.Text = "password";
            txtPass.ForeColor = Color.DarkGray;

            cmbCompany.Items.Add("Monheim");
            cmbCompany.Items.Add("Maryland");
            cmbCompany.Items.Add("Rheinland");
            cmbCompany.Items.Add("Centro Maryland");
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }
        private void txtUsrName_Click(object sender, EventArgs e)
        {
            txtUsrName.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.sqlCon(cmbCompany.Text);

            if (con.loginVal(txtUsrName.Text, txtPass.Text) == true && cmbCompany.Text != "")
            {
                Class.GlobalVars.strUserName = txtUsrName.Text;

                con.insertLogs("LOGIN", DateTime.Now.ToString());

                GUI.frmDelSched form2 = new GUI.frmDelSched();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!, Check username and password or select Company");
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            X = Control.MousePosition.X - this.Location.X;
            Y = Control.MousePosition.Y - this.Location.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newPoint = Control.MousePosition;
                newPoint.X -= (X);
                newPoint.Y -= (Y);
                this.Location = newPoint;
            }

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
        }

        private void txtUsrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsrName.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
