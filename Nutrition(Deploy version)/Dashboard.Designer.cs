namespace INutrition
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.foodTile = new MetroFramework.Controls.MetroTile();
            this.nutritionBTN = new MetroFramework.Controls.MetroTile();
            this.workoutBTN = new MetroFramework.Controls.MetroTile();
            this.clientBTN = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsTile.Location = new System.Drawing.Point(538, 480);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(249, 159);
            this.settingsTile.TabIndex = 4;
            this.settingsTile.Text = "الاعدادات";
            this.settingsTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.settingsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("settingsTile.TileImage")));
            this.settingsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.settingsTile.UseSelectable = true;
            this.settingsTile.UseStyleColors = true;
            this.settingsTile.UseTileImage = true;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
            // 
            // foodTile
            // 
            this.foodTile.ActiveControl = null;
            this.foodTile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foodTile.Location = new System.Drawing.Point(538, 299);
            this.foodTile.Name = "foodTile";
            this.foodTile.Size = new System.Drawing.Size(249, 159);
            this.foodTile.TabIndex = 3;
            this.foodTile.Text = "الأصناف الغذائية";
            this.foodTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.foodTile.TileImage = ((System.Drawing.Image)(resources.GetObject("foodTile.TileImage")));
            this.foodTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.foodTile.UseSelectable = true;
            this.foodTile.UseStyleColors = true;
            this.foodTile.UseTileImage = true;
            this.foodTile.Click += new System.EventHandler(this.foodTile_Click);
            // 
            // nutritionBTN
            // 
            this.nutritionBTN.ActiveControl = null;
            this.nutritionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nutritionBTN.Location = new System.Drawing.Point(51, 385);
            this.nutritionBTN.Name = "nutritionBTN";
            this.nutritionBTN.Size = new System.Drawing.Size(400, 254);
            this.nutritionBTN.TabIndex = 2;
            this.nutritionBTN.Text = "التغذية";
            this.nutritionBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.nutritionBTN.TileImage = ((System.Drawing.Image)(resources.GetObject("nutritionBTN.TileImage")));
            this.nutritionBTN.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nutritionBTN.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.nutritionBTN.UseSelectable = true;
            this.nutritionBTN.UseStyleColors = true;
            this.nutritionBTN.UseTileImage = true;
            this.nutritionBTN.Click += new System.EventHandler(this.nutritionBTN_Click);
            // 
            // workoutBTN
            // 
            this.workoutBTN.ActiveControl = null;
            this.workoutBTN.Location = new System.Drawing.Point(538, 117);
            this.workoutBTN.Name = "workoutBTN";
            this.workoutBTN.Size = new System.Drawing.Size(249, 159);
            this.workoutBTN.TabIndex = 1;
            this.workoutBTN.Text = "التمارين";
            this.workoutBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.workoutBTN.TileImage = ((System.Drawing.Image)(resources.GetObject("workoutBTN.TileImage")));
            this.workoutBTN.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.workoutBTN.UseSelectable = true;
            this.workoutBTN.UseStyleColors = true;
            this.workoutBTN.UseTileImage = true;
            this.workoutBTN.Click += new System.EventHandler(this.workoutBTN_Click);
            // 
            // clientBTN
            // 
            this.clientBTN.ActiveControl = null;
            this.clientBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientBTN.Location = new System.Drawing.Point(51, 117);
            this.clientBTN.Name = "clientBTN";
            this.clientBTN.Size = new System.Drawing.Size(400, 251);
            this.clientBTN.TabIndex = 0;
            this.clientBTN.Text = "العملاء";
            this.clientBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.clientBTN.TileImage = ((System.Drawing.Image)(resources.GetObject("clientBTN.TileImage")));
            this.clientBTN.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientBTN.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.clientBTN.UseSelectable = true;
            this.clientBTN.UseStyleColors = true;
            this.clientBTN.UseTileImage = true;
            this.clientBTN.Click += new System.EventHandler(this.clientBTN_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 662);
            this.Controls.Add(this.settingsTile);
            this.Controls.Add(this.foodTile);
            this.Controls.Add(this.nutritionBTN);
            this.Controls.Add(this.workoutBTN);
            this.Controls.Add(this.clientBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "القائمة الرئيسية";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile clientBTN;
        private MetroFramework.Controls.MetroTile workoutBTN;
        private MetroFramework.Controls.MetroTile nutritionBTN;
        private MetroFramework.Controls.MetroTile foodTile;
        private MetroFramework.Controls.MetroTile settingsTile;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}