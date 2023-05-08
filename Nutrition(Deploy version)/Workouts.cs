using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Nutrition;
using System.Diagnostics;
using Aspose.Pdf.Operators;

namespace INutrition
{
    public partial class Workouts :  MetroFramework.Forms.MetroForm
    {
        public Workouts()
        {
            InitializeComponent();
        }
        string query,extn,filename, filepath;
        Workouts_Procedures Workouts_Procedures = new Workouts_Procedures();
        Procedures_exe pop = new Procedures_exe();


        private void uploadBTN_Click(object sender, EventArgs e)
        {
            Save_workout();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            Delete_workout();
        }

        private void Workouts_Load(object sender, EventArgs e)
        {
            Workouts_style();
            pop.Fill_Cb_Byname("SELECT W_Name FROM WORKOUTS", "W_Name", workoutNameCB);

        }

        private void workoutNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Workouts_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            metroTextBox1.StyleManager = metroStyleManager1;
            uploadBTN.StyleManager = metroStyleManager1;
            workoutNameCB.StyleManager= metroStyleManager1;
        }

        private void Save_workout()
        {
            string fileName = "Workouts";
            string targetPath = @"Workouts";

            
            try
            {
                //this.openFileDialog1.InitialDirectory = @"E:\";
                this.openFileDialog1.Title = "البحث عن التمرين";
                this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                DialogResult result = this.openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    query = "Insert_workout";
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(fileName);
                    }
                    
                    extn = "workouts";
                    filepath = this.openFileDialog1.FileName;
                    var fi = new FileInfo(filepath);
                    filename = fi.Name;
                    try
                    {
                      //  pictureBox1.Image = Image.FromFile(filepath);
                    }
                    catch (Exception E)
                    {
                        result = MessageBox.Show("اضغط (Yes)إذا كنت ترغب في فتح الملف", "هذا الملف غير قابل للعرض", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(filepath);
                        }
                    }
                    File.Copy(filepath, Path.Combine(extn, Path.GetFileName(filepath)), true);
                    Workouts_Procedures.Insert_Workout(query, extn, filename);
                    MessageBox.Show("تم حفظ الملف بنجاح");
                    pop.Fill_Cb_Byname("SELECT W_Name FROM WORKOUTS", "W_Name", workoutNameCB);

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_workout()
        {
            try
            {
                string fileName = "Workouts";
                string targetPath = @"Workouts";

                this.openFileDialog1.InitialDirectory = "C:\\Nutrition(Deploy version)\\bin\\Debug\\Workouts";
                this.openFileDialog1.Title = "البحث عن التمرين";
                //openFileDialog1.InitialDirectory = "Nutrition\\bin\\Debug\\Workouts";
                this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
                DialogResult result = this.openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    query = "deleteWorkouts";
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(fileName);
                    }
                    extn = "workouts";
                    filepath = this.openFileDialog1.FileName;
                    var fi = new FileInfo(filepath);
                    filename = fi.Name;


                    result = MessageBox.Show("هل انته واثق من حذف هذا الملف", "عملية حذف", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Workouts_Procedures.Delete_Workout(query, filename);
                        foreach (var process in Process.GetProcessesByName("Photos"))
                        {
                            process.Kill();
                        }
                        File.Delete(filepath);
                        MessageBox.Show("تم حذف الملف بنجاح");
                        pop.Fill_Cb_Byname("SELECT W_Name FROM WORKOUTS", "W_Name", workoutNameCB);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
    public partial class Workouts_Procedures
    {
        public SqlConnection SqlConnection()
        {
            Connection cn = new Connection();
            SqlConnection Con = cn.Getconnection();
            return Con;
        }

        public void Insert_Workout(string query, string extn, string name)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@ext", SqlDbType.NVarChar).Value = extn;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void Delete_Workout(string query, string name)
        {
            SqlConnection Con = SqlConnection();
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@W_Name", SqlDbType.NVarChar).Value = name;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
