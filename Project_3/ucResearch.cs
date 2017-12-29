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
    public partial class ucResearch : UserControl
    {

        Research research;
        REST rj = new REST("http://www.ist.rit.edu/api/");
        private static ucResearch _research;
        public static ucResearch Instance
        {
            get
            {
                if(_research == null)
                {
                    _research = new ucResearch();
                }
                return _research;

            }
        }
        public ucResearch()
        {
            InitializeComponent();
        }

        private void ucResearch_Load(object sender, EventArgs e)
        {
            // get data of research
            string jsonString = rj.getJSON("/research/");
            research = JToken.Parse(jsonString).ToObject<Research>();

            // populate research by interest in the first list box
            foreach (ByInterestArea bi in research.byInterestArea)
            {
                research_interest.Items.Add(bi.areaName);
            }

            // populate research by faculty in the second list box
            foreach (ByFaculty bf in research.byFaculty)
            {
                research_faculty.Items.Add(bf.facultyName);
            }

            

        }

        private void research_interest_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enter only if the selection is not null
            // the selection is null when clearSelected() event is triggered
            if (research_interest.SelectedItem != null)
            {
                // clear the datagrid view
                research_list.Rows.Clear();
                research_list.Refresh();
                // fetch the seleted item from the listbox
                string selected = research_interest.SelectedItem.ToString();

                ByInterestArea data = null;

                // search the interest area which has been selected
                foreach (ByInterestArea bi in research.byInterestArea)
                {
                    if (bi.areaName.Equals(selected))
                    {
                        data = bi;
                        break;
                    }
                }

                // populate the datagrid with the research data
                foreach (string cite in data.citations)
                {
                    int n = research_list.Rows.Add(cite);
                    // wrap the research text to avoid a hrorizontal scroll bar
                    research_list.Rows[n].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            

        }

        private void research_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enter only if the selection is not null
            // the selection is null when clearSelected() event is triggered
            if(research_faculty.SelectedItem != null)
            {
                // clear the datagrid view
                research_list.Rows.Clear();
                research_list.Refresh();
                // fetch the seleted faculty from the listbox
                string selected = research_faculty.SelectedItem.ToString();

                ByFaculty data = null;

                // search the faculty which has been selected
                foreach (ByFaculty bf in research.byFaculty)
                {
                    if (bf.facultyName.Equals(selected))
                    {
                        data = bf;
                        break;
                    }
                }

                // populate the datagrid with the research data
                foreach (string cite in data.citations)
                {
                    int n = research_list.Rows.Add(cite);
                    // wrap the research text to avoid a hrorizontal scroll bar
                    research_list.Rows[n].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
            

        }

        private void research_interest_Leave(object sender, EventArgs e)
        {
            // clear the selection when you loose focus on the research by interest box
            
            research_interest.ClearSelected();
        }

        private void research_faculty_Leave(object sender, EventArgs e)
        {
            // clear the selection when you loose focus on the research by faculty box
            research_faculty.ClearSelected();
        }
    }
}
