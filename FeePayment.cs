using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FeePayment : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public FeePayment()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.Show();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            float outstandingfee = float.Parse(PayAmount.Text) - float.Parse(getFee.fee);
            float result = Math.Abs(outstandingfee);
            cmd.Connection = con;
            cmd.CommandText = "update [Student] set OutstandingFee = '"+result.ToString()+ "' where StudentName= '" + Student.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pay Successfully");
            MessageBox.Show(Student.SelectedItem.ToString() + "\n\r"+"Paid Amount: RM"+PayAmount.Text+"\n\r"+"Outstanding Amount: RM"+result.ToString()+"\n\r"+"Paid at: " +  System.DateTime.Now.ToString(), "Receipt");
        }

        private int startX, StartY;
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startX = e.X;
                StartY = e.Y;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - StartY;
            }
        }


        private void Student_MouseClick(object sender, MouseEventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select StudentName from[Student]";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Student.Items.Clear();
                while (reader.Read())
                {
                    Student.Items.Add(reader[0].ToString());
                }
            }
            reader.Close();
            Student.DroppedDown = true;
        }
        private void Student_KeyDown(object sender, KeyEventArgs e)
        {
            Student.DroppedDown = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(139, 141, 169);
        }


        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(69, 72, 118);
        }

        private void Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "select OutstandingFee from [Student] where StudentName = '"+Student.SelectedItem.ToString()+"'";
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            { ;
                getFee.fee = reader[0].ToString();
                OutstandingFee.Text = "RM "+getFee.fee;
            }
            reader.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FeePayment_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = StudentManagementSystem.accdb";
            con.Open();
        }

      
    }
}
