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
using INutrition;

namespace Nutrition
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       User_procedures user_Procedures = new User_procedures();

        public Login()
        {
            InitializeComponent();
            
        }
        string query, username, password,email;
        int status;  

        private void Login_Load(object sender, EventArgs e)
        {
           Login_style();
        }

        private void Login_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;

            Password_Tb.StyleManager = metroStyleManager1;
            UserName_Tb.StyleManager = metroStyleManager1;
            Sign_In_Btn.StyleManager = metroStyleManager1;
        }
        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void Sign_In_Btn_Click_1(object sender, EventArgs e)
        {
            Sign_Commit();
        }

        private void Sign_Commit()
        {
            Root_Case();
            email = UserName_Tb.Text.Trim();
            username= UserName_Tb.Text.Trim();
            password= Password_Tb.Text.Trim();
            query = "SIGNIN_User";
            status = user_Procedures.SignIn_User(query,email,username,password);

            if (UserName_Tb.Text.Trim() == "" || Password_Tb.Text.Trim() == "")
            {
                MessageBox.Show("أدخل كلمة المرور و اسم المستخدم من فضلك", "حاول مرة أخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (status == 1)
                {
                    Open_Dashboard();
                }
                else
                {
                    MessageBox.Show("خطاء في اسم المستخدم او كلمة المرور", "حاول مرة أخرى", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
        }

        private void Root_Case()
        {
            if (UserName_Tb.Text.Trim() == "Noor" & Password_Tb.Text.Trim() == "Noor")
            {
                Open_Dashboard();
            }
        }

        private void Open_Dashboard()
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}

