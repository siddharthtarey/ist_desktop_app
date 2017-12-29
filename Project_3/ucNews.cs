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
    public partial class ucNews : UserControl
    {
        REST rj = new REST("http://www.ist.rit.edu/api/");
        News newsData;
        private static ucNews _news;
        // singleton pattern to load the usercontrol on the main window
        public static ucNews Instance
        {
            get
            {
                if(_news == null)
                {
                    _news = new ucNews();
                }
                return _news;
            }
        }

        public ucNews()
        {
            InitializeComponent();
        }

        // this method is triggered when the news button is clicked 
        private void ucNews_Load(object sender, EventArgs e)
        {
            
            string jsonstring = rj.getJSON("/news/");
            // convert the json string to the news object
            newsData = JToken.Parse(jsonstring).ToObject<News>();
            news_date.Text = "";
            news_des.Text = "";
            news_title.Text = "";
         
            // load the list box with news title
            foreach (Older o in newsData.older)
            {
                list_data.Items.Add(o.title);
                
            }
        }

        // this method is triggered when an option from
        // the listbox is selected
        private void list_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = list_data.SelectedItem.ToString();
            // search the news article
            foreach (Older o  in newsData.older)
            {
                // when the news article is found, display it
                if (selected.Equals(o.title))
                {
                    news_date.Text = o.date;
                    news_title.Text = o.title;
                    news_des.Text = o.description;
                    

                    break;
                }
            }
        }
    }
}
