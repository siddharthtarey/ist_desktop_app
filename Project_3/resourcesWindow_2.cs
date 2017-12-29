using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class resourcesWindow_2 : Form
    {
        StudentAmbassadors ambData;
        Forms formData;
        CoopEnrollment coopData;
        public resourcesWindow_2()
        {
            InitializeComponent();
        }

        // this function dynamically adds table to the ambassador panel
        // the data for student ambassador is added to this table
        public void ambassador(StudentAmbassadors sa)
        {
            ambData = sa;
            // create a table
            TableLayoutPanel table = new TableLayoutPanel();
            // set table parameters
            table.ColumnCount = 1;
            table.RowCount = 0;
            table.MinimumSize = new Size(500, 1300);
            // dock the table to the parameter
            amb_data_panel.Controls.Add(table);
            // make the panel scrollable
            amb_data_panel.AutoScroll = true;
            // dock the main panel to display on the pop-up form
            ambassador_panel.Dock = DockStyle.Fill;
            ambassador_panel.BringToFront();
            // apply padding and anchor to table for better looks and responsiveness
            table.Padding = new Padding(20, 20, 20, 20);
            table.Anchor = ( AnchorStyles.Left | AnchorStyles.Right  | AnchorStyles.Top);

            // define fonts for the table data
            Font f1 = new Font("Palatino Linotype",13,FontStyle.Bold);
            Font f2 = new Font("Palatino Linotype",10, FontStyle.Italic);
            // iterate through all the student ambassador subsections
            foreach (SubSectionContent ssc in ambData.subSectionContent)
            {
                table.RowCount = table.RowCount + 1;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                // add title to the table
                table.Controls.Add(new Label() {Text = ssc.title,Font=f1, Dock=DockStyle.Bottom,AutoSize=false }, 1, table.RowCount - 1);
                table.RowCount = table.RowCount + 1;
                // add the description for the title
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
                table.Controls.Add(new Label() { Text = ssc.description, Font = f2, Dock = DockStyle.Fill, AutoSize = false }, 1, table.RowCount - 1);

            }
            // main title and application link
            amb_title.Text = ambData.title;
            amb_link.Text = "Apply";

        }

        private void resourcesWindow_2_Load(object sender, EventArgs e)
        {
            

        }

        // this method opens the link in a browser
        // this is the ambassador application link
        // this is the event triggered when the link is clicked

        private void amb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            amb_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(ambData.applicationFormLink);
        }

        // this method loads the form data for resources
        public void forms(Forms f)
        {
            formData = f;

            /*
             * gererate table and populate data for graduate forms
             */

            TableLayoutPanel table = new TableLayoutPanel();
            // set table parameters
            table.ColumnCount = 2;
            table.RowCount = 0;
            table.MinimumSize = new Size(500, 400);

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            graduate_form.Controls.Add(table);
            graduate_form.AutoScroll = true;
            form_panel.Dock = DockStyle.Fill;
            form_panel.BringToFront();
            table.Padding = new Padding(20, 20, 20, 20);
            table.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            // define fonts for the table data
            Font f1 = new Font("Palatino Linotype", 9, FontStyle.Bold);
            Font f2 = new Font("Palatino Linotype", 9, FontStyle.Italic);
            foreach (GraduateForm gf in formData.graduateForms)
            {
                table.RowCount = table.RowCount + 1;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                // add formname to the table
                table.Controls.Add(new Label() { Text = "http://ist.rit.edu/"+gf.href, Font = f2, Dock = DockStyle.Fill, AutoSize = false }, 1, table.RowCount - 1);

                // add the href for the form
                table.Controls.Add(new Label() { Text = gf.formName+":", Font = f1, Dock = DockStyle.Fill, AutoSize = false }, 2, table.RowCount -2);
            }

            /*
             * populate data for undergraduate fomrs
             */

            TableLayoutPanel table_2 = new TableLayoutPanel();
            // set table parameters
            table_2.ColumnCount = 2;
            table_2.RowCount = 0;
            table_2.MinimumSize = new Size(500, 400);

            table_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            table_2.Padding = new Padding(20, 20, 20, 20);
            table_2.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            undergrad_forms.Controls.Add(table_2);
            undergrad_forms.AutoScroll = true;

            foreach (UndergraduateForm uf in formData.undergraduateForms)
            {
                table_2.RowCount = table_2.RowCount + 1;
                table_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                // add formname to the table
                table_2.Controls.Add(new Label() { Text = "http://ist.rit.edu/" + uf.href, Font = f2, Dock = DockStyle.Fill, AutoSize = false }, 1, table_2.RowCount - 1);

                // add the href for the form
                table_2.Controls.Add(new Label() { Text = uf.formName + ":", Font = f1, Dock = DockStyle.Fill, AutoSize = false }, 2, table_2.RowCount - 2);
            }

        }

        // this method loads the coop data for resources
        public void coop(CoopEnrollment coop)
        {
            coopData = coop;

            TableLayoutPanel table = new TableLayoutPanel();
            // set table parameters
            table.ColumnCount = 1;
            table.RowCount = 0;
            table.MinimumSize = new Size(500, 1300);
            // dock the table to the parameter
            coop_info.Controls.Add(table);
            // make the panel scrollable
            coop_info.AutoScroll = true;
            // dock the main panel to display on the pop-up form
            coop_enroll.Dock = DockStyle.Fill;
            coop_enroll.BringToFront();
            // apply padding and anchor to table for better looks and responsiveness
            table.Padding = new Padding(20, 20, 20, 20);
            table.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            // define fonts for the table data
            Font f1 = new Font("Palatino Linotype", 13, FontStyle.Bold);
            Font f2 = new Font("Palatino Linotype", 10, FontStyle.Italic);
            // iterate through all the student coop subsections
            foreach (EnrollmentInformationContent info in coopData.enrollmentInformationContent)
            {
                table.RowCount = table.RowCount + 1;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                // add title to the table
                table.Controls.Add(new Label() { Text = info.title, Font = f1, Dock = DockStyle.Bottom, AutoSize = false }, 1, table.RowCount - 1);
                table.RowCount = table.RowCount + 1;
                // add the description for the title
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
                table.Controls.Add(new Label() { Text = info.description, Font = f2, Dock = DockStyle.Fill, AutoSize = false }, 1, table.RowCount - 1);

            }
            coop_title.Text = coopData.title;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            amb_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(coopData.RITJobZoneGuidelink);
        }

        private void ambassador_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
