namespace Project_3
{
    partial class resourcesWindow_2
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
            this.ambassador_panel = new System.Windows.Forms.Panel();
            this.amb_link = new System.Windows.Forms.LinkLabel();
            this.amb_title = new System.Windows.Forms.Label();
            this.amb_data_panel = new System.Windows.Forms.Panel();
            this.form_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.graduate_form = new System.Windows.Forms.TabPage();
            this.undergrad_forms = new System.Windows.Forms.TabPage();
            this.coop_enroll = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.coop_title = new System.Windows.Forms.Label();
            this.coop_info = new System.Windows.Forms.Panel();
            this.ambassador_panel.SuspendLayout();
            this.form_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.coop_enroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // ambassador_panel
            // 
            this.ambassador_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambassador_panel.AutoScroll = true;
            this.ambassador_panel.Controls.Add(this.amb_link);
            this.ambassador_panel.Controls.Add(this.amb_title);
            this.ambassador_panel.Controls.Add(this.amb_data_panel);
            this.ambassador_panel.Location = new System.Drawing.Point(0, 27);
            this.ambassador_panel.Name = "ambassador_panel";
            this.ambassador_panel.Size = new System.Drawing.Size(246, 265);
            this.ambassador_panel.TabIndex = 0;
            this.ambassador_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ambassador_panel_Paint);
            // 
            // amb_link
            // 
            this.amb_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amb_link.AutoSize = true;
            this.amb_link.Location = new System.Drawing.Point(510, 34);
            this.amb_link.Name = "amb_link";
            this.amb_link.Size = new System.Drawing.Size(55, 13);
            this.amb_link.TabIndex = 2;
            this.amb_link.TabStop = true;
            this.amb_link.Text = "linkLabel1";
            this.amb_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.amb_link_LinkClicked);
            // 
            // amb_title
            // 
            this.amb_title.AutoSize = true;
            this.amb_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amb_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.amb_title.Location = new System.Drawing.Point(20, 25);
            this.amb_title.Name = "amb_title";
            this.amb_title.Size = new System.Drawing.Size(74, 24);
            this.amb_title.TabIndex = 1;
            this.amb_title.Text = "label1";
            // 
            // amb_data_panel
            // 
            this.amb_data_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amb_data_panel.AutoScroll = true;
            this.amb_data_panel.BackColor = System.Drawing.Color.Bisque;
            this.amb_data_panel.Location = new System.Drawing.Point(23, 58);
            this.amb_data_panel.Name = "amb_data_panel";
            this.amb_data_panel.Padding = new System.Windows.Forms.Padding(50);
            this.amb_data_panel.Size = new System.Drawing.Size(187, 204);
            this.amb_data_panel.TabIndex = 0;
            // 
            // form_panel
            // 
            this.form_panel.Controls.Add(this.label1);
            this.form_panel.Controls.Add(this.tabControl1);
            this.form_panel.Location = new System.Drawing.Point(482, 27);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(156, 112);
            this.form_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forms";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.graduate_form);
            this.tabControl1.Controls.Add(this.undergrad_forms);
            this.tabControl1.Location = new System.Drawing.Point(13, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(125, 42);
            this.tabControl1.TabIndex = 0;
            // 
            // graduate_form
            // 
            this.graduate_form.Location = new System.Drawing.Point(4, 22);
            this.graduate_form.Name = "graduate_form";
            this.graduate_form.Padding = new System.Windows.Forms.Padding(3);
            this.graduate_form.Size = new System.Drawing.Size(117, 16);
            this.graduate_form.TabIndex = 0;
            this.graduate_form.Text = "Graduate Forms";
            this.graduate_form.UseVisualStyleBackColor = true;
            // 
            // undergrad_forms
            // 
            this.undergrad_forms.Location = new System.Drawing.Point(4, 22);
            this.undergrad_forms.Name = "undergrad_forms";
            this.undergrad_forms.Padding = new System.Windows.Forms.Padding(3);
            this.undergrad_forms.Size = new System.Drawing.Size(204, 0);
            this.undergrad_forms.TabIndex = 1;
            this.undergrad_forms.Text = "Undergraduate Forms";
            this.undergrad_forms.UseVisualStyleBackColor = true;
            // 
            // coop_enroll
            // 
            this.coop_enroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coop_enroll.AutoScroll = true;
            this.coop_enroll.Controls.Add(this.linkLabel1);
            this.coop_enroll.Controls.Add(this.coop_title);
            this.coop_enroll.Controls.Add(this.coop_info);
            this.coop_enroll.Location = new System.Drawing.Point(264, 152);
            this.coop_enroll.Name = "coop_enroll";
            this.coop_enroll.Size = new System.Drawing.Size(327, 137);
            this.coop_enroll.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(341, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "JobZoneGuide";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // coop_title
            // 
            this.coop_title.AutoSize = true;
            this.coop_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coop_title.ForeColor = System.Drawing.Color.DarkOrange;
            this.coop_title.Location = new System.Drawing.Point(31, 23);
            this.coop_title.Name = "coop_title";
            this.coop_title.Size = new System.Drawing.Size(74, 24);
            this.coop_title.TabIndex = 1;
            this.coop_title.Text = "label1";
            // 
            // coop_info
            // 
            this.coop_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coop_info.AutoScroll = true;
            this.coop_info.BackColor = System.Drawing.Color.Bisque;
            this.coop_info.Location = new System.Drawing.Point(23, 58);
            this.coop_info.Name = "coop_info";
            this.coop_info.Padding = new System.Windows.Forms.Padding(50);
            this.coop_info.Size = new System.Drawing.Size(367, 59);
            this.coop_info.TabIndex = 0;
            // 
            // resourcesWindow_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 309);
            this.Controls.Add(this.coop_enroll);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.ambassador_panel);
            this.Name = "resourcesWindow_2";
            this.Text = "resourcesWindow_2";
            this.Load += new System.EventHandler(this.resourcesWindow_2_Load);
            this.ambassador_panel.ResumeLayout(false);
            this.ambassador_panel.PerformLayout();
            this.form_panel.ResumeLayout(false);
            this.form_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.coop_enroll.ResumeLayout(false);
            this.coop_enroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ambassador_panel;
        private System.Windows.Forms.Panel amb_data_panel;
        private System.Windows.Forms.Label amb_title;
        private System.Windows.Forms.LinkLabel amb_link;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage graduate_form;
        private System.Windows.Forms.TabPage undergrad_forms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel coop_enroll;
        private System.Windows.Forms.Label coop_title;
        private System.Windows.Forms.Panel coop_info;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}