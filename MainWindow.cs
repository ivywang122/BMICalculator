using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private Image[] imgs;

        private void Form1_Load(object sender, EventArgs e)
        {
            imgs = new Image[4];
            for (int i = 0; i < imgs.Length; i++)
            {
                String num = i.ToString();
                imgs[i] = Image.FromFile("..\\images\\face-" + num + ".png");
            }
            FacePictureBox.Image = imgs[0];
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Color red = System.Drawing.Color.Red;
            Color green = System.Drawing.Color.Green;
            Color purple = System.Drawing.Color.Purple;
            if (String.IsNullOrEmpty(HeightTextBox.Text))
            {
                StateLabel.Text = "請輸入身高!";
                StateLabel.ForeColor = red;
                FacePictureBox.Image = imgs[3];
            }
            else if (String.IsNullOrEmpty(WeightTextBox.Text))
            {
                StateLabel.Text = "請輸入體重!";
                StateLabel.ForeColor = red;
                FacePictureBox.Image = imgs[3];
            }
            else
            {
                float height = 0.0f;
                float weight = 0.0f;
                bool isHeightConvert = float.TryParse(HeightTextBox.Text, out height);
                bool isWeightConvert = float.TryParse(WeightTextBox.Text, out weight);
                if (!isHeightConvert || !isWeightConvert)
                {
                    StateLabel.Text = "請輸入合法數字!";
                    StateLabel.ForeColor = red;
                    FacePictureBox.Image = imgs[3];
                }
                else
                {
                    height /= 100f;
                    float bmi = weight / (height * height);
                    String bmiResult = bmi.ToString("#.##");
                    ResultLabel.Text = bmiResult;
                    if (bmi >= 28)
                    {
                        ResultLabel.ForeColor = red;

                        StateLabel.Text = "肥胖, 請多運動";
                        StateLabel.ForeColor = red;
                        FacePictureBox.Image = imgs[2];
                    }
                    else if (bmi >= 24)
                    {
                        ResultLabel.ForeColor = red;

                        StateLabel.Text = "體重過重, 請多運動";
                        StateLabel.ForeColor = red;
                        FacePictureBox.Image = imgs[2];
                    }
                    else if (bmi < 18.5)
                    {
                        ResultLabel.ForeColor = purple;

                        StateLabel.Text = "體重過輕, 請多飲食";
                        StateLabel.ForeColor = purple;
                        FacePictureBox.Image = imgs[2];
                    }
                    else if (bmi < 16)
                    {
                        ResultLabel.ForeColor = purple;

                        StateLabel.Text = "體重嚴重不足, 請多飲食";
                        StateLabel.ForeColor = purple;
                        FacePictureBox.Image = imgs[2];
                    }
                    else
                    {
                        ResultLabel.ForeColor = green;

                        StateLabel.Text = "非常健康! 請多保持";
                        StateLabel.ForeColor = green;
                        FacePictureBox.Image = imgs[1];
                    }
                }
            }
        }

        private void HeightTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CalculateButton_Click(this, null);
        }

        private void WeightTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CalculateButton_Click(this, null);
        }
    }
}