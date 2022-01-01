namespace Work_System_Csharp_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSStart = new System.Windows.Forms.Button();
            this.buttonSStop = new System.Windows.Forms.Button();
            this.buttonSResume = new System.Windows.Forms.Button();
            this.buttonFResume = new System.Windows.Forms.Button();
            this.buttonFStop = new System.Windows.Forms.Button();
            this.buttonFStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "max";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(264, 16);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(83, 23);
            this.numericUpDown2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 370);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "simple numbers";
            // 
            // buttonSStart
            // 
            this.buttonSStart.Location = new System.Drawing.Point(559, 14);
            this.buttonSStart.Name = "buttonSStart";
            this.buttonSStart.Size = new System.Drawing.Size(75, 23);
            this.buttonSStart.TabIndex = 6;
            this.buttonSStart.Text = "start";
            this.buttonSStart.UseVisualStyleBackColor = true;
            this.buttonSStart.Click += new System.EventHandler(this.buttonSStart_Click);
            // 
            // buttonSStop
            // 
            this.buttonSStop.Location = new System.Drawing.Point(640, 14);
            this.buttonSStop.Name = "buttonSStop";
            this.buttonSStop.Size = new System.Drawing.Size(75, 23);
            this.buttonSStop.TabIndex = 7;
            this.buttonSStop.Text = "stop";
            this.buttonSStop.UseVisualStyleBackColor = true;
            this.buttonSStop.Click += new System.EventHandler(this.buttonSStop_Click);
            // 
            // buttonSResume
            // 
            this.buttonSResume.Location = new System.Drawing.Point(721, 14);
            this.buttonSResume.Name = "buttonSResume";
            this.buttonSResume.Size = new System.Drawing.Size(75, 23);
            this.buttonSResume.TabIndex = 8;
            this.buttonSResume.Text = "|| / ->";
            this.buttonSResume.UseVisualStyleBackColor = true;
            this.buttonSResume.Click += new System.EventHandler(this.buttonSResume_Click);
            // 
            // buttonFResume
            // 
            this.buttonFResume.Location = new System.Drawing.Point(721, 48);
            this.buttonFResume.Name = "buttonFResume";
            this.buttonFResume.Size = new System.Drawing.Size(75, 23);
            this.buttonFResume.TabIndex = 12;
            this.buttonFResume.Text = "|| / ->";
            this.buttonFResume.UseVisualStyleBackColor = true;
            this.buttonFResume.Click += new System.EventHandler(this.buttonFResume_Click);
            // 
            // buttonFStop
            // 
            this.buttonFStop.Location = new System.Drawing.Point(640, 48);
            this.buttonFStop.Name = "buttonFStop";
            this.buttonFStop.Size = new System.Drawing.Size(75, 23);
            this.buttonFStop.TabIndex = 11;
            this.buttonFStop.Text = "stop";
            this.buttonFStop.UseVisualStyleBackColor = true;
            this.buttonFStop.Click += new System.EventHandler(this.buttonFStop_Click);
            // 
            // buttonFStart
            // 
            this.buttonFStart.Location = new System.Drawing.Point(559, 48);
            this.buttonFStart.Name = "buttonFStart";
            this.buttonFStart.Size = new System.Drawing.Size(75, 23);
            this.buttonFStart.TabIndex = 10;
            this.buttonFStart.Text = "start";
            this.buttonFStart.UseVisualStyleBackColor = true;
            this.buttonFStart.Click += new System.EventHandler(this.buttonFStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fibonachi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 313);
            this.textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonFResume);
            this.Controls.Add(this.buttonFStop);
            this.Controls.Add(this.buttonFStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSResume);
            this.Controls.Add(this.buttonSStop);
            this.Controls.Add(this.buttonSStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSStart;
        private System.Windows.Forms.Button buttonSStop;
        private System.Windows.Forms.Button buttonSResume;
        private System.Windows.Forms.Button buttonFResume;
        private System.Windows.Forms.Button buttonFStop;
        private System.Windows.Forms.Button buttonFStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}
