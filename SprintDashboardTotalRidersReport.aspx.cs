﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SprintDashboardTotalRidersReport : System.Web.UI.Page
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
            cmd.CommandText = "sp_SprintDashboardTotalRiderReport";
            cmd.Connection = Getconnected.getconnecting();
            using (sdr = cmd.ExecuteReader())
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int sno = Convert.ToInt16(sdr[0]);
                        string Name = Convert.ToString(sdr[1]);
                        string Address = Convert.ToString(sdr[2]);
                        string email = Convert.ToString(sdr[3]);
                        string phone = Convert.ToString(sdr[4]);
                        //string outwarddatetime = Convert.ToDateTime(sdr[3]).ToLongDateString() + " " + Convert.ToDateTime(sdr[3]).ToShortTimeString();

                        data += "<tr><td>" + sno + "</td><td>" + Name + "</td><td>"
                            + Address + "</td><td>" + email + "</td><td>" + phone + "</td></tr>";
                    }
                }
            }
            return data;
        }
    }
}