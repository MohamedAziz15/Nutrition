namespace INutrition
{
    partial class settings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ThemeLBL = new MetroFramework.Controls.MetroLabel();
            this.ThemeCB = new MetroFramework.Controls.MetroComboBox();
            this.ColorLBL = new MetroFramework.Controls.MetroLabel();
            this.ColorCB = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.HelpTile = new MetroFramework.Controls.MetroTile();
            this.User_Grid = new MetroFramework.Controls.MetroGrid();
            this.AddUserBTN = new MetroFramework.Controls.MetroButton();
            this.Delete_User_Btn = new MetroFramework.Controls.MetroButton();
            this.Apply_Design_Btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeLBL
            // 
            this.ThemeLBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ThemeLBL.AutoSize = true;
            this.ThemeLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ThemeLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ThemeLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThemeLBL.Location = new System.Drawing.Point(558, 191);
            this.ThemeLBL.Name = "ThemeLBL";
            this.ThemeLBL.Size = new System.Drawing.Size(75, 25);
            this.ThemeLBL.Style = MetroFramework.MetroColorStyle.Green;
            this.ThemeLBL.TabIndex = 0;
            this.ThemeLBL.Text = "Theme:";
            this.ThemeLBL.UseCustomForeColor = true;
            this.ThemeLBL.UseStyleColors = true;
            // 
            // ThemeCB
            // 
            this.ThemeCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ThemeCB.FormattingEnabled = true;
            this.ThemeCB.ItemHeight = 24;
            this.ThemeCB.Items.AddRange(new object[] {
            "Default",
            "Light",
            "Dark"});
            this.ThemeCB.Location = new System.Drawing.Point(648, 191);
            this.ThemeCB.Name = "ThemeCB";
            this.ThemeCB.Size = new System.Drawing.Size(150, 30);
            this.ThemeCB.TabIndex = 1;
            this.ThemeCB.UseSelectable = true;
            // 
            // ColorLBL
            // 
            this.ColorLBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ColorLBL.AutoSize = true;
            this.ColorLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ColorLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ColorLBL.Location = new System.Drawing.Point(570, 106);
            this.ColorLBL.Name = "ColorLBL";
            this.ColorLBL.Size = new System.Drawing.Size(63, 25);
            this.ColorLBL.Style = MetroFramework.MetroColorStyle.Green;
            this.ColorLBL.TabIndex = 2;
            this.ColorLBL.Text = "Color:";
            this.ColorLBL.UseCustomForeColor = true;
            this.ColorLBL.UseStyleColors = true;
            // 
            // ColorCB
            // 
            this.ColorCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ColorCB.FormattingEnabled = true;
            this.ColorCB.ItemHeight = 24;
            this.ColorCB.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.ColorCB.Location = new System.Drawing.Point(648, 106);
            this.ColorCB.Name = "ColorCB";
            this.ColorCB.Size = new System.Drawing.Size(150, 30);
            this.ColorCB.TabIndex = 3;
            this.ColorCB.UseSelectable = true;
            this.ColorCB.SelectedIndexChanged += new System.EventHandler(this.ColorCB_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // HelpTile
            // 
            this.HelpTile.ActiveControl = null;
            this.HelpTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpTile.ForeColor = System.Drawing.Color.White;
            this.HelpTile.Location = new System.Drawing.Point(11, 582);
            this.HelpTile.Name = "HelpTile";
            this.HelpTile.Size = new System.Drawing.Size(833, 76);
            this.HelpTile.TabIndex = 5;
            this.HelpTile.Text = "ولا تتردد فى الأتصال بنا لمساعدتك فى اى خدمات او اضافات للبرنامج ورقم هاتفنا هو 0" +
    "1098059272  / 01025215495";
            this.HelpTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.HelpTile.UseCustomForeColor = true;
            this.HelpTile.UseSelectable = true;
            this.HelpTile.UseStyleColors = true;
            // 
            // User_Grid
            // 
            this.User_Grid.AllowUserToResizeRows = false;
            this.User_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.User_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.User_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.User_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.User_Grid.EnableHeadersVisualStyles = false;
            this.User_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.User_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.User_Grid.Location = new System.Drawing.Point(23, 85);
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.User_Grid.RowHeadersWidth = 51;
            this.User_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.User_Grid.RowTemplate.Height = 24;
            this.User_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_Grid.Size = new System.Drawing.Size(464, 401);
            this.User_Grid.TabIndex = 6;
            this.User_Grid.UseCustomBackColor = true;
            this.User_Grid.UseCustomForeColor = true;
            this.User_Grid.UseStyleColors = true;
            this.User_Grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_Grid_CellEndEdit);
            // 
            // AddUserBTN
            // 
            this.AddUserBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddUserBTN.AutoSize = true;
            this.AddUserBTN.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddUserBTN.ForeColor = System.Drawing.Color.Green;
            this.AddUserBTN.Location = new System.Drawing.Point(566, 460);
            this.AddUserBTN.Name = "AddUserBTN";
            this.AddUserBTN.Size = new System.Drawing.Size(106, 26);
            this.AddUserBTN.TabIndex = 7;
            this.AddUserBTN.Text = "ADD";
            this.AddUserBTN.UseCustomBackColor = true;
            this.AddUserBTN.UseSelectable = true;
            this.AddUserBTN.UseStyleColors = true;
            this.AddUserBTN.Click += new System.EventHandler(this.AddUserBTN_Click);
            // 
            // Delete_User_Btn
            // 
            this.Delete_User_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Delete_User_Btn.AutoSize = true;
            this.Delete_User_Btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Delete_User_Btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_User_Btn.Location = new System.Drawing.Point(710, 460);
            this.Delete_User_Btn.Name = "Delete_User_Btn";
            this.Delete_User_Btn.Size = new System.Drawing.Size(106, 26);
            this.Delete_User_Btn.Style = MetroFramework.MetroColorStyle.Green;
            this.Delete_User_Btn.TabIndex = 8;
            this.Delete_User_Btn.Text = "Delete";
            this.Delete_User_Btn.UseCustomBackColor = true;
            this.Delete_User_Btn.UseCustomForeColor = true;
            this.Delete_User_Btn.UseSelectable = true;
            this.Delete_User_Btn.UseStyleColors = true;
            this.Delete_User_Btn.Click += new System.EventHandler(this.Delete_User_Btn_Click);
            // 
            // Apply_Design_Btn
            // 
            this.Apply_Design_Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Apply_Design_Btn.AutoSize = true;
            this.Apply_Design_Btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Apply_Design_Btn.ForeColor = System.Drawing.Color.Green;
            this.Apply_Design_Btn.Location = new System.Drawing.Point(668, 260);
            this.Apply_Design_Btn.Name = "Apply_Design_Btn";
            this.Apply_Design_Btn.Size = new System.Drawing.Size(106, 26);
            this.Apply_Design_Btn.TabIndex = 9;
            this.Apply_Design_Btn.Text = "Apply";
            this.Apply_Design_Btn.UseCustomBackColor = true;
            this.Apply_Design_Btn.UseSelectable = true;
            this.Apply_Design_Btn.UseStyleColors = true;
            this.Apply_Design_Btn.Click += new System.EventHandler(this.Apply_Design_Btn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 662);
            this.Controls.Add(this.Apply_Design_Btn);
            this.Controls.Add(this.Delete_User_Btn);
            this.Controls.Add(this.AddUserBTN);
            this.Controls.Add(this.User_Grid);
            this.Controls.Add(this.HelpTile);
            this.Controls.Add(this.ColorCB);
            this.Controls.Add(this.ColorLBL);
            this.Controls.Add(this.ThemeCB);
            this.Controls.Add(this.ThemeLBL);
            this.Name = "settings";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ThemeLBL;
        private MetroFramework.Controls.MetroComboBox ThemeCB;
        private MetroFramework.Controls.MetroLabel ColorLBL;
        private MetroFramework.Controls.MetroComboBox ColorCB;
        private MetroFramework.Controls.MetroTile HelpTile;
        private MetroFramework.Controls.MetroGrid User_Grid;
        private MetroFramework.Controls.MetroButton Delete_User_Btn;
        private MetroFramework.Controls.MetroButton AddUserBTN;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton Apply_Design_Btn;
    }
}