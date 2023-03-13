namespace usersignup
{
    partial class Return
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaccessionnumber = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txtyrpublished = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnreturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(369, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowed books";
            // 
            // txtaccessionnumber
            // 
            this.txtaccessionnumber.Location = new System.Drawing.Point(570, 242);
            this.txtaccessionnumber.Name = "txtaccessionnumber";
            this.txtaccessionnumber.Size = new System.Drawing.Size(212, 23);
            this.txtaccessionnumber.TabIndex = 2;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(570, 274);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(212, 23);
            this.txttitle.TabIndex = 2;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(570, 303);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(212, 23);
            this.txtauthor.TabIndex = 2;
            // 
            // txtyrpublished
            // 
            this.txtyrpublished.Location = new System.Drawing.Point(570, 333);
            this.txtyrpublished.Name = "txtyrpublished";
            this.txtyrpublished.Size = new System.Drawing.Size(212, 23);
            this.txtyrpublished.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accession Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Year Published";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(707, 379);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 5;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(457, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Book Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(457, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Borrowers Information";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(567, 79);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(215, 23);
            this.txtusername.TabIndex = 7;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(567, 108);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(215, 23);
            this.txtfirstname.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Date Borrowed";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(567, 166);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(215, 23);
            this.txtdate.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Last Name";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(567, 137);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(213, 23);
            this.txtlastname.TabIndex = 11;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyrpublished);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtaccessionnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.borrowed_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtaccessionnumber;
        private TextBox txttitle;
        private TextBox txtauthor;
        private TextBox txtyrpublished;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Button btnreturn;
        private Label label6;
        private Label label7;
        private TextBox txtusername;
        private TextBox txtfirstname;
        private Label label8;
        private Label label11;
        private TextBox txtdate;
        private Label label9;
        private Label label10;
        private TextBox txtlastname;
    }
}