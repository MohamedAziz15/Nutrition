using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutrition;

namespace Nutrition
{
    internal class Food_procedures
    {
        public SqlConnection SqlConnection()
        {
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            return Con;
        }
        public void Excute_Insert_food_Procedures(string query, string foodName, int Qty, double pro, double Carb, double Fat, double Cal, double K, double NA, double PH, double CA, double Water)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = foodName;
            cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = Qty;
            cmd.Parameters.AddWithValue("@Protein", SqlDbType.Float).Value = pro;
            cmd.Parameters.AddWithValue("@Carb", SqlDbType.Float).Value = Carb;
            cmd.Parameters.AddWithValue("@Fat", SqlDbType.Float).Value = Fat;
            cmd.Parameters.AddWithValue("@Calories", SqlDbType.Float).Value = Cal;
            cmd.Parameters.AddWithValue("@K", SqlDbType.Float).Value = K;
            cmd.Parameters.AddWithValue("@NA", SqlDbType.Float).Value = NA;
            cmd.Parameters.AddWithValue("@PH", SqlDbType.Float).Value = PH;
            cmd.Parameters.AddWithValue("@CA", SqlDbType.Float).Value = CA;
            cmd.Parameters.AddWithValue("@Water", SqlDbType.Float).Value = Water;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public void Excute_Update_food_Procedures(string query, int food_ID, string foodName, int Qty, double pro, double Carb, double Fat, double Cal, double K, double NA, double PH, double CA, double Water)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@food_ID", SqlDbType.Int).Value = food_ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = foodName;
            cmd.Parameters.AddWithValue("@Quantity", SqlDbType.Int).Value = Qty;
            cmd.Parameters.AddWithValue("@Protein", SqlDbType.Float).Value = pro;
            cmd.Parameters.AddWithValue("@Carb", SqlDbType.Float).Value = Carb;
            cmd.Parameters.AddWithValue("@Fat", SqlDbType.Float).Value = Fat;
            cmd.Parameters.AddWithValue("@Calories", SqlDbType.Float).Value = Cal;
            cmd.Parameters.AddWithValue("@K", SqlDbType.Float).Value = K;
            cmd.Parameters.AddWithValue("@NA", SqlDbType.Float).Value = NA;
            cmd.Parameters.AddWithValue("@PH", SqlDbType.Float).Value = PH;
            cmd.Parameters.AddWithValue("@CA", SqlDbType.Float).Value = CA;
            cmd.Parameters.AddWithValue("@Water", SqlDbType.Float).Value = Water;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        //public void Excute_Delete_food_Procedures(string query, int food_ID)
        //{
        //    SqlConnection Con = SqlConnection();
        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    Con.Open();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@food_ID", SqlDbType.NVarChar).Value = food_ID;
        //    cmd.ExecuteNonQuery();
        //    Con.Close();
        //}
        //public DataSet Excute_Search_food_procedures(string query)
        //{
        //    SqlConnection Con = Getconnection();
        //    Con.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
        //    DataSet dt = new DataSet();
        //    sda.Fill(dt);
        //    Con.Close();
        //    return dt;
        //}

        //public void SetDataNoMessage(string query)
        //{
        //    SqlConnection Con = Getconnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = Con;
        //    Con.Open();
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    Con.Close();
        //}

        //public DataSet GetData(string query)
        //{
        //    SqlConnection Con = Getconnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection= Con;
        //    cmd.CommandText = query;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}
    }
}
