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

            if (company == "Monheim")
            {
                serverName = "mdiserver";
                dbName = "MONHEIMAPP";
            }
            else if (company == "Maryland" || company == "Rheinland")
            {
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

            Class.GlobalVars.strCompany = company;
        }

        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;

        //--------------------------------------------------------MDISERVER-L - WhseSchedDelSys - TBLOGIN---------------------------------------------------------------
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

        //--------------------------------------------------------MDISERVER - MONHEIMAPP - a_Whse_Delivery_Sched_sys-------------------------------------------------------
        public DataTable filterDGVSched(string city, bool isFiltered)
        {
            connSL.Open();

            if (isFiltered == false || city == "")
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,City FROM a_Whse_Delivery_Sched_sys WHERE InvcNbr IS NOT NULL AND InvcNbr != ''", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else
            {

                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,City FROM a_Whse_Delivery_Sched_sys WHERE CITY = '" + city + "' AND InvcNbr IS NOT NULL AND InvcNbr != '' ORDER BY CancelDate ASC", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }

            connSL.Close();
            return dt;
        }

        public void fillcmbCity(ComboBox cmbCity)
        {
            connOS.Open();

            sda = new SqlDataAdapter("SELECT DISTINCT CITY FROM a_Whse_Delivery_Sched_sys WHERE CITY IS NOT NULL AND CITY != '' AND InvcNbr IS NOT NULL AND InvcNbr != ''", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbCity.Items.Add(row["CITY"].ToString());
            }

            connOS.Close();
        }

        //--------------------------------------------------------MDISERVER - dbOpenShippers - shipvia------------------------------------------------------------------
        public void fillcmbDT(ComboBox cmbDT)
        {
            connOS.Open();

            sda = new SqlDataAdapter("SELECT RTRIM(LTRIM(ShipViaID)) AS ShipViaID FROM shipvia", connOS);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbDT.Items.Add(row["ShipViaID"].ToString());
            }

            connOS.Close();
        }

        string shipDesc;

        public string showLblDT(string shipvia)
        {

            connOS.Open();

            sda = new SqlDataAdapter("SELECT Description FROM shipvia WHERE ShipViaID = '" + shipvia + "' ", connOS);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                shipDesc = row["Description"].ToString();
            }

            connOS.Close();

            return shipDesc;
        }

        //--------------------------------------------------------MDISERVER-L - WhseSchedDelSys - TempInsertTable---------------------------------------------------------------
        public void clearTemp()
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM TempInsertTable", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        int toggle;

        public bool insertToTempTbl(string invcNbr, string shipName, double amt)
        {
            conn.Open();

            toggle = 0;

            sda = new SqlDataAdapter("SELECT InvcNbr from TempInsertTable WHERE InvcNbr = '" + invcNbr + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row != null)
                    {
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        toggle = 1;
                    }
                }
            }
            else
            {
                toggle = 1;
            }

            if (toggle == 1)
            {
                using (cmd = new SqlCommand("INSERT INTO TempInsertTable VALUES(@invcNbr,@shipName,@amt)", conn))
                {
                    cmd.Parameters.AddWithValue("@invcNbr", invcNbr);
                    cmd.Parameters.AddWithValue("@shipName", shipName);
                    cmd.Parameters.AddWithValue("@amt", amt);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            return false;
        }

        public void deleteTempInvcID(string invcNbr)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM TempInsertTable WHERE InvcNbr = '"+ invcNbr +"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //count outlet
        int outCount;
        public int outletCount()
        {
            outCount = 0;

            conn.Open();

            sda = new SqlDataAdapter("SELECT DISTINCT SHIPNAME FROM tempInsertTable", conn);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                outCount++;
            }

            conn.Close();
            return outCount;
        }

    }
}
