using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Abidi\\source\\repos\\PharmacyManagementSystem\\PharmacyManagementSystem\\TestDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserTbl values (@ID,@Name,@Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Abidi\\source\\repos\\PharmacyManagementSystem\\PharmacyManagementSystem\\TestDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update UserTbl set Name=@Name, Age=@Age where ID=@ID",con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Name",textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Updated Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE FROM table_name WHERE condition;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Abidi\\source\\repos\\PharmacyManagementSystem\\PharmacyManagementSystem\\TestDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete from UserTbl where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted Successfully"); 


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Abidi\\source\\repos\\PharmacyManagementSystem\\PharmacyManagementSystem\\TestDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTbl where ID=@ID",con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
