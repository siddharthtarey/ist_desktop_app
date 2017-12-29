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
    public partial class ucMinor : UserControl
    {
        REST rj = new REST("http://ist.rit.edu/api");
        
        Minor minor_data;

        private static ucMinor _minor;
        // get the singleton class object for the minor panel
        public static ucMinor Instance
        {
            get
            {
                if (_minor == null)
                {
                    _minor = new ucMinor();
                }
                return _minor;

            }

        }
        public ucMinor()
        {
            InitializeComponent();
        }

        private void ucMinor_Load(object sender, EventArgs e)
        {
            // when minor loads fetch the data from the api
            string jsonString = rj.getJSON("/minors/");
            // assign minor data to the object
            minor_data = JToken.Parse(jsonString).ToObject<Minor>();


        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors) {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_data.Text) ) {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_geo_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_geo.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_health_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_health.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_mob_design_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_mob_design.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_mob_dev_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_mob_dev.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_nsa_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_nsa.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_web_dev_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_web_dev.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }

        private void btn_web_dd_Click(object sender, EventArgs e)
        {
            UgMinor data = new UgMinor();
            // get the undergraduate degree on the first button click
            foreach (UgMinor um in minor_data.UgMinors)
            {
                // assign the minor DBDDI-MN to 'data'
                if (um.name.Equals(btn_web_dd.Text))
                {
                    data = um;
                    break;
                }
            }
            // open new window and append the data
            minorWindow mw = new minorWindow(data);
            mw.Show();
        }
    }
}
