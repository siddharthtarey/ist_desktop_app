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
    public partial class ucPeople : UserControl
    {
        REST rj = new REST("http://www.ist.rit.edu/api/");
        // will contain the faculty and staff data
        People  people;
        private static ucPeople _people;
        // a singleton design pattern to create 
        // only one instance of this user control
        public static ucPeople Instance
        {
            get {

                if(_people == null)
                {

                    _people = new ucPeople();
                }
                return _people;
            }
        }


        public ucPeople()
        {
            InitializeComponent();
        }

        private void ucPeople_Load(object sender, EventArgs e)
        {
            // get data for faculty and staff
            string jsonstring = rj.getJSON("/people/");
            people = JToken.Parse(jsonstring).ToObject<People>();

            people_title.Text = people.title;
            // load the faculty data in faculty user control
            loadFaculty();
        }

        private void loadFaculty()
        {
            fac_email.Text = "";
            fac_name.Text = "";
            fac_phone.Text = "";
            fac_website.Text = "";
            fac_position.Text = "";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
           
           // populate the faculty data 
            foreach(Faculty f in people.faculty)
            {
                faculty_list.Items.Add(f.name);
            }
            
            // populate the staff data in the combobox
            foreach(Staff s in people.staff)
            {
                staff_data.Items.Add(s.name);
            }

            
            
        }

        private void faculty_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // extract the name from the selected option
            string selected = faculty_list.SelectedItem.ToString();
            
            // browse through every name 
            foreach(Faculty fac in people.faculty)
            {
                // choose the faculty member that has been selected
                if (fac.name.Equals(selected))
                {
                    // load the faculty data
                    fac_email.Text = fac.email;
                    fac_name.Text = fac.name;
                    fac_phone.Text = fac.phone;
                    fac_position.Text = "("+fac.title+")";
                    fac_website.Text = fac.website;
                    fac_image.ImageLocation = fac.imagePath;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
            }
        }

        

        private void staff_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            // extract the name from the selected option
            string selected = staff_data.SelectedItem.ToString();
            // browse through every name 
            foreach (Staff staff in people.staff)
            {

                // choose the staff member that has been selected
                if (staff.name.Equals(selected))
                {
                    // load the staff data
                    fac_email.Text = staff.email;
                    fac_name.Text = staff.name;
                    fac_phone.Text = staff.phone;
                    fac_position.Text = "(" + staff.title + ")";
                    fac_website.Text = staff.website;
                    fac_image.ImageLocation = staff.imagePath;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
            }
        }

        
    }
}
