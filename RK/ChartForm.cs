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
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.t.Length; i++)
            {
                ResultsChart.Series[0].Points.AddXY(Data.t[i], Data.q[i]);
            }
        }
    }
}
