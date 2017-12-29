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
    public partial class about_panel : UserControl
    {
        About about;
        REST rj = new REST("http://ist.rit.edu/api");
        private static about_panel _about;
        public static about_panel Instance
        {
            get
            {
                if (_about == null)
                {
                    _about = new about_panel();
                }
                return _about;

            }

        }
        
        public about_panel()
        {
            InitializeComponent();
        }

        // loads when the about button is clicked on the main window
        private void about_panel_Load(object sender, EventArgs e)
        {
            // get the about information
            string jsonAbout = rj.getJSON("/about/");
            // convert the json string to the About object
            about = JToken.Parse(jsonAbout).ToObject<About>();
            // populate the labels with the about information
            abt_title.Text = about.title;
            abt_description.Text = about.description;
            abt_quote.Text = about.quote;
            abt_author.Text = about.quoteAuthor;
        }
    }
}
