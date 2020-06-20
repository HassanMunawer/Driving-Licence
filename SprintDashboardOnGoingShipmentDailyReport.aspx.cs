﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SprintDashboardOnGoingShipmentDailyReport : System.Web.UI.Page
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
            cmd.CommandText = "sp_SprintDashboard_OnGoingShipment_DailyReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string shipmentid = Convert.ToString(sdr[1]);
                        string assignedon = Convert.ToDateTime(sdr[2]).ToLongDateString();
                        //string outwarddatetime = Convert.ToDateTime(sdr[3]).ToLongDateString() + " " + Convert.ToDateTime(sdr[3]).ToShortTimeString();
                        string rider = Convert.ToString(sdr[3]);
                        string District = Convert.ToString(sdr[4]);
                        string City = Convert.ToString(sdr[5]);
                        data += "<tr><td>" + sno + "</td><td>" + shipmentid + "</td><td>" + assignedon + "</td><td>"
                            + rider + "</td><td>" + District + "</td><td>" + City + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}