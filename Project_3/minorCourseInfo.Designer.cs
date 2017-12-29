namespace Project_3
{
    partial class minorCourseInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.course_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.course_des = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.course_title);
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 58);
            this.panel1.TabIndex = 0;
            // 
            // course_title
            // 
            this.course_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.course_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_title.Location = new System.Drawing.Point(0, 0);
            this.course_title.Name = "course_title";
            this.course_title.Size = new System.Drawing.Size(579, 58);
            this.course_title.TabIndex = 0;
            this.course_title.Text = "label1";
            this.course_title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.course_title.Click += new System.EventHandler(this.course_title_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.course_des);
            this.panel2.Location = new System.Drawing.Point(34, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 202);
            this.panel2.TabIndex = 1;
            // 
            // course_des
            // 
            this.course_des.Dock = System.Windows.Forms.DockStyle.Fill;
            this.course_des.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_des.Location = new System.Drawing.Point(0, 0);
            this.course_des.Name = "course_des";
            this.course_des.Size = new System.Drawing.Size(608, 202);
            this.course_des.TabIndex = 0;
            this.course_des.Text = "label1";
            // 
            // minorCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(654, 317);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "minorCourseInfo";
            this.Text = "minorCourseInfo";
            this.Load += new System.EventHandler(this.minorCourseInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label course_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label course_des;
    }
}