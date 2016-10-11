using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            ResultsListBox.Items.Clear();

            string tText, qText;
            for (int i = 0; i < Data.t.Length; i++)
            {
                tText = string.Format("t[{0}] = {1:f8}", i, Data.t[i]);
                qText = string.Format("q[{0}] = {1}", i, Data.q[i]);

                ResultsListBox.Items.Add(string.Format("{0,-30} {1,-30}", tText, qText));
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartForm chart = new ChartForm();
            chart.Show();
        }
    }
}
