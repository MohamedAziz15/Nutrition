using INutrition;
using Nutrition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Nutrition
{
    public partial class Food : MetroFramework.Forms.MetroForm
    {
        //this class "Delete_populate" is for only the dynamic delete and update procedures
        Procedures_exe delete_Populate = new Procedures_exe();
        Food_procedures fd = new Food_procedures();

        string parameter;
        string query,Fname;
        int qty, food_ID;
        double pro, Carb, Fat, Cal, K, NA, PH, CA, Water;

        public Food()
        {
            InitializeComponent();
            
        }

        private void Empty_boxes()
        {
            food_Name_Tb.Text = "";
            food_Qty_Tb.Text = "";
            food_Pro_Tb.Text = "";
            food_Carb_Tb.Text = "";
            food_Fat_Tb.Text = "";
            food_Cal_Tb.Text = "";
            food_K_Tb.Text = "";
            food_NA_Tb.Text = "";
            food_PH_Tb.Text = "";
            food_CA_Tb.Text = "";
            food_Water_Tb.Text = "";
        }

        private void Food_Load(object sender, EventArgs e)
        {
           Populate_food(foodGrid);
            Food_style();
        }

        private void Food_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            food_Cal_Tb.StyleManager = metroStyleManager1;
            food_Carb_Tb.StyleManager = metroStyleManager1;
            food_Pro_Tb                  .StyleManager = metroStyleManager1;
            food_Qty_Tb                  .StyleManager = metroStyleManager1;
            food_Name_Tb                 .StyleManager = metroStyleManager1;
            foodGrid                     .StyleManager = metroStyleManager1;
             insert_Food_Btn             .StyleManager = metroStyleManager1;
             update_Food_Btn             .StyleManager = metroStyleManager1;
             Delete_Food_Btn             .StyleManager = metroStyleManager1;
             food_Water_Tb               .StyleManager = metroStyleManager1;
             food_CA_Tb                  .StyleManager = metroStyleManager1;
             food_PH_Tb                  .StyleManager = metroStyleManager1;
             food_NA_Tb                  .StyleManager = metroStyleManager1;
             food_K_Tb                   .StyleManager = metroStyleManager1;
             food_Fat_Tb                 .StyleManager = metroStyleManager1;
            food_Search_Tb.StyleManager = metroStyleManager1;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Empty_boxes();
        }

        private void Populate_food(MetroFramework.Controls.MetroGrid metroGrid)
        {
            query = "populate_food";
            metroGrid.DataSource = delete_Populate.Populate_Procedures(query);
        }

        private void Insert_Food()
        {
            query = "Insert_food";
            Fname = food_Name_Tb.Text;
            qty = (int)Convert_To_Double(food_Qty_Tb.Text);
            pro = Convert_To_Double(food_Pro_Tb.Text);
            Carb = Convert_To_Double(food_Carb_Tb.Text);
            Fat = Convert_To_Double(food_Fat_Tb.Text);
            Cal = Convert_To_Double(food_Cal_Tb.Text);
            K = Convert_To_Double(food_K_Tb.Text);
            NA = Convert_To_Double(food_NA_Tb.Text);
            PH = Convert_To_Double(food_PH_Tb.Text);
            CA = Convert_To_Double(food_CA_Tb.Text);
            Water = Convert_To_Double(food_Water_Tb.Text);
            fd.Excute_Insert_food_Procedures(query, Fname, qty, pro, Carb, Fat, Cal, K, NA, PH, CA, Water);
            MessageBox.Show("تم أدخال الصنف بنجاح", "ادخال", MessageBoxButtons.OK);
        }

        private void Insert_Check()
        {
            try
            {
                if (food_Name_Tb.Text == "" || food_Qty_Tb.Text == "" || food_Cal_Tb.Text == "" || food_Carb_Tb.Text == "" || food_CA_Tb.Text == "" || food_Fat_Tb.Text == "" || food_K_Tb.Text == "" || food_NA_Tb.Text == "" || food_PH_Tb.Text == "" || food_Pro_Tb.Text == "" || food_Water_Tb.Text == "")
                {
                    DialogResult result = MessageBox.Show("هناك نقص في البيانات هل أنت واثق من حفظ البيانات بهذا الشكل", "نقص في البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        Insert_Food();
                    }
                    else if(result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    Insert_Food();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static double Convert_To_Double(string text)
        {
            double check;
            Double.TryParse(text, out check);
            if (check > 0)
            {
                return check;
            }
            else
            {
                return 0;
            }
        }

        private void insert_Food_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (foodGrid.Rows[0].Cells[1].Value.Equals(food_Name_Tb.Text) == true)
                {
                    MessageBox.Show("هذا الصنف موجود بالفعل");
                }
                else
                {
                    Insert_Check();
                    Populate_food(foodGrid);
                    Empty_boxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void foodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    food_Name_Tb.Text = foodGrid.SelectedRows[0].Cells[1].Value?.ToString();
                    food_Qty_Tb.Text = foodGrid.SelectedRows[0].Cells[2].Value?.ToString();
                    food_Pro_Tb.Text = foodGrid.SelectedRows[0].Cells[3].Value?.ToString();
                    food_Carb_Tb.Text = foodGrid.SelectedRows[0].Cells[4].Value?.ToString();
                    food_Fat_Tb.Text = foodGrid.SelectedRows[0].Cells[5].Value?.ToString();
                    food_Cal_Tb.Text = foodGrid.SelectedRows[0].Cells[6].Value?.ToString();
                    food_K_Tb.Text = foodGrid.SelectedRows[0].Cells[7].Value?.ToString();
                    food_NA_Tb.Text = foodGrid.SelectedRows[0].Cells[8].Value?.ToString();
                    food_PH_Tb.Text = foodGrid.SelectedRows[0].Cells[9].Value?.ToString();
                    food_CA_Tb.Text = foodGrid.SelectedRows[0].Cells[10].Value?.ToString();
                    food_Water_Tb.Text = foodGrid.SelectedRows[0].Cells[11].Value?.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Food()
        {
            try
            {
                if (Convert.ToInt32(foodGrid.SelectedRows[0].Cells[0].Value) == null)
                {
                    MessageBox.Show("تأكد من اختيار الصنف من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (food_Name_Tb.Text == "" || food_Qty_Tb.Text == "" || food_Cal_Tb.Text == "" || food_Carb_Tb.Text == "" || food_CA_Tb.Text == "" || food_Fat_Tb.Text == "" || food_K_Tb.Text == "" || food_NA_Tb.Text == "" || food_PH_Tb.Text == "" || food_Pro_Tb.Text == "" || food_Water_Tb.Text == "")
                {
                    MessageBox.Show("رجاءً ادخل جميع الخنات المطلوبه او اكتب 0", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "Update_food";
                     food_ID = Convert.ToInt32(foodGrid.SelectedRows[0].Cells[0].Value);
                     qty = Convert.ToInt32(food_Qty_Tb.Text);
                     pro = Convert.ToDouble(food_Pro_Tb.Text);
                     Carb = Convert.ToDouble(food_Carb_Tb.Text);
                     Fat = Convert.ToDouble(food_Fat_Tb.Text);
                     Cal = Convert.ToDouble(food_Cal_Tb.Text);
                     K = Convert.ToDouble(food_K_Tb.Text);
                     NA = Convert.ToDouble(food_NA_Tb.Text);
                     PH = Convert.ToDouble(food_PH_Tb.Text);
                     CA = Convert.ToDouble(food_CA_Tb.Text);
                     Water = Convert.ToDouble(food_Water_Tb.Text);
                    fd.Excute_Update_food_Procedures(query, food_ID, food_Name_Tb.Text, qty, pro, Carb, Fat, Cal, K, NA, PH, CA, Water);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Food_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(foodGrid.SelectedRows[0].Cells[0].Value) == null)
                {
                    MessageBox.Show("تأكد من اختيار الصنف من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (food_Name_Tb.Text == "" || food_Qty_Tb.Text == "" || food_Cal_Tb.Text == "" || food_Carb_Tb.Text == "" || food_CA_Tb.Text == "" || food_Fat_Tb.Text == "" || food_K_Tb.Text == "" || food_NA_Tb.Text == "" || food_PH_Tb.Text == "" || food_Pro_Tb.Text == "" || food_Water_Tb.Text == "")
                {
                    MessageBox.Show("رجاءً ادخل جميع الخنات المطلوبه او اكتب 0", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Update_Food();
                    MessageBox.Show("تم تحديث الصنف بنجاح", "تحديث", MessageBoxButtons.OK);
                    Populate_food(foodGrid);
                    Empty_boxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Delete_food()
        {
            try
            {
                    if (Convert.ToInt32(foodGrid.SelectedRows[0].Cells[0].Value) == null)
                    {
                        MessageBox.Show("تأكد من اختيار الصنف من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        parameter = "@food_ID";
                        query = "Delete_food";
                        food_ID = Convert.ToInt32(foodGrid.SelectedRows[0].Cells[0].Value);
                        delete_Populate.Delete_Procedures(query,parameter, food_ID);
                    }
                
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Delete_Food_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل انته واثق من حذف الصنف", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    Delete_food();
                    MessageBox.Show("تم حذف الصنف بنجاح", "حذف", MessageBoxButtons.OK);
                    Populate_food(foodGrid);
                    Empty_boxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        public void search_Food(MetroFramework.Controls.MetroTextBox textBox, MetroFramework.Controls.MetroGrid metroGrid)
        {
            query = "search_food";
            parameter = "@Food_Name";
            Fname = textBox.Text;
            metroGrid.DataSource = delete_Populate.Search_procedures(query, Fname, parameter);
            if(textBox.Text == "")
            {
                Populate_food(foodGrid);
            }
        }

        private void food_Search_Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                search_Food(food_Search_Tb,foodGrid);
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
