using MetroFramework.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Nutrition;
using INutrition;
using System.Xml.Linq;
using System.Threading;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.LogicalStructure;
using Aspose.Pdf.Forms;
using Aspose.Pdf.Facades;
using Aspose.Pdf.GroupProcessor;
using Aspose.Pdf.LogicalStructure;
using Aspose.Foundation.UriResolver;
using Aspose.Pdf.Operators;
using Aspose.Pdf.Optimization;
using Aspose.Pdf.PdfAOptionClasses;
using Aspose.Pdf.Sanitization;
using Aspose.Pdf.Structure;
using Aspose.Pdf.Tagged;
using Aspose.Pdf.XfaConverter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using MetroFramework.Components;


namespace Nutrition
{
    public partial class AllNutrition : MetroFramework.Forms.MetroForm
    {

        public AllNutrition()
        {
            for (int i = 0; i < 10; i++)
            {
                allRows.Add(new DataGridViewRow[20]);
            }
            InitializeComponent();
            foodselectedinMealGV.Rows.Clear();
        }

        Connection cn = new Connection();
        Procedures_exe pop = new Procedures_exe();
        AllNutrition_procedures Nutrition_Procedures = new AllNutrition_procedures();
        List<MetroGrid> metroGrids = new List<MetroGrid>();

        private static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void Select_client_Info()
        {
            DataTable dataTable = new DataTable();
            string name = clientNameCB.SelectedValue.ToString();
            dataTable = pop.Search_procedures("returnDateClient", name, "@C_Name");
            clientsNotesTB.Text = dataTable.Rows[0]["C_notes"].ToString();
           // pictureBox1.Image = ByteToImage((byte[])dataTable.Rows[0]["C_inbody"]);
            startDateClientsTile.Text = dataTable.Rows[0]["C_StartDate"].ToString();
            sportsNameTile.Text = dataTable.Rows[0]["S_type"].ToString();
        }
        private void Style_Form()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            metroTabControl1.StyleManager = metroStyleManager1;
            nutritionTabPage.StyleManager = metroStyleManager1;
            NutritionNotesTB.StyleManager = metroStyleManager1;
            clientsNotesTB.StyleManager = metroStyleManager1;
            sportsNameTile.StyleManager = metroStyleManager1;
            startDateClientsTile.StyleManager = metroStyleManager1;
            ArchieveClientsBTN.StyleManager = metroStyleManager1;
            numberOfDaysNutritionLBL.StyleManager = metroStyleManager1;
            numberOfDaysNutritionTB.StyleManager = metroStyleManager1;
            nutrition_NameLBL.StyleManager = metroStyleManager1;
            nutritionNameTB.StyleManager = metroStyleManager1;
            WorkoutNameLBL.StyleManager = metroStyleManager1;
            workoutNameCB.StyleManager = metroStyleManager1;
            clientNameLBL.StyleManager = metroStyleManager1;
            clientNameCB.StyleManager = metroStyleManager1;
            mealsTabPage.StyleManager = metroStyleManager1;
            SaveBTN.StyleManager = metroStyleManager1;
            PrintBTN.StyleManager = metroStyleManager1;
            ChooseFoodTB.StyleManager = metroStyleManager1;
            NameMealTB.StyleManager = metroStyleManager1;
            searcchFoodGV.StyleManager = metroStyleManager1;
            addFoodtoMealBTN.StyleManager = metroStyleManager1;
            foodGramsTextBox2.StyleManager = metroStyleManager1;
            deleteMealBTN.StyleManager = metroStyleManager1;
            AddMealBTN.StyleManager = metroStyleManager1;
            TOTAL_CA_TB.StyleManager = metroStyleManager1;
            TOTAL_PH_TB.StyleManager = metroStyleManager1;
            TOTAL_NA_TB.StyleManager = metroStyleManager1;
            TOTAL_K_TB.StyleManager = metroStyleManager1;
            TOTAL_FAT_TB.StyleManager = metroStyleManager1;
            TOTAL_CHO_TB.StyleManager = metroStyleManager1;
            TOTAL_PROTIEN_TB.StyleManager = metroStyleManager1;
            TOTAL_CALOIRIES_TB.StyleManager = metroStyleManager1;
            metroLabel7.StyleManager = metroStyleManager1;
            metroLabel8.StyleManager = metroStyleManager1;
            metroLabel9.StyleManager = metroStyleManager1;
            metroLabel10.StyleManager = metroStyleManager1;
            metroLabel11.StyleManager = metroStyleManager1;
            ProtienLBL.StyleManager = metroStyleManager1;
            CaloriesLBL.StyleManager = metroStyleManager1;
            FatLBL.StyleManager = metroStyleManager1;
            CarbLBL.StyleManager = metroStyleManager1;
            MealsTabControler.StyleManager = metroStyleManager1;
            metroTabPage7.StyleManager = metroStyleManager1;
            archieveTabPage.StyleManager = metroStyleManager1;
            DeleteNutritionBTN.StyleManager = metroStyleManager1;
            searchNutriNameTB.StyleManager = metroStyleManager1;
            NutritionArchievemGV.StyleManager = metroStyleManager1;
            foodselectedinMealGV.StyleManager = metroStyleManager1;
            RefreshBTN.StyleManager = metroStyleManager1;
        }
        private void AllNutrition_Load(object sender, EventArgs e)
        {
            Style_Form();
            SqlConnection sqlConnection = cn.Getconnection();
            sqlConnection.Open();
            Thread.Sleep(500);
            sqlConnection.Close();

            //retreive client_name , workout_name
            pop.Fill_Cb_Byname("SELECT C_Name FROM Clients ", "C_Name", clientNameCB);
            pop.Fill_Cb_Byname("SELECT W_Name FROM WORKOUTS", "W_Name", workoutNameCB);
            NutritionArchievemGV.DataSource = pop.Populate_Procedures("populate_nutrition_archieve");

            Populate_food();
        }

