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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DefaultValues_Click(object sender, EventArgs e)
        {
            RangeFromTextBox.Text = 0.ToString();
            RangeToTextBox.Text = 0.05.ToString();
            StepSizeTextBox.Text = 0.001.ToString();
            InitialConditionTextBox.Text = 0.ToString();

            ResistanceTextBox.Text = 1000.ToString();
            CapacityTextBox.Text = Math.Pow(10, -5).ToString();
            VoltageTextBox.Text = 10.ToString();
        }

        /// <summary>
        /// Указывает на наличие ошибки в RangeFromTextBox
        /// </summary>
        private void RangeFromTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderRangeFrom.SetIconPadding(RangeFromTextBox, -20);
            ErrorProviderRangeFrom.SetError(RangeFromTextBox, "Bad");
        }
    }
}
