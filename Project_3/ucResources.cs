using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestUtil;
using Newtonsoft.Json.Linq;

namespace Project_3
{
    public partial class ucResources : UserControl
    {

        Resources resource;
        REST rj = new REST("http://www.ist.rit.edu/api");
        private static ucResources _resources;
        // initialize the singleton pattern to load resources
        public static ucResources Instance
        {
            get
            {
                if(_resources == null)
                {
                    _resources = new ucResources();
                }
                return _resources;
            }

        }

        public ucResources()
        {
            InitializeComponent();
        }

        private void ucResources_Load(object sender, EventArgs e)
        {
            // get the json data as a string from the api
            string jsonstring = rj.getJSON("/resources/");
            resource = JToken.Parse(jsonstring).ToObject<Resources>();

            // assign text to the buttons of resources
            btn_coop.Text = resource.coopEnrollment.title;
            btn_forms.Text = "Forms";
            btn_studentService.Text = resource.studentServices.title;
            btn_study.Text = resource.studyAbroad.title;
            btn_tutor.Text = resource.tutorsAndLabInformation.title;
            btn_ambassador.Text = resource.studentAmbassadors.title;

        }

        private void btn_study_Click(object sender, EventArgs e)
        {
            // load a new form
            resourcesWindow rw = new resourcesWindow();
            // call this method to fill in all the study abroad data in the new form
            rw.studyLoad(resource.studyAbroad);
            // the new form pops up on the button click
            rw.Show();

        }

        private void btn_studentService_Click(object sender, EventArgs e)
        {
            // load the new form
            resourcesWindow rw = new resourcesWindow();
            // load the student services data
            rw.studentService(resource.studentServices);
            // show the new form
            rw.Show();
        }

        private void btn_tutor_Click(object sender, EventArgs e)
        {
            // load the new form
            resourcesWindow rw = new resourcesWindow();
            // load the student services data
            rw.tutorService(resource.tutorsAndLabInformation);
            // show the new form
            rw.Show();
        }

        private void btn_ambassador_Click(object sender, EventArgs e)
        {
            // load the new form
            resourcesWindow_2 rw = new resourcesWindow_2();
            // load the student services data
            rw.ambassador(resource.studentAmbassadors);
            // show the new form
            rw.Show();
        }

        private void btn_forms_Click(object sender, EventArgs e)
        {
            // load the new form
            resourcesWindow_2 rw = new resourcesWindow_2();
            // load the student services data
            rw.forms(resource.forms);
            // show the new form
            rw.Show();
        }

        private void btn_coop_Click(object sender, EventArgs e)
        {
            resourcesWindow_2 rw = new resourcesWindow_2();
            // load the student services data
            rw.coop(resource.coopEnrollment);
            // show the new form
            rw.Show();
        }
    }
}
