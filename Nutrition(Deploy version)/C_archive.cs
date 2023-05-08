using Aspose.Pdf.Operators;
using INutrition;
using Nutrition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nutrition
{
    public partial class C_archive : MetroFramework.Forms.MetroForm
    {
        Clients_procedures cp = new Clients_procedures();
        Procedures_exe delete_Populate = new Procedures_exe();

        string query;
        string name, Address, Status, Gender = "", TargetNutri, Notes;
        string S_Player, phone, S_type, S_SEASON, S_Level, S_Champion, G_Player, G_Goal, G_SEASON, G_Level, G_Champion, W_Player, W_type, W_Time;

        DateTime DOB;
        int ID;

        private void Search_client()
        {
            query = "Search_ClientArchive";
            name = Search_client_Tb.Text;
            string para = "@client_Name";
            client_Grid.DataSource = delete_Populate.Search_procedures(query, name, para);
            if(Search_client_Tb.Text == "")
            {
                Populate_clients_Grid();
            }
        }

        private void Search_client_Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_client();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void client_Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Archieve();
        }

        private void Update_Archieve()
        {
            try
            {
                if (ID == null)
                {
                    MessageBox.Show("رجاءً أختر الصف", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "UPDATE_ClientArchive";
                    ID = Convert.ToInt32(client_Grid.SelectedRows[0].Cells[0].Value);
                    name = client_Grid.SelectedRows[0].Cells[1].Value?.ToString();
                    phone = client_Grid.SelectedRows[0].Cells[2].Value?.ToString();
                    Address = client_Grid.SelectedRows[0].Cells[3].Value?.ToString();
                    Status = client_Grid.SelectedRows[0].Cells[4].Value?.ToString();
                    Gender = client_Grid.SelectedRows[0].Cells[5].Value?.ToString();
                    DOB = Convert.ToDateTime(client_Grid.SelectedRows[0].Cells[6].Value);
                    TargetNutri = client_Grid.SelectedRows[0].Cells[7].Value?.ToString();
                    Notes = client_Grid.SelectedRows[0].Cells[8].Value?.ToString();
                    S_Player = client_Grid.SelectedRows[0].Cells[9].Value?.ToString();
                    S_type = client_Grid.SelectedRows[0].Cells[10].Value?.ToString();
                    S_SEASON = client_Grid.SelectedRows[0].Cells[11].Value?.ToString();
                    S_Level = client_Grid.SelectedRows[0].Cells[12].Value?.ToString();
                    S_Champion = client_Grid.SelectedRows[0].Cells[13].Value?.ToString();
                    G_Player = client_Grid.SelectedRows[0].Cells[14].Value?.ToString();
                    G_Goal = client_Grid.SelectedRows[0].Cells[15].Value?.ToString();
                    G_SEASON = client_Grid.SelectedRows[0].Cells[16].Value?.ToString();
                    G_Level = client_Grid.SelectedRows[0].Cells[17].Value?.ToString();
                    G_Champion = client_Grid.SelectedRows[0].Cells[18].Value?.ToString();
                    W_Player = client_Grid.SelectedRows[0].Cells[19].Value?.ToString();
                    W_type = client_Grid.SelectedRows[0].Cells[20].Value?.ToString();
                    W_Time = client_Grid.SelectedRows[0].Cells[21].Value?.ToString();
                    cp.Excute_update_Client_archive_Procedures(query, name, phone, Address, Status, Gender, DOB, TargetNutri, Notes, S_Player, S_type, S_SEASON, S_Level, S_Champion, G_Player, G_Goal, G_SEASON, G_Level, G_Champion, W_Player, W_type, W_Time, ID);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
       
        public C_archive()
        {
            InitializeComponent();
        }

        private void Populate_clients_Grid()
        {
            try
            {
                query = "populate_ClientArchive";
                client_Grid.DataSource = delete_Populate.Populate_Procedures(query);
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void C_archive_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            Delete_archive_Btn.StyleManager = metroStyleManager1;
            client_Grid                 .StyleManager = metroStyleManager1;
            metroButton1                .StyleManager = metroStyleManager1;
            Search_client_Tb            .StyleManager = metroStyleManager1;
        }

        private void C_archive_Load(object sender, EventArgs e)
        {
            Populate_clients_Grid();
            C_archive_style();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            C_form clients = new C_form();
            clients.ShowDialog();
            this.Hide();
        }

        private void Delete_archive_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل انته واثق من حذف العميل", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    Delete_client_Archive();
                    Populate_clients_Grid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_client_Archive()
        {
            try
            {
                if (Convert.ToInt32(client_Grid.SelectedRows[0].Cells[0].Value) == null)
                {
                    MessageBox.Show("تأكد من اختيار العميل من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ID = Convert.ToInt32(client_Grid.SelectedRows[0].Cells[0].Value);
                    query = "Delete_ClientArchive";
                    delete_Populate.Delete_Procedures(query, "@ID", ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في البيانات"  + ex, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
