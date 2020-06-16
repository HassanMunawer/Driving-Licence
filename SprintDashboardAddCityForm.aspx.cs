using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddCityForm : System.Web.UI.Page
{
    Properties p = new Properties();
    Insertion insert = new Insertion();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] != null && Session["password"] != null)
            {

                if (!IsPostBack)
                {
                    slctCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
                    slctCountry.DataTextField = "Text";
                    slctCountry.DataValueField = "Value";
                    slctCountry.DataBind();


                    slctCountry.DataSource = Dropdown.GetSprintDashboardDropdownCountryName();
                    slctCountry.DataTextField = "Text";
                    slctCountry.DataValueField = "Value";
                    slctCountry.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertCity_CityName = txtCity.Value;
        p.SprintInsertCity_FK_Country = Convert.ToInt32(slctCountry.SelectedValue);
        p.SprintInsertCity_FK_Createdby = Convert.ToInt32(Session["username"]);

        insert.SprintInsertCity(p);
    }
}