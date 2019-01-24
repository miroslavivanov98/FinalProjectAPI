using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodyCalculator;
using DLL;
using static DLL.Calculation;

namespace BodyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (Buton_M.Checked == true)
            {
                gender = "male";
            }

            else if (Buton_F.Checked == true)
            {
                gender = "female";
            }

            try
            {
                var results = Results.Calculate(Weight_Txt.Text, Height_Txt.Text, gender);
                BMI_Txt.Text = results.BMI_Txt.ToString();
                PerfectWeight_Txt.Text = results.PerfectWeight_Txt.ToString();
                BonesWeight_Txt.Text = results.BonesWeight_Txt.ToString();
            } catch(FormatException ex)
            {
                MessageBox.Show("Provided input is invalid", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Height_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Buton_F_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Buton_M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PerfectWeight_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMI_Txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PerfectWeight_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void BonesWeight_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Height_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_Txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
