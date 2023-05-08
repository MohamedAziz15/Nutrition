using INutrition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition
{
    public partial class ForgetPassword : MetroFramework.Forms.MetroForm
    {
        User_procedures user_Procedures = new User_procedures();
        Login login = new Login();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void Reset_Password_Btn_Click(object sender, EventArgs e)
        {
            Reset_Password(); 
        }
        
        private void Reset_Password()
        {
            string query, email, username, password, message;
            query = "Change_Password_User";
            email = Email_Tb.Text;
            username = Username_Tb.Text;
            password = New_Password_Tb.Text.Trim();

            if (email == "" || username == "" || password == "")
            {
                MessageBox.Show("تأكد من تعبئة جميع الخانات من فضلك", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (New_Password_Tb.Text.Trim() != Confirm_Password_Tb.Text.Trim())
                {
                    MessageBox.Show("كلمة السر الخاصة بك غير متطابقة", "نقص في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    user_Procedures.Change_Password_Insert_User(query, email, username, password);
                    
                        DialogResult result;
                        result = MessageBox.Show("\n للعوده إلى صفحة تسجيل الدخول اضغط" + "\nYes", "تم تغير كلمة السر بنجاح", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                            login.Show();
                        }
                }
            }
        }

        private void ForgetPassword_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            Confirm_Password_Tb.StyleManager = metroStyleManager1;
            Email_Tb.StyleManager = metroStyleManager1;
            New_Password_Tb.StyleManager = metroStyleManager1;
            Reset_Password_Btn.StyleManager = metroStyleManager1;
            Username_Tb.StyleManager = metroStyleManager1;
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            ForgetPassword_style();
        }
    }
}
