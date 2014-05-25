using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetAssessment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            pnAddTag.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animalTrackingDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.animalTrackingDataSet.Owners);

        }

        private void btnTagSelectQuery_Click(object sender, EventArgs e)
        {
            pnSelectedTag.Visible = true;

        }
    }
}
