
namespace Cars
{
    partial class registration
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
            this.components = new System.ComponentModel.Container();
            this.rnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chassistxt = new System.Windows.Forms.TextBox();
            this.advancetxt = new System.Windows.Forms.TextBox();
            this.remaingtxt = new System.Windows.Forms.TextBox();
            this.enginetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttlamont = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.maskedTnictxtextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rnametxt
            // 
            this.rnametxt.Location = new System.Drawing.Point(405, 145);
            this.rnametxt.Name = "rnametxt";
            this.rnametxt.Size = new System.Drawing.Size(369, 26);
            this.rnametxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(173, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chassistxt
            // 
            this.chassistxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.chassistxt.Location = new System.Drawing.Point(405, 487);
            this.chassistxt.Name = "chassistxt";
            this.chassistxt.Size = new System.Drawing.Size(369, 26);
            this.chassistxt.TabIndex = 8;
            this.chassistxt.Text = "CH-";
            this.chassistxt.TextChanged += new System.EventHandler(this.chassistxt_TextChanged);
            // 
            // advancetxt
            // 
            this.advancetxt.Location = new System.Drawing.Point(405, 399);
            this.advancetxt.Name = "advancetxt";
            this.advancetxt.Size = new System.Drawing.Size(369, 26);
            this.advancetxt.TabIndex = 6;
            this.advancetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.advancetxt_KeyPress);
            // 
            // remaingtxt
            // 
            this.remaingtxt.Location = new System.Drawing.Point(1073, 402);
            this.remaingtxt.Name = "remaingtxt";
            this.remaingtxt.Size = new System.Drawing.Size(369, 26);
            this.remaingtxt.TabIndex = 7;
            this.remaingtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.remaingtxt_KeyPress);
            // 
            // enginetxt
            // 
            this.enginetxt.Location = new System.Drawing.Point(1073, 230);
            this.enginetxt.Name = "enginetxt";
            this.enginetxt.Size = new System.Drawing.Size(369, 26);
            this.enginetxt.TabIndex = 3;
            this.enginetxt.Text = "EG-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(173, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chassis Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(173, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Booking date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(173, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Advance ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(849, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remaing Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(849, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delivery Date ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(858, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Engine number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(858, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "NIC";
            // 
            // ttlamont
            // 
            this.ttlamont.Location = new System.Drawing.Point(1073, 480);
            this.ttlamont.Name = "ttlamont";
            this.ttlamont.Size = new System.Drawing.Size(369, 26);
            this.ttlamont.TabIndex = 9;
            this.ttlamont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttlamont_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(173, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "CAR NAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(849, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 314);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1073, 310);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(369, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // maskedTnictxtextBox1
            // 
            this.maskedTnictxtextBox1.Location = new System.Drawing.Point(1073, 145);
            this.maskedTnictxtextBox1.Mask = "00000-0000000-0";
            this.maskedTnictxtextBox1.Name = "maskedTnictxtextBox1";
            this.maskedTnictxtextBox1.Size = new System.Drawing.Size(137, 26);
            this.maskedTnictxtextBox1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTnictxtextBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ttlamont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remaingtxt);
            this.Controls.Add(this.enginetxt);
            this.Controls.Add(this.advancetxt);
            this.Controls.Add(this.chassistxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rnametxt);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rnametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chassistxt;
        private System.Windows.Forms.TextBox advancetxt;
        private System.Windows.Forms.TextBox remaingtxt;
        private System.Windows.Forms.TextBox enginetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttlamont;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox maskedTnictxtextBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}