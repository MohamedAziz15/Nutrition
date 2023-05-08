using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INutrition;
using Nutrition;

namespace INutrition
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Dashboard_style();
        }

        private void Dashboard_style()
        {
            settings settings = new settings();
            metroStyleManager1 = settings.Select_sty();
            StyleManager = metroStyleManager1;
            clientBTN               .StyleManager =    metroStyleManager1;
            workoutBTN              .StyleManager =    metroStyleManager1;
            nutritionBTN            .StyleManager =    metroStyleManager1;
            foodTile                .StyleManager =    metroStyleManager1;
            settingsTile            .StyleManager = metroStyleManager1;
        }

        private void settingsTile_Click(object sender, EventArgs e)
        {
            settings setting = new settings();
            setting.Show();
            Dashboard_style();
        }

        private void nutritionBTN_Click(object sender, EventArgs e)
        {
            AllNutrition nutri = new AllNutrition();
            nutri.Show();
            Dashboard_style();
        }

        private void workoutBTN_Click(object sender, EventArgs e)
        {
            Workouts workouts = new Workouts();
            workouts.Show();
            Dashboard_style();
        }

        private void clientBTN_Click(object sender, EventArgs e)
        {
            C_form client = new C_form();
            client.Show();
            Dashboard_style();
        }

        private void foodTile_Click(object sender, EventArgs e)
        {
            Food foods = new Food();
            foods.Show();
            Dashboard_style();
        }


    }
}
