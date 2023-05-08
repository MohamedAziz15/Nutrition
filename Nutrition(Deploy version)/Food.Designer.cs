namespace Nutrition
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.food_Water_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_CA_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_PH_Tb = new MetroFramework.Controls.MetroTextBox();
            this.insert_Food_Btn = new MetroFramework.Controls.MetroButton();
            this.food_NA_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_K_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Fat_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Cal_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Carb_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Pro_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Qty_Tb = new MetroFramework.Controls.MetroTextBox();
            this.food_Name_Tb = new MetroFramework.Controls.MetroTextBox();
            this.update_Food_Btn = new MetroFramework.Controls.MetroButton();
            this.foodGrid = new MetroFramework.Controls.MetroGrid();
            this.Delete_Food_Btn = new MetroFramework.Controls.MetroButton();
            this.food_Search_Tb = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.food_Water_Tb);
            this.groupBox1.Controls.Add(this.food_CA_Tb);
            this.groupBox1.Controls.Add(this.food_PH_Tb);
            this.groupBox1.Controls.Add(this.insert_Food_Btn);
            this.groupBox1.Controls.Add(this.food_NA_Tb);
            this.groupBox1.Controls.Add(this.food_K_Tb);
            this.groupBox1.Controls.Add(this.food_Fat_Tb);
            this.groupBox1.Controls.Add(this.food_Cal_Tb);
            this.groupBox1.Controls.Add(this.food_Carb_Tb);
            this.groupBox1.Controls.Add(this.food_Pro_Tb);
            this.groupBox1.Controls.Add(this.food_Qty_Tb);
            this.groupBox1.Controls.Add(this.food_Name_Tb);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1335, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1011, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // food_Water_Tb
            // 
            // 
            // 
            // 
            this.food_Water_Tb.CustomButton.Image = null;
            this.food_Water_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Water_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Water_Tb.CustomButton.Name = "";
            this.food_Water_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Water_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Water_Tb.CustomButton.TabIndex = 1;
            this.food_Water_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Water_Tb.CustomButton.UseSelectable = true;
            this.food_Water_Tb.CustomButton.Visible = false;
            this.food_Water_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Water_Tb.Lines = new string[0];
            this.food_Water_Tb.Location = new System.Drawing.Point(294, 228);
            this.food_Water_Tb.MaxLength = 32767;
            this.food_Water_Tb.Multiline = true;
            this.food_Water_Tb.Name = "food_Water_Tb";
            this.food_Water_Tb.PasswordChar = '\0';
            this.food_Water_Tb.PromptText = "Water";
            this.food_Water_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Water_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Water_Tb.SelectedText = "";
            this.food_Water_Tb.SelectionLength = 0;
            this.food_Water_Tb.SelectionStart = 0;
            this.food_Water_Tb.ShortcutsEnabled = true;
            this.food_Water_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Water_Tb.TabIndex = 10;
            this.food_Water_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Water_Tb.UseSelectable = true;
            this.food_Water_Tb.UseStyleColors = true;
            this.food_Water_Tb.WaterMark = "Water";
            this.food_Water_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Water_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_CA_Tb
            // 
            // 
            // 
            // 
            this.food_CA_Tb.CustomButton.Image = null;
            this.food_CA_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_CA_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_CA_Tb.CustomButton.Name = "";
            this.food_CA_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_CA_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_CA_Tb.CustomButton.TabIndex = 1;
            this.food_CA_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_CA_Tb.CustomButton.UseSelectable = true;
            this.food_CA_Tb.CustomButton.Visible = false;
            this.food_CA_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_CA_Tb.Lines = new string[0];
            this.food_CA_Tb.Location = new System.Drawing.Point(294, 173);
            this.food_CA_Tb.MaxLength = 32767;
            this.food_CA_Tb.Multiline = true;
            this.food_CA_Tb.Name = "food_CA_Tb";
            this.food_CA_Tb.PasswordChar = '\0';
            this.food_CA_Tb.PromptText = "Ca";
            this.food_CA_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_CA_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_CA_Tb.SelectedText = "";
            this.food_CA_Tb.SelectionLength = 0;
            this.food_CA_Tb.SelectionStart = 0;
            this.food_CA_Tb.ShortcutsEnabled = true;
            this.food_CA_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_CA_Tb.TabIndex = 9;
            this.food_CA_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_CA_Tb.UseSelectable = true;
            this.food_CA_Tb.UseStyleColors = true;
            this.food_CA_Tb.WaterMark = "Ca";
            this.food_CA_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_CA_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_PH_Tb
            // 
            // 
            // 
            // 
            this.food_PH_Tb.CustomButton.Image = null;
            this.food_PH_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_PH_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_PH_Tb.CustomButton.Name = "";
            this.food_PH_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_PH_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_PH_Tb.CustomButton.TabIndex = 1;
            this.food_PH_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_PH_Tb.CustomButton.UseSelectable = true;
            this.food_PH_Tb.CustomButton.Visible = false;
            this.food_PH_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_PH_Tb.Lines = new string[0];
            this.food_PH_Tb.Location = new System.Drawing.Point(294, 121);
            this.food_PH_Tb.MaxLength = 32767;
            this.food_PH_Tb.Multiline = true;
            this.food_PH_Tb.Name = "food_PH_Tb";
            this.food_PH_Tb.PasswordChar = '\0';
            this.food_PH_Tb.PromptText = "Ph";
            this.food_PH_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_PH_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_PH_Tb.SelectedText = "";
            this.food_PH_Tb.SelectionLength = 0;
            this.food_PH_Tb.SelectionStart = 0;
            this.food_PH_Tb.ShortcutsEnabled = true;
            this.food_PH_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_PH_Tb.TabIndex = 8;
            this.food_PH_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_PH_Tb.UseSelectable = true;
            this.food_PH_Tb.UseStyleColors = true;
            this.food_PH_Tb.WaterMark = "Ph";
            this.food_PH_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_PH_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // insert_Food_Btn
            // 
            this.insert_Food_Btn.ForeColor = System.Drawing.Color.Green;
            this.insert_Food_Btn.Location = new System.Drawing.Point(54, 228);
            this.insert_Food_Btn.Name = "insert_Food_Btn";
            this.insert_Food_Btn.Size = new System.Drawing.Size(124, 33);
            this.insert_Food_Btn.TabIndex = 11;
            this.insert_Food_Btn.Text = "إضافة";
            this.insert_Food_Btn.UseSelectable = true;
            this.insert_Food_Btn.UseStyleColors = true;
            this.insert_Food_Btn.Click += new System.EventHandler(this.insert_Food_Btn_Click);
            // 
            // food_NA_Tb
            // 
            // 
            // 
            // 
            this.food_NA_Tb.CustomButton.Image = null;
            this.food_NA_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_NA_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_NA_Tb.CustomButton.Name = "";
            this.food_NA_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_NA_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_NA_Tb.CustomButton.TabIndex = 1;
            this.food_NA_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_NA_Tb.CustomButton.UseSelectable = true;
            this.food_NA_Tb.CustomButton.Visible = false;
            this.food_NA_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_NA_Tb.Lines = new string[0];
            this.food_NA_Tb.Location = new System.Drawing.Point(294, 73);
            this.food_NA_Tb.MaxLength = 32767;
            this.food_NA_Tb.Multiline = true;
            this.food_NA_Tb.Name = "food_NA_Tb";
            this.food_NA_Tb.PasswordChar = '\0';
            this.food_NA_Tb.PromptText = "NA";
            this.food_NA_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_NA_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_NA_Tb.SelectedText = "";
            this.food_NA_Tb.SelectionLength = 0;
            this.food_NA_Tb.SelectionStart = 0;
            this.food_NA_Tb.ShortcutsEnabled = true;
            this.food_NA_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_NA_Tb.TabIndex = 7;
            this.food_NA_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_NA_Tb.UseSelectable = true;
            this.food_NA_Tb.UseStyleColors = true;
            this.food_NA_Tb.WaterMark = "NA";
            this.food_NA_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_NA_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_K_Tb
            // 
            // 
            // 
            // 
            this.food_K_Tb.CustomButton.Image = null;
            this.food_K_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_K_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_K_Tb.CustomButton.Name = "";
            this.food_K_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_K_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_K_Tb.CustomButton.TabIndex = 1;
            this.food_K_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_K_Tb.CustomButton.UseSelectable = true;
            this.food_K_Tb.CustomButton.Visible = false;
            this.food_K_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_K_Tb.Lines = new string[0];
            this.food_K_Tb.Location = new System.Drawing.Point(294, 23);
            this.food_K_Tb.MaxLength = 32767;
            this.food_K_Tb.Multiline = true;
            this.food_K_Tb.Name = "food_K_Tb";
            this.food_K_Tb.PasswordChar = '\0';
            this.food_K_Tb.PromptText = "K";
            this.food_K_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_K_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_K_Tb.SelectedText = "";
            this.food_K_Tb.SelectionLength = 0;
            this.food_K_Tb.SelectionStart = 0;
            this.food_K_Tb.ShortcutsEnabled = true;
            this.food_K_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_K_Tb.TabIndex = 6;
            this.food_K_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_K_Tb.UseSelectable = true;
            this.food_K_Tb.UseStyleColors = true;
            this.food_K_Tb.WaterMark = "K";
            this.food_K_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_K_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Fat_Tb
            // 
            // 
            // 
            // 
            this.food_Fat_Tb.CustomButton.Image = null;
            this.food_Fat_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Fat_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Fat_Tb.CustomButton.Name = "";
            this.food_Fat_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Fat_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Fat_Tb.CustomButton.TabIndex = 1;
            this.food_Fat_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Fat_Tb.CustomButton.UseSelectable = true;
            this.food_Fat_Tb.CustomButton.Visible = false;
            this.food_Fat_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Fat_Tb.Lines = new string[0];
            this.food_Fat_Tb.Location = new System.Drawing.Point(647, 173);
            this.food_Fat_Tb.MaxLength = 32767;
            this.food_Fat_Tb.Multiline = true;
            this.food_Fat_Tb.Name = "food_Fat_Tb";
            this.food_Fat_Tb.PasswordChar = '\0';
            this.food_Fat_Tb.PromptText = "Fat(gm)";
            this.food_Fat_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Fat_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Fat_Tb.SelectedText = "";
            this.food_Fat_Tb.SelectionLength = 0;
            this.food_Fat_Tb.SelectionStart = 0;
            this.food_Fat_Tb.ShortcutsEnabled = true;
            this.food_Fat_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Fat_Tb.TabIndex = 4;
            this.food_Fat_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Fat_Tb.UseSelectable = true;
            this.food_Fat_Tb.UseStyleColors = true;
            this.food_Fat_Tb.WaterMark = "Fat(gm)";
            this.food_Fat_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Fat_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Cal_Tb
            // 
            // 
            // 
            // 
            this.food_Cal_Tb.CustomButton.Image = null;
            this.food_Cal_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Cal_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Cal_Tb.CustomButton.Name = "";
            this.food_Cal_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Cal_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Cal_Tb.CustomButton.TabIndex = 1;
            this.food_Cal_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Cal_Tb.CustomButton.UseSelectable = true;
            this.food_Cal_Tb.CustomButton.Visible = false;
            this.food_Cal_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Cal_Tb.Lines = new string[0];
            this.food_Cal_Tb.Location = new System.Drawing.Point(647, 228);
            this.food_Cal_Tb.MaxLength = 32767;
            this.food_Cal_Tb.Multiline = true;
            this.food_Cal_Tb.Name = "food_Cal_Tb";
            this.food_Cal_Tb.PasswordChar = '\0';
            this.food_Cal_Tb.PromptText = "K.cal";
            this.food_Cal_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Cal_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Cal_Tb.SelectedText = "";
            this.food_Cal_Tb.SelectionLength = 0;
            this.food_Cal_Tb.SelectionStart = 0;
            this.food_Cal_Tb.ShortcutsEnabled = true;
            this.food_Cal_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Cal_Tb.TabIndex = 5;
            this.food_Cal_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Cal_Tb.UseSelectable = true;
            this.food_Cal_Tb.UseStyleColors = true;
            this.food_Cal_Tb.WaterMark = "K.cal";
            this.food_Cal_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Cal_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Carb_Tb
            // 
            // 
            // 
            // 
            this.food_Carb_Tb.CustomButton.Image = null;
            this.food_Carb_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Carb_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Carb_Tb.CustomButton.Name = "";
            this.food_Carb_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Carb_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Carb_Tb.CustomButton.TabIndex = 1;
            this.food_Carb_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Carb_Tb.CustomButton.UseSelectable = true;
            this.food_Carb_Tb.CustomButton.Visible = false;
            this.food_Carb_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Carb_Tb.Lines = new string[0];
            this.food_Carb_Tb.Location = new System.Drawing.Point(647, 121);
            this.food_Carb_Tb.MaxLength = 32767;
            this.food_Carb_Tb.Multiline = true;
            this.food_Carb_Tb.Name = "food_Carb_Tb";
            this.food_Carb_Tb.PasswordChar = '\0';
            this.food_Carb_Tb.PromptText = "CHO(gm)";
            this.food_Carb_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Carb_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Carb_Tb.SelectedText = "";
            this.food_Carb_Tb.SelectionLength = 0;
            this.food_Carb_Tb.SelectionStart = 0;
            this.food_Carb_Tb.ShortcutsEnabled = true;
            this.food_Carb_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Carb_Tb.TabIndex = 3;
            this.food_Carb_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Carb_Tb.UseSelectable = true;
            this.food_Carb_Tb.UseStyleColors = true;
            this.food_Carb_Tb.WaterMark = "CHO(gm)";
            this.food_Carb_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Carb_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Pro_Tb
            // 
            // 
            // 
            // 
            this.food_Pro_Tb.CustomButton.Image = null;
            this.food_Pro_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Pro_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Pro_Tb.CustomButton.Name = "";
            this.food_Pro_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Pro_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Pro_Tb.CustomButton.TabIndex = 1;
            this.food_Pro_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Pro_Tb.CustomButton.UseSelectable = true;
            this.food_Pro_Tb.CustomButton.Visible = false;
            this.food_Pro_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Pro_Tb.Lines = new string[0];
            this.food_Pro_Tb.Location = new System.Drawing.Point(647, 73);
            this.food_Pro_Tb.MaxLength = 32767;
            this.food_Pro_Tb.Multiline = true;
            this.food_Pro_Tb.Name = "food_Pro_Tb";
            this.food_Pro_Tb.PasswordChar = '\0';
            this.food_Pro_Tb.PromptText = "Protein(gm)";
            this.food_Pro_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Pro_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Pro_Tb.SelectedText = "";
            this.food_Pro_Tb.SelectionLength = 0;
            this.food_Pro_Tb.SelectionStart = 0;
            this.food_Pro_Tb.ShortcutsEnabled = true;
            this.food_Pro_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Pro_Tb.TabIndex = 2;
            this.food_Pro_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Pro_Tb.UseSelectable = true;
            this.food_Pro_Tb.UseStyleColors = true;
            this.food_Pro_Tb.WaterMark = "Protein(gm)";
            this.food_Pro_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Pro_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Qty_Tb
            // 
            // 
            // 
            // 
            this.food_Qty_Tb.CustomButton.Image = null;
            this.food_Qty_Tb.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.food_Qty_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Qty_Tb.CustomButton.Name = "";
            this.food_Qty_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Qty_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Qty_Tb.CustomButton.TabIndex = 1;
            this.food_Qty_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Qty_Tb.CustomButton.UseSelectable = true;
            this.food_Qty_Tb.CustomButton.Visible = false;
            this.food_Qty_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Qty_Tb.Lines = new string[0];
            this.food_Qty_Tb.Location = new System.Drawing.Point(647, 23);
            this.food_Qty_Tb.MaxLength = 32767;
            this.food_Qty_Tb.Multiline = true;
            this.food_Qty_Tb.Name = "food_Qty_Tb";
            this.food_Qty_Tb.PasswordChar = '\0';
            this.food_Qty_Tb.PromptText = "الكمية (جم)";
            this.food_Qty_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Qty_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Qty_Tb.SelectedText = "";
            this.food_Qty_Tb.SelectionLength = 0;
            this.food_Qty_Tb.SelectionStart = 0;
            this.food_Qty_Tb.ShortcutsEnabled = true;
            this.food_Qty_Tb.Size = new System.Drawing.Size(229, 33);
            this.food_Qty_Tb.TabIndex = 1;
            this.food_Qty_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Qty_Tb.UseSelectable = true;
            this.food_Qty_Tb.UseStyleColors = true;
            this.food_Qty_Tb.WaterMark = "الكمية (جم)";
            this.food_Qty_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Qty_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // food_Name_Tb
            // 
            // 
            // 
            // 
            this.food_Name_Tb.CustomButton.Image = null;
            this.food_Name_Tb.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.food_Name_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.food_Name_Tb.CustomButton.Name = "";
            this.food_Name_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.food_Name_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Name_Tb.CustomButton.TabIndex = 1;
            this.food_Name_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Name_Tb.CustomButton.UseSelectable = true;
            this.food_Name_Tb.CustomButton.Visible = false;
            this.food_Name_Tb.ForeColor = System.Drawing.Color.Green;
            this.food_Name_Tb.Lines = new string[0];
            this.food_Name_Tb.Location = new System.Drawing.Point(1011, 23);
            this.food_Name_Tb.MaxLength = 32767;
            this.food_Name_Tb.Multiline = true;
            this.food_Name_Tb.Name = "food_Name_Tb";
            this.food_Name_Tb.PasswordChar = '\0';
            this.food_Name_Tb.PromptText = "اسم الصنف";
            this.food_Name_Tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.food_Name_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Name_Tb.SelectedText = "";
            this.food_Name_Tb.SelectionLength = 0;
            this.food_Name_Tb.SelectionStart = 0;
            this.food_Name_Tb.ShortcutsEnabled = true;
            this.food_Name_Tb.Size = new System.Drawing.Size(287, 33);
            this.food_Name_Tb.TabIndex = 0;
            this.food_Name_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Name_Tb.UseSelectable = true;
            this.food_Name_Tb.UseStyleColors = true;
            this.food_Name_Tb.WaterMark = "اسم الصنف";
            this.food_Name_Tb.WaterMarkColor = System.Drawing.Color.Black;
            this.food_Name_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // update_Food_Btn
            // 
            this.update_Food_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_Food_Btn.ForeColor = System.Drawing.Color.Black;
            this.update_Food_Btn.Location = new System.Drawing.Point(1104, 378);
            this.update_Food_Btn.Name = "update_Food_Btn";
            this.update_Food_Btn.Size = new System.Drawing.Size(124, 33);
            this.update_Food_Btn.TabIndex = 14;
            this.update_Food_Btn.Text = "تعديل";
            this.update_Food_Btn.UseCustomForeColor = true;
            this.update_Food_Btn.UseSelectable = true;
            this.update_Food_Btn.UseStyleColors = true;
            this.update_Food_Btn.Click += new System.EventHandler(this.Update_Food_Btn_Click);
            // 
            // foodGrid
            // 
            this.foodGrid.AllowUserToOrderColumns = true;
            this.foodGrid.AllowUserToResizeRows = false;
            this.foodGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.foodGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foodGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.foodGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.foodGrid.EnableHeadersVisualStyles = false;
            this.foodGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.foodGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foodGrid.Location = new System.Drawing.Point(23, 436);
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.ReadOnly = true;
            this.foodGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.foodGrid.RowHeadersWidth = 51;
            this.foodGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.foodGrid.RowTemplate.Height = 24;
            this.foodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodGrid.Size = new System.Drawing.Size(1335, 360);
            this.foodGrid.TabIndex = 13;
            this.foodGrid.UseStyleColors = true;
            this.foodGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGrid_CellClick);
            // 
            // Delete_Food_Btn
            // 
            this.Delete_Food_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Food_Btn.Location = new System.Drawing.Point(1234, 378);
            this.Delete_Food_Btn.Name = "Delete_Food_Btn";
            this.Delete_Food_Btn.Size = new System.Drawing.Size(124, 33);
            this.Delete_Food_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.Delete_Food_Btn.TabIndex = 15;
            this.Delete_Food_Btn.Text = "حذف";
            this.Delete_Food_Btn.UseSelectable = true;
            this.Delete_Food_Btn.UseStyleColors = true;
            this.Delete_Food_Btn.Click += new System.EventHandler(this.Delete_Food_Btn_Click);
            // 
            // food_Search_Tb
            // 
            // 
            // 
            // 
            this.food_Search_Tb.CustomButton.Image = null;
            this.food_Search_Tb.CustomButton.Location = new System.Drawing.Point(337, 1);
            this.food_Search_Tb.CustomButton.Name = "";
            this.food_Search_Tb.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.food_Search_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.food_Search_Tb.CustomButton.TabIndex = 1;
            this.food_Search_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.food_Search_Tb.CustomButton.UseSelectable = true;
            this.food_Search_Tb.CustomButton.Visible = false;
            this.food_Search_Tb.Lines = new string[0];
            this.food_Search_Tb.Location = new System.Drawing.Point(23, 352);
            this.food_Search_Tb.MaxLength = 32767;
            this.food_Search_Tb.Multiline = true;
            this.food_Search_Tb.Name = "food_Search_Tb";
            this.food_Search_Tb.PasswordChar = '\0';
            this.food_Search_Tb.PromptText = "أبحث من هنا";
            this.food_Search_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.food_Search_Tb.SelectedText = "";
            this.food_Search_Tb.SelectionLength = 0;
            this.food_Search_Tb.SelectionStart = 0;
            this.food_Search_Tb.ShortcutsEnabled = true;
            this.food_Search_Tb.Size = new System.Drawing.Size(377, 41);
            this.food_Search_Tb.TabIndex = 12;
            this.food_Search_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.food_Search_Tb.UseSelectable = true;
            this.food_Search_Tb.UseStyleColors = true;
            this.food_Search_Tb.WaterMark = "أبحث من هنا";
            this.food_Search_Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.food_Search_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_Search_Tb.TextChanged += new System.EventHandler(this.food_Search_Tb_TextChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 819);
            this.Controls.Add(this.food_Search_Tb);
            this.Controls.Add(this.Delete_Food_Btn);
            this.Controls.Add(this.foodGrid);
            this.Controls.Add(this.update_Food_Btn);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.YellowGreen;
            this.Name = "Food";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "الأصناف";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Food_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox food_Cal_Tb;
        private MetroFramework.Controls.MetroTextBox food_Carb_Tb;
        private MetroFramework.Controls.MetroTextBox food_Pro_Tb;
        private MetroFramework.Controls.MetroTextBox food_Qty_Tb;
        private MetroFramework.Controls.MetroTextBox food_Name_Tb;
        private MetroFramework.Controls.MetroGrid foodGrid;
        private MetroFramework.Controls.MetroButton insert_Food_Btn;
        private MetroFramework.Controls.MetroButton update_Food_Btn;
        private MetroFramework.Controls.MetroButton Delete_Food_Btn;
        private MetroFramework.Controls.MetroTextBox food_Water_Tb;
        private MetroFramework.Controls.MetroTextBox food_CA_Tb;
        private MetroFramework.Controls.MetroTextBox food_PH_Tb;
        private MetroFramework.Controls.MetroTextBox food_NA_Tb;
        private MetroFramework.Controls.MetroTextBox food_K_Tb;
        private MetroFramework.Controls.MetroTextBox food_Fat_Tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox food_Search_Tb;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}