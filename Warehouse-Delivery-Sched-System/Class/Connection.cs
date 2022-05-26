using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Warehouse_Delivery_Sched_System.Class
{
    internal class Connection
    {
        SqlConnection connSL = new SqlConnection();
        SqlConnection conn = new SqlConnection();
        SqlConnection connOS = new SqlConnection();


        string conSL;
        string conDashL;
        string conOpenShip;

        string serverName;
        string dbName;

        public void sqlCon(string company)
        {

            if (company == "Monheim") {
                serverName = "mdiserver";
                dbName = "MONHEIMAPP";
            }
            else if(company == "Maryland" || company == "Rheinland") {
                serverName = "solomon";
                dbName = "MLDIAPP";
            }
            else if (company == "Centro Maryland")
            {
                serverName = "cmdiserver";
                dbName = "CENTROAPP";
            }

            conSL = "server=" + serverName + ";user id=" + "sa" + ";password=" + "Passw0rd" + ";database=" + dbName;
            connSL = new SqlConnection(conSL);

            conDashL = "server=" + "mdiserver-l" + ";user id=" + "sa" + ";password=" + "Passw0rd" + ";database=" + "WhseSchedDelSys";
            conn = new SqlConnection(conDashL);

            conOpenShip = "server=" + "mdiserver" + ";user id=" + "sa" + ";password=" + "Passw0rd" + ";database=" + "dbOpenShippers";
            connOS = new SqlConnection(conOpenShip);
        }

        SqlDataAdapter sda;
        DataTable dt;
        //SqlCommand cmd;

        public bool loginVal(string usr, string pass)
        {
            conn.Open();

            sda = new SqlDataAdapter("SELECT USERID FROM TBLOGIN WHERE USERNAME = '" + usr + "' AND PASSWORD = '" + pass + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row != null)
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();

            return false;
        }

        public void fillDGVSched(GUI.frmDelSched delSched)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT * FROM a_Whse_Delivery_Sched_sys WHERE InvcNbr IS NOT NULL", connSL);
            dt = new DataTable(); 
            sda.Fill(dt);

            delSched.dgvSched.DataSource = dt;

            connSL.Close();
        }


        public void fillcmbDT(GUI.frmDelSched delSched)
        {
            connOS.Open();

            sda = new SqlDataAdapter("SELECT RTRIM(LTRIM(ShipViaID)) AS ShipViaID FROM shipvia", connOS);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                delSched.cmbDT.Items.Add(row["ShipViaID"].ToString());
            }

            connOS.Close();
        }
    }
}
