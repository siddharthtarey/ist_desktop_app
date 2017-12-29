using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;
using RestUtil;

namespace Project_3
{
    public partial class Form1 : Form
    {
        
        about_panel abt_panel;
        Degrees degree;
        ucMinor minor;
        ucEmployment employment;
        ucPeople people;
        ucResearch research;
        ucResources resources;
        ucNews news;
        Footer foot;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disable the maximize button
            this.MaximizeBox = false;
            // bring about panel to frront if not on front
            if (!panelFill.Controls.Contains(about_panel.Instance))
            {
                // if about data is not poulated, then populate it
                if(abt_panel == null)
                {
                    // call the load of about user control
                    abt_panel = new about_panel();
                }
           
                // bring the about data to the front
                panelFill.Controls.Add(about_panel.Instance);
                about_panel.Instance.Dock = DockStyle.Fill;
                about_panel.Instance.BringToFront();
            }
            else
            {
                about_panel.Instance.BringToFront();
            }

            REST rj = new REST("http://www.ist.rit.edu/api/");
            string copyright = rj.getJSON("/footer/");
            foot = JToken.Parse(copyright).ToObject<Footer>();
            Console.WriteLine(foot.copyright.html);
            webBrowser1.DocumentText = foot.copyright.html;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!panelFill.Controls.Contains(about_panel.Instance))
            {
                panelFill.Controls.Add(about_panel.Instance);
                about_panel.Instance.Dock = DockStyle.Fill;
                about_panel.Instance.BringToFront();
            }
            else
            {
                about_panel.Instance.BringToFront();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(Degrees.Instance))
            {
                if (degree == null)
                {
                    // call the load of about user control
                    degree = new Degrees();
                }
                panelFill.Controls.Add(Degrees.Instance);
                Degrees.Instance.Dock = DockStyle.Fill;
                Degrees.Instance.BringToFront();
            }
            else {
                Degrees.Instance.BringToFront();
            }
            
        }

        private void btn_minors_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucMinor.Instance))
            {
                if (minor == null)
                {
                    // call the load of about user control
                    minor = new ucMinor();
                }
                panelFill.Controls.Add(ucMinor.Instance);
                ucMinor.Instance.Dock = DockStyle.Fill;
                ucMinor.Instance.BringToFront();
            }
            else
            {
                ucMinor.Instance.BringToFront();
            }
        }

        private void employment_btn_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucEmployment.Instance))
            {
                if (employment == null)
                {
                    // call the load of about user control
                    employment = new ucEmployment();
                }
                panelFill.Controls.Add(ucEmployment.Instance);
                ucEmployment.Instance.Dock = DockStyle.Fill;
                ucEmployment.Instance.BringToFront();
            }
            else
            {
                ucEmployment.Instance.BringToFront();
            }
        }

        private void people_btn_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucPeople.Instance)) {

                if(people == null)
                {
                    people = new ucPeople();
                }

                panelFill.Controls.Add(ucPeople.Instance);
                ucPeople.Instance.Dock = DockStyle.Fill;
                ucPeople.Instance.BringToFront();

            }
            else
            {

                ucPeople.Instance.BringToFront();   
            }
        }

        private void btn_research_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucResearch.Instance))
            {
                if (research == null) {

                    research = new ucResearch();
                    panelFill.Controls.Add(ucResearch.Instance);
                    ucResearch.Instance.Dock = DockStyle.Fill;
                    ucResearch.Instance.BringToFront();
                }
                

            }
            else
            {
                ucResearch.Instance.BringToFront();
            }
        }

        private void btn_resources_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucResources.Instance))
            {
                if(resources == null)
                {
                    resources = new ucResources();
                    panelFill.Controls.Add(ucResources.Instance);
                    ucResources.Instance.Dock = DockStyle.Fill;
                    ucResources.Instance.BringToFront();

                }
            }
            else
            {
                ucResources.Instance.BringToFront();
            }
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            if (!panelFill.Controls.Contains(ucNews.Instance))
            {
                if(news == null)
                {
                    news = new ucNews();
                    panelFill.Controls.Add(ucNews.Instance);
                    ucNews.Instance.Dock = DockStyle.Fill;
                    ucNews.Instance.BringToFront();
                }
            }
            else
            {
                ucNews.Instance.BringToFront();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = foot.social.title;
            // add twitter label and link
            twitter_label.Text = "Twitter";
            twitter_link.Text = foot.social.twitter;

            // add fb link and label
            fb_label.Text = "Facebook";
            fb_link.Text = foot.social.facebook;

            // add application link and label
            apply_label.Text = foot.quickLinks[0].title;
            apply_link.Text = foot.quickLinks[0].href;

            // add about label and link
            about_label.Text = foot.quickLinks[1].title;
            abouut_link.Text = foot.quickLinks[1].href;

            // add support link and label
            support_label.Text = foot.quickLinks[2].title;
            support_link.Text = foot.quickLinks[2].href;

            //add lab hours link and label
            lab_label.Text = foot.quickLinks[3].title;
            lab_link.Text = foot.quickLinks[3].href;

            social_panel.Dock = DockStyle.Fill;
            social_panel.BringToFront();
        }

        private void twitter_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            twitter_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.social.twitter);
        }

        private void fb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mark the linked as visited, the color changes to purple
            fb_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.social.facebook);
        }

        private void apply_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            apply_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.quickLinks[0].href);
        }

        private void abouut_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abouut_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.quickLinks[1].href);
        }

        private void support_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            support_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.quickLinks[2].href);
        }

        private void lab_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lab_link.LinkVisited = true;
            //open link in browser
            System.Diagnostics.Process.Start(foot.quickLinks[3].href);
        }
    }
}
