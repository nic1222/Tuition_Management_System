namespace WindowsFormsApp1
{
    partial class Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor));
            this.MainPage = new System.Windows.Forms.Button();
            this.CheckStudentInformation = new System.Windows.Forms.Button();
            this.UpdateClassInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.MainPage.FlatAppearance.BorderSize = 0;
            this.MainPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.MainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.MainPage.Image = ((System.Drawing.Image)(resources.GetObject("MainPage.Image")));
            this.MainPage.Location = new System.Drawing.Point(591, 178);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(135, 162);
            this.MainPage.TabIndex = 9;
            this.MainPage.Text = "Main Page";
            this.MainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MainPage.UseVisualStyleBackColor = false;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // CheckStudentInformation
            // 
            this.CheckStudentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.CheckStudentInformation.FlatAppearance.BorderSize = 0;
            this.CheckStudentInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.CheckStudentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckStudentInformation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckStudentInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.CheckStudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("CheckStudentInformation.Image")));
            this.CheckStudentInformation.Location = new System.Drawing.Point(386, 178);
            this.CheckStudentInformation.Name = "CheckStudentInformation";
            this.CheckStudentInformation.Size = new System.Drawing.Size(135, 162);
            this.CheckStudentInformation.TabIndex = 6;
            this.CheckStudentInformation.Text = "Check Student Information";
            this.CheckStudentInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckStudentInformation.UseVisualStyleBackColor = false;
            this.CheckStudentInformation.Click += new System.EventHandler(this.CheckStudentInformation_Click);
            // 
            // UpdateClassInformation
            // 
            this.UpdateClassInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(189)))), ((int)(((byte)(218)))));
            this.UpdateClassInformation.FlatAppearance.BorderSize = 0;
            this.UpdateClassInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.UpdateClassInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateClassInformation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClassInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(95)))));
            this.UpdateClassInformation.Image = ((System.Drawing.Image)(resources.GetObject("UpdateClassInformation.Image")));
            this.UpdateClassInformation.Location = new System.Drawing.Point(181, 178);
            this.UpdateClassInformation.Name = "UpdateClassInformation";
            this.UpdateClassInformation.Size = new System.Drawing.Size(135, 162);
            this.UpdateClassInformation.TabIndex = 5;
            this.UpdateClassInformation.Text = "Update Class Information";
            this.UpdateClassInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateClassInformation.UseVisualStyleBackColor = false;
            this.UpdateClassInformation.Click += new System.EventHandler(this.UpdateClassInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hi, Tutor";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 124);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(747, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(643, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.CheckStudentInformation);
            this.Controls.Add(this.UpdateClassInformation);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tutor";
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.Tutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.Button CheckStudentInformation;
        private System.Windows.Forms.Button UpdateClassInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}