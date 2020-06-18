using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SprintDashboardUpdateCityForm : System.Web.UI.Page
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
                    slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slcteditCity.DataTextField = "Text";
                    slcteditCity.DataValueField = "Value";
                    slcteditCity.DataBind();


                    slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slcteditCity.DataTextField = "Text";
                    slcteditCity.DataValueField = "Value";
                    slcteditCity.DataBind();
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
            variables.SprintUpdateCity_ID = Convert.ToInt16(slcteditCity.SelectedValue);
            variables.SprintUpdateCity_CityName = txtCity.Value;
            variables.SprintUpdateCity_FK_Updatedby = Convert.ToInt16(Session["username"]);
            update.SprintUpdateCity(variables);


            txtCity.Value = "";

            slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
            slcteditCity.DataTextField = "Text";
            slcteditCity.DataValueField = "Value";
            slcteditCity.DataBind();


            slcteditCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
            slcteditCity.DataTextField = "Text";
            slcteditCity.DataValueField = "Value";
            slcteditCity.DataBind();
        }
        catch (Exception ex) { }
    }

    protected void slcteditCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.SprintEditCityForm = Convert.ToInt16(slcteditCity.SelectedValue);
            table = ed.SprintEditCityForm(variables);

            txtCity.Value = table.Rows[0][1].ToString().Trim();
        }
        catch (Exception ex)
        {

        }
    }
}