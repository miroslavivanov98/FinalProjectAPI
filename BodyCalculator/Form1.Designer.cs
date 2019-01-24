namespace BodyCalculator
{
    partial class Form1
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
            this.Submit = new System.Windows.Forms.Button();
            this.Height_Lbl = new System.Windows.Forms.Label();
            this.Weight_Lbl = new System.Windows.Forms.Label();
            this.Height_Txt = new System.Windows.Forms.TextBox();
            this.Weight_Txt = new System.Windows.Forms.TextBox();
            this.Buton_M = new System.Windows.Forms.RadioButton();
            this.Buton_F = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BMI_Lbl = new System.Windows.Forms.Label();
            this.PerfectWeight_Lbl = new System.Windows.Forms.Label();
            this.BonesWeight_Lbl = new System.Windows.Forms.Label();
            this.BMI_Txt = new System.Windows.Forms.TextBox();
            this.PerfectWeight_Txt = new System.Windows.Forms.TextBox();
            this.BonesWeight_Txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(27, 138);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(464, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Calculate";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Height_Lbl
            // 
            this.Height_Lbl.AutoSize = true;
            this.Height_Lbl.Location = new System.Drawing.Point(24, 26);
            this.Height_Lbl.Name = "Height_Lbl";
            this.Height_Lbl.Size = new System.Drawing.Size(41, 13);
            this.Height_Lbl.TabIndex = 1;
            this.Height_Lbl.Text = "Height:";
            this.Height_Lbl.Click += new System.EventHandler(this.Height_Lbl_Click);
            // 
            // Weight_Lbl
            // 
            this.Weight_Lbl.AutoSize = true;
            this.Weight_Lbl.Location = new System.Drawing.Point(292, 26);
            this.Weight_Lbl.Name = "Weight_Lbl";
            this.Weight_Lbl.Size = new System.Drawing.Size(44, 13);
            this.Weight_Lbl.TabIndex = 2;
            this.Weight_Lbl.Text = "Weight:";
            // 
            // Height_Txt
            // 
            this.Height_Txt.Location = new System.Drawing.Point(81, 23);
            this.Height_Txt.Name = "Height_Txt";
            this.Height_Txt.Size = new System.Drawing.Size(100, 20);
            this.Height_Txt.TabIndex = 3;
            this.Height_Txt.TextChanged += new System.EventHandler(this.Height_Txt_TextChanged);
            // 
            // Weight_Txt
            // 
            this.Weight_Txt.Location = new System.Drawing.Point(365, 23);
            this.Weight_Txt.Name = "Weight_Txt";
            this.Weight_Txt.Size = new System.Drawing.Size(100, 20);
            this.Weight_Txt.TabIndex = 4;
            this.Weight_Txt.TextChanged += new System.EventHandler(this.Weight_Txt_TextChanged);
            // 
            // Buton_M
            // 
            this.Buton_M.AutoSize = true;
            this.Buton_M.Checked = true;
            this.Buton_M.Location = new System.Drawing.Point(3, 20);
            this.Buton_M.Name = "Buton_M";
            this.Buton_M.Size = new System.Drawing.Size(48, 17);
            this.Buton_M.TabIndex = 5;
            this.Buton_M.TabStop = true;
            this.Buton_M.Text = "Male";
            this.Buton_M.UseVisualStyleBackColor = true;
            this.Buton_M.CheckedChanged += new System.EventHandler(this.Buton_M_CheckedChanged);
            // 
            // Buton_F
            // 
            this.Buton_F.AutoSize = true;
            this.Buton_F.Location = new System.Drawing.Point(3, 43);
            this.Buton_F.Name = "Buton_F";
            this.Buton_F.Size = new System.Drawing.Size(59, 17);
            this.Buton_F.TabIndex = 6;
            this.Buton_F.Text = "Female";
            this.Buton_F.UseVisualStyleBackColor = true;
            this.Buton_F.CheckedChanged += new System.EventHandler(this.Buton_F_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Buton_M);
            this.panel1.Controls.Add(this.Buton_F);
            this.panel1.Location = new System.Drawing.Point(27, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 70);
            this.panel1.TabIndex = 7;
            // 
            // BMI_Lbl
            // 
            this.BMI_Lbl.AutoSize = true;
            this.BMI_Lbl.Location = new System.Drawing.Point(29, 199);
            this.BMI_Lbl.Name = "BMI_Lbl";
            this.BMI_Lbl.Size = new System.Drawing.Size(26, 13);
            this.BMI_Lbl.TabIndex = 8;
            this.BMI_Lbl.Text = "BMI";
            this.BMI_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // PerfectWeight_Lbl
            // 
            this.PerfectWeight_Lbl.AutoSize = true;
            this.PerfectWeight_Lbl.Location = new System.Drawing.Point(27, 234);
            this.PerfectWeight_Lbl.Name = "PerfectWeight_Lbl";
            this.PerfectWeight_Lbl.Size = new System.Drawing.Size(78, 13);
            this.PerfectWeight_Lbl.TabIndex = 9;
            this.PerfectWeight_Lbl.Text = "Perfect Weight";
            this.PerfectWeight_Lbl.Click += new System.EventHandler(this.PerfectWeight_Lbl_Click);
            // 
            // BonesWeight_Lbl
            // 
            this.BonesWeight_Lbl.AutoSize = true;
            this.BonesWeight_Lbl.Location = new System.Drawing.Point(27, 284);
            this.BonesWeight_Lbl.Name = "BonesWeight_Lbl";
            this.BonesWeight_Lbl.Size = new System.Drawing.Size(71, 13);
            this.BonesWeight_Lbl.TabIndex = 10;
            this.BonesWeight_Lbl.Text = "BonesWeight";
            // 
            // BMI_Txt
            // 
            this.BMI_Txt.Location = new System.Drawing.Point(61, 196);
            this.BMI_Txt.Name = "BMI_Txt";
            this.BMI_Txt.Size = new System.Drawing.Size(100, 20);
            this.BMI_Txt.TabIndex = 11;
            this.BMI_Txt.TextChanged += new System.EventHandler(this.BMI_Txt_TextChanged);
            // 
            // PerfectWeight_Txt
            // 
            this.PerfectWeight_Txt.Location = new System.Drawing.Point(122, 234);
            this.PerfectWeight_Txt.Name = "PerfectWeight_Txt";
            this.PerfectWeight_Txt.Size = new System.Drawing.Size(100, 20);
            this.PerfectWeight_Txt.TabIndex = 12;
            this.PerfectWeight_Txt.TextChanged += new System.EventHandler(this.PerfectWeight_Txt_TextChanged);
            // 
            // BonesWeight_Txt
            // 
            this.BonesWeight_Txt.Location = new System.Drawing.Point(104, 281);
            this.BonesWeight_Txt.Name = "BonesWeight_Txt";
            this.BonesWeight_Txt.Size = new System.Drawing.Size(100, 20);
            this.BonesWeight_Txt.TabIndex = 13;
            this.BonesWeight_Txt.TextChanged += new System.EventHandler(this.BonesWeight_Txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 353);
            this.Controls.Add(this.BonesWeight_Txt);
            this.Controls.Add(this.PerfectWeight_Txt);
            this.Controls.Add(this.BMI_Txt);
            this.Controls.Add(this.BonesWeight_Lbl);
            this.Controls.Add(this.PerfectWeight_Lbl);
            this.Controls.Add(this.BMI_Lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Weight_Txt);
            this.Controls.Add(this.Height_Txt);
            this.Controls.Add(this.Weight_Lbl);
            this.Controls.Add(this.Height_Lbl);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Height_Lbl;
        private System.Windows.Forms.Label Weight_Lbl;
        private System.Windows.Forms.TextBox Height_Txt;
        private System.Windows.Forms.TextBox Weight_Txt;
        private System.Windows.Forms.RadioButton Buton_M;
        private System.Windows.Forms.RadioButton Buton_F;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BMI_Lbl;
        private System.Windows.Forms.Label PerfectWeight_Lbl;
        private System.Windows.Forms.Label BonesWeight_Lbl;
        private System.Windows.Forms.TextBox BMI_Txt;
        private System.Windows.Forms.TextBox PerfectWeight_Txt;
        private System.Windows.Forms.TextBox BonesWeight_Txt;
    }
}

