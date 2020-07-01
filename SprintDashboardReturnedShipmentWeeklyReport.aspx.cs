using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SprintDashboardReturnedShipmentWeeklyReport : System.Web.UI.Page
{
    Fetch fet = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        getattendance();
    }

    public string getattendance()
    {
        string data = "";
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_SprintDashboard_ReturnedShipment_WeeklyReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string shipmentid = Convert.ToString(sdr[1]);
                        string Returnedon = Convert.ToDateTime(sdr[2]).ToLongDateString();
                        string Reason = Convert.ToString(sdr[3]);
                        string rider = Convert.ToString(sdr[4]);
                        string District = Convert.ToString(sdr[5]);
                        string City = Convert.ToString(sdr[6]);
                        data += "<tr><td>" + sno + "</td><td>" + shipmentid + "</td><td>" + Returnedon + "</td><td>" + Reason + "</td><td>"
                            + rider + "</td><td>" + District + "</td><td>" + City + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}