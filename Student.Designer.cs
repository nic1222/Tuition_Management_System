namespace WindowsFormsApp1
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePersonalInformation = new System.Windows.Forms.Button();
            this.CheckOutstandingFee = new System.Windows.Forms.Button();
            this.CheckSchedule = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi, Student";
            // 
            // UpdatePersonalInformation
            // 
            this.UpdatePersonalInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.UpdatePersonalInformation.FlatAppearance.BorderSize = 0;
            this.UpdatePersonalInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.UpdatePersonalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePersonalInformation.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.UpdatePersonalInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.UpdatePersonalInformation.Image = ((System.Drawing.Image)(resources.GetObject("UpdatePersonalInformation.Image")));
            this.UpdatePersonalInformation.Location = new System.Drawing.Point(164, 174);
            this.UpdatePersonalInformation.Name = "UpdatePersonalInformation";
            this.UpdatePersonalInformation.Size = new System.Drawing.Size(135, 162);
            this.UpdatePersonalInformation.TabIndex = 1;
            this.UpdatePersonalInformation.Text = "Update Personal Information";
            this.UpdatePersonalInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdatePersonalInformation.UseVisualStyleBackColor = false;
            this.UpdatePersonalInformation.Click += new System.EventHandler(this.UpdatePersonalInformation_Click);
            // 
            // CheckOutstandingFee
            // 
            this.CheckOutstandingFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.CheckOutstandingFee.FlatAppearance.BorderSize = 0;
            this.CheckOutstandingFee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.CheckOutstandingFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutstandingFee.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CheckOutstandingFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.CheckOutstandingFee.Image = ((System.Drawing.Image)(resources.GetObject("CheckOutstandingFee.Image")));
            this.CheckOutstandingFee.Location = new System.Drawing.Point(322, 174);
            this.CheckOutstandingFee.Name = "CheckOutstandingFee";
            this.CheckOutstandingFee.Size = new System.Drawing.Size(135, 162);
            this.CheckOutstandingFee.TabIndex = 2;
            this.CheckOutstandingFee.Text = "Check Outstanding Fee";
            this.CheckOutstandingFee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckOutstandingFee.UseVisualStyleBackColor = false;
            this.CheckOutstandingFee.Click += new System.EventHandler(this.CheckOutstandingFee_Click);
            // 
            // CheckSchedule
            // 
            this.CheckSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.CheckSchedule.FlatAppearance.BorderSize = 0;
            this.CheckSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.CheckSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckSchedule.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CheckSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.CheckSchedule.Image = ((System.Drawing.Image)(resources.GetObject("CheckSchedule.Image")));
            this.CheckSchedule.Location = new System.Drawing.Point(480, 174);
            this.CheckSchedule.Name = "CheckSchedule";
            this.CheckSchedule.Size = new System.Drawing.Size(135, 162);
            this.CheckSchedule.TabIndex = 3;
            this.CheckSchedule.Text = "Check Schedule";
            this.CheckSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckSchedule.UseVisualStyleBackColor = false;
            this.CheckSchedule.Click += new System.EventHandler(this.CheckSchedule_Click);
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.MainPage.FlatAppearance.BorderSize = 0;
            this.MainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.MainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPage.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.MainPage.Image = ((System.Drawing.Image)(resources.GetObject("MainPage.Image")));
            this.MainPage.Location = new System.Drawing.Point(638, 174);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(135, 162);
            this.MainPage.TabIndex = 4;
            this.MainPage.Text = "Main Page";
            this.MainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainPage.UseVisualStyleBackColor = false;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 124);
            this.label2.TabIndex = 12;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(223, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.CheckSchedule);
            this.Controls.Add(this.CheckOutstandingFee);
            this.Controls.Add(this.UpdatePersonalInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdatePersonalInformation;
        private System.Windows.Forms.Button CheckOutstandingFee;
        private System.Windows.Forms.Button CheckSchedule;
        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}