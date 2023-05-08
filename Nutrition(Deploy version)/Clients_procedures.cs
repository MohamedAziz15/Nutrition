using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nutrition;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Nutrition
{
    internal class Clients_procedures
    {        
        public SqlConnection SqlConnection()
        {
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            return Con;
        }

        public void Excute_Insert_Client_Procedures(string query, string Name, string PHONE, string Address, string Status, string Gender, DateTime DOB, string TargetNutri, string Notes, byte[] Inbody,
            string S_Player, string S_type, string S_SEASON, string S_Level, string S_Champion, string G_Player, string G_Goal, string G_SEASON, string G_Level,
            string G_Champion, string W_Player, string W_type, string W_Time, DateTime C_StartDate, int number_months, double Subtotal, double Discount, double TOTAL, string Contract_NOTES)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            //personal
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@PHONE", SqlDbType.NVarChar).Value = PHONE;
            cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Status;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = Gender;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = DOB;
            cmd.Parameters.AddWithValue("@TargetNutri", SqlDbType.NVarChar).Value = TargetNutri;
            cmd.Parameters.AddWithValue("@Notes", SqlDbType.NVarChar).Value = Notes;
            cmd.Parameters.AddWithValue("@Inbody", SqlDbType.NVarChar).Value = Inbody;
            //sport
            //cmd.Parameters.AddWithValue("@sportClient_ID", SqlDbType.Int).Value = sportClient_ID;
            cmd.Parameters.AddWithValue("@S_Player", SqlDbType.NVarChar).Value = S_Player;
            cmd.Parameters.AddWithValue("@S_type", SqlDbType.NVarChar).Value = S_type;
            cmd.Parameters.AddWithValue("@S_SEASON", SqlDbType.NVarChar).Value = S_SEASON;
            cmd.Parameters.AddWithValue("@S_Level", SqlDbType.NVarChar).Value = S_Level;
            cmd.Parameters.AddWithValue("@S_Champion", SqlDbType.NVarChar).Value = S_Champion;
            cmd.Parameters.AddWithValue("@G_Player", SqlDbType.NVarChar).Value = G_Player;
            cmd.Parameters.AddWithValue("@G_Goal", SqlDbType.NVarChar).Value = G_Goal;
            cmd.Parameters.AddWithValue("@G_SEASON", SqlDbType.NVarChar).Value = G_SEASON;
            cmd.Parameters.AddWithValue("@G_Level", SqlDbType.NVarChar).Value = G_Level;
            cmd.Parameters.AddWithValue("@G_Champion", SqlDbType.NVarChar).Value = G_Champion;
            cmd.Parameters.AddWithValue("@W_Player", SqlDbType.NVarChar).Value = W_Player;
            cmd.Parameters.AddWithValue("@W_type", SqlDbType.NVarChar).Value = W_type;
            cmd.Parameters.AddWithValue("@W_Time", SqlDbType.NVarChar).Value = W_Time;
            //contract
            //cmd.Parameters.AddWithValue("@ContractClient_ID", SqlDbType.Int).Value = ContractClient_ID;
            cmd.Parameters.AddWithValue("@C_StartDate", SqlDbType.DateTime).Value = C_StartDate;
            cmd.Parameters.AddWithValue("@number_months", SqlDbType.Int).Value = number_months;
            cmd.Parameters.AddWithValue("@Subtotal", SqlDbType.Float).Value = Subtotal;
            cmd.Parameters.AddWithValue("@Discount", SqlDbType.Float).Value = Discount;
            cmd.Parameters.AddWithValue("@TOTAL", SqlDbType.Float).Value = TOTAL;
            cmd.Parameters.AddWithValue("@Contract_NOTES", SqlDbType.Image).Value = Contract_NOTES;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void Excute_Insert_Client_Procedures_dynamic(string query,string[] args, int[] ints, string para, System.Data.SqlDbType sqlDbType)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
          
            //personal
            foreach(string i in args)
            {
                //cmd.Parameters.AddWithValue("@Contract_NOTES", SqlDbType.Image).Value = ;
                cmd.Parameters.AddWithValue(para, sqlDbType).Value = args;
            }
            foreach (int n in ints)
            {

                cmd.Parameters.AddWithValue(para, sqlDbType).Value = ints;
            }
            Con.Close();
            //cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = Name;
            //cmd.Parameters.AddWithValue("@PHONE", SqlDbType.NVarChar).Value = PHONE;
            //cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = Address;
            //cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Status;
            //cmd.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = Gender;
            //cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = DOB;
            //cmd.Parameters.AddWithValue("@TargetNutri", SqlDbType.NVarChar).Value = TargetNutri;
            //cmd.Parameters.AddWithValue("@Notes", SqlDbType.NVarChar).Value = Notes;
            //cmd.Parameters.AddWithValue("@Inbody", SqlDbType.NVarChar).Value = Inbody;
            ////sport
            ////cmd.Parameters.AddWithValue("@sportClient_ID", SqlDbType.Int).Value = sportClient_ID;
            //cmd.Parameters.AddWithValue("@S_Player", SqlDbType.NVarChar).Value = S_Player;
            //cmd.Parameters.AddWithValue("@S_type", SqlDbType.NVarChar).Value = S_type;
            //cmd.Parameters.AddWithValue("@S_SEASON", SqlDbType.NVarChar).Value = S_SEASON;
            //cmd.Parameters.AddWithValue("@S_Level", SqlDbType.NVarChar).Value = S_Level;
            //cmd.Parameters.AddWithValue("@S_Champion", SqlDbType.NVarChar).Value = S_Champion;
            //cmd.Parameters.AddWithValue("@G_Player", SqlDbType.NVarChar).Value = G_Player;
            //cmd.Parameters.AddWithValue("@G_Goal", SqlDbType.NVarChar).Value = G_Goal;
            //cmd.Parameters.AddWithValue("@G_SEASON", SqlDbType.NVarChar).Value = G_SEASON;
            //cmd.Parameters.AddWithValue("@G_Level", SqlDbType.NVarChar).Value = G_Level;
            //cmd.Parameters.AddWithValue("@G_Champion", SqlDbType.NVarChar).Value = G_Champion;
            //cmd.Parameters.AddWithValue("@W_Player", SqlDbType.NVarChar).Value = W_Player;
            //cmd.Parameters.AddWithValue("@W_type", SqlDbType.NVarChar).Value = W_type;
            //cmd.Parameters.AddWithValue("@W_Time", SqlDbType.NVarChar).Value = W_Time;
            ////contract
            ////cmd.Parameters.AddWithValue("@ContractClient_ID", SqlDbType.Int).Value = ContractClient_ID;
            //cmd.Parameters.AddWithValue("@C_StartDate", SqlDbType.DateTime).Value = C_StartDate;
            //cmd.Parameters.AddWithValue("@number_months", SqlDbType.Int).Value = number_months;
            //cmd.Parameters.AddWithValue("@Subtotal", SqlDbType.Float).Value = Subtotal;
            //cmd.Parameters.AddWithValue("@Discount", SqlDbType.Float).Value = Discount;
            //cmd.Parameters.AddWithValue("@TOTAL", SqlDbType.Float).Value = TOTAL;
            //cmd.Parameters.AddWithValue("@Contract_NOTES", SqlDbType.Image).Value = Contract_NOTES;
            //cmd.ExecuteNonQuery();
        }

        public void Excute_update_Client_archive_Procedures(string query, string Name, string PHONE, string Address, string Status, string Gender, DateTime DOB, string TargetNutri, string Notes,
           string S_Player, string S_type, string S_SEASON, string S_Level, string S_Champion, string G_Player, string G_Goal, string G_SEASON, string G_Level,
           string G_Champion, string W_Player, string W_type, string W_Time, int @C_ID)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            //personal
            cmd.Parameters.AddWithValue("@C_ID", SqlDbType.Int).Value = @C_ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@PHONE", SqlDbType.NVarChar).Value = PHONE;
            cmd.Parameters.AddWithValue("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Status;
            cmd.Parameters.AddWithValue("@Gender", SqlDbType.NVarChar).Value = Gender;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.DateTime).Value = DOB;
            cmd.Parameters.AddWithValue("@TargetNutri", SqlDbType.NVarChar).Value = TargetNutri;
            cmd.Parameters.AddWithValue("@Notes", SqlDbType.NVarChar).Value = Notes;
            //sport
            cmd.Parameters.AddWithValue("@S_Player", SqlDbType.NVarChar).Value = S_Player;
            cmd.Parameters.AddWithValue("@S_type", SqlDbType.NVarChar).Value = S_type;
            cmd.Parameters.AddWithValue("@S_SEASON", SqlDbType.NVarChar).Value = S_SEASON;
            cmd.Parameters.AddWithValue("@S_Level", SqlDbType.NVarChar).Value = S_Level;
            cmd.Parameters.AddWithValue("@S_Champion", SqlDbType.NVarChar).Value = S_Champion;
            cmd.Parameters.AddWithValue("@G_Player", SqlDbType.NVarChar).Value = G_Player;
            cmd.Parameters.AddWithValue("@G_Goal", SqlDbType.NVarChar).Value = G_Goal;
            cmd.Parameters.AddWithValue("@G_SEASON", SqlDbType.NVarChar).Value = G_SEASON;
            cmd.Parameters.AddWithValue("@G_Level", SqlDbType.NVarChar).Value = G_Level;
            cmd.Parameters.AddWithValue("@G_Champion", SqlDbType.NVarChar).Value = G_Champion;
            cmd.Parameters.AddWithValue("@W_Player", SqlDbType.NVarChar).Value = W_Player;
            cmd.Parameters.AddWithValue("@W_type", SqlDbType.NVarChar).Value = W_type;
            cmd.Parameters.AddWithValue("@W_Time", SqlDbType.NVarChar).Value = W_Time;
            
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void Excute_Insert_Sport_Procedures(string query, string Sport_Name)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sport_Name", SqlDbType.NVarChar).Value = Sport_Name;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
       
        public void Excute_Update_Contract_Procedures(string query,int contract_ID, DateTime C_StartDate, int number_months, double Subtotal, double Discount, double TOTAL, string Contract_NOTES)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@contract_ID", SqlDbType.Int).Value = contract_ID;
            cmd.Parameters.AddWithValue("@C_StartDate", SqlDbType.DateTime).Value = C_StartDate;
            cmd.Parameters.AddWithValue("@number_months", SqlDbType.Int).Value = number_months;
            cmd.Parameters.AddWithValue("@Subtotal", SqlDbType.Float).Value = Subtotal;
            cmd.Parameters.AddWithValue("@Discount", SqlDbType.Float).Value = Discount;
            cmd.Parameters.AddWithValue("@TOTAL", SqlDbType.Float).Value = TOTAL;
            cmd.Parameters.AddWithValue("@Contract_NOTES", SqlDbType.Image).Value = Contract_NOTES;
            cmd.ExecuteNonQuery();
        }
       
    }
    
}
