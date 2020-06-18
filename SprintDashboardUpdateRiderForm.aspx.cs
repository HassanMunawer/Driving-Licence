using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SprintDashboardUpdateRiderForm : System.Web.UI.Page
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
                    slcteditName.DataSource = Dropdown.GetSprintDashboardDropdownRiderName();
                    slcteditName.DataTextField = "Text";
                    slcteditName.DataValueField = "Value";
                    slcteditName.DataBind();


                    slcteditName.DataSource = Dropdown.GetSprintDashboardDropdownRiderName();
                    slcteditName.DataTextField = "Text";
                    slcteditName.DataValueField = "Value";
                    slcteditName.DataBind();
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
            variables.SprintUpdateRider_ID = Convert.ToInt16(slcteditName.SelectedValue);
            variables.SprintUpdateRider_Name = txtName.Value;
            variables.SprintUpdateRider_CNIC = txtemail.Value;
            variables.SprintUpdateRider_Address = txtAddress.Value;
            variables.SprintUpdateRider_Phone = txtcell.Value;
            variables.SprintUpdateRider_FK_Updatedby = Convert.ToInt16(Session["username"]);
            update.SprintUpdateRider(variables);


            txtName.Value = "";
            txtAddress.Value = "";
            txtemail.Value = "";
            txtcell.Value = "";

            slcteditName.DataSource = Dropdown.GetSprintDashboardDropdownRiderName();
            slcteditName.DataTextField = "Text";
            slcteditName.DataValueField = "Value";
            slcteditName.DataBind();


            slcteditName.DataSource = Dropdown.GetSprintDashboardDropdownRiderName();
            slcteditName.DataTextField = "Text";
            slcteditName.DataValueField = "Value";
            slcteditName.DataBind();
        }
        catch (Exception ex) { }
    }

    protected void slcteditName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            variables.SprintEditRiderForm = Convert.ToInt16(slcteditName.SelectedValue);
            table = ed.SprintEditRiderForm(variables);

            txtName.Value = table.Rows[0][1].ToString().Trim();
            txtemail.Value = table.Rows[0][2].ToString().Trim();
            txtAddress.Value = table.Rows[0][3].ToString().Trim();
            txtcell.Value = table.Rows[0][4].ToString().Trim();
        }
        catch (Exception ex)
        {

        }
    }
}