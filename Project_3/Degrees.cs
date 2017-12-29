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
    public partial class Degrees : UserControl
    {
        REST rj = new REST("http://ist.rit.edu/api"); 
        Degree_Data  data_degree;

        private static Degrees _degree;
        public static Degrees Instance
        {
            get
            {
                if (_degree == null)
                {
                    _degree = new Degrees();
                }
                return _degree;

            }

        }
        public Degrees()
        {
            InitializeComponent();
        }

        
        // executes when the degree buton on the main window is clicked
        private void Degrees_Load(object sender, EventArgs e)
        {
            // get the json data
            string jsonDegree = rj.getJSON("/degrees/");
            data_degree = JToken.Parse(jsonDegree).ToObject<Degree_Data>();
            Description.Visible = false;
            // populate the combobox
            foreach (Graduate g in data_degree.graduate) {
                
                    dd_graduate.Items.Add(g.degreeName);
                
            }
            // populate the under grad combobox
            foreach (Undergraduate ug in data_degree.undergraduate)
            {

                dd_undergraduate.Items.Add(ug.degreeName);
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            

        }

        // this function is triggered when an option from the graduate
        // drop down is selected
        private void dd_graduate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // get the selected item
            string selectedDegree = (string)dd_graduate.SelectedItem;
            
            foreach(Graduate g in data_degree.graduate)
            {
                // find the selected item in the list
                if (g.degreeName.Equals(selectedDegree)) {

                    // this is necessary sing the "certificate"
                    // does not have a title
                    if (g.title != null)
                    {
                        Description.Visible = true;
                        label2.Text = g.title;
                        label4.Text = g.description;
                    }
                    else {

                        label2.Text = g.degreeName;
                        
                    }
                    
                    break;
                }

            }

        }
        // this event is triggered when undergrad option is selected
        // from the drop down
        private void dd_undergraduate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDegree = (string)dd_undergraduate.SelectedItem;
            Description.Visible = true;
            foreach (Undergraduate ug in data_degree.undergraduate) {

                if (ug.degreeName.Equals(selectedDegree)) {

                    label2.Text = ug.title;
                    label4.Text = ug.description;
                }
                
            }

        }
    }
}
