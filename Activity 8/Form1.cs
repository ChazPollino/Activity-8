using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private double FatCalories(double Fatgrams)
        {
            return Fatgrams * 9;
        }

        private double CarbCalories(double Carbgrams)
        {
            return Carbgrams * 4;
        }




        private void button1_Click(object sender, EventArgs e)
        {

            double Carbgrams, Fatgrams, TotalCalories;

            double TotalCarbs;
            double TotalFats;

            if (double.TryParse(FatsTextbox.Text, out Fatgrams))
            {
                if (double.TryParse(CarbsTextbox.Text, out Carbgrams))
                {
                    TotalCarbs = CarbCalories(Carbgrams);

                    TotalFats = FatCalories(Fatgrams);

                    TotalCalories = FatCalories(Fatgrams) + CarbCalories(Carbgrams);

                    AnswerLabel.Text = TotalCalories.ToString();

                }
            }






        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FatsTextbox.Text = "";
            CarbsTextbox.Text = "";
            AnswerLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}