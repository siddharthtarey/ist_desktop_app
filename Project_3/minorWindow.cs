using Newtonsoft.Json.Linq;
using RestUtil;
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
    public partial class minorWindow : Form
    {
        UgMinor minor_data;
        string option;
        public minorWindow()
        {
            InitializeComponent();
        }

        public minorWindow(UgMinor data):this()
        {
            minor_data = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minorWindow_Load(object sender, EventArgs e)
        {
            // extract minor title and attach it to the label
            minor_title.Text = minor_data.title;
            // extract minor descrioption and attach it to the label
            minor_description.Text = minor_data.description;

            

            addCourseButtons();
        }

        private void addCourseButtons()
        {
            TableLayoutPanel table = new TableLayoutPanel();
            // set table parameters
            table.ColumnCount = 0;
            table.RowCount = 0;

            minor_courses.Controls.Add(table);
            // apply padding and anchor to table for better looks and responsiveness
            table.Padding = new Padding(20, 20, 20, 20);
            table.Dock = DockStyle.Fill;
            //table.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            Font f1 = new Font("Palatino Linotype", 13, FontStyle.Bold);
            // rowcount and count variables here, so that there are only three buttons in a row
            int rowCount = 0;
            int count = 0;
            foreach (string c in minor_data.courses)
            {
                // we want to add the buttons to the columns 
                table.ColumnCount = table.ColumnCount + 1;
                count++;
                // create the button
                Button b = new Button();
                b.Text = c;
                b.Width = 100;
                b.Height = 30;
                b.Click += new EventHandler(button_click);
                b.BackColor = Color.DarkOrange;
                b.Font = f1;
                b.FlatStyle = FlatStyle.Flat;
                b.Cursor = Cursors.Hand;
                // add the button to the table
                table.Controls.Add(b,table.ColumnCount-1,rowCount);
                // initializes the count to 0 again, so that buttons
                // will be added to the next row.
                if (count % 3 == 0)
                {
                    rowCount++;
                    table.ColumnCount = 0;
                }
            }
        }

        // this method triggers when the button
        // displaying minor courses is clicked
        private void button_click(object sender, EventArgs e)
        {
            REST rj = new REST("http://ist.rit.edu/api/");
            // get the text on the button
            string course = ((Button)sender).Text;

            // get the minor course related json
            string jsonString = rj.getJSON("course/courseID="+course);

            // convert the jsson string to object
            minorCourse mCourse = JToken.Parse(jsonString).ToObject<minorCourse>();

            // display the minor course related information
            minorCourseInfo mci = new minorCourseInfo(mCourse);
            mci.Show();

        }
    }
}
