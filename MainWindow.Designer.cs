namespace BMICalculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FacePictureBox = new System.Windows.Forms.PictureBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ResultTitleLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightLabel.Location = new System.Drawing.Point(29, 118);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(97, 27);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "身高(cm)";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HeightTextBox.Location = new System.Drawing.Point(149, 112);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(250, 39);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeightTextBox_KeyDown);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeightTextBox.Location = new System.Drawing.Point(149, 186);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(250, 39);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WeightTextBox_KeyDown);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WeightLabel.Location = new System.Drawing.Point(29, 192);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(92, 27);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "體重(kg)";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalculateButton.Location = new System.Drawing.Point(34, 264);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(365, 72);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "開始計算";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TitleLabel.Location = new System.Drawing.Point(89, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(272, 61);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "BMI 計算機";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FacePictureBox
            // 
            this.FacePictureBox.Location = new System.Drawing.Point(34, 372);
            this.FacePictureBox.Name = "FacePictureBox";
            this.FacePictureBox.Size = new System.Drawing.Size(100, 100);
            this.FacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FacePictureBox.TabIndex = 6;
            this.FacePictureBox.TabStop = false;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StateLabel.Location = new System.Drawing.Point(160, 437);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(0, 19);
            this.StateLabel.TabIndex = 7;
            // 
            // ResultTitleLabel
            // 
            this.ResultTitleLabel.AutoSize = true;
            this.ResultTitleLabel.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResultTitleLabel.Location = new System.Drawing.Point(156, 376);
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(108, 47);
            this.ResultTitleLabel.TabIndex = 8;
            this.ResultTitleLabel.Text = "BMI :";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultLabel.Location = new System.Drawing.Point(270, 376);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 47);
            this.ResultLabel.TabIndex = 9;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 517);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTitleLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.FacePictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BMICalculator";
            this.Text = "簡易BMI計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox FacePictureBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ResultTitleLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

