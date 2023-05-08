namespace Nutrition
{
    partial class C_archive
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
            this.Delete_archive_Btn = new MetroFramework.Controls.MetroButton();
            this.client_Grid = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Search_client_Tb = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.client_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_archive_Btn
            // 
            this.Delete_archive_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_archive_Btn.Location = new System.Drawing.Point(921, 60);
            this.Delete_archive_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_archive_Btn.Name = "Delete_archive_Btn";
            this.Delete_archive_Btn.Size = new System.Drawing.Size(96, 31);
            this.Delete_archive_Btn.Style = MetroFramework.MetroColorStyle.Red;
            this.Delete_archive_Btn.TabIndex = 14;
            this.Delete_archive_Btn.Text = "حذف";
            this.Delete_archive_Btn.UseSelectable = true;
            this.Delete_archive_Btn.UseStyleColors = true;
            this.Delete_archive_Btn.Click += new System.EventHandler(this.Delete_archive_Btn_Click);
            // 
            // client_Grid
            // 
            this.client_Grid.AllowUserToResizeRows = false;
            this.client_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.client_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.client_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.client_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.client_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.client_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.client_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.client_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.client_Grid.EnableHeadersVisualStyles = false;
            this.client_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.client_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.client_Grid.Location = new System.Drawing.Point(10, 98);
            this.client_Grid.Margin = new System.Windows.Forms.Padding(2);
            this.client_Grid.Name = "client_Grid";
            this.client_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.client_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.client_Grid.RowHeadersWidth = 51;
            this.client_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.client_Grid.RowTemplate.Height = 24;
            this.client_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_Grid.Size = new System.Drawing.Size(1007, 519);
            this.client_Grid.TabIndex = 12;
            this.client_Grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_Grid_CellEndEdit);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(298, 60);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 33);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "إضافة عميل جديد";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Search_client_Tb
            // 
            // 
            // 
            // 
            this.Search_client_Tb.CustomButton.Image = null;
            this.Search_client_Tb.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.Search_client_Tb.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.Search_client_Tb.CustomButton.Name = "";
            this.Search_client_Tb.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.Search_client_Tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Search_client_Tb.CustomButton.TabIndex = 1;
            this.Search_client_Tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Search_client_Tb.CustomButton.UseSelectable = true;
            this.Search_client_Tb.CustomButton.Visible = false;
            this.Search_client_Tb.Lines = new string[0];
            this.Search_client_Tb.Location = new System.Drawing.Point(10, 60);
            this.Search_client_Tb.Margin = new System.Windows.Forms.Padding(2);
            this.Search_client_Tb.MaxLength = 32767;
            this.Search_client_Tb.Multiline = true;
            this.Search_client_Tb.Name = "Search_client_Tb";
            this.Search_client_Tb.PasswordChar = '\0';
            this.Search_client_Tb.PromptText = "أبحث من هنا";
            this.Search_client_Tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Search_client_Tb.SelectedText = "";
            this.Search_client_Tb.SelectionLength = 0;
            this.Search_client_Tb.SelectionStart = 0;
            this.Search_client_Tb.ShortcutsEnabled = true;
            this.Search_client_Tb.Size = new System.Drawing.Size(283, 33);
            this.Search_client_Tb.TabIndex = 16;
            this.Search_client_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Search_client_Tb.UseSelectable = true;
            this.Search_client_Tb.UseStyleColors = true;
            this.Search_client_Tb.WaterMark = "أبحث من هنا";
            this.Search_client_Tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Search_client_Tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_client_Tb.TextChanged += new System.EventHandler(this.Search_client_Tb_TextChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // C_archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.Search_client_Tb);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Delete_archive_Btn);
            this.Controls.Add(this.client_Grid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "C_archive";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "أرشيف العملاء";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.C_archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Delete_archive_Btn;
        private MetroFramework.Controls.MetroGrid client_Grid;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox Search_client_Tb;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}