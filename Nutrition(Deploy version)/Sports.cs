using INutrition;
using Nutrition;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition
{
    public partial class Sports : MetroFramework.Forms.MetroForm
    {
        public Sports()
        {
            InitializeComponent();
        }
        string query;

        private void Sports_Load(object sender, EventArgs e)
        {
            settings settings = new settings();
            //metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            Sport_Name_Tb.StyleManager= metroStyleManager1;
            AddSport.StyleManager= metroStyleManager1;
        }
        private void insert_sport()
        {
            string query = "Insert_SportType", Sport_Name = Sport_Name_Tb.Text;
            Clients_procedures cp = new Clients_procedures();
            cp.Excute_Insert_Sport_Procedures(query, Sport_Name);
        }

        private void AddSport_Click(object sender, EventArgs e)
        {
            insert_sport();
        }

        private void delete_sportBtn_Click(object sender, EventArgs e)
        {
            query = "Delete_sport";
            string sportName = Sport_Name_Tb.Text;
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@S_Name", SqlDbType.NVarChar).Value = sportName;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
