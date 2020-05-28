﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class DataEntryShipmentEntry : System.Web.UI.Page
{
    Fetch f = new Fetch();
    Properties P = new Properties();
    Insertion insert = new Insertion();
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {  }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        P.AdminInsertentryreceivedon = Convert.ToDateTime(txtreceivedate.Value);
        P.AdminInsertentryreceivedby = Convert.ToString(ddlreceiveby.SelectedItem);
        P.AdminInsertentryestimatedongoingdate = Convert.ToDateTime(txtreceivedate.Value).AddDays(1);
        P.AdminInsertentrycreatedby = Convert.ToInt32(Session["username"]);
        P.AdminInsertentryshipment = Convert.ToInt32(ddllicence.SelectedValue);
        P.AdminInsertentryrider = Convert.ToInt32(ddlreceiveby.SelectedValue);
        P.AdminFetchID = Convert.ToInt32(ddlreceiveby.SelectedValue);
        dt = f.AdminFetchcheckshipmententry(P);

        if (dt.Rows[0][0] != null)
        {
            insert.AdminInsertshipmententry(P);
        }

        else
        {

        }
    }
}