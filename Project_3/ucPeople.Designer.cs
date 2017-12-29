namespace Project_3
{
    partial class ucPeople
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.people_faculty = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.faculty_list = new System.Windows.Forms.ComboBox();
            this.people_staff = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.staff_data = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fac_image = new System.Windows.Forms.PictureBox();
            this.fac_website = new System.Windows.Forms.Label();
            this.fac_phone = new System.Windows.Forms.Label();
            this.fac_email = new System.Windows.Forms.Label();
            this.fac_position = new System.Windows.Forms.Label();
            this.fac_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.people_title = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.people_faculty.SuspendLayout();
            this.people_staff.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fac_image)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.people_faculty);
            this.tabControl1.Controls.Add(this.people_staff);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // people_faculty
            // 
            this.people_faculty.Controls.Add(this.label7);
            this.people_faculty.Controls.Add(this.faculty_list);
            this.people_faculty.Location = new System.Drawing.Point(4, 22);
            this.people_faculty.Name = "people_faculty";
            this.people_faculty.Padding = new System.Windows.Forms.Padding(3);
            this.people_faculty.Size = new System.Drawing.Size(299, 242);
            this.people_faculty.TabIndex = 0;
            this.people_faculty.Text = "Faculty";
            this.people_faculty.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select a faculty member :";
            // 
            // faculty_list
            // 
            this.faculty_list.FormattingEnabled = true;
            this.faculty_list.Location = new System.Drawing.Point(17, 59);
            this.faculty_list.Name = "faculty_list";
            this.faculty_list.Size = new System.Drawing.Size(153, 21);
            this.faculty_list.TabIndex = 0;
            this.faculty_list.SelectedIndexChanged += new System.EventHandler(this.faculty_list_SelectedIndexChanged);
            // 
            // people_staff
            // 
            this.people_staff.Controls.Add(this.label6);
            this.people_staff.Controls.Add(this.staff_data);
            this.people_staff.Location = new System.Drawing.Point(4, 22);
            this.people_staff.Name = "people_staff";
            this.people_staff.Padding = new System.Windows.Forms.Padding(3);
            this.people_staff.Size = new System.Drawing.Size(299, 242);
            this.people_staff.TabIndex = 1;
            this.people_staff.Text = "Staff";
            this.people_staff.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select a staff member :";
            // 
            // staff_data
            // 
            this.staff_data.FormattingEnabled = true;
            this.staff_data.Location = new System.Drawing.Point(29, 51);
            this.staff_data.Name = "staff_data";
            this.staff_data.Size = new System.Drawing.Size(174, 21);
            this.staff_data.TabIndex = 0;
            this.staff_data.SelectedIndexChanged += new System.EventHandler(this.staff_data_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.fac_website);
            this.panel1.Controls.Add(this.fac_phone);
            this.panel1.Controls.Add(this.fac_email);
            this.panel1.Controls.Add(this.fac_position);
            this.panel1.Controls.Add(this.fac_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(316, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 268);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Website:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fac_image);
            this.panel2.Location = new System.Drawing.Point(81, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 123);
            this.panel2.TabIndex = 6;
            // 
            // fac_image
            // 
            this.fac_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fac_image.Location = new System.Drawing.Point(0, 0);
            this.fac_image.Name = "fac_image";
            this.fac_image.Size = new System.Drawing.Size(117, 123);
            this.fac_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fac_image.TabIndex = 0;
            this.fac_image.TabStop = false;
            // 
            // fac_website
            // 
            this.fac_website.AutoSize = true;
            this.fac_website.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fac_website.Location = new System.Drawing.Point(78, 227);
            this.fac_website.Name = "fac_website";
            this.fac_website.Size = new System.Drawing.Size(42, 17);
            this.fac_website.TabIndex = 5;
            this.fac_website.Text = "label1";
            // 
            // fac_phone
            // 
            this.fac_phone.AutoSize = true;
            this.fac_phone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fac_phone.Location = new System.Drawing.Point(78, 206);
            this.fac_phone.Name = "fac_phone";
            this.fac_phone.Size = new System.Drawing.Size(42, 17);
            this.fac_phone.TabIndex = 4;
            this.fac_phone.Text = "label1";
            // 
            // fac_email
            // 
            this.fac_email.AutoSize = true;
            this.fac_email.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fac_email.Location = new System.Drawing.Point(78, 187);
            this.fac_email.Name = "fac_email";
            this.fac_email.Size = new System.Drawing.Size(42, 17);
            this.fac_email.TabIndex = 3;
            this.fac_email.Text = "label1";
            // 
            // fac_position
            // 
            this.fac_position.AutoSize = true;
            this.fac_position.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fac_position.Location = new System.Drawing.Point(78, 168);
            this.fac_position.Name = "fac_position";
            this.fac_position.Size = new System.Drawing.Size(42, 17);
            this.fac_position.TabIndex = 2;
            this.fac_position.Text = "label2";
            // 
            // fac_name
            // 
            this.fac_name.AutoSize = true;
            this.fac_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fac_name.Location = new System.Drawing.Point(77, 149);
            this.fac_name.Name = "fac_name";
            this.fac_name.Size = new System.Drawing.Size(45, 19);
            this.fac_name.TabIndex = 1;
            this.fac_name.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 274);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // people_title
            // 
            this.people_title.AutoSize = true;
            this.people_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.people_title.Location = new System.Drawing.Point(23, 24);
            this.people_title.Name = "people_title";
            this.people_title.Size = new System.Drawing.Size(74, 24);
            this.people_title.TabIndex = 3;
            this.people_title.Text = "label6";
            // 
            // ucPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.people_title);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPeople";
            this.Size = new System.Drawing.Size(630, 343);
            this.Load += new System.EventHandler(this.ucPeople_Load);
            this.tabControl1.ResumeLayout(false);
            this.people_faculty.ResumeLayout(false);
            this.people_faculty.PerformLayout();
            this.people_staff.ResumeLayout(false);
            this.people_staff.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fac_image)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage people_faculty;
        private System.Windows.Forms.TabPage people_staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fac_website;
        private System.Windows.Forms.Label fac_phone;
        private System.Windows.Forms.Label fac_email;
        private System.Windows.Forms.Label fac_position;
        private System.Windows.Forms.Label fac_name;
        private System.Windows.Forms.PictureBox fac_image;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox faculty_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox staff_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label people_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
