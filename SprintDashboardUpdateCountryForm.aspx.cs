using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SprintDashboardUpdateCountryForm : System.Web.UI.Page
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
                    slcteditCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
                    slcteditCountry.DataTextField = "Text";
                    slcteditCountry.DataValueField = "Value";
                    slcteditCountry.DataBind();


                    slcteditCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
                    slcteditCountry.DataTextField = "Text";
                    slcteditCountry.DataValueField = "Value";
                    slcteditCountry.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }
    
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            variables.SprintUpdateCountry_ID = Convert.ToInt16(slcteditCountry.SelectedValue);
            variables.SprintUpdateCountry_CountryName = txtCountry.Value;
            variables.SprintUpdateCountry_FK_Updatedby = Convert.ToInt16(Session["username"]);
            update.SprintUpdateCountry(variables);


            txtCountry.Value = "";

            slcteditCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
            slcteditCountry.DataTextField = "Text";
            slcteditCountry.DataValueField = "Value";
            slcteditCountry.DataBind();


            slcteditCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
            slcteditCountry.DataTextField = "Text";
            slcteditCountry.DataValueField = "Value";
            slcteditCountry.DataBind();
        }
        catch (Exception ex) { }
    }

    protected void slcteditCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.SprintEditCountryForm = Convert.ToInt16(slcteditCountry.SelectedValue);
            table = ed.SprintEditCountryForm(variables);

            txtCountry.Value = table.Rows[0][1].ToString().Trim();
        }
        catch (Exception ex)
        {

        }
    }
}