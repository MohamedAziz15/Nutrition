using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nutrition
{
    internal class User_procedures
    {
        public SqlConnection SqlConnection()
        {
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            return Con;
        }

        public void Change_Password_Insert_User(string query,string EMail, string Username,string Password)
        {
            SqlConnection con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EMail", SqlDbType.VarChar).Value = EMail;
            cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = Username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = Password;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update_User(string query,int id, string EMail, string Username, string Password)
        {
            SqlConnection con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.AddWithValue("@EMail", SqlDbType.VarChar).Value = EMail;
            cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = Username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = Password;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int SignIn_User(string query, string EMail, string Username, string Password)
        {
            int status;
            SqlConnection con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EMail", SqlDbType.VarChar).Value = EMail;
            cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = Username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = Password;
            status = (int)cmd.ExecuteScalar();
            con.Close();
            return status;
        }

        public void Update_Style(string color, string theme)
        {
            SqlConnection con = SqlConnection();
            SqlCommand cmd = new SqlCommand("Update_Style", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Color", SqlDbType.NVarChar).Value = color;
            cmd.Parameters.AddWithValue("@Theme", SqlDbType.NVarChar).Value = theme;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
