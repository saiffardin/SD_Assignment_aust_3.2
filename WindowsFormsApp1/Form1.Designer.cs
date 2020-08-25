namespace WindowsFormsApp1
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
            this.btn_convert = new System.Windows.Forms.Button();
            this.radioBtn_farToCel = new System.Windows.Forms.RadioButton();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_farToKel = new System.Windows.Forms.RadioButton();
            this.radioBtn_kelToCel = new System.Windows.Forms.RadioButton();
            this.radioBtn_celToKel = new System.Windows.Forms.RadioButton();
            this.radioBtn_celToFar = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(298, 467);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(126, 40);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBtn_farToCel
            // 
            this.radioBtn_farToCel.AutoSize = true;
            this.radioBtn_farToCel.Location = new System.Drawing.Point(36, 154);
            this.radioBtn_farToCel.Name = "radioBtn_farToCel";
            this.radioBtn_farToCel.Size = new System.Drawing.Size(162, 21);
            this.radioBtn_farToCel.TabIndex = 1;
            this.radioBtn_farToCel.TabStop = true;
            this.radioBtn_farToCel.Text = "Fahrenheit to Celsius";
            this.radioBtn_farToCel.UseVisualStyleBackColor = true;
            this.radioBtn_farToCel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(108, 45);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(152, 22);
            this.textBox_input.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_farToKel);
            this.groupBox1.Controls.Add(this.radioBtn_kelToCel);
            this.groupBox1.Controls.Add(this.radioBtn_celToKel);
            this.groupBox1.Controls.Add(this.radioBtn_celToFar);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.textBox_output);
            this.groupBox1.Controls.Add(this.textBox_input);
            this.groupBox1.Controls.Add(this.btn_convert);
            this.groupBox1.Controls.Add(this.radioBtn_farToCel);
            this.groupBox1.Location = new System.Drawing.Point(131, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 536);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioBtn_farToKel
            // 
            this.radioBtn_farToKel.AutoSize = true;
            this.radioBtn_farToKel.Location = new System.Drawing.Point(36, 317);
            this.radioBtn_farToKel.Name = "radioBtn_farToKel";
            this.radioBtn_farToKel.Size = new System.Drawing.Size(155, 21);
            this.radioBtn_farToKel.TabIndex = 8;
            this.radioBtn_farToKel.TabStop = true;
            this.radioBtn_farToKel.Text = "Fahrenheit to Kelvin";
            this.radioBtn_farToKel.UseVisualStyleBackColor = true;
            // 
            // radioBtn_kelToCel
            // 
            this.radioBtn_kelToCel.AutoSize = true;
            this.radioBtn_kelToCel.Location = new System.Drawing.Point(36, 274);
            this.radioBtn_kelToCel.Name = "radioBtn_kelToCel";
            this.radioBtn_kelToCel.Size = new System.Drawing.Size(132, 21);
            this.radioBtn_kelToCel.TabIndex = 7;
            this.radioBtn_kelToCel.TabStop = true;
            this.radioBtn_kelToCel.Text = "Kelvin to Celsius";
            this.radioBtn_kelToCel.UseVisualStyleBackColor = true;
            // 
            // radioBtn_celToKel
            // 
            this.radioBtn_celToKel.AutoSize = true;
            this.radioBtn_celToKel.Location = new System.Drawing.Point(36, 233);
            this.radioBtn_celToKel.Name = "radioBtn_celToKel";
            this.radioBtn_celToKel.Size = new System.Drawing.Size(132, 21);
            this.radioBtn_celToKel.TabIndex = 6;
            this.radioBtn_celToKel.TabStop = true;
            this.radioBtn_celToKel.Text = "Celsius to Kelvin";
            this.radioBtn_celToKel.UseVisualStyleBackColor = true;
            // 
            // radioBtn_celToFar
            // 
            this.radioBtn_celToFar.AutoSize = true;
            this.radioBtn_celToFar.Location = new System.Drawing.Point(36, 192);
            this.radioBtn_celToFar.Name = "radioBtn_celToFar";
            this.radioBtn_celToFar.Size = new System.Drawing.Size(166, 21);
            this.radioBtn_celToFar.TabIndex = 5;
            this.radioBtn_celToFar.TabStop = true;
            this.radioBtn_celToFar.Text = "Celsius to Fahrenheit ";
            this.radioBtn_celToFar.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(36, 467);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(110, 40);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(298, 390);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(126, 22);
            this.textBox_output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 639);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.RadioButton radioBtn_farToCel;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.RadioButton radioBtn_farToKel;
        private System.Windows.Forms.RadioButton radioBtn_kelToCel;
        private System.Windows.Forms.RadioButton radioBtn_celToKel;
        private System.Windows.Forms.RadioButton radioBtn_celToFar;
    }
}

