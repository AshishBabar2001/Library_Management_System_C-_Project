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
    public partial class Add_New_Book : Form
    {
        public Add_New_Book()
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

        int Auto_Incr()
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From New_Book_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Book_ID) From New_Book_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;

            }

            SCon_Closed();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Author_Name.Text = "";
            tb_Book_Name.Text = "";
            tb_Price.Text = "";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Book_Name.Text != "" && tb_Price.Text != "" && tb_Author_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into New_Book_Details(Book_Id,Book_Name,Price,Publication_Date,Author_Name) Values(" + tb_Book_ID.Text + " ,'" + tb_Book_Name.Text + "'," + tb_Price.Text + " ,@PD,'" + tb_Author_Name.Text + "')";
                Cmd.Parameters.Add("@PD", SqlDbType.Date).Value = dtp_PD.Value.Date;
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully");

                tb_Book_ID.Text = Convert.ToString(Auto_Incr());

                Clear_Controls();

                tb_Book_Name.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Records ");
            }

            SCon_Closed();
        }

        private void Add_New_Book_Load(object sender, EventArgs e)
        {
            tb_Book_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

    }
}
