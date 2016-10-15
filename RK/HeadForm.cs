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
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();

            Timer MyTimer = new Timer();
            MyTimer.Interval = 6000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
