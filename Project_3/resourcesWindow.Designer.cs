namespace Project_3
{
    partial class resourcesWindow
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
            this.study_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.list_places = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.abroad_pDes = new System.Windows.Forms.Label();
            this.abroad_pTitle = new System.Windows.Forms.Label();
            this.panel_description = new System.Windows.Forms.Panel();
            this.abroad_description = new System.Windows.Forms.Label();
            this.abroad_title = new System.Windows.Forms.Label();
            this.stu_service_panel = new System.Windows.Forms.Panel();
            this.advising_title = new System.Windows.Forms.Label();
            this.stu_services_tab = new System.Windows.Forms.TabControl();
            this.tab_acad_adv = new System.Windows.Forms.TabPage();
            this.acad_link = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.acad_des = new System.Windows.Forms.Label();
            this.acad_title = new System.Windows.Forms.Label();
            this.tab_prof_advisor = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.prof_advisor_data = new System.Windows.Forms.DataGridView();
            this.adv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof_adv_title = new System.Windows.Forms.Label();
            this.tab_faculty = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.faculty_des = new System.Windows.Forms.Label();
            this.faculty_title = new System.Windows.Forms.Label();
            this.tab_minor_adv = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.minor_stu_services = new System.Windows.Forms.DataGridView();
            this.minor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adv_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minor_title = new System.Windows.Forms.Label();
            this.tutor_panel = new System.Windows.Forms.Panel();
            this.tutor_link = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tutor_des = new System.Windows.Forms.Label();
            this.tutor_title = new System.Windows.Forms.Label();
            this.study_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_description.SuspendLayout();
            this.stu_service_panel.SuspendLayout();
            this.stu_services_tab.SuspendLayout();
            this.tab_acad_adv.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_prof_advisor.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prof_advisor_data)).BeginInit();
            this.tab_faculty.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tab_minor_adv.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minor_stu_services)).BeginInit();
            this.tutor_panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // study_panel
            // 
            this.study_panel.Controls.Add(this.label1);
            this.study_panel.Controls.Add(this.tableLayoutPanel1);
            this.study_panel.Controls.Add(this.panel_description);
            this.study_panel.Controls.Add(this.abroad_title);
            this.study_panel.Location = new System.Drawing.Point(317, 12);
            this.study_panel.Name = "study_panel";
            this.study_panel.Size = new System.Drawing.Size(322, 306);
            this.study_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a place for description:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.list_places, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 179);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // list_places
            // 
            this.list_places.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_places.FormattingEnabled = true;
            this.list_places.Location = new System.Drawing.Point(3, 3);
            this.list_places.Name = "list_places";
            this.list_places.Size = new System.Drawing.Size(132, 173);
            this.list_places.TabIndex = 2;
            this.list_places.SelectedIndexChanged += new System.EventHandler(this.list_places_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.abroad_pTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(141, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 173);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.abroad_pDes);
            this.panel2.Location = new System.Drawing.Point(7, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 133);
            this.panel2.TabIndex = 1;
            // 
            // abroad_pDes
            // 
            this.abroad_pDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abroad_pDes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abroad_pDes.Location = new System.Drawing.Point(0, 0);
            this.abroad_pDes.Name = "abroad_pDes";
            this.abroad_pDes.Size = new System.Drawing.Size(124, 133);
            this.abroad_pDes.TabIndex = 0;
            this.abroad_pDes.Text = "label4";
            // 
            // abroad_pTitle
            // 
            this.abroad_pTitle.AutoSize = true;
            this.abroad_pTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abroad_pTitle.Location = new System.Drawing.Point(3, 13);
            this.abroad_pTitle.Name = "abroad_pTitle";
            this.abroad_pTitle.Size = new System.Drawing.Size(49, 19);
            this.abroad_pTitle.TabIndex = 0;
            this.abroad_pTitle.Text = "label3";
            // 
            // panel_description
            // 
            this.panel_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_description.Controls.Add(this.abroad_description);
            this.panel_description.Location = new System.Drawing.Point(16, 27);
            this.panel_description.Name = "panel_description";
            this.panel_description.Size = new System.Drawing.Size(276, 68);
            this.panel_description.TabIndex = 1;
            // 
            // abroad_description
            // 
            this.abroad_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abroad_description.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abroad_description.Location = new System.Drawing.Point(0, 0);
            this.abroad_description.Name = "abroad_description";
            this.abroad_description.Size = new System.Drawing.Size(276, 68);
            this.abroad_description.TabIndex = 0;
            this.abroad_description.Text = "label2";
            this.abroad_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abroad_title
            // 
            this.abroad_title.AutoSize = true;
            this.abroad_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abroad_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.abroad_title.Location = new System.Drawing.Point(12, 0);
            this.abroad_title.Name = "abroad_title";
            this.abroad_title.Size = new System.Drawing.Size(74, 24);
            this.abroad_title.TabIndex = 0;
            this.abroad_title.Text = "label1";
            // 
            // stu_service_panel
            // 
            this.stu_service_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stu_service_panel.BackColor = System.Drawing.SystemColors.Control;
            this.stu_service_panel.Controls.Add(this.advising_title);
            this.stu_service_panel.Controls.Add(this.stu_services_tab);
            this.stu_service_panel.Location = new System.Drawing.Point(13, 15);
            this.stu_service_panel.Name = "stu_service_panel";
            this.stu_service_panel.Size = new System.Drawing.Size(157, 180);
            this.stu_service_panel.TabIndex = 1;
            // 
            // advising_title
            // 
            this.advising_title.AutoSize = true;
            this.advising_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advising_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.advising_title.Location = new System.Drawing.Point(10, 13);
            this.advising_title.Name = "advising_title";
            this.advising_title.Size = new System.Drawing.Size(74, 24);
            this.advising_title.TabIndex = 1;
            this.advising_title.Text = "label1";
            // 
            // stu_services_tab
            // 
            this.stu_services_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stu_services_tab.Controls.Add(this.tab_acad_adv);
            this.stu_services_tab.Controls.Add(this.tab_prof_advisor);
            this.stu_services_tab.Controls.Add(this.tab_faculty);
            this.stu_services_tab.Controls.Add(this.tab_minor_adv);
            this.stu_services_tab.Location = new System.Drawing.Point(6, 40);
            this.stu_services_tab.Name = "stu_services_tab";
            this.stu_services_tab.SelectedIndex = 0;
            this.stu_services_tab.Size = new System.Drawing.Size(151, 140);
            this.stu_services_tab.TabIndex = 0;
            // 
            // tab_acad_adv
            // 
            this.tab_acad_adv.Controls.Add(this.acad_link);
            this.tab_acad_adv.Controls.Add(this.panel4);
            this.tab_acad_adv.Controls.Add(this.acad_title);
            this.tab_acad_adv.Location = new System.Drawing.Point(4, 22);
            this.tab_acad_adv.Name = "tab_acad_adv";
            this.tab_acad_adv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_acad_adv.Size = new System.Drawing.Size(143, 114);
            this.tab_acad_adv.TabIndex = 0;
            this.tab_acad_adv.Text = "Academic Advisors";
            this.tab_acad_adv.UseVisualStyleBackColor = true;
            // 
            // acad_link
            // 
            this.acad_link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acad_link.AutoSize = true;
            this.acad_link.Location = new System.Drawing.Point(9, 236);
            this.acad_link.Name = "acad_link";
            this.acad_link.Size = new System.Drawing.Size(55, 13);
            this.acad_link.TabIndex = 2;
            this.acad_link.TabStop = true;
            this.acad_link.Text = "linkLabel1";
            this.acad_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.acad_link_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.acad_des);
            this.panel4.Location = new System.Drawing.Point(9, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 191);
            this.panel4.TabIndex = 1;
            // 
            // acad_des
            // 
            this.acad_des.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acad_des.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acad_des.Location = new System.Drawing.Point(0, 0);
            this.acad_des.Name = "acad_des";
            this.acad_des.Size = new System.Drawing.Size(448, 191);
            this.acad_des.TabIndex = 0;
            this.acad_des.Text = "label3";
            // 
            // acad_title
            // 
            this.acad_title.AutoSize = true;
            this.acad_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acad_title.Location = new System.Drawing.Point(8, 19);
            this.acad_title.Name = "acad_title";
            this.acad_title.Size = new System.Drawing.Size(65, 20);
            this.acad_title.TabIndex = 0;
            this.acad_title.Text = "label2";
            // 
            // tab_prof_advisor
            // 
            this.tab_prof_advisor.Controls.Add(this.panel5);
            this.tab_prof_advisor.Controls.Add(this.prof_adv_title);
            this.tab_prof_advisor.Location = new System.Drawing.Point(4, 22);
            this.tab_prof_advisor.Name = "tab_prof_advisor";
            this.tab_prof_advisor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_prof_advisor.Size = new System.Drawing.Size(143, 114);
            this.tab_prof_advisor.TabIndex = 1;
            this.tab_prof_advisor.Text = "Professional Advisors";
            this.tab_prof_advisor.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.prof_advisor_data);
            this.panel5.Location = new System.Drawing.Point(9, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(587, 145);
            this.panel5.TabIndex = 2;
            // 
            // prof_advisor_data
            // 
            this.prof_advisor_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prof_advisor_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adv_name,
            this.dept,
            this.email});
            this.prof_advisor_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prof_advisor_data.Location = new System.Drawing.Point(0, 0);
            this.prof_advisor_data.Name = "prof_advisor_data";
            this.prof_advisor_data.Size = new System.Drawing.Size(587, 145);
            this.prof_advisor_data.TabIndex = 0;
            // 
            // adv_name
            // 
            this.adv_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adv_name.HeaderText = "Advisor Name";
            this.adv_name.Name = "adv_name";
            // 
            // dept
            // 
            this.dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dept.HeaderText = "Departmet";
            this.dept.Name = "dept";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // prof_adv_title
            // 
            this.prof_adv_title.AutoSize = true;
            this.prof_adv_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_adv_title.Location = new System.Drawing.Point(18, 25);
            this.prof_adv_title.Name = "prof_adv_title";
            this.prof_adv_title.Size = new System.Drawing.Size(65, 20);
            this.prof_adv_title.TabIndex = 1;
            this.prof_adv_title.Text = "label2";
            // 
            // tab_faculty
            // 
            this.tab_faculty.Controls.Add(this.panel3);
            this.tab_faculty.Controls.Add(this.faculty_title);
            this.tab_faculty.Location = new System.Drawing.Point(4, 22);
            this.tab_faculty.Name = "tab_faculty";
            this.tab_faculty.Padding = new System.Windows.Forms.Padding(3);
            this.tab_faculty.Size = new System.Drawing.Size(143, 114);
            this.tab_faculty.TabIndex = 2;
            this.tab_faculty.Text = "Faculty Advisors";
            this.tab_faculty.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.faculty_des);
            this.panel3.Location = new System.Drawing.Point(21, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 195);
            this.panel3.TabIndex = 1;
            // 
            // faculty_des
            // 
            this.faculty_des.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faculty_des.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_des.Location = new System.Drawing.Point(0, 0);
            this.faculty_des.Name = "faculty_des";
            this.faculty_des.Size = new System.Drawing.Size(429, 195);
            this.faculty_des.TabIndex = 0;
            this.faculty_des.Text = "label3";
            this.faculty_des.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faculty_title
            // 
            this.faculty_title.AutoSize = true;
            this.faculty_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_title.Location = new System.Drawing.Point(18, 14);
            this.faculty_title.Name = "faculty_title";
            this.faculty_title.Size = new System.Drawing.Size(52, 16);
            this.faculty_title.TabIndex = 0;
            this.faculty_title.Text = "label2";
            // 
            // tab_minor_adv
            // 
            this.tab_minor_adv.Controls.Add(this.panel6);
            this.tab_minor_adv.Controls.Add(this.minor_title);
            this.tab_minor_adv.Location = new System.Drawing.Point(4, 22);
            this.tab_minor_adv.Name = "tab_minor_adv";
            this.tab_minor_adv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_minor_adv.Size = new System.Drawing.Size(143, 114);
            this.tab_minor_adv.TabIndex = 3;
            this.tab_minor_adv.Text = "Minor Advisor";
            this.tab_minor_adv.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.minor_stu_services);
            this.panel6.Location = new System.Drawing.Point(21, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 13);
            this.panel6.TabIndex = 2;
            // 
            // minor_stu_services
            // 
            this.minor_stu_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minor_stu_services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minor,
            this.advisor,
            this.adv_email});
            this.minor_stu_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minor_stu_services.Location = new System.Drawing.Point(0, 0);
            this.minor_stu_services.Name = "minor_stu_services";
            this.minor_stu_services.Size = new System.Drawing.Size(240, 13);
            this.minor_stu_services.TabIndex = 0;
            // 
            // minor
            // 
            this.minor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.minor.HeaderText = "Minor Specialization";
            this.minor.Name = "minor";
            // 
            // advisor
            // 
            this.advisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.advisor.HeaderText = "Advisor";
            this.advisor.Name = "advisor";
            // 
            // adv_email
            // 
            this.adv_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adv_email.HeaderText = "Email";
            this.adv_email.Name = "adv_email";
            // 
            // minor_title
            // 
            this.minor_title.AutoSize = true;
            this.minor_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_title.Location = new System.Drawing.Point(9, 25);
            this.minor_title.Name = "minor_title";
            this.minor_title.Size = new System.Drawing.Size(65, 20);
            this.minor_title.TabIndex = 1;
            this.minor_title.Text = "label2";
            // 
            // tutor_panel
            // 
            this.tutor_panel.Controls.Add(this.tutor_link);
            this.tutor_panel.Controls.Add(this.panel7);
            this.tutor_panel.Controls.Add(this.tutor_title);
            this.tutor_panel.Location = new System.Drawing.Point(27, 207);
            this.tutor_panel.Name = "tutor_panel";
            this.tutor_panel.Size = new System.Drawing.Size(107, 104);
            this.tutor_panel.TabIndex = 2;
            // 
            // tutor_link
            // 
            this.tutor_link.AutoSize = true;
            this.tutor_link.Location = new System.Drawing.Point(20, 141);
            this.tutor_link.Name = "tutor_link";
            this.tutor_link.Size = new System.Drawing.Size(55, 13);
            this.tutor_link.TabIndex = 4;
            this.tutor_link.TabStop = true;
            this.tutor_link.Text = "linkLabel1";
            this.tutor_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tutor_link_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.tutor_des);
            this.panel7.Location = new System.Drawing.Point(20, 48);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(67, 15);
            this.panel7.TabIndex = 3;
            // 
            // tutor_des
            // 
            this.tutor_des.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tutor_des.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutor_des.Location = new System.Drawing.Point(0, 0);
            this.tutor_des.Name = "tutor_des";
            this.tutor_des.Size = new System.Drawing.Size(67, 15);
            this.tutor_des.TabIndex = 0;
            this.tutor_des.Text = "label3";
            // 
            // tutor_title
            // 
            this.tutor_title.AutoSize = true;
            this.tutor_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutor_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.tutor_title.Location = new System.Drawing.Point(16, 8);
            this.tutor_title.Name = "tutor_title";
            this.tutor_title.Size = new System.Drawing.Size(74, 24);
            this.tutor_title.TabIndex = 2;
            this.tutor_title.Text = "label1";
            // 
            // resourcesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 330);
            this.Controls.Add(this.tutor_panel);
            this.Controls.Add(this.stu_service_panel);
            this.Controls.Add(this.study_panel);
            this.Name = "resourcesWindow";
            this.Text = "resourcesWindow";
            this.Load += new System.EventHandler(this.resourcesWindow_Load);
            this.study_panel.ResumeLayout(false);
            this.study_panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_description.ResumeLayout(false);
            this.stu_service_panel.ResumeLayout(false);
            this.stu_service_panel.PerformLayout();
            this.stu_services_tab.ResumeLayout(false);
            this.tab_acad_adv.ResumeLayout(false);
            this.tab_acad_adv.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tab_prof_advisor.ResumeLayout(false);
            this.tab_prof_advisor.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prof_advisor_data)).EndInit();
            this.tab_faculty.ResumeLayout(false);
            this.tab_faculty.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tab_minor_adv.ResumeLayout(false);
            this.tab_minor_adv.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minor_stu_services)).EndInit();
            this.tutor_panel.ResumeLayout(false);
            this.tutor_panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel study_panel;
        private System.Windows.Forms.Label abroad_title;
        private System.Windows.Forms.Panel panel_description;
        private System.Windows.Forms.Label abroad_description;
        private System.Windows.Forms.ListBox list_places;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label abroad_pTitle;
        private System.Windows.Forms.Label abroad_pDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel stu_service_panel;
        private System.Windows.Forms.TabControl stu_services_tab;
        private System.Windows.Forms.TabPage tab_acad_adv;
        private System.Windows.Forms.TabPage tab_prof_advisor;
        private System.Windows.Forms.TabPage tab_faculty;
        private System.Windows.Forms.TabPage tab_minor_adv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label acad_title;
        private System.Windows.Forms.LinkLabel acad_link;
        private System.Windows.Forms.Label acad_des;
        private System.Windows.Forms.Label prof_adv_title;
        private System.Windows.Forms.DataGridView prof_advisor_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label faculty_title;
        private System.Windows.Forms.Label faculty_des;
        private System.Windows.Forms.DataGridView minor_stu_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn minor;
        private System.Windows.Forms.DataGridViewTextBoxColumn advisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn adv_email;
        private System.Windows.Forms.Label minor_title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn adv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label advising_title;
        private System.Windows.Forms.Panel tutor_panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label tutor_title;
        private System.Windows.Forms.Label tutor_des;
        private System.Windows.Forms.LinkLabel tutor_link;
    }
}