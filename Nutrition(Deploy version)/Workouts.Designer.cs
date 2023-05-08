namespace INutrition
{
    partial class Workouts
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
            this.uploadBTN = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Delete_Btn = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.workoutNameCB = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBTN
            // 
            this.uploadBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadBTN.Location = new System.Drawing.Point(885, 96);
            this.uploadBTN.Margin = new System.Windows.Forms.Padding(2);
            this.uploadBTN.Name = "uploadBTN";
            this.uploadBTN.Size = new System.Drawing.Size(132, 46);
            this.uploadBTN.TabIndex = 0;
            this.uploadBTN.Text = "رفع ملف التمرين";
            this.uploadBTN.UseSelectable = true;
            this.uploadBTN.UseStyleColors = true;
            this.uploadBTN.Click += new System.EventHandler(this.uploadBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(18, 96);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "بحث عن تمرين";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(226, 33);
            this.metroTextBox1.TabIndex = 17;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "بحث عن تمرين";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(775, 96);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(93, 46);
            this.Delete_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.Delete_Btn.TabIndex = 19;
            this.Delete_Btn.Text = "حذف";
            this.Delete_Btn.UseSelectable = true;
            this.Delete_Btn.UseStyleColors = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // workoutNameCB
            // 
            this.workoutNameCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workoutNameCB.AutoCompleteCustomSource.AddRange(new string[] {
            "hossam ",
            "mohamed",
            "shady"});
            this.workoutNameCB.FormattingEnabled = true;
            this.workoutNameCB.ItemHeight = 23;
            this.workoutNameCB.Location = new System.Drawing.Point(278, 96);
            this.workoutNameCB.Margin = new System.Windows.Forms.Padding(2);
            this.workoutNameCB.Name = "workoutNameCB";
            this.workoutNameCB.Size = new System.Drawing.Size(234, 29);
            this.workoutNameCB.TabIndex = 41;
            this.workoutNameCB.UseSelectable = true;
            this.workoutNameCB.SelectedIndexChanged += new System.EventHandler(this.workoutNameCB_SelectedIndexChanged);
            // 
            // Workouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.workoutNameCB);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.uploadBTN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Workouts";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "التمارين";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Workouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton uploadBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton Delete_Btn;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox workoutNameCB;
    }
}