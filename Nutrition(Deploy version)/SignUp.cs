using INutrition;
using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nutrition
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        User_procedures user_Procedures = new User_procedures();
        Login login = new Login();
        string query, email, username, password;
        int status;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            Password_Tb.StyleManager = metroStyleManager1;
            Username_Tb           .StyleManager = metroStyleManager1;
            Email_Tb              .StyleManager = metroStyleManager1;
            ConfirmPassword_Tb    .StyleManager = metroStyleManager1;
            metroLabel1           .StyleManager = metroStyleManager1;
            Sign_Up_Btn.StyleManager = metroStyleManager1;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SignUp_style();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void Insert_User()
        {
            try
            {
                query = "Insert_User";
                email = Email_Tb.Text;
                username = Username_Tb.Text;
                password = Password_Tb.Text;
                if (email == "" || username == "" || password == "")
                {
                    MessageBox.Show("تأكد من تعبئة جميع الخانات من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (password != ConfirmPassword_Tb.Text)
                    {
                        MessageBox.Show("كلمة السر الخاصة بك غير متطابق", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        status = user_Procedures.SignIn_User(query, email, username, password);
                        if(status == 0)
                        {
                            DialogResult result;
                            result = MessageBox.Show("\n اسم المستخدم او كلمة المرور مستخدمه في حساب اخر للعوده إلى صفحة تسجيل الدخول اضغط"+ "\nYes", "هذا الحساب موجود بالفعل", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("INutrition" + " شكرا على التسجيل في برنامج ", username + "اهلاً بك ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sign_Up_Btn_Click(object sender, EventArgs e)
        {
            Insert_User();
        }

        
    }
}
