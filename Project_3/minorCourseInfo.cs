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
    public partial class minorCourseInfo : Form
    {
        minorCourse minor;
        public minorCourseInfo()
        {
            InitializeComponent();
        }

        public minorCourseInfo(minorCourse mc) : this()
        {
            minor = mc;
        }

        private void course_title_Click(object sender, EventArgs e)
        {

        }

        // this method initiates when the window loads
        private void minorCourseInfo_Load(object sender, EventArgs e)
        {
            // assign the title and description of the course
            course_title.Text = minor.title;
            course_des.Text = minor.description;
        }
    }
}
