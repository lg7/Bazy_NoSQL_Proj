namespace BotApi
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.posxBox3 = new System.Windows.Forms.TextBox();
            this.posyBox4 = new System.Windows.Forms.TextBox();
            this.rmBox5 = new System.Windows.Forms.TextBox();
            this.peselBox6 = new System.Windows.Forms.TextBox();
            this.speedBox7 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REQUEST URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "POS_X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "POS_Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PESEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SPEED";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 20);
            this.textBox1.TabIndex = 7;
            // 
            // posxBox3
            // 
            this.posxBox3.Location = new System.Drawing.Point(94, 121);
            this.posxBox3.Name = "posxBox3";
            this.posxBox3.Size = new System.Drawing.Size(100, 20);
            this.posxBox3.TabIndex = 9;
            // 
            // posyBox4
            // 
            this.posyBox4.Location = new System.Drawing.Point(94, 156);
            this.posyBox4.Name = "posyBox4";
            this.posyBox4.Size = new System.Drawing.Size(100, 20);
            this.posyBox4.TabIndex = 10;
            // 
            // rmBox5
            // 
            this.rmBox5.Location = new System.Drawing.Point(94, 188);
            this.rmBox5.Name = "rmBox5";
            this.rmBox5.Size = new System.Drawing.Size(100, 20);
            this.rmBox5.TabIndex = 11;
            // 
            // peselBox6
            // 
            this.peselBox6.Location = new System.Drawing.Point(94, 223);
            this.peselBox6.Name = "peselBox6";
            this.peselBox6.Size = new System.Drawing.Size(100, 20);
            this.peselBox6.TabIndex = 12;
            // 
            // speedBox7
            // 
            this.speedBox7.Location = new System.Drawing.Point(94, 261);
            this.speedBox7.Name = "speedBox7";
            this.speedBox7.Size = new System.Drawing.Size(100, 20);
            this.speedBox7.TabIndex = 13;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(592, 41);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 16;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(592, 70);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.speedBox7);
            this.Controls.Add(this.peselBox6);
            this.Controls.Add(this.rmBox5);
            this.Controls.Add(this.posyBox4);
            this.Controls.Add(this.posxBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox posxBox3;
        private System.Windows.Forms.TextBox posyBox4;
        private System.Windows.Forms.TextBox rmBox5;
        private System.Windows.Forms.TextBox peselBox6;
        private System.Windows.Forms.TextBox speedBox7;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stopButton;
    }
}

