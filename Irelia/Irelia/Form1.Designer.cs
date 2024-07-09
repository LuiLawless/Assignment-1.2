namespace Irelia
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNsad = new System.Windows.Forms.RadioButton();
            this.BTNhappy = new System.Windows.Forms.RadioButton();
            this.BTNanxious = new System.Windows.Forms.RadioButton();
            this.BTNcalm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me for answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(85, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ask me any yes or no question, and I will give you your answer.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNcalm);
            this.groupBox1.Controls.Add(this.BTNanxious);
            this.groupBox1.Controls.Add(this.BTNhappy);
            this.groupBox1.Controls.Add(this.BTNsad);
            this.groupBox1.Location = new System.Drawing.Point(114, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BTNsad
            // 
            this.BTNsad.AutoSize = true;
            this.BTNsad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNsad.Location = new System.Drawing.Point(23, 33);
            this.BTNsad.Name = "BTNsad";
            this.BTNsad.Size = new System.Drawing.Size(44, 17);
            this.BTNsad.TabIndex = 0;
            this.BTNsad.TabStop = true;
            this.BTNsad.Text = "Sad";
            this.BTNsad.UseVisualStyleBackColor = true;
            this.BTNsad.CheckedChanged += new System.EventHandler(this.BTNsad_CheckedChanged);
            // 
            // BTNhappy
            // 
            this.BTNhappy.AutoSize = true;
            this.BTNhappy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNhappy.Location = new System.Drawing.Point(23, 57);
            this.BTNhappy.Name = "BTNhappy";
            this.BTNhappy.Size = new System.Drawing.Size(56, 17);
            this.BTNhappy.TabIndex = 1;
            this.BTNhappy.TabStop = true;
            this.BTNhappy.Text = "Happy";
            this.BTNhappy.UseVisualStyleBackColor = true;
            this.BTNhappy.CheckedChanged += new System.EventHandler(this.BTNhappy_CheckedChanged);
            // 
            // BTNanxious
            // 
            this.BTNanxious.AutoSize = true;
            this.BTNanxious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNanxious.Location = new System.Drawing.Point(173, 33);
            this.BTNanxious.Name = "BTNanxious";
            this.BTNanxious.Size = new System.Drawing.Size(62, 17);
            this.BTNanxious.TabIndex = 2;
            this.BTNanxious.TabStop = true;
            this.BTNanxious.Text = "Anxious";
            this.BTNanxious.UseVisualStyleBackColor = true;
            this.BTNanxious.CheckedChanged += new System.EventHandler(this.BTNanxious_CheckedChanged);
            // 
            // BTNcalm
            // 
            this.BTNcalm.AutoSize = true;
            this.BTNcalm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNcalm.Location = new System.Drawing.Point(173, 57);
            this.BTNcalm.Name = "BTNcalm";
            this.BTNcalm.Size = new System.Drawing.Size(48, 17);
            this.BTNcalm.TabIndex = 3;
            this.BTNcalm.TabStop = true;
            this.BTNcalm.Text = "Calm";
            this.BTNcalm.UseVisualStyleBackColor = true;
            this.BTNcalm.CheckedChanged += new System.EventHandler(this.BTNcalm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(179, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "What is your mood?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(369, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(369, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(481, 323);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BTNhappy;
        private System.Windows.Forms.RadioButton BTNsad;
        private System.Windows.Forms.RadioButton BTNcalm;
        private System.Windows.Forms.RadioButton BTNanxious;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

