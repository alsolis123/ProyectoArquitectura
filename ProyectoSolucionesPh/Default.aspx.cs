using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoSolucionesPh
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString)) 
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.CommandText="SP_consultaUsuarios";
                    cmd.Connection= conn;
                    conn.Open();
                    gvdAlumnos.DataSource=cmd.ExecuteReader();
                    gvdAlumnos.DataBind();
                }
                
            }
        }
    }
}