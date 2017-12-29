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
    public partial class resourcesWindow : Form
    {
        StudyAbroad abroadData;
        StudentServices studentData;
        TutorsAndLabInformation tutorData;
        public resourcesWindow()
        {
            InitializeComponent();
        }

        /*
         * this method is triggered everytime a selection is made in the study abroad 
         * list view
         */
        private void list_places_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected item from the student abroad list
            string place = list_places.SelectedItem.ToString();
            // search which location the selection is refering to
            foreach(Place pl in abroadData.places)
            {
                if (pl.nameOfPlace.Equals(place))
                {
                    // populate the labels according to the location
                    abroad_pTitle.Text = pl.nameOfPlace;
                    abroad_pDes.Text = pl.description;
                    break;
                }
            }
        }

        // this function loads the content of study abroad
        public void studyLoad(StudyAbroad sa)
        {
            // intialize the label to blank
            abroadData = sa;
            abroad_pTitle.Text = "";
            abroad_pDes.Text = "";
            // populate the list view in study abroad
            foreach (Place place in abroadData.places)
            {
                list_places.Items.Add(place.nameOfPlace);
            }
            // populate the title and description.
            abroad_title.Text = abroadData.title;
            abroad_description.Text = abroadData.description;
           
            study_panel.Dock = DockStyle.Fill;
            study_panel.BringToFront();
        }
        // the link label in advising redirects to a browser
        // this is an event
        private void acad_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            acad_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(studentData.academicAdvisors.faq.contentHref);
        }

        // this function populates data for advising
        public void studentService(StudentServices ss)
        {
            studentData = ss;
            // dock the panel to the form
            stu_service_panel.Dock = DockStyle.Fill;
            stu_service_panel.BringToFront();
            advising_title.Text = studentData.title;
            /*
             * load the academic advising tab 
             */
            acad_title.Text = studentData.academicAdvisors.title;
            acad_des.Text = studentData.academicAdvisors.description;
            acad_link.Text = studentData.academicAdvisors.faq.title;

            /*
             * load the professional advisors data
             */
            prof_adv_title.Text = studentData.professonalAdvisors.title;

            foreach(AdvisorInformation ai in studentData.professonalAdvisors.advisorInformation)
            {
                int n =prof_advisor_data.Rows.Add();

                prof_advisor_data.Rows[n].Cells[0].Value = ai.name;
                prof_advisor_data.Rows[n].Cells[1].Value = ai.department;
                prof_advisor_data.Rows[n].Cells[2].Value = ai.email;

            }

            /*
             * load the faculty advisors data
             */

            faculty_title.Text = studentData.facultyAdvisors.title;
            faculty_des.Text = studentData.facultyAdvisors.description;

            /*
             * load the minor advising data
             */
            minor_title.Text = studentData.istMinorAdvising.title;

            foreach(MinorAdvisorInformation mai in studentData.istMinorAdvising.minorAdvisorInformation)
            {
                int n = minor_stu_services.Rows.Add();
                minor_stu_services.Rows[n].Cells[0].Value = mai.title;
                minor_stu_services.Rows[n].Cells[1].Value = mai.advisor;
                minor_stu_services.Rows[n].Cells[2].Value = mai.email;
            }


        }

        // this function loads the data for tutoring 
        public void tutorService(TutorsAndLabInformation tal) {

            tutorData = tal;
            tutor_panel.Dock = DockStyle.Fill;
            tutor_panel.BringToFront();
            tutor_title.Text = tutorData.title;
            tutor_des.Text = tutorData.description;
            tutor_link.Text = "Tutoring and Lab hours";



        }

        // the link label in advising redirects to a browser
        // this is an event
        private void tutor_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            acad_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(tutorData.tutoringLabHoursLink);
        }

        private void resourcesWindow_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
