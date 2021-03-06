using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

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

            conSL = $"server={serverName};user id=sa;password=Passw0rd;database={dbName}";
            connSL = new SqlConnection(conSL);

            conDashL = "server=mdiserver-l;user id=sa;password=Passw0rd;database=WhseSchedDelSys";
            conn = new SqlConnection(conDashL);

            conOpenShip = "server=mdiserver;user id=sa;password=Passw0rd;database=dbOpenShippers";
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
        //public DataTable filterDGVSched(string strFilter, bool isFiltered, bool isFilteredBrgy,bool isFilteredInvc, string invcNbr)
        public DataTable filterDGVSched(string strFilterType, string strFilter)
        {
            connSL.Open();

            if (strFilterType == "INVC")
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,Status,City,BARANGAY,QtyInCase FROM a_Whse_Delivery_Sched_sys WHERE InvcNbr = '" + strFilter + "' ORDER BY CancelDate ASC", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (strFilterType == "CUST")
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,Status,City,BARANGAY,QtyInCase FROM a_Whse_Delivery_Sched_sys WHERE custID = '" + strFilter + "' ORDER BY CancelDate ASC", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (strFilterType == "ALL")
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,Status,City,BARANGAY,QtyInCase FROM a_Whse_Delivery_Sched_sys", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }
            else if (strFilterType == "BRGY")
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,Status,City,BARANGAY,QtyInCase FROM a_Whse_Delivery_Sched_sys WHERE BARANGAY = '" + strFilter + "' ORDER BY CancelDate ASC", connSL);
                dt = new DataTable();
                sda.Fill(dt);
            }      
            else
            {
                sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,CancelDate,Amount,Status,City,BARANGAY,QtyInCase FROM a_Whse_Delivery_Sched_sys WHERE CITY = '" + strFilter + "' ORDER BY CancelDate ASC", connSL);
                dt = new DataTable();
                sda.Fill(dt);              
            }

            connSL.Close();
            return dt;
        }

        public void fillcmbCity(ComboBox cmbCity)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT DISTINCT CITY FROM a_Whse_Delivery_Sched_sys WHERE CITY IS NOT NULL AND CITY != ''", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbCity.Items.Add(row["CITY"].ToString());
            }

            connSL.Close();
        }

        public void fillCmbBrgy(ComboBox cmbBrgy,string city)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT DISTINCT Barangay FROM a_Whse_Delivery_Sched_sys WHERE CITY IS NOT NULL AND CITY != '' AND City = '"+ city+"'", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbBrgy.Items.Add(row["Barangay"].ToString());
            }

            connSL.Close();
        }

        public void fillcmbInvc(ComboBox cmbInv)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT LTRIM(RTRIM(InvcNbr)) AS InvcNbr FROM a_Whse_Delivery_Sched_sys", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbInv.Items.Add(row["InvcNbr"].ToString());
            }

            connSL.Close();
        }
        public void fillcmbCust(ComboBox cmbCUst)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT DISTINCT CustID FROM a_Whse_Delivery_Sched_sys", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmbCUst.Items.Add(row["CustID"].ToString());
            }

            connSL.Close();
        }

        //Update SOShipHeader when Live
        public void updateSOShipHeader(string invcNbr, string shipvia,string ordDate,string tag)
        {
            connSL.Open();

            if (tag == "IN-TRANSIT")
                tag = "IT";
            else
                tag = "OF";

            using (cmd = new SqlCommand("UPDATE SOShipheader set User8=@tag,orddate=@ordDate,shipviaid=@shipvia WHERE invcnbr='" + invcNbr +"'", connSL))
                cmd.Parameters.AddWithValue("@ordDate", ordDate);
                cmd.Parameters.AddWithValue("@shipvia", shipvia);
                cmd.Parameters.AddWithValue("@tag", tag);
                cmd.ExecuteNonQuery();

            connSL.Close();
        }


        //Insert per item in temptable -----------------frmItemList

        //public int itemIndex = 0;
        public void showItemsSelected(string invcNbr)
        {
            connSL.Open();
            conn.Open();
            sda = new SqlDataAdapter("SELECT InvtID,Descr,QtyInCase FROM a_Open_Delivered_Invoices WHERE InvcNbr ='" + invcNbr + "'", connSL);
            dt = new DataTable();
            sda.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                using (cmd = new SqlCommand("INSERT INTO TempInsertTableItems VALUES(@InvtID,@Descr,@QtyInCase)", conn))
                    cmd.Parameters.AddWithValue("@InvtID", row["InvtID"].ToString());
                    cmd.Parameters.AddWithValue("@Descr", row["Descr"].ToString());
                    cmd.Parameters.AddWithValue("@QtyInCase", row["QtyInCase"].ToString());
                    cmd.ExecuteNonQuery();
            }

            conn.Close();
            connSL.Close();
        }

        public DataTable fillItemList()
        {
            conn.Open();
            sda = new SqlDataAdapter("SELECT InvtID,Descr,Qty FROM ItemList ORDER BY QTY DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);

            conn.Close();
            return dt;
        }

        public void clerTempItems()
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM TempInsertTableItems", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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

        string lblshipVia;
        public string showLblShipvia(string invc)
        {

            connSL.Open();

            sda = new SqlDataAdapter("SELECT ShipviaID FROM SOSHIPHEADER WHERE InvcNbr = '" + invc + "' ", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                lblshipVia = row["ShipviaID"].ToString();
            }

            connSL.Close();

            return lblshipVia;
        }

        //--------------------------------------------------------MDISERVER-L - WhseSchedDelSys - TempInsertTable---------------------------------------------------------------
        public void clearTemp()
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM TempInsertTable", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //----------------------------------MULTI INVOICE
        public bool findInvc(string invcNbr)
        {
            connSL.Open();

            sda = new SqlDataAdapter("SELECT LTRIM(RTRIM(ShipName)) As ShipName,LTRIM(RTRIM(InvcNbr)) AS InvcNbr," +
                "Amount,QtyInCase FROM a_Whse_Delivery_Sched_sys WHERE InvcNbr = '" + invcNbr + "'", connSL);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row != null)
                {
                    insertToTempTbl(row["InvcNbr"].ToString(), row["ShipName"].ToString(), Convert.ToDouble(row["Amount"].ToString()), Int32.Parse(row["QtyInCase"].ToString()));
                }
            }

            connSL.Close();
            return false;
        }

        int toggle;

        public bool insertToTempTbl(string invcNbr, string shipName, double amt, int QtyInCase)
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
                using (cmd = new SqlCommand("INSERT INTO TempInsertTable VALUES(@invcNbr,@shipName,@amt,@QtyInCase)", conn))
                    cmd.Parameters.AddWithValue("@invcNbr", invcNbr);
                    cmd.Parameters.AddWithValue("@shipName", shipName);
                    cmd.Parameters.AddWithValue("@amt", amt);
                    cmd.Parameters.AddWithValue("@QtyInCase", QtyInCase);
                    cmd.ExecuteNonQuery();
            }
            conn.Close();
            return false;
        }

        public DataTable filldgvInsertDel()
        {
            conn.Open();

            sda = new SqlDataAdapter("SELECT InvcNbr,ShipName,Amount FROM TempInsertTable", conn);
            dt = new DataTable();
            sda.Fill(dt);

            conn.Close();
            return dt;
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

        int caseCount;

        //count Item Per Case
        public int itemPerCaseCount()
        {
            caseCount = 0;

            conn.Open();

            sda = new SqlDataAdapter("SELECT QtyInCase FROM tempInsertTable", conn);
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                caseCount =  caseCount + Int32.Parse(row["QtyInCase"].ToString()) ;
            }

            conn.Close();
            return caseCount;
        }

        bool insSumToggle;

        //insert function
        public bool insertSummary(string shipVia,string invcNbr, string shipName, double amt, string date)
        {
            conn.Open();

            insSumToggle = false;

            sda = new SqlDataAdapter("SELECT InvcNbr from Summary WHERE InvcNbr = '" + invcNbr + "'", conn);
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
                        insSumToggle = true;
                    }
                }
            }
            else
            {
                insSumToggle = true;
            }

            if (insSumToggle == true)
            {
                using (cmd = new SqlCommand("INSERT INTO Summary VALUES(@shipVia,@invcNbr,@shipName,@amt,@schedDate)", conn))
                    cmd.Parameters.AddWithValue("@shipVia", shipVia);
                    cmd.Parameters.AddWithValue("@invcNbr", invcNbr);
                    cmd.Parameters.AddWithValue("@shipName", shipName);
                    cmd.Parameters.AddWithValue("@amt", amt);
                    cmd.Parameters.AddWithValue("@schedDate", date);
                    cmd.ExecuteNonQuery();
            }


            conn.Close();
            return false;
        }


        public void updateSummary(string shipVia, string date, string invcNbr)
        {
            conn.Open();

            using (cmd = new SqlCommand("UPDATE Summary SET shipViaID=@shipvia,ScheduleDate=@schedDate WHERE InvcNbr=@invcNbr ", conn))
                cmd.Parameters.AddWithValue("@shipVia", shipVia);
                cmd.Parameters.AddWithValue("@schedDate", date);
                cmd.Parameters.AddWithValue("@invcNbr", invcNbr);
                cmd.ExecuteNonQuery();

            conn.Close();
        }

        //--------------------------------------------------------MDISERVER-L - WhseSchedDelSys - Summary---------------------------------------------------------------

        public DataTable fillDGVSum()
        {
            conn.Open();
            sda = new SqlDataAdapter("SELECT * FROM Summary", conn);
            dt = new DataTable();
            sda.Fill(dt);

            conn.Close();
            return dt;
        }

        string queryFilter;
        public void fillCmbFilter(ComboBox cmbDT,string filter)
        {
            conn.Open();


            if (filter == "ShipViaID")
            {
                sda = new SqlDataAdapter("SELECT DISTINCT ShipViaId FROM Summary", conn);
                queryFilter = "ShipViaId";
            }
            else if (filter == "INVC#")
            {
                sda = new SqlDataAdapter("SELECT DISTINCT InvcNbr FROM Summary", conn);
                queryFilter = "InvcNbr";
            }
            else
            {
                sda = new SqlDataAdapter("SELECT DISTINCT ScheduleDate FROM Summary", conn);
                queryFilter = "ScheduleDate";
            }
            
            dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if(filter != "ShipViaID" && filter != "INVC#")
                {
                    cmbDT.Items.Add(DateTime.Parse(row[queryFilter].ToString()).ToString("M/d/yyyy"));
                }
                else
                {
                    cmbDT.Items.Add(row[queryFilter].ToString());
                }
            }

            conn.Close();
        }

        public DataTable filterDGVSum(string selFilter)
        {
            conn.Open();
            sda = new SqlDataAdapter("SELECT * FROM Summary WHERE " + queryFilter + "='" + selFilter + "'", conn);
            dt = new DataTable();
            sda.Fill(dt);

            conn.Close();
            return dt;
        }

        //----------------------------------LOGS

        public void insertLogs(string trans, string dateTime)
        {
            conn.Open();

            using (cmd = new SqlCommand("INSERT INTO Logs VALUES(@UserName,@Trans,@DateTime)", conn))
                cmd.Parameters.AddWithValue("@UserName", GlobalVars.strUserName);
                cmd.Parameters.AddWithValue("@Trans", trans);
                cmd.Parameters.AddWithValue("@DateTime", dateTime);
                cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
