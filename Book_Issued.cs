using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Book_Issued : Form
    {
        public Book_Issued()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Library_Management_System;Integrated Security=True");

        void SCon_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void SCon_Closed()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void clear_Controls()
        {
            tb_Author_Name.Clear();
            tb_Student_Name.Clear();
            tb_Book_Name.Clear();
            tb_Price.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Student_Name.Text != "" && tb_Book_Name.Text != "" && tb_Author_Name.Text == "" && tb_Price.Text == "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into Book_Issue_Details(Student_Name,Book_Name,Pric,Tie_Up_Date,Author_Name) Values('" + tb_Student_Name.Text + "','" + tb_Book_Name.Text + "'," + tb_Price.Text + " ,'" + dtp_TUD.Text + "','" + tb_Author_Name.Text + "')";
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully");

                clear_Controls();

                tb_Student_Name.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Records ");
            }

            SCon_Closed();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Student_Name.Text != "" || tb_Book_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Book_Issue_Details Where Student_Name = '" + tb_Student_Name.Text + "' And Book_Name = '" + tb_Book_Name.Text + "'";

                var obj = Cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Price.Text = obj.GetString(obj.GetOrdinal("Pric"));
                    dtp_TUD.Text = (obj["Tie_Up_Date"].ToString());
                    tb_Author_Name.Text = (obj["Author_Name"].ToString());

                }
                else
                {
                    MessageBox.Show("Invalid ID Number!!!");

                    tb_Book_Name.Clear();
                    tb_Student_Name.Clear();
                    tb_Student_Name.Focus();
                }
            }
        }

        private void Book_Issued_Load(object sender, EventArgs e)
        {

        }
    }
}
