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

namespace INutrition
{
    public partial class settings : MetroFramework.Forms.MetroForm
    {
        Procedures_exe procedures_Exe = new Procedures_exe();
        User_procedures user_Procedures = new User_procedures();
        string query, param, email, password, username,color, theme;
        int id;

        public settings()
        {
            InitializeComponent();
            StyleManager = metroStyleManager1;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            Populate_User();
            Select_sty();
        }

        public MetroFramework.Components.MetroStyleManager Select_sty()
        {
            DataTable dt = new DataTable();
            query = "Populate_Style";

            dt = procedures_Exe.Populate_Procedures(query);

            color = dt.Rows[0][0].ToString().Trim();
            theme = dt.Rows[0][1].ToString().Trim();

            int new_color;
            int new_theme;

            new_color = Check_color(color);
            new_theme = Check_theme(theme);

            metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)Convert.ToInt32(new_theme);
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(new_color);

            return metroStyleManager1;
        }
        
        private int Check_theme(string theme)
        {
            switch(theme)
            {
                case "Default":
                    return 0;
                case "Light":
                    return 1;
                case "Dark":
                    return 2;
            }
            return 0;
        }

        private int Check_color(string color)
        {
            switch (color)
            {
                case "Default":
                    return 0;
                case "Black":
                    return 1;
                case "White":
                    return 2;
                case "Silver":
                    return 3;
                case "Blue":
                    return 4;
                case "Green":
                    return 5;
                case "lime":
                    return 6;
                case "Teal":
                    return 7;
                case "Orange":
                    return 8;
                case "Brown":
                    return 9; 
                case "Pink":
                    return 10;
                case "Magenta":
                    return 11;
                case "Purple":
                    return 12;
                case "Red":
                    return 13; 
                case "Yellow":
                    return 14;
            }
            return 0;
        }

        private void Update_sty()
        {
            try
            {
                if (ThemeCB.SelectedItem == null || ColorCB.SelectedItem == null)
                {
                    MessageBox.Show("اختر اللون و الثيم من فضلك");
                }
                else
                {
                    theme = ThemeCB.SelectedItem.ToString();
                    color = ColorCB.SelectedItem.ToString();

                    user_Procedures.Update_Style(color, theme);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"");
            }
        }

        private void Apply_Design_Btn_Click(object sender, EventArgs e)
        {
            Update_sty();
            Select_sty();
        }

        private void ThemeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (ThemeCB.SelectedIndex)
            //{
            //    case 0:
            //        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            //        break;
            //    case 1:
            //        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            //        break;
            //    case 2:
            //        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            //        break;
            //}

        }

        private void ColorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(ColorCB.SelectedIndex);
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
            Hide();
        }

        private void User_Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_User();
        }

        private void Populate_User()
        {
            query = "Populate_User";
            User_Grid.DataSource = procedures_Exe.Populate_Procedures(query);
        }

        private void Update_User()
        {
            query = "Update_User";
            id = Convert.ToInt32(User_Grid.SelectedRows[0].Cells[0].Value);
            email = User_Grid.SelectedRows[0].Cells[1].Value.ToString();
            username = User_Grid.SelectedRows[0].Cells[2].Value.ToString();
            password = User_Grid.SelectedRows[0].Cells[3].Value.ToString();
            user_Procedures.Update_User(query, id, email, username, password);
        }

        private void Delete_User_Btn_Click(object sender, EventArgs e)
        {
            Delete_User();
            Populate_User();    
        }

        private void Delete_User()
        {
            id = Convert.ToInt32(User_Grid.SelectedRows[0].Cells[0].Value);
            query = "Delete_User";
            param = "@UserID";
            procedures_Exe.Delete_Procedures(query, param, id);
        }
    }
}
