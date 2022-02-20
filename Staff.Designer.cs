namespace WindowsFormsApp1
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.StudentRegistration = new System.Windows.Forms.Button();
            this.CourseEnrolment = new System.Windows.Forms.Button();
            this.FeePayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentRegistration
            // 
            this.StudentRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.StudentRegistration.FlatAppearance.BorderSize = 0;
            this.StudentRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.StudentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.StudentRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.StudentRegistration.Image = ((System.Drawing.Image)(resources.GetObject("StudentRegistration.Image")));
            this.StudentRegistration.Location = new System.Drawing.Point(147, 173);
            this.StudentRegistration.Name = "StudentRegistration";
            this.StudentRegistration.Size = new System.Drawing.Size(135, 162);
            this.StudentRegistration.TabIndex = 0;
            this.StudentRegistration.Text = "Student Registration";
            this.StudentRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StudentRegistration.UseVisualStyleBackColor = false;
            this.StudentRegistration.Click += new System.EventHandler(this.StudentRegistration_Click);
            // 
            // CourseEnrolment
            // 
            this.CourseEnrolment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.CourseEnrolment.FlatAppearance.BorderSize = 0;
            this.CourseEnrolment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.CourseEnrolment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.CourseEnrolment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.CourseEnrolment.Image = ((System.Drawing.Image)(resources.GetObject("CourseEnrolment.Image")));
            this.CourseEnrolment.Location = new System.Drawing.Point(309, 172);
            this.CourseEnrolment.Name = "CourseEnrolment";
            this.CourseEnrolment.Size = new System.Drawing.Size(135, 162);
            this.CourseEnrolment.TabIndex = 1;
            this.CourseEnrolment.Text = "Course Enrolment";
            this.CourseEnrolment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CourseEnrolment.UseVisualStyleBackColor = false;
            this.CourseEnrolment.Click += new System.EventHandler(this.CourseEnrolment_Click);
            // 
            // FeePayment
            // 
            this.FeePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.FeePayment.FlatAppearance.BorderSize = 0;
            this.FeePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.FeePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FeePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.FeePayment.Image = ((System.Drawing.Image)(resources.GetObject("FeePayment.Image")));
            this.FeePayment.Location = new System.Drawing.Point(471, 172);
            this.FeePayment.Name = "FeePayment";
            this.FeePayment.Size = new System.Drawing.Size(135, 162);
            this.FeePayment.TabIndex = 2;
            this.FeePayment.Text = "Fee Payment";
            this.FeePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FeePayment.UseVisualStyleBackColor = false;
            this.FeePayment.Click += new System.EventHandler(this.FeePayment_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 124);
            this.label1.TabIndex = 3;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.MainPage.FlatAppearance.BorderSize = 0;
            this.MainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.MainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.MainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.MainPage.Image = ((System.Drawing.Image)(resources.GetObject("MainPage.Image")));
            this.MainPage.Location = new System.Drawing.Point(633, 172);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(135, 162);
            this.MainPage.TabIndex = 4;
            this.MainPage.Text = "Main Page";
            this.MainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainPage.UseVisualStyleBackColor = false;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(221, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(747, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "HI, Staff";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeePayment);
            this.Controls.Add(this.CourseEnrolment);
            this.Controls.Add(this.StudentRegistration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentRegistration;
        private System.Windows.Forms.Button CourseEnrolment;
        private System.Windows.Forms.Button FeePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}