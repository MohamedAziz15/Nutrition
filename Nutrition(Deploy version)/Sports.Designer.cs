namespace Nutrition
{
    partial class Sports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sport_Name_Tb = new MetroFramework.Controls.MetroTextBox();
            this.AddSport = new MetroFramework.Controls.MetroButton();
            this.delete_sportBtn = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sport_Name_Tb
            // 
            // 
            // 
            // 
            this.Sport_Name_Tb.CustomButton.Image = null;
            this.Sport_Name_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.Sport_Name_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.Sport_Name_Tb.CustomButton.Name = "";
            this.Sport_Name_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Sport_Name_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Sport_Name_Tb.CustomButton.TabIndex = 1;
            this.Sport_Name_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Sport_Name_Tb.CustomButton.UseSelectable = true;
            this.Sport_Name_Tb.CustomButton.Visible = false;
            this.Sport_Name_Tb.Lines = new string[0];
            this.Sport_Name_Tb.Location = new System.Drawing.Point(11, 72);
            this.Sport_Name_Tb.MaxLength = 32767;
            this.Sport_Name_Tb.Multiline = true;
            this.Sport_Name_Tb.Name = "Sport_Name_Tb";
            this.Sport_Name_Tb.PasswordChar = '\0';
            this.Sport_Name_Tb.PromptText = "اسم الرياضة";
            this.Sport_Name_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Sport_Name_Tb.SelectedText = "";
            this.Sport_Name_Tb.SelectionLength = 0;
            this.Sport_Name_Tb.SelectionStart = 0;
            this.Sport_Name_Tb.ShortcutsEnabled = true;
            this.Sport_Name_Tb.Size = new System.Drawing.Size(229, 33);
            this.Sport_Name_Tb.TabIndex = 1;
            this.Sport_Name_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Sport_Name_Tb.UseSelectable = true;
            this.Sport_Name_Tb.UseStyleColors = true;
            this.Sport_Name_Tb.WaterMark = "اسم الرياضة";
            this.Sport_Name_Tb.WaterMarkColor = System.Drawing.SystemColors.ControlText;
            this.Sport_Name_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AddSport
            // 
            this.AddSport.Location = new System.Drawing.Point(11, 121);
            this.AddSport.Name = "AddSport";
            this.AddSport.Size = new System.Drawing.Size(94, 33);
            this.AddSport.TabIndex = 4;
            this.AddSport.Text = "حفظ";
            this.AddSport.UseSelectable = true;
            this.AddSport.UseStyleColors = true;
            this.AddSport.Click += new System.EventHandler(this.AddSport_Click);
            // 
            // delete_sportBtn
            // 
            this.delete_sportBtn.Location = new System.Drawing.Point(146, 121);
            this.delete_sportBtn.Name = "delete_sportBtn";
            this.delete_sportBtn.Size = new System.Drawing.Size(94, 33);
            this.delete_sportBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.delete_sportBtn.TabIndex = 5;
            this.delete_sportBtn.Text = "حذف";
            this.delete_sportBtn.UseSelectable = true;
            this.delete_sportBtn.UseStyleColors = true;
            this.delete_sportBtn.Click += new System.EventHandler(this.delete_sportBtn_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 180);
            this.Controls.Add(this.delete_sportBtn);
            this.Controls.Add(this.AddSport);
            this.Controls.Add(this.Sport_Name_Tb);
            this.MaximizeBox = false;
            this.Name = "Sports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "إضافة رياضة";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Sports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Sport_Name_Tb;
        private MetroFramework.Controls.MetroButton AddSport;
        private MetroFramework.Controls.MetroButton delete_sportBtn;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}