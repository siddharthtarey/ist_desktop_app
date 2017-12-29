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
    public partial class ucEmployment : UserControl
    {
        Employment employment;
        REST rj = new REST("http://ist.rit.edu/api");
        private static ucEmployment  _employment;
        // singleton pattern to load the usercontrol to the main window
        public static ucEmployment Instance
        {

            get
            {
                if(_employment == null)
                {
                    _employment = new ucEmployment();
                }

                return _employment;

            }
        }

        public ucEmployment()
        {
            InitializeComponent();
        }

        private void stat_des_4_Click(object sender, EventArgs e)
        {

        }

        private void tb_employment_1_Click(object sender, EventArgs e)
        {
            
        }
        // executes when the employment is clicked on the main window
        private void ucEmployment_Load(object sender, EventArgs e)
        {
            string jsonstring = rj.getJSON("/employment/");
            // convert the json string to employment objects
            employment = JToken.Parse(jsonstring).ToObject<Employment>();
            
            // load the content on the labels
            title.Text = employment.introduction.title;
            stat_title_1.Text = employment.degreeStatistics.statistics[0].value;
            stat_des_1.Text = employment.degreeStatistics.statistics[0].description;

            stat_title_2.Text = employment.degreeStatistics.statistics[1].value;
            stat_title_2.BringToFront();

            stat_des_2.Text = employment.degreeStatistics.statistics[1].description;

            stat_title_3.Text = employment.degreeStatistics.statistics[2].value;
            stat_title_3.BringToFront();
            stat_des_3.Text = employment.degreeStatistics.statistics[2].description;

            stat_title_4.Text = employment.degreeStatistics.statistics[3].value;
            stat_title_4.BringToFront();
            stat_des_4.Text = employment.degreeStatistics.statistics[3].description;

            // load the data on the second tab
            tab2DataLoad();
            // load the data on the third tab
            tab3DataLoad();
            
            
        }

        private void tab3DataLoad()
        {
            // load the initail labels
            emp_title.Text = employment.introduction.content[0].title;
            emp_des.Text = employment.introduction.content[0].description;
            emp_table.Text = "Employment history of our students:";
            // load the professional employment information
            foreach (ProfessionalEmploymentInformation em in employment.employmentTable.professionalEmploymentInformation)
            {

                int n = emp_data.Rows.Add();
               
                emp_data.Rows[n].Cells[0].Value = em.employer;
                emp_data.Rows[n].Cells[1].Value = em.degree;
                emp_data.Rows[n].Cells[2].Value = em.city;
                emp_data.Rows[n].Cells[3].Value = em.title;
                emp_data.Rows[n].Cells[4].Value = em.startDate;

            }
        }

        private void tab2DataLoad()
        {
            coop_title.Text = employment.introduction.content[1].title;
            coop_description.Text = employment.introduction.content[1].description;
            coop_t.Text = "Co-op history of our students:";

            // load the coop information in the second tab
            foreach (CoopInformation ci in employment.coopTable.coopInformation) {

                int n = coop.Rows.Add();

                coop.Rows[n].Cells[0].Value = ci.employer;
                coop.Rows[n].Cells[1].Value = ci.degree;
                coop.Rows[n].Cells[2].Value = ci.city;
                coop.Rows[n].Cells[3].Value = ci.term;

            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
