using INutrition;
using MetroFramework.Controls;
using MetroFramework.Drawing.Html;
using Nutrition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition
{
    public partial class C_form : MetroFramework.Forms.MetroForm
    {
        //this class "Delete_populate" is for only the dynamic delete and update procedures
        Procedures_exe delete_Populate = new Procedures_exe();
        private Clients_procedures cp = new Clients_procedures();
        string query, parameter;
        string name, Address, Status , Gender = "", TargetNutri , Notes;
        string S_Player ,phone, S_type , S_SEASON , S_Level , S_Champion, G_Player , G_Goal , G_SEASON , G_Level , G_Champion , W_Player, W_type , W_Time, Contract_NOTES;
        int contract_ID, number_months;

        private void Discount_Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if(double.TryParse(number_Months_CB.SelectedItem, out Subtotal)
                Subtotal = Convert.ToInt32(number_Months_CB.SelectedItem) * 200;
                if (Discount_Tb.Text != "")
                {
                    Discount = Convert.ToDouble(Discount_Tb.Text);
                    TOTAL = Subtotal - (Subtotal * Discount / 100);
                    total_Tb.Text = TOTAL.ToString();
                    subtotal_Tb.Text = Subtotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "حدث خطاء", MessageBoxButtons.OK);
            }
        }
 
        DateTime DOB, C_StartDate;
        Double TOTAL, Subtotal, Discount;

        private void Search_Contract_Tb_TextChanged(object sender, EventArgs e)
        {
            Search_Contract();
        }

        private void Search_Contract()
        {
            query = "search_Contract";
            name = Search_Contract_Tb.Text;
            parameter = "@C_Name";
            Contract_Grid.DataSource = delete_Populate.Search_procedures(query, name, parameter);
            if (Search_Contract_Tb.Text == "")
            {
                Populate_contractTbl();
            }
        }

        private void Contract_Grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Update_Contract();
        }

        private void s_Type_CB_Click(object sender, EventArgs e)
        {
            Fill_sport_Cb();
        }

        private void Delete_Contract()
        {
            parameter = "@contract_ID";
            query = "Delete_Contract";
            contract_ID = Convert.ToInt32(Contract_Grid.SelectedRows[0].Cells[1].Value);
            delete_Populate.Delete_Procedures(query, parameter, contract_ID);
        }

        private void Delete_Contract_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل أنت واثق من حذف العميل", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    Delete_Contract();
                    Populate_contractTbl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في البيانات" + ex, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public C_form()
        {
            InitializeComponent();
        }

        private void C_form_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;

            C_TabControl.StyleManager = metroStyleManager1;
            metroTabPage1                                 .StyleManager = metroStyleManager1;
            metroTabPage3                                 .StyleManager = metroStyleManager1;
            C_Name_Tb                                     .StyleManager = metroStyleManager1;
            C_adress_Tb                                   .StyleManager = metroStyleManager1;
            C_phone_Tb                                    .StyleManager = metroStyleManager1;
            C_DOB_Tb                                      .StyleManager = metroStyleManager1;
            C_female                                      .StyleManager = metroStyleManager1;
            C_male                                        .StyleManager = metroStyleManager1;
            C_status_Tb                                   .StyleManager = metroStyleManager1;
            C_notes_Tb                                    .StyleManager = metroStyleManager1;
             C_goalNutrtion_Tb                            .StyleManager = metroStyleManager1;
             metroLabel1                                  .StyleManager = metroStyleManager1;
             upload_Inbody_btn                            .StyleManager = metroStyleManager1;
             save_client_btn                              .StyleManager = metroStyleManager1;
            metroLabel4                                   .StyleManager = metroStyleManager1;
            metroLabel13                                  .StyleManager = metroStyleManager1;
            metroLabel12                                  .StyleManager = metroStyleManager1;
            metroLabel11                                  .StyleManager = metroStyleManager1;
            number_Months_CB                              .StyleManager = metroStyleManager1;
            contract_start_DT                             .StyleManager = metroStyleManager1;
            Discount_Tb                                   .StyleManager = metroStyleManager1;
            total_Tb                                      .StyleManager = metroStyleManager1;
            subtotal_Tb                                   .StyleManager = metroStyleManager1;
             metroLabel14                                 .StyleManager = metroStyleManager1;
             metroTabPage2                                .StyleManager = metroStyleManager1;
             w_Time_Tb                                    .StyleManager = metroStyleManager1;
             w_Type_Tb                                    .StyleManager = metroStyleManager1;
             metroLabel9                                  .StyleManager = metroStyleManager1;
             g_Level_CB                                   .StyleManager = metroStyleManager1;
             addSportBtn                                  .StyleManager = metroStyleManager1;
             s_Champion_Tb                                .StyleManager = metroStyleManager1;
             g_Goal_Tb                                    .StyleManager = metroStyleManager1;
             metroLabel5                                  .StyleManager = metroStyleManager1;
             metroLabel6                                  .StyleManager = metroStyleManager1;
             g_Champion_Tb                                .StyleManager = metroStyleManager1;
             s_Level_CB                                   .StyleManager = metroStyleManager1;
             metroLabel3                                  .StyleManager = metroStyleManager1;
             s_Type_CB                                    .StyleManager = metroStyleManager1;
             metroLabel2                                  .StyleManager = metroStyleManager1;
             metroLabel15                                 .StyleManager = metroStyleManager1;
             metroLabel10                                 .StyleManager = metroStyleManager1;
             metroLabel8                                  .StyleManager = metroStyleManager1;
             metroLabel17                                 .StyleManager = metroStyleManager1;
             metroLabel16                                 .StyleManager = metroStyleManager1;
             metroLabel18                                 .StyleManager = metroStyleManager1;
             metroLabel7                                  .StyleManager = metroStyleManager1;
             sSeson_CheckBox_No                           .StyleManager = metroStyleManager1;
             sSeson_CheckBox_Yes                          .StyleManager = metroStyleManager1;
             sPlayer_CheckBox_No                          .StyleManager = metroStyleManager1;
             sPlayer_CheckBox_Yes                         .StyleManager = metroStyleManager1;
             wPlayer_CheckBox_No                          .StyleManager = metroStyleManager1;
             wPlayer_CheckBox_Yes                         .StyleManager = metroStyleManager1;
             gSeson_CheckBox_No                           .StyleManager = metroStyleManager1;
             gSeson_CheckBox_Yes                          .StyleManager = metroStyleManager1;
             gPlayer_CheckBox_No                          .StyleManager = metroStyleManager1;
             gPlayer_CheckBox_Yes                         .StyleManager = metroStyleManager1;
             metroButton3                                 .StyleManager = metroStyleManager1;
             Contract_Grid                                .StyleManager = metroStyleManager1;
             contract_Notes_Tb                            .StyleManager = metroStyleManager1;
             metroLabel20                                 .StyleManager = metroStyleManager1;
             metroLabel19                                 .StyleManager = metroStyleManager1;
            Delete_Contract_Btn                           .StyleManager = metroStyleManager1;
             Search_Contract_Tb                           .StyleManager = metroStyleManager1;
            Delete_Contract_Btn                           .StyleManager = metroStyleManager1;
        }

        private void C_form_Load(object sender, EventArgs e)
        {
            C_form_style();
            C_DOB_Tb.ClientSize = new System.Drawing.Size(229, 50);
            Populate_contractTbl();
            Fill_sport_Cb();
        }

        private void Populate_contractTbl()
        {
            query = "populate_Contract";
            Contract_Grid.DataSource = delete_Populate.Populate_Procedures(query);
        }

        public void Fill_sport_Cb()
        {
            query = "select S_Name from Sports";
            string sportName = "S_Name";
            delete_Populate.Fill_Cb_Byname(query, sportName, s_Type_CB);
        }

        private void addSportBtn_Click(object sender, EventArgs e)
        {
            Sports sports = new Sports();
            sports.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            C_archive archive = new C_archive();
            archive.ShowDialog();
            Hide();
        }

        private void Insert_Client()
        {
            try
            {
                if (C_Name_Tb.Text == "" || C_phone_Tb.Text == "" || C_adress_Tb.Text == "" || C_status_Tb.SelectedItem.ToString() == null || s_Type_CB.SelectedValue.ToString() == null || s_Champion_Tb.Text == "" || g_Goal_Tb.Text == "" || g_Level_CB.SelectedItem.ToString() == null || g_Champion_Tb.Text == "" || w_Type_Tb.Text == "" || w_Time_Tb.Text == "" || number_Months_CB.SelectedItem == null || subtotal_Tb.Text == "" || Discount_Tb.Text == "" || total_Tb.Text == "" || contract_Notes_Tb.Text == "")
                {
                    DialogResult result;
                    result = MessageBox.Show("هنالك نقص في البيانات هل انت واثق من حفظ بيانات العميل بهذا الشكل", "نقص في البيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if(result == DialogResult.Yes)
                    {
                        query = "Insert_Client";
                        //personal
                        name = C_Name_Tb.Text;
                        phone = C_phone_Tb.Text;
                        Address = C_adress_Tb.Text;

                        if(C_status_Tb.SelectedItem?.ToString() == null || s_Level_CB.SelectedItem?.ToString() == null || g_Level_CB.SelectedItem?.ToString() == null)
                        {
                            Status = "";
                            S_Level = "";
                            G_Level = "";
                        }
                        else
                        {
                            S_Level = s_Level_CB.SelectedItem?.ToString();
                            Status = C_status_Tb.SelectedItem?.ToString();
                            G_Level = g_Level_CB.SelectedItem?.ToString();
                        }

                        if (C_male.Checked == true) { Gender = "زكر"; } else if (C_female.Checked == true) { Gender = "أنثى"; }
                        TargetNutri = C_goalNutrtion_Tb.Text;
                        Notes = C_notes_Tb.Text;
                        //sport
                        if (sPlayer_CheckBox_Yes.Checked == true) { S_Player = sPlayer_CheckBox_Yes.Text; } else if (sPlayer_CheckBox_No.Checked == true) { S_Player = sPlayer_CheckBox_No.Text; }

                        S_type = s_Type_CB.SelectedValue?.ToString();

                        if (sSeson_CheckBox_Yes.Checked == true) { S_SEASON = sSeson_CheckBox_Yes.Text; } else if (sSeson_CheckBox_No.Checked == true) { S_SEASON = sSeson_CheckBox_No.Text; };

                        S_Champion = s_Champion_Tb.Text;
                        if (gPlayer_CheckBox_Yes.Checked == true) { G_Player = gPlayer_CheckBox_Yes.Text; } else if (gPlayer_CheckBox_No.Checked == true) { G_Player = gPlayer_CheckBox_No.Text; };
                        G_Goal = g_Goal_Tb.Text;
                        if (gSeson_CheckBox_Yes.Checked == true) { G_SEASON = gSeson_CheckBox_Yes.Text; } else if (gSeson_CheckBox_No.Checked == true) { G_SEASON = gSeson_CheckBox_No.Text; };

                        G_Champion = g_Champion_Tb.Text;
                        if (wPlayer_CheckBox_Yes.Checked == true) { W_Player = wPlayer_CheckBox_Yes.Text; } else if (wPlayer_CheckBox_No.Checked == true) { W_Player = wPlayer_CheckBox_No.Text; };
                        W_type = w_Type_Tb.Text;
                        W_Time = w_Time_Tb.Text;
                        //contract
                        DOB = C_DOB_Tb.Value;
                        C_StartDate = contract_start_DT.Value;
                        number_months = Convert.ToInt32(number_Months_CB.SelectedItem);
                        if(number_months > 0) 
                        {
                            Subtotal = Convert.ToDouble(subtotal_Tb.Text);
                            Discount = Convert.ToDouble(Discount_Tb.Text);
                            TOTAL = Convert.ToDouble(total_Tb.Text);
                        }
                        Contract_NOTES = contract_Notes_Tb.Text;

                        MemoryStream stream = new MemoryStream();
                        C_inbody_Ib.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] inbody = stream.ToArray();

                        cp.Excute_Insert_Client_Procedures(query, name, phone, Address, Status, Gender, DOB, TargetNutri, Notes, inbody, S_Player, S_type, S_SEASON, S_Level, S_Champion, G_Player, G_Goal, G_SEASON, G_Level, G_Champion, W_Player, W_type, W_Time, C_StartDate, number_months, Subtotal, Discount, TOTAL, Contract_NOTES);

                        MessageBox.Show("تم حفظ العميل بنجاح", "", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_client_btn_Click(object sender, EventArgs e)
        {
            Insert_Client();
            Empty_boxes();
        }

        private void upload_Inbody_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            C_inbody_Ib.Image = Image.FromFile(filePath);
        }

        private void Update_Contract()
        {
            try
            {
                if (Convert.ToInt32(Contract_Grid.SelectedRows[0].Cells[1].Value) == null)
                {
                    MessageBox.Show("رجاءً أختر الصف", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    query = "Update_contract";
                    contract_ID = Convert.ToInt32(Contract_Grid.SelectedRows[0].Cells[1].Value);
                    Contract_NOTES = contract_Notes_Tb.Text;
                    TOTAL = Convert.ToDouble(total_Tb.Text);
                    Subtotal = Convert.ToDouble(subtotal_Tb.Text);
                    Discount = Convert.ToDouble(Discount_Tb.Text);
                    C_StartDate = contract_start_DT.Value;
                    number_months = Convert.ToInt32(number_Months_CB.SelectedValue);
                    cp.Excute_Update_Contract_Procedures(query, contract_ID, C_StartDate, number_months, Subtotal, Discount, TOTAL, Contract_NOTES);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Contract_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contract_start_DT.Text = Contract_Grid.SelectedRows[0].Cells[2].Value?.ToString();
                number_Months_CB.Text = Contract_Grid.SelectedRows[0].Cells[3].Value?.ToString();
                subtotal_Tb.Text = Contract_Grid.SelectedRows[0].Cells[4].Value?.ToString();
                Discount_Tb.Text = Contract_Grid.SelectedRows[0].Cells[5].Value?.ToString();
                total_Tb.Text = Contract_Grid.SelectedRows[0].Cells[6].Value?.ToString();
                contract_Notes_Tb.Text = Contract_Grid.SelectedRows[0].Cells[7].Value?.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Empty_boxes()
        {
            C_Name_Tb.Text = "";
            C_phone_Tb.Text = "";
            C_adress_Tb.Text = "";
            C_status_Tb.Text = "";
            if (C_male.Checked == true) { Gender = "زكر"; } else { Gender = "أنثى"; }
            C_goalNutrtion_Tb.Text = "";
            C_notes_Tb.Text = "";
            //sport
            s_Type_CB.Text = "";
            s_Level_CB.Text = "";
            s_Champion_Tb.Text = "";
            g_Goal_Tb.Text = "";
            g_Level_CB.Text = "";
            g_Champion_Tb.Text = "";
            w_Type_Tb.Text = "";
            w_Time_Tb.Text = "";
            //contract
            number_Months_CB.Text = "";
            total_Tb.Text = "";
            subtotal_Tb.Text = "";
            Discount_Tb.Text = "";
            contract_Notes_Tb.Text = "";
        }
    }
}
