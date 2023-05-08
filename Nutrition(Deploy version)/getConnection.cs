using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nutrition
{
    class Connection
    {
        public SqlConnection Getconnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-LO44UHS\SQLEXPRESS;Initial Catalog=Nutrition;Integrated Security=True";
            return Con;
        }

       

        //public void SetData(string query,string msg)
        //{
        //    SqlConnection Con =Getconnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = Con;
        //    Con.Open();
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    Con.Close();
        //    MessageBox.Show(msg,"بيانات",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //}


    }
    partial class Procedures_exe
    {
        public SqlConnection SqlConnection()
        {
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            return Con;
        }
        public void Delete_Procedures(string query, string parameter, int ID)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parameter, SqlDbType.NVarChar).Value = ID;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public DataTable Populate_Procedures(string query)
        {
            SqlConnection Con = SqlConnection();
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;
        }

        public DataTable Search_procedures(string query,string Name, string para)
        {
            SqlConnection Con = SqlConnection();
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(para, Name);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            Con.Close();
            return dt;
        }

        public void Fill_Cb_Byname(string query, string Name, MetroFramework.Controls.MetroComboBox cBoxName)
        {
            try
            {
                SqlConnection Con = SqlConnection();
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add(Name, typeof(string));
                dt.Load(rdr);
                cBoxName.ValueMember = Name;
                cBoxName.DataSource = dt;
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