        private void Populate_food()
        {
            try
            {
                string query = "populate_food";
                searcchFoodGV.DataSource = pop.Populate_Procedures(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_food()
        {
            Food food = new Food();
            food.search_Food(ChooseFoodTB, searcchFoodGV);
        }

        private void ChooseFoodTB_TextChanged(object sender, EventArgs e)
        {
            search_food();
        }

        private void deleteMealBTN_Click(object sender, EventArgs e)
        {           
            int selected = MealsTabControler.SelectedIndex;
            allRows.RemoveAt(selected);
            allRows.Add(new DataGridViewRow[20]);
            int count = foodselectedinMealGV.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                delete_food_from_Meal();
            }
            MealsTabControler.TabPages.Remove(MealsTabControler.TabPages[selected]);
        }

        int selected;


        private void AddMealBTN_Click(object sender, EventArgs e)
        {

            MealsTabControler.TabPages.Add(NameMealTB.Text, NameMealTB.Text);
            int selected = MealsTabControler.TabPages.Count - 1;
           
        }

        double TOTAL_protien = 0;
        double TOTAL_CARB = 0;
        double TOTAL_FAT = 0;
        double TOTAL_CALORIES = 0;
        double TOTAL_K = 0;
        double TOTAL_NA = 0;
        double TOTAL_PH = 0;
        double TOTAL_CA = 0;


        private void searcchFoodGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = searcchFoodGV.Rows[e.RowIndex];
                string food_Name = row.Cells[1].Value.ToString();
            }
        }

        public DataTable Search_procedures(string query, string Name, string para)
        {
            SqlConnection Con = cn.Getconnection();
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

        private void searchNutriNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Search_procedures("SELECT * FROM NUTRITION WHERE N_Name = " + searchNutriNameTB.Text, searchNutriNameTB.Text, "N_Name");
            }
        }

        private void insert_nutrition_facts(string query, double Total_Protein, double Total_CARB, double Total_FAT, double Total_CALORIES, double Total_k, double Total_NA, double Total_PH, double Total_CA)
        {
            //--SAVE_NUTRI_FACTS
            //@Total_Protein FLOAT(53), @Total_CARB FLOAT(53), @Total_FAT FLOAT(53), @Total_CALORIES FLOAT(53), @Total_k FLOAT(53),
            //@Total_NA FLOAT(53), @Total_PH FLOAT(53), @Total_CA FLOAT(53),
            SqlConnection Con = cn.Getconnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Total_Protein", SqlDbType.Float).Value = Total_Protein;
            cmd.Parameters.AddWithValue("@Total_CARB", SqlDbType.Float).Value = Total_CARB;
            cmd.Parameters.AddWithValue("@Total_FAT", SqlDbType.Float).Value = Total_FAT;
            cmd.Parameters.AddWithValue("@Total_CALORIES", SqlDbType.Float).Value = Total_CALORIES;
            cmd.Parameters.AddWithValue("@Total_k", SqlDbType.Float).Value = Total_k;
            cmd.Parameters.AddWithValue("@Total_NA", SqlDbType.Float).Value = Total_NA;
            cmd.Parameters.AddWithValue("@Total_PH", SqlDbType.Float).Value = Total_PH;
            cmd.Parameters.AddWithValue("@Total_CA", SqlDbType.Float).Value = Total_CA;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void insert_meal_food(string query, string FoodName, double FoodGram)
        {
            SqlConnection Con = cn.Getconnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FoodName", SqlDbType.NVarChar).Value = FoodName;
            cmd.Parameters.AddWithValue("@FoodGrams", SqlDbType.Float).Value = FoodGram;
            cmd.ExecuteNonQuery();
            Con.Close();
            //--SAVE_MEAL_FOOD
            //@FoodName NVARCHAR(50),
            //@FoodGrams INT

        }

        private void insert_nutri_meal(string query, string MEAL_NAME)
        {
            SqlConnection Con = cn.Getconnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MealName", SqlDbType.NVarChar).Value = MEAL_NAME;
            cmd.ExecuteNonQuery();
            Con.Close();


        }

        private void insert_Nutrition(string query, string nutrition_name, string nutri_days, string NUTRI_INSTRUCTION, string client_Name, string workout_name)

        {
            SqlConnection Con = cn.Getconnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@N_Name", SqlDbType.NVarChar).Value = nutrition_name;
            cmd.Parameters.AddWithValue("@N_Days", SqlDbType.DateTime).Value = nutri_days;
            cmd.Parameters.AddWithValue("@N_INSTRUCTION", SqlDbType.Int).Value = NUTRI_INSTRUCTION;
            cmd.Parameters.AddWithValue("@C_Name", SqlDbType.Float).Value = client_Name;
            cmd.Parameters.AddWithValue("@W_NAME", SqlDbType.Float).Value = workout_name;
            cmd.ExecuteNonQuery();
            Con.Close();

        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            selected = MealsTabControler.SelectedIndex;
            foodselectedinMealGV.Rows.CopyTo(allRows[selected], 0);
            //1- insert nutrition 
            string nutrition_name = nutritionNameTB.Text;
            string nutri_days = numberOfDaysNutritionTB.Text;
            string NUTRI_INSTRUCTION = NutritionNotesTB.Text;
            string client_Name = clientNameCB.SelectedValue.ToString();
            string workout_name = workoutNameCB.SelectedValue == null ? "null value" : workoutNameCB.SelectedValue.ToString();
            insert_Nutrition("SAVE_NUTRI", nutrition_name, nutri_days, NUTRI_INSTRUCTION, client_Name, workout_name);

            //loop outer meals ,inner food

            foreach (TabPage tabPage in MealsTabControler.TabPages)
            {
                //2- insert nutri_meal
                string MEAL_NAME = tabPage.Text;
                //MessageBox.Show(MEAL_NAME);
                insert_nutri_meal("SAVE_NUTRI_Meal", MEAL_NAME);

                // allRows ==> Array of Meal Food Rows
                for (int i = 0; i < allRows[MealsTabControler.TabPages.IndexOf(tabPage)].Length; i++)
                {
                    if (allRows[MealsTabControler.TabPages.IndexOf(tabPage)][i] == null)
                    {
                        break;
                    }
                    //3-insert Food for each meal 
                    //--SAVE_MEAL_FOOD
                    //@FoodName NVARCHAR(50),
                    //@FoodGrams INT

                    var name = allRows[MealsTabControler.TabPages.IndexOf(tabPage)][i].Cells[0].Value.ToString();
                    double grams = double.Parse(allRows[MealsTabControler.TabPages.IndexOf(tabPage)][i].Cells[1].Value.ToString());
                    insert_meal_food("SAVE_MEAL_FOOD", name, grams);
                }



            }

            insert_nutrition_facts("SAVE_NUTRI_FACTS", double.Parse(TOTAL_PROTIEN_TB.Text), double.Parse(TOTAL_CHO_TB.Text), double.Parse(TOTAL_FAT_TB.Text),
                                                       double.Parse(TOTAL_CALOIRIES_TB.Text), double.Parse(TOTAL_K_TB.Text), double.Parse(TOTAL_NA_TB.Text)
                                                       , double.Parse(TOTAL_PH_TB.Text), double.Parse(TOTAL_CA_TB.Text));
            //then save next meal,etc.
            //4-insert nutrition_facts
            NutritionArchievemGV.DataSource = pop.Populate_Procedures("populate_nutrition_archieve");

        }

        private void searchNutriNameTB_TextChanged(object sender, EventArgs e)
        {
            if (searchNutriNameTB.Text != "")
            {
                NutritionArchievemGV.DataSource = pop.Search_procedures("search_nutrition", searchNutriNameTB.Text, "@N_Name");
            }
            else
            {
                NutritionArchievemGV.DataSource = pop.Populate_Procedures("populate_nutrition_archieve");
            }

        }
        double precent;
        double quantity;


        private void addFoodtoMealBTN_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = searcchFoodGV.SelectedRows[0];
            string food_Name = row.Cells[1].Value.ToString();

            if (foodGramsTextBox2.Text != "" ) 
            {
                try
                {
                    foodselectedinMealGV.Rows.Add(food_Name, foodGramsTextBox2.Text);

                    quantity = Convert.ToDouble(row.Cells[2].Value.ToString());

                    precent = ((Convert.ToDouble(foodGramsTextBox2.Text)) / quantity);

                    TOTAL_protien = Math.Floor(((double.Parse(row.Cells[3].Value.ToString()) * precent)));
                    TOTAL_CARB = Math.Floor(((double.Parse(row.Cells[4].Value.ToString()) * precent)));
                    TOTAL_FAT = Math.Floor(((double.Parse(row.Cells[5].Value.ToString()) * precent)));
                    TOTAL_CALORIES = Math.Floor(((double.Parse(row.Cells[6].Value.ToString()) * precent)));
                    TOTAL_K = Math.Floor(((double.Parse(row.Cells[7].Value.ToString()) * precent)));
                    TOTAL_NA = Math.Floor(((double.Parse(row.Cells[8].Value.ToString()) * precent)));
                    TOTAL_PH = Math.Floor(((double.Parse(row.Cells[9].Value.ToString()) * precent)));
                    TOTAL_CA = Math.Floor(((double.Parse(row.Cells[10].Value.ToString()) * precent)));

                    TOTAL_CALOIRIES_TB.Text = (Convert.ToDouble(TOTAL_CALOIRIES_TB.Text) + TOTAL_CALORIES).ToString();
                    TOTAL_CA_TB.Text = (Convert.ToDouble(TOTAL_CA_TB.Text) + TOTAL_CA).ToString();
                    TOTAL_CHO_TB.Text = (Convert.ToDouble(TOTAL_CHO_TB.Text) + TOTAL_CARB).ToString();
                    TOTAL_FAT_TB.Text = (Convert.ToDouble(TOTAL_FAT_TB.Text) + TOTAL_FAT).ToString();
                    TOTAL_K_TB.Text = (Convert.ToDouble(TOTAL_K_TB.Text) + TOTAL_K).ToString();
                    TOTAL_NA_TB.Text = (Convert.ToDouble(TOTAL_NA_TB.Text) + TOTAL_NA).ToString();
                    TOTAL_PH_TB.Text = (Convert.ToDouble(TOTAL_PH_TB.Text) + TOTAL_PH).ToString();
                    TOTAL_PROTIEN_TB.Text = (Convert.ToDouble(TOTAL_PROTIEN_TB.Text) + TOTAL_protien).ToString();
                }
                catch (Exception E)
                {
                    MessageBox.Show("لقد نسيت ادخال عدد الجرامات ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("لقد نسيت ادخال عدد الجرامات ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       

        private void DeleteNutritionBTN_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = NutritionArchievemGV.SelectedRows[0];
            int NID = (int)row.Cells[0].Value;
            pop.Delete_Procedures("Delete_NutritionArchive", "@N_ID", NID);
            NutritionArchievemGV.DataSource = pop.Populate_Procedures("populate_nutrition_archieve");

        }
        public static int Convert_To_INT(string text)
        {
            int check;
            int.TryParse(text, out check);
            if (check > 0)
            {
                return check;
            }
            else
            {
                return 0;
            }
        }

        //private void Update_NutritionArchieve()
        //{
        //    DataGridViewRow row = NutritionArchievemGV.SelectedRows[0];
        //    int N_ID = int.Parse(row.Cells[0].Value.ToString() ?? "");
        //    string N_Name = row.Cells[1].Value.ToString() ?? "";
        //    string N_Days = row.Cells[2].Value.ToString() ?? "";
        //    string N_INSTRUCTION = row.Cells[3].Value.ToString() ?? "";
        //    int C_ID = int.Parse(row.Cells[4].Value.ToString() ?? "");
        //    int W_ID = Convert_To_INT(row.Cells[5].Value.ToString() ?? "");
        //    int Meal_ID = int.Parse(row.Cells[6].Value.ToString() ?? "");
        //    string MealName = row.Cells[8].Value.ToString() ?? "";
        //    double Total_Protein = double.Parse(row.Cells[10].Value.ToString());
        //    double Total_CARB = (double)row.Cells[11].Value;
        //    double Total_FAT = (double)row.Cells[12].Value;
        //    double Total_CALORIES = (double)row.Cells[13].Value;
        //    double Total_k = (double)row.Cells[14].Value;
        //    double Total_NA = (double)row.Cells[15].Value;
        //    double Total_PH = (double)row.Cells[16].Value;
        //    double Total_CA = (double)row.Cells[17].Value;
        //    string FoodName = row.Cells[20].Value.ToString() ?? "";
        //    int FoodGrams = int.Parse(row.Cells[21].Value.ToString() ?? "");

        //    Nutrition_Procedures.Update_nutrition_Archive("Update_NutritionArchive", N_ID, N_Name, N_Days, N_INSTRUCTION, C_ID, W_ID, Meal_ID, MealName, Total_Protein, Total_CARB, Total_FAT, Total_CALORIES, Total_k, Total_NA, Total_PH, Total_CA, FoodName, FoodGrams);
        //    MessageBox.Show("تم تعديل بنجاح", "success", MessageBoxButtons.OK);
        //}
       

        //private void NutritionArchievemGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    Update_NutritionArchieve();
        //}

        private void AddMealBTN_Click_1(object sender, EventArgs e)
        {
            MealsTabControler.TabPages.Add(NameMealTB.Text, NameMealTB.Text);

        }
        

        List<DataGridViewRow[]> allRows = new List<DataGridViewRow[]>(10);

        private void MealsTabControler_Deselected(object sender, TabControlEventArgs e)
        {
            selected = MealsTabControler.SelectedIndex;
            //MessageBox.Show("deselected : ", foodselectedinMealGV.Rows.ToString());
            if (selected >= 0)
            {
                foodselectedinMealGV.Rows.CopyTo(allRows[selected], 0);
                foodselectedinMealGV.Rows.Clear();
            }

        }

        private void MealsTabControler_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int selected = MealsTabControler.SelectedIndex;
                if (selected != -1)
                {
                    MealsTabControler.TabPages[selected].Controls.Add(foodselectedinMealGV);
                    
                    for (int i = 0; i < allRows[selected].Length; i++)
                    {
                        if (allRows[selected][i] != null)
                            foodselectedinMealGV.Rows.Add(allRows[selected][i]);
                    }
                }
            
        }


        private void clientNameCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Select_client_Info();
        }

        private void ArchieveClientsBTN_Clic(object sender, EventArgs e)
        {
            C_archive c_Archive = new C_archive();
            c_Archive.ShowDialog();
            Hide();
        }

        private void delete_food_from_Meal()
        {
            double qty;
            int selected;
            int selectedRow;
            string foodSelected;

            selected = MealsTabControler.SelectedIndex;
            if (foodselectedinMealGV.CurrentCell == null || foodselectedinMealGV.CurrentCell.Value.ToString() == "" || Convert.ToDouble(foodselectedinMealGV.SelectedRows[0].Cells[1].Value) <= 0)
            {
                MessageBox.Show("لا يوجد اكلات في الجدول");
                foodSelected = "";
                qty = 0;
                selectedRow = 0;

            }
            else
            {
                selectedRow = foodselectedinMealGV.CurrentCell.RowIndex;
                foodSelected = Convert.ToString(foodselectedinMealGV.CurrentCell.Value);
                qty = Convert.ToDouble(foodselectedinMealGV.SelectedRows[0].Cells[1].Value);

                DataTable dataTable = pop.Search_procedures("search_food_Distinct", foodSelected, "@Food_Name");


                double grams = double.Parse(dataTable.Rows[0][2].ToString());

                double protine = double.Parse(dataTable.Rows[0][3].ToString());
                double cho = double.Parse(dataTable.Rows[0][4].ToString());
                double fat = double.Parse(dataTable.Rows[0][5].ToString());
                double calories = double.Parse(dataTable.Rows[0][6].ToString());
                double K = double.Parse(dataTable.Rows[0][7].ToString());
                double Na = double.Parse(dataTable.Rows[0][8].ToString());
                double Ph = double.Parse(dataTable.Rows[0][9].ToString());
                double Ca = double.Parse(dataTable.Rows[0][10].ToString());

                protine = Math.Floor(Nutri_Calculate(qty, grams, protine));
                cho = Math.Floor(Nutri_Calculate(qty, grams, cho));
                fat = Math.Floor(Nutri_Calculate(qty, grams, fat));
                calories = Math.Floor(Nutri_Calculate(qty, grams, calories));
                K = Math.Floor(Nutri_Calculate(qty, grams, K));
                Na = Math.Floor(Nutri_Calculate(qty, grams, Na));
                Ph = Math.Floor(Nutri_Calculate(qty, grams, Ph));
                Ca = Math.Floor(Nutri_Calculate(qty, grams, Ca));



                TOTAL_CALOIRIES_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CALOIRIES_TB.Text) - calories)).ToString();
                TOTAL_CA_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CA_TB.Text) - Ca)).ToString();
                TOTAL_CHO_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CHO_TB.Text) - cho)).ToString();
                TOTAL_FAT_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_FAT_TB.Text) - fat)).ToString();
                TOTAL_K_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_K_TB.Text) - K)).ToString();
                TOTAL_NA_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_NA_TB.Text) - Na)).ToString();
                TOTAL_PH_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_PH_TB.Text) - Ph)).ToString();
                TOTAL_PROTIEN_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_PROTIEN_TB.Text) - protine)).ToString();


                //if (allRows[selected][selectedRow] != null)
                //{
                //    allRows[selected] = allRows[selected].Where(val => val != allRows[selected][selectedRow]).ToArray();
                //}
                //else
                //{
                foodselectedinMealGV.Rows.RemoveAt(selectedRow);
                // }

            }
        }

        private void foodselectedinMealGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //delete_food_from_Meal();

            double qty;
            int selected;
            int selectedRow;
            string foodSelected;

            selected = MealsTabControler.SelectedIndex;
            if (foodselectedinMealGV.CurrentCell == null || foodselectedinMealGV.CurrentCell.Value.ToString() == "" || Convert.ToDouble(foodselectedinMealGV.SelectedRows[0].Cells[1].Value) <= 0)
            {
                MessageBox.Show("لا يوجد اكلات في الجدول");
                foodSelected = "";
                qty = 0;
                selectedRow = 0;

            }
            else
            {
                selectedRow = foodselectedinMealGV.CurrentCell.RowIndex;
                foodSelected = Convert.ToString(foodselectedinMealGV.CurrentCell.Value);
                qty = Convert.ToDouble(foodselectedinMealGV.SelectedRows[0].Cells[1].Value);

                DataTable dataTable = pop.Search_procedures("search_food_Distinct", foodSelected, "@Food_Name");


                double grams = double.Parse(dataTable.Rows[0][2].ToString());

                double protine = double.Parse(dataTable.Rows[0][3].ToString());
                double cho = double.Parse(dataTable.Rows[0][4].ToString());
                double fat = double.Parse(dataTable.Rows[0][5].ToString());
                double calories = double.Parse(dataTable.Rows[0][6].ToString());
                double K = double.Parse(dataTable.Rows[0][7].ToString());
                double Na = double.Parse(dataTable.Rows[0][8].ToString());
                double Ph = double.Parse(dataTable.Rows[0][9].ToString());
                double Ca = double.Parse(dataTable.Rows[0][10].ToString());

                protine = Math.Floor(Nutri_Calculate(qty, grams, protine));
                cho = Math.Floor(Nutri_Calculate(qty, grams, cho));
                fat = Math.Floor(Nutri_Calculate(qty, grams, fat));
                calories = Math.Floor(Nutri_Calculate(qty, grams, calories));
                K = Math.Floor(Nutri_Calculate(qty, grams, K));
                Na = Math.Floor(Nutri_Calculate(qty, grams, Na));
                Ph = Math.Floor(Nutri_Calculate(qty, grams, Ph));
                Ca = Math.Floor(Nutri_Calculate(qty, grams, Ca));



                TOTAL_CALOIRIES_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CALOIRIES_TB.Text) - calories)).ToString();
                TOTAL_CA_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CA_TB.Text) - Ca)).ToString();
                TOTAL_CHO_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_CHO_TB.Text) - cho)).ToString();
                TOTAL_FAT_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_FAT_TB.Text) - fat)).ToString();
                TOTAL_K_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_K_TB.Text) - K)).ToString();
                TOTAL_NA_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_NA_TB.Text) - Na)).ToString();
                TOTAL_PH_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_PH_TB.Text) - Ph)).ToString();
                TOTAL_PROTIEN_TB.Text = (Math.Floor(Convert.ToDouble(TOTAL_PROTIEN_TB.Text) - protine)).ToString();

                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    if (allRows[selected][selectedRow] != null)
                    {
                        allRows[selected] = allRows[selected].Where(val => val != allRows[selected][selectedRow]).ToArray();
                    }
                    else
                    {
                        foodselectedinMealGV.Rows.RemoveAt(selectedRow);
                    }
                    //foodselectedinMealGV.Rows.RemoveAt(selectedRow);              
                }
            }
        }
        private double Nutri_Calculate(double qty, double grams, double element)
        {
            precent = (qty / grams);
            element = element * precent;
            return element;
        }

        private void clear_nulls()
        {

            for (int j = 0; j < MealsTabControler.TabCount; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (allRows[j][i] == null)
                    {
                        allRows[j] = allRows[j].Where(val => val != allRows[j][i]).ToArray();
                        break;
                    }
                }
            }
        }

       
        private void clear_nulls_printed(List<DataGridViewRow[]> printed_All_Rows)
        {

            for (int j = 0; j < MealsTabControler.TabCount; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (printed_All_Rows[j][i] == null)
                    {
                        printed_All_Rows[j] = printed_All_Rows[j].Where(val => val != printed_All_Rows[j][i]).ToArray();
                        break;
                    }
                }
            }
        }
        
        private void printPdf(object sender, EventArgs e)
        {
            SaveBTN_Click(sender, e);
            if (1 == 1)
            {
                int selected = MealsTabControler.SelectedIndex;
                if (selected == MealsTabControler.TabCount - 1)
                {
                    if (selected >= 0)
                    {
                        foodselectedinMealGV.Rows.CopyTo(allRows[selected], 0);
                    }
                }
                

                List<DataGridViewRow[]> printed_All_Rows = new List<DataGridViewRow[]>(10);

                for (int i = 0; i < 10; i++)
                {
                    printed_All_Rows.Add(new DataGridViewRow[20]);
                }


                // Copy AllRows in printed_All_Rows
                for (int j = 0; j < MealsTabControler.TabCount; j++)
                {
                    allRows[j].CopyTo(printed_All_Rows[j], 0);

                    for (int i = 0; i < 100; i++)
                    {
                        // Remove nulls from (printed_All_Rows)
                        if (allRows[j][i] == null)
                        {
                            printed_All_Rows[j] = allRows[j].Where(val => val != allRows[j][i]).ToArray();
                            break;
                        }
                        
                    }
                }

               

                // print (printed_All_Rows) instead of (allRows)

                Document pdfDocument15 = new Document("noor.pdf");

                Aspose.Pdf.Page pdfPage25 = (Aspose.Pdf.Page)pdfDocument15.Pages[1];

                TextFragment textFragment2 = new TextFragment(clientNameCB.SelectedValue.ToString());

                textFragment2.Position = new Position(200, 695);
                textFragment2.TextState.Font = FontRepository.FindFont("Arial Black");
                textFragment2.TextState.FontSize = 24;
                textFragment2.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                // Create TextBuilder object 
                TextBuilder textBuilder25 = new TextBuilder(pdfPage25);

                TextFragment textFragment3 = new TextFragment(numberOfDaysNutritionTB.Text);
                textFragment3.Position = new Position(345, 530);
                textFragment3.TextState.Font = FontRepository.FindFont("Arial Black");
                textFragment3.TextState.FontSize = 18;


                // Append the text fragment to the PDF page
                textBuilder25.AppendText(textFragment2);
                textBuilder25.AppendText(textFragment3);

                //m -= 30;
                // Save resulting PDF document.
                pdfDocument15.Save("newNutrition.pdf");


                /////////////////////////////////////////////////////////////////////////////////////////
                // Write instructions 

                Document pdfDocument16 = new Document("newNutrition.pdf");
                string paragraph1 = NutritionNotesTB.Text;
                //for (int i = 0; i < paragraph1; i++)
                //{
                //    List<string> List_paragraphs = paragraph1[i].ToList<string>();
                //}

                List<string> paragraph_list = paragraph1.Split(' ').ToList();
                string temporary = "";
                int yaxis = 420;
                int start = 0;
                int max = 10;
                for (int i = 0; i < (paragraph_list.Count / 10) + 1; i++)
                {
                    temporary = "";
                    for (int v = start; v < max; v++)
                    {
                        if (v >= paragraph_list.Count)
                        {

                        }
                        else
                        {
                            temporary += paragraph_list[v].ToString() + " ";
                            //paragraph_list.RemoveAt(v);
                        }
                    }

                    Aspose.Pdf.Page pdfPage26 = (Aspose.Pdf.Page)pdfDocument15.Pages[3];
                    TextFragment textFragment26 = new TextFragment(temporary);
                    textFragment26.Position = new Position(100, yaxis);
                    textFragment26.TextState.Font = FontRepository.FindFont("Arial Black");
                    textFragment26.TextState.FontSize = 18;
                    textFragment26.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);
                    // Create TextBuilder object 
                    TextBuilder textBuilder26 = new TextBuilder(pdfPage26);

                    // Append the text fragment to the PDF page
                    textBuilder26.AppendText(textFragment26);
                    //Xasix -= 20;
                    //    }
                    yaxis -= 25;
                    start += 10;
                    max += 10;

                }
                //}

                // Save resulting PDF document.
                pdfDocument15.Save("newNutrition.pdf");

                ///////////////////////////////////////////////////////////////////////////////////////////
                Document pdfDocument = new Document("newNutrition.pdf");
                //Aspose.Pdf.Page pdfPage = (Aspose.Pdf.Page)pdfDocument.Pages[2];
                int k = 420;

                // Create text fragment
                for (int i = 0; i < MealsTabControler.TabCount; i++)
                {
                    Aspose.Pdf.Page pdfPage4 = (Aspose.Pdf.Page)pdfDocument.Pages[1];

                    TextFragment textFragment4 = new TextFragment("\u2022" + MealsTabControler.TabPages[i].Text + " : ");
                    textFragment4.Position = new Position(350, k);

                    // Set text properties
                    textFragment4.TextState.FontSize = 18;
                    textFragment4.TextState.Font = FontRepository.FindFont("Arial Black");
                    textFragment4.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.OrangeRed);

                    // Create TextBuilder object
                    TextBuilder textBuilder4 = new TextBuilder(pdfPage4);

                    // Append the text fragment to the PDF page
                    textBuilder4.AppendText(textFragment4);
                    //int m = 440;
                    //string[] ss;
                    foreach (DataGridViewRow viewRow in printed_All_Rows[i])
                    {
                        //  m -= 105;
                        //ss.Append(viewRow.Cells[0].Value.ToString() + "  " + viewRow.Cells[1].Value.ToString() + "جرام" + " ، ");
                        TextFragment textFragment5 = new TextFragment(viewRow.Cells[0].Value.ToString() + "  " + viewRow.Cells[1].Value.ToString() + "جرام" + " ، " + "\n");
                        // for (int j = 0; j < ss.Length; j++)
                        // {
                        // TextFragment textFragment5 = new TextFragment(ss[j]);
                        textFragment5.Position = new Position(120, k);

                        // Set text properties
                        textFragment5.TextState.FontSize = 16;
                        textFragment5.TextState.Font = FontRepository.FindFont("Arial Black");
                        textFragment5.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                        // Create TextBuilder object
                        TextBuilder textBuilder5 = new TextBuilder(pdfPage4);

                        // Append the text fragment to the PDF page
                        textBuilder5.AppendText(textFragment5);
                        //  }

                        k -= 15;
                    }
                    k -= 10;


                }

                pdfDocument.Save("newNutrition.pdf");



                ////////////////////////////////////////////////////////////////////////////////
                // Write Nutrition Facts into PDF.

                decimal[] paragraphs = new decimal[8];
                paragraphs[0] = Math.Floor(Decimal.Parse(TOTAL_CHO_TB.Text));
                paragraphs[1] = Math.Floor(Decimal.Parse(TOTAL_PROTIEN_TB.Text));
                paragraphs[2] = Math.Floor(Decimal.Parse(TOTAL_CALOIRIES_TB.Text));
                paragraphs[3] = Math.Floor(Decimal.Parse(TOTAL_FAT_TB.Text));
                paragraphs[4] = Math.Floor(Decimal.Parse(TOTAL_K_TB.Text));
                paragraphs[5] = Math.Floor(Decimal.Parse(TOTAL_NA_TB.Text));
                paragraphs[6] = Math.Floor(Decimal.Parse(TOTAL_CA_TB.Text));
                paragraphs[7] = Math.Floor(Decimal.Parse(TOTAL_PH_TB.Text));

                // i create this list for distination when i print 
                List<int> destination = new List<int>() { 150, 170, 180, 140, 140, 140, 140, 140 };

                int m = 450;
                for (int l = 0; l < paragraphs.Length; l++)
                {
                    Aspose.Pdf.Page pdfPage2 = (Aspose.Pdf.Page)pdfDocument.Pages[2];
                    TextFragment textFragment6 = new TextFragment(paragraphs[l].ToString());
                    textFragment6.Position = new Position(destination[l], m);

                    // Set text properties
                    textFragment6.TextState.FontSize = 14;
                    textFragment6.TextState.Font = FontRepository.FindFont("Arial Black");
                    textFragment6.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

                    // Create TextBuilder object 
                    TextBuilder textBuilder2 = new TextBuilder(pdfPage2);

                    // Append the text fragment to the PDF page
                    textBuilder2.AppendText(textFragment6);
                    m -= 22;
                    // Save resulting PDF document.
                }
                pdfDocument.Save("newNutrition.pdf");


                // create PdfFileEditor object
                PdfFileEditor pdfEditor = new PdfFileEditor();
                // merge files
                pdfEditor.Concatenate("part1.pdf", "newNutrition.pdf", "merged.pdf");
                Document pdfDocument1 = new Document("merged.pdf");

                //   System.IO.File.Copy("newNutrition.pdf", nutritionNameTB.Text);

                string fileName = "Nutrition Plans";
              //  string sourcePath = @"";
                string targetPath = @"Nutrition Plans";

                //// Use Path class to manipulate file and directory paths.
                //string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                //string destFile = System.IO.Path.Combine(targetPath, fileName);

                // To copy a folder's contents to a new location:
                // Create a new target folder.
                // If the directory already exists, this method does not create a new directory.
                //System.IO.Directory.CreateDirectory(targetPath);

                // To copy a file to another location and
                // overwrite the destination file if it already exists.
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(fileName);
                }

                if (!System.IO.File.Exists(fileName + "/" + nutritionNameTB.Text + ".pdf"))
                {
                    pdfDocument1.Save(fileName + "/" + nutritionNameTB.Text + ".pdf");


                }
                else
                {
                    DialogResult dr = MessageBox.Show("Do you want to write over exist file \n this mean the past file will be deleted?",
                                          "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            pdfDocument1.Save(fileName + "/" + nutritionNameTB.Text + ".pdf");
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                MessageBox.Show("تم حفظ وطباعة النظام الغذائى بنجاح ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        int clock = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clock == 0)
            {
                pictureBox1.Size = new Size(508, 600);
                clock = 1;
            }
            else
            {
                pictureBox1.Size = new Size(380, 200);
                clock = 0;
            }
        }

        private void searchNutriNameTB_TextChanged_1(object sender, EventArgs e)
        {
            if (searchNutriNameTB.Text != "")
            {
                NutritionArchievemGV.DataSource = pop.Search_procedures("search_nutrition", searchNutriNameTB.Text, "@N_Name");
            }
            else
            {
                NutritionArchievemGV.DataSource = pop.Populate_Procedures("populate_nutrition_archieve");
            }
        }

        AllNutrition_procedures cc= new AllNutrition_procedures();

        private void clear_ALLRows_and_GridView()
        {
            allRows.Clear();
            for (int i = 0; i < 10; i++)
            {
                allRows.Add(new DataGridViewRow[20]);
            }
            foodselectedinMealGV.Rows.Clear();
            TOTAL_CALOIRIES_TB.Text = "0";
            TOTAL_CA_TB.Text =        "0";
            TOTAL_CHO_TB.Text =       "0";
            TOTAL_FAT_TB.Text =       "0";
            TOTAL_K_TB.Text =         "0";
            TOTAL_NA_TB.Text =        "0";
            TOTAL_PH_TB.Text =        "0";
            TOTAL_PROTIEN_TB.Text =   "0";
        }

        private void NutritionArchievemGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //messagebox  with Yes or No Buttons
            DialogResult dialogResult = MessageBox.Show("Are you sure to open this nutrition plan \n this will lose the current nutrition plan ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
            


                  allRows.Clear();
                  for (int i = 0; i < 10; i++)
                  {
                      allRows.Add(new DataGridViewRow[20]);
                  }
                  //MealsTabControler.TabPages.Clear();
                  int counter_tabPages = MealsTabControler.TabPages.Count;
                  //1.get N_ID
                  DataGridViewRow row = NutritionArchievemGV.SelectedRows[0];
                  int NID = (int)row.Cells[0].Value;
                  
                  //2.procedure for return [mealsname] by (N_ID)
                  DataTable dataTable_meals_name = cc.return_meals_name("return_Meals_name", NID);
                  
                  // open row in meals(tabpage)
                  for (int i  = 0; i  < dataTable_meals_name.Rows.Count; i ++)
                  {
                      MealsTabControler.TabPages.Add(dataTable_meals_name.Rows[i][0].ToString());
                      int Meal_Id = Convert.ToInt16(dataTable_meals_name.Rows[i][1].ToString());
                      DataTable dataTable_foods_in_meal = cc.return_Foods_in_meal("return_Foods_in_meal", NID, Meal_Id);
                      int number_foods =  dataTable_foods_in_meal.Rows.Count;
                      // if rows != null clear rows
                      if (foodselectedinMealGV.Rows.Count != null)
                      {
                          foodselectedinMealGV.Rows.Clear();
                      }
                      foodselectedinMealGV.Rows.Add(number_foods);
                  
                      for (int k = 0; k < dataTable_foods_in_meal.Rows.Count; k++)
                      {                                                    
                          for (int j = 0; j < 2; j++)
                          {
                              var y = dataTable_foods_in_meal.Rows[k][j].ToString();
                              foodselectedinMealGV.Rows[k].Cells[j].Value = y;                            
                          }
                      }

                      foodselectedinMealGV.Rows.CopyTo(allRows[i], 0);
                      foodselectedinMealGV.Rows.Clear();
                  
                  }
                  
                  //Return Nutrition Facts in textBoxes
                  DataGridViewRow row1 = NutritionArchievemGV.SelectedRows[0];
                  double Total_Protein = Convert.ToDouble(row.Cells[8].Value);
                  double Total_CARB =     Convert.ToDouble(row.Cells[9].Value);
                  double Total_FAT =      Convert.ToDouble(row.Cells[10].Value);
                  double Total_CALORIES = Convert.ToDouble(row.Cells[11].Value);
                  double Total_k = Convert.ToDouble(row.Cells[12].Value);
                  double Total_NA = Convert.ToDouble(row.Cells[13].Value);
                  double Total_PH = Convert.ToDouble(row.Cells[14].Value);
                  double Total_CA = Convert.ToDouble(row.Cells[15].Value);
                  
                  //if textboxes null 
                  TOTAL_CALOIRIES_TB.Text = Convert.ToString(Total_CALORIES);
                  TOTAL_CA_TB.Text        = Convert.ToString(Total_CA)       ;
                  TOTAL_CHO_TB.Text       = Convert.ToString(Total_CARB)     ;
                  TOTAL_FAT_TB.Text       = Convert.ToString(Total_FAT)      ;
                  TOTAL_K_TB.Text         = Convert.ToString(Total_k)        ;
                  TOTAL_NA_TB.Text        = Convert.ToString(Total_NA)       ;
                  TOTAL_PH_TB.Text        = Convert.ToString(Total_PH)       ;
                  TOTAL_PROTIEN_TB.Text   = Convert.ToString(Total_Protein)  ;                                   
                  
                  
                  //remove previous tabpages
                  for (int i = 0; i < counter_tabPages; i++)
                  {
                      MealsTabControler.TabPages.RemoveAt(i);
                  
                  }
                  
                  MessageBox.Show("لقد تم فتح النظام الغذائى بنجاح  \n برجاء الذهاب للوجبات ");
                      //3.procedure for return [foodnames] & [grams] by (N_ID , Meal_ID) 
                  
                      //4.save it at [ALLROWS]
                      //5. move nutrtion facts from [row[ to [textboxes]
                  
            }
            else if (dialogResult == DialogResult.No)
            {
                 //Do something
            }

        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            clear_ALLRows_and_GridView();
            if (MealsTabControler.TabCount > 0)
            {
                MealsTabControler.TabPages.Clear();
            }
            MealsTabControler.TabPages.Add("الفطار", "الفطار");
            MealsTabControler.TabPages["الفطار"].Controls.Add(foodselectedinMealGV);
        }

       
    }





    public partial class AllNutrition_procedures
        {
            public SqlConnection SqlConnection()
            {
                Connection cn = new Connection();
                SqlConnection Con = cn.Getconnection();
                return Con;
            }

            public void Update_nutrition_Archive(string query, int N_ID, string N_Name, string N_Days, string N_INSTRUCTION, int C_ID, int W_ID, int Meal_ID, string MealName, double Total_Protein, double Total_CARB, double Total_FAT, double Total_CALORIES, double Total_k, double Total_NA, double Total_PH, double Total_CA, string FoodName, int FoodGrams)
            {
                SqlConnection Con = SqlConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@N_ID", SqlDbType.Int).Value = N_ID;
                cmd.Parameters.AddWithValue("@N_Name", SqlDbType.NVarChar).Value = N_Name;
                cmd.Parameters.AddWithValue("@N_Days", SqlDbType.NVarChar).Value = N_Days;
                cmd.Parameters.AddWithValue("@N_INSTRUCTION", SqlDbType.NVarChar).Value = N_INSTRUCTION;
                cmd.Parameters.AddWithValue("@C_ID", SqlDbType.Int).Value = C_ID;
                cmd.Parameters.AddWithValue("@W_ID", SqlDbType.Int).Value = W_ID;
                cmd.Parameters.AddWithValue("@Meal_ID", SqlDbType.Int).Value = Meal_ID;
                cmd.Parameters.AddWithValue("@MealName", SqlDbType.NVarChar).Value = MealName;
                cmd.Parameters.AddWithValue("@Total_Protein", SqlDbType.Float).Value = Total_Protein;
                cmd.Parameters.AddWithValue("@Total_CARB", SqlDbType.Float).Value = Total_CARB;
                cmd.Parameters.AddWithValue("@Total_FAT", SqlDbType.Float).Value = Total_FAT;
                cmd.Parameters.AddWithValue("@Total_CALORIES", SqlDbType.Float).Value = Total_CALORIES;
                cmd.Parameters.AddWithValue("@Total_k", SqlDbType.Float).Value = Total_k;
                cmd.Parameters.AddWithValue("@Total_NA", SqlDbType.Float).Value = Total_NA;
                cmd.Parameters.AddWithValue("@Total_PH", SqlDbType.Float).Value = Total_PH;
                cmd.Parameters.AddWithValue("@Total_CA", SqlDbType.Float).Value = Total_CA;
                cmd.Parameters.AddWithValue("@FoodName", SqlDbType.NVarChar).Value = FoodName;
                cmd.Parameters.AddWithValue("@FoodGrams", SqlDbType.Int).Value = FoodGrams;
                cmd.ExecuteNonQuery();
            }
            
            public DataTable return_meals_name(string query, int N_ID)
            {
                SqlConnection Con = SqlConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@N_ID", SqlDbType.Int).Value = N_ID;
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Con.Close();
                return dt;

            }
           
            public DataTable return_Foods_in_meal(string query, int N_ID,int Meal_ID)
            {
                SqlConnection Con = SqlConnection();
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@N_ID", SqlDbType.Int).Value = N_ID;
                cmd.Parameters.AddWithValue("@Meal_ID", SqlDbType.Int).Value = Meal_ID;
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Con.Close();
                return dt;
            }

    }    
    
}



