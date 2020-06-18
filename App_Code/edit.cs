using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class edit
{
    private static SqlCommand cmd;
    private static SqlDataReader sdr;
    private static SqlDataAdapter sda;
    private static SqlConnection conn;

    private static DataTable dt;
    public DataTable SprintEditCountryForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcountry";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditCountryForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable SprintEditCityForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchcity";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditCityForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable SprintEditDistrictForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchdistrict";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditDistrictForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable SprintEditReturnReasonForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchreturnreason";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditReturnReasonForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable SprintEditRiderForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fetchrider";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditRiderForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }


    public DataTable SprintEditUserForm(Properties P)
    {
        DataTable table = new DataTable();
        using (cmd = new SqlCommand())
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Fetch_UserInfo";
            cmd.Connection = Getconnected.getconnecting();
            cmd.Parameters.AddWithValue("@id", P.SprintEditUserForm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(table);
            return table;
        }

    }
}