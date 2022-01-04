namespace Library_Management_System
{
    partial class Add_New_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Book));
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_PD = new System.Windows.Forms.DateTimePicker();
            this.tb_Author_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_Book_ID = new System.Windows.Forms.TextBox();
            this.lbl_Author_Name = new System.Windows.Forms.Label();
            this.lbl_Add_New_Books = new System.Windows.Forms.Label();
            this.lbl_Publication_Date = new System.Windows.Forms.Label();
            this.lbl_Price_No = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(377, 676);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(177, 43);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_PD
            // 
            this.dtp_PD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PD.Location = new System.Drawing.Point(817, 457);
            this.dtp_PD.Name = "dtp_PD";
            this.dtp_PD.Size = new System.Drawing.Size(321, 30);
            this.dtp_PD.TabIndex = 16;
            // 
            // tb_Author_Name
            // 
            this.tb_Author_Name.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Author_Name.Location = new System.Drawing.Point(817, 529);
            this.tb_Author_Name.MaxLength = 10;
            this.tb_Author_Name.Multiline = true;
            this.tb_Author_Name.Name = "tb_Author_Name";
            this.tb_Author_Name.Size = new System.Drawing.Size(321, 41);
            this.tb_Author_Name.TabIndex = 17;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(817, 366);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Multiline = true;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(321, 41);
            this.tb_Price.TabIndex = 15;
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(817, 291);
            this.tb_Book_Name.MaxLength = 40;
            this.tb_Book_Name.Multiline = true;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(321, 41);
            this.tb_Book_Name.TabIndex = 14;
            // 
            // tb_Book_ID
            // 
            this.tb_Book_ID.Enabled = false;
            this.tb_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_ID.Location = new System.Drawing.Point(817, 216);
            this.tb_Book_ID.MaxLength = 5;
            this.tb_Book_ID.Multiline = true;
            this.tb_Book_ID.Name = "tb_Book_ID";
            this.tb_Book_ID.Size = new System.Drawing.Size(321, 41);
            this.tb_Book_ID.TabIndex = 13;
            // 
            // lbl_Author_Name
            // 
            this.lbl_Author_Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Author_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Author_Name.Location = new System.Drawing.Point(371, 536);
            this.lbl_Author_Name.Name = "lbl_Author_Name";
            this.lbl_Author_Name.Size = new System.Drawing.Size(258, 34);
            this.lbl_Author_Name.TabIndex = 9;
            this.lbl_Author_Name.Text = "Author Name";
            // 
            // lbl_Add_New_Books
            // 
            this.lbl_Add_New_Books.AutoSize = true;
            this.lbl_Add_New_Books.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Add_New_Books.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Books.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Add_New_Books.Location = new System.Drawing.Point(527, 46);
            this.lbl_Add_New_Books.Name = "lbl_Add_New_Books";
            this.lbl_Add_New_Books.Size = new System.Drawing.Size(453, 69);
            this.lbl_Add_New_Books.TabIndex = 1;
            this.lbl_Add_New_Books.Text = "Add New Book";
            // 
            // lbl_Publication_Date
            // 
            this.lbl_Publication_Date.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Publication_Date.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publication_Date.ForeColor = System.Drawing.Color.Red;
            this.lbl_Publication_Date.Location = new System.Drawing.Point(371, 455);
            this.lbl_Publication_Date.Name = "lbl_Publication_Date";
            this.lbl_Publication_Date.Size = new System.Drawing.Size(258, 34);
            this.lbl_Publication_Date.TabIndex = 8;
            this.lbl_Publication_Date.Text = "Publication Date";
            // 
            // lbl_Price_No
            // 
            this.lbl_Price_No.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Price_No.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Price_No.Location = new System.Drawing.Point(371, 373);
            this.lbl_Price_No.Name = "lbl_Price_No";
            this.lbl_Price_No.Size = new System.Drawing.Size(258, 34);
            this.lbl_Price_No.TabIndex = 10;
            this.lbl_Price_No.Text = "Price";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Book_Name.Location = new System.Drawing.Point(371, 298);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(258, 34);
            this.lbl_Book_Name.TabIndex = 12;
            this.lbl_Book_Name.Text = "Book Name";
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_Book_ID.Location = new System.Drawing.Point(371, 216);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(258, 41);
            this.lbl_Book_ID.TabIndex = 11;
            this.lbl_Book_ID.Text = "Book ID";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_Header.Controls.Add(this.lbl_Add_New_Books);
            this.pnl_Header.Location = new System.Drawing.Point(1, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1388, 148);
            this.pnl_Header.TabIndex = 7;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(863, 676);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(177, 43);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1387, 745);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_PD);
            this.Controls.Add(this.tb_Author_Name);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_Book_ID);
            this.Controls.Add(this.lbl_Author_Name);
            this.Controls.Add(this.lbl_Publication_Date);
            this.Controls.Add(this.lbl_Price_No);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_ID);
            this.Controls.Add(this.pnl_Header);
            this.Name = "Add_New_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Book";
            this.Load += new System.EventHandler(this.Add_New_Book_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_PD;
        private System.Windows.Forms.TextBox tb_Author_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_Book_ID;
        private System.Windows.Forms.Label lbl_Author_Name;
        private System.Windows.Forms.Label lbl_Add_New_Books;
        private System.Windows.Forms.Label lbl_Publication_Date;
        private System.Windows.Forms.Label lbl_Price_No;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Close;
    }
}