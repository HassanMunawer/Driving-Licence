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
}