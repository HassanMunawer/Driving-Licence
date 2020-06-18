using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SprintDashboardUpdateDistrictForm : System.Web.UI.Page
{
    DataTable table = new DataTable();
    Properties variables = new Properties();
    Updation update = new Updation();
    edit ed = new edit();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {

                if (!IsPostBack)
                {
                    slcteditDistrict.DataSource = Dropdown.GetSprintDashboardDropdownDistrictName();
                    slcteditDistrict.DataTextField = "Text";
                    slcteditDistrict.DataValueField = "Value";
                    slcteditDistrict.DataBind();


                    slcteditDistrict.DataSource = Dropdown.GetSprintDashboardDropdownDistrictName();
                    slcteditDistrict.DataTextField = "Text";
                    slcteditDistrict.DataValueField = "Value";
                    slcteditDistrict.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //try
        //{
            variables.SprintUpdateDistrict_ID = Convert.ToInt16(slcteditDistrict.SelectedValue);
            variables.SprintUpdateDistrict_DistrictName = txtDistrict.Value;
            variables.SprintUpdateDistrict_FK_Updatedby = Convert.ToInt16(Session["username"]);
            update.SprintUpdateDistrict(variables);


            txtDistrict.Value = "";

            slcteditDistrict.DataSource = Dropdown.GetSprintDashboardDropdownDistrictName();
            slcteditDistrict.DataTextField = "Text";
            slcteditDistrict.DataValueField = "Value";
            slcteditDistrict.DataBind();


            slcteditDistrict.DataSource = Dropdown.GetSprintDashboardDropdownDistrictName();
            slcteditDistrict.DataTextField = "Text";
            slcteditDistrict.DataValueField = "Value";
            slcteditDistrict.DataBind();
        //}
        //catch (Exception ex) { }
    }

    protected void slcteditDistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
            variables.SprintEditDistrictForm = Convert.ToInt16(slcteditDistrict.SelectedValue);
            table = ed.SprintEditDistrictForm(variables);

            txtDistrict.Value = table.Rows[0][1].ToString().Trim();
        //}
        //catch (Exception ex)
        //{

        //}
    }
}