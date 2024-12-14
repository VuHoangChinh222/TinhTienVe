namespace TinhTienVe
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
            this.classTicket = new System.Windows.Forms.ComboBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dasda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelss = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.changCost = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.name = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.idCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classTicket
            // 
            this.classTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.classTicket.FormattingEnabled = true;
            this.classTicket.Items.AddRange(new object[] {
            "Business Class",
            "Economy Class"});
            this.classTicket.Location = new System.Drawing.Point(235, 203);
            this.classTicket.Name = "classTicket";
            this.classTicket.Size = new System.Drawing.Size(238, 39);
            this.classTicket.TabIndex = 0;
            this.classTicket.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.birthday.Location = new System.Drawing.Point(235, 160);
            this.birthday.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(480, 38);
            this.birthday.TabIndex = 1;
            this.birthday.Value = new System.DateTime(2024, 12, 14, 0, 0, 0, 0);
            this.birthday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // dasda
            // 
            this.dasda.AutoSize = true;
            this.dasda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dasda.Location = new System.Drawing.Point(12, 60);
            this.dasda.Name = "dasda";
            this.dasda.Size = new System.Drawing.Size(118, 32);
            this.dasda.TabIndex = 4;
            this.dasda.Text = "Address";
            this.dasda.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(121, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "*";
            // 
            // labelss
            // 
            this.labelss.AutoSize = true;
            this.labelss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelss.Location = new System.Drawing.Point(12, 110);
            this.labelss.Name = "labelss";
            this.labelss.Size = new System.Drawing.Size(103, 32);
            this.labelss.TabIndex = 6;
            this.labelss.Text = "ID card";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(189, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(204, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(12, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Type of Class";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(12, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "Payment";
            // 
            // changCost
            // 
            this.changCost.AutoSize = true;
            this.changCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.changCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.changCost.Location = new System.Drawing.Point(228, 260);
            this.changCost.Name = "changCost";
            this.changCost.Size = new System.Drawing.Size(35, 38);
            this.changCost.TabIndex = 13;
            this.changCost.Text = "0";
            this.changCost.TextChanged += new System.EventHandler(this.changeCost);
            this.changCost.Click += new System.EventHandler(this.label3_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name.Location = new System.Drawing.Point(235, 12);
            this.name.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(643, 38);
            this.name.TabIndex = 14;
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adress.Location = new System.Drawing.Point(235, 57);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(643, 38);
            this.adress.TabIndex = 15;
            // 
            // idCard
            // 
            this.idCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.idCard.Location = new System.Drawing.Point(235, 104);
            this.idCard.Name = "idCard";
            this.idCard.Size = new System.Drawing.Size(643, 38);
            this.idCard.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(721, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "(DD/MM/YYYY)";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCard);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Controls.Add(this.changCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelss);
            this.Controls.Add(this.dasda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.classTicket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classTicket;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dasda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label changCost;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox idCard;
        private System.Windows.Forms.Label label4;
    }
}

