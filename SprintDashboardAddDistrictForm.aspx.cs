using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SprintDashboardAddDistrictForm : System.Web.UI.Page
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
                    slctCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slctCity.DataTextField = "Text";
                    slctCity.DataValueField = "Value";
                    slctCity.DataBind();


                    slctCity.DataSource = Dropdown.GetSprintDashboardDropdownCityName();
                    slctCity.DataTextField = "Text";
                    slctCity.DataValueField = "Value";
                    slctCity.DataBind();
                }
            }
            else { Response.Redirect("SignIn.aspx"); }
        }
        catch (Exception ex) { }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        p.SprintInsertDistrict_DistrictName = txtDistrict.Value;
        p.SprintInsertDistrict_FK_Createdby = Convert.ToInt32(Session["username"]);
        p.SprintInsertDistrict_FK_City = Convert.ToInt32(slctCity.SelectedValue);

        insert.SprintInsertDistrict(p);
    }
}