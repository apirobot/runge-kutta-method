using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace RK
{
    public partial class MainForm : Form
    {
        // Объявление переменных, хранящих исходные данные.
        private double rangeFrom;
        private double rangeTo;
        private int stepNumber;
        private double initialCondition;
        private double resistance;
        private double capacity;
        private double voltage;

        public double RangeFrom
        {
            get { return rangeFrom; }
            private set
            {
                if (value < 0)
                    throw new Exception("Значение должно быть не меньше 0");
                rangeFrom = value;
            }
        }

        public double RangeTo
        {
            get { return rangeTo; }
            private set
            {
                if (value <= 0)
                    throw new Exception("Значение должно быть больше 0");
                rangeTo = value;
            }
        }

        public int StepNumber
        {
            get { return stepNumber; }
            private set
            {
                if (value <= 0 || value > 10000)
                    throw new Exception("Количество разбиений должно быть больше 0 и не больше 10000");
                stepNumber = value;
            }
        }

        public double InitialCondition
        {
            get { return initialCondition; }
            private set { initialCondition = value; }
        }

        public double Resistance
        {
            get { return resistance; }
            private set
            {
                if (value <= 0)
                    throw new Exception("Значение должно быть больше 0");
                resistance = value;
            }
        }

        public double Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                    throw new Exception("Значение должно быть больше 0");
                capacity = value;
            }
        }

        public double Voltage
        {
            get { return voltage; }
            private set
            {
                if (value < 0)
                    throw new Exception("Значение должно быть не меньше 0");
                voltage = value;
            }
        }

        // Проверка на правильность ввода исходных данных.
        public bool RangeFromChecked { get; private set; } = false;
        public bool RangeToChecked { get; private set; } = false;
        public bool StepNumberChecked { get; private set; } = false;
        public bool InitialConditionChecked { get; private set; } = false;
        public bool ResistanceChecked { get; private set; } = false;
        public bool CapacityChecked { get; private set; } = false;
        public bool VoltageChecked { get; private set; } = false;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает значения по умолчанию (значения по варианту).
        /// </summary>
        private void DefaultValues_Click(object sender, EventArgs e)
        {
            RangeFrom = 0;
            RangeFromTextBox.Text = RangeFrom.ToString();
            RangeFromChecked = true;

            RangeTo = 0.05;
            RangeToTextBox.Text = RangeTo.ToString();
            RangeToChecked = true;

            StepNumber = 100;
            StepNumberTextBox.Text = StepNumber.ToString();
            StepNumberChecked = true;

            InitialCondition = 0;
            InitialConditionTextBox.Text = InitialCondition.ToString();
            InitialConditionChecked = true;

            Resistance = 1000;
            ResistanceTextBox.Text = Resistance.ToString();
            ResistanceChecked = true;

            Capacity = Math.Pow(10, -5);
            CapacityTextBox.Text = Capacity.ToString();
            CapacityChecked = true;

            Voltage = 10;
            VoltageTextBox.Text = Voltage.ToString();
            VoltageChecked = true;
        }

        /// <summary>
        /// Проверяет значение в RangeFromTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void RangeFromTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderRangeFrom.SetIconPadding(RangeFromTextBox, -20);

            try
            {
                RangeFrom = double.Parse(RangeFromTextBox.Text);

                if (double.TryParse(RangeToTextBox.Text, out rangeTo))
                    if (RangeTo - RangeFrom <= 0)
                        throw new Exception("Разность между конечным и начальным значениями интервала должна быть больше 0");

                ErrorProviderRangeFrom.Clear();
                ErrorProviderRangeTo.Clear();
                RangeFromChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Значение должно быть не меньше 0" ||
                    ex.Message == "Разность между конечным и начальным значениями интервала должна быть больше 0")
                    ErrorProviderRangeFrom.SetError(RangeFromTextBox, ex.Message);
                else
                    ErrorProviderRangeFrom.SetError(RangeFromTextBox, "Ошибка ввода");

                RangeFromChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в RangeToTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void RangeToTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderRangeTo.SetIconPadding(RangeToTextBox, -20);

            try
            {
                RangeTo = double.Parse(RangeToTextBox.Text);

                if (double.TryParse(RangeFromTextBox.Text, out rangeFrom))
                    if (RangeTo - RangeFrom <= 0)
                        throw new Exception("Разность между конечным и начальным значениями интервала должна быть больше 0");

                ErrorProviderRangeFrom.Clear();
                ErrorProviderRangeTo.Clear();
                RangeToChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Значение должно быть больше 0" ||
                    ex.Message == "Разность между конечным и начальным значениями интервала должна быть больше 0")
                    ErrorProviderRangeTo.SetError(RangeToTextBox, ex.Message);
                else
                    ErrorProviderRangeTo.SetError(RangeToTextBox, "Ошибка ввода");

                RangeToChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в StepNumberTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void StepNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderStepNumber.SetIconPadding(StepNumberTextBox, -20);

            try
            {
                StepNumber = int.Parse(StepNumberTextBox.Text);

                ErrorProviderStepNumber.Clear();
                StepNumberChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Количество разбиений должно быть больше 0 и не больше 10000")
                    ErrorProviderStepNumber.SetError(StepNumberTextBox, ex.Message);
                else
                    ErrorProviderStepNumber.SetError(StepNumberTextBox, "Ошибка ввода");

                StepNumberChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в InitialConditionTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void InitialConditionTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderInitialCondition.SetIconPadding(InitialConditionTextBox, -20);

            try
            {
                InitialCondition = double.Parse(InitialConditionTextBox.Text);

                ErrorProviderInitialCondition.Clear();
                InitialConditionChecked = true;
            }
            catch
            {
                ErrorProviderInitialCondition.SetError(InitialConditionTextBox, "Ошибка ввода");

                InitialConditionChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в ResistanceTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void ResistanceTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderResistance.SetIconPadding(ResistanceTextBox, -20);

            try
            {
                Resistance = double.Parse(ResistanceTextBox.Text);

                ErrorProviderResistance.Clear();
                ResistanceChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Значение должно быть больше 0")
                    ErrorProviderResistance.SetError(ResistanceTextBox, ex.Message);
                else
                    ErrorProviderResistance.SetError(ResistanceTextBox, "Ошибка ввода");

                ResistanceChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в CapacityTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void CapacityTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderCapacity.SetIconPadding(CapacityTextBox, -20);

            try
            {
                Capacity = double.Parse(CapacityTextBox.Text);

                ErrorProviderCapacity.Clear();
                CapacityChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Значение должно быть больше 0")
                    ErrorProviderCapacity.SetError(CapacityTextBox, ex.Message);
                else
                    ErrorProviderCapacity.SetError(CapacityTextBox, "Ошибка ввода");

                CapacityChecked = false;
            }
        }

        /// <summary>
        /// Проверяет значение в VoltageTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void VoltageTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderVoltage.SetIconPadding(VoltageTextBox, -20);

            try
            {
                Voltage = double.Parse(VoltageTextBox.Text);

                ErrorProviderVoltage.Clear();
                VoltageChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Значение должно быть не меньше 0")
                    ErrorProviderVoltage.SetError(VoltageTextBox, ex.Message);
                else
                    ErrorProviderVoltage.SetError(VoltageTextBox, "Ошибка ввода");

                VoltageChecked = false;
            }
        }

        /// <summary>
        /// Кнопка вычислить. Вычисляются значения по методу Рунге-Кутта и заносятся в класс Data.
        /// Если возникает ошибка, то показывается соответствующий MessageBox.
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!RangeFromChecked || !RangeToChecked || !StepNumberChecked || !InitialConditionChecked ||
                !ResistanceChecked || !CapacityChecked || !VoltageChecked)
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResultsMenuItem.Enabled = false;
                return;
            }

            try
            {
                RK4 equation = new RK4(RangeFrom, RangeTo, StepNumber, InitialCondition, Resistance, Capacity, Voltage);
                equation.Solve();
            }
            catch
            {
                MessageBox.Show("Во время вычислений возникла ошибка. Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResultsMenuItem.Enabled = false;
                return;
            }

            MessageBox.Show("Вычисления выполнены успешно. Таблица результатов и график находятся в меню \"Результаты\"", "Вычисления выполнены", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ResultsMenuItem.Enabled = true;
        }

        /// <summary>
        /// Таблица результатов.
        /// </summary>
        private void TableMenuItem_Click(object sender, EventArgs e)
        {
            TableForm table = new TableForm();
            table.Show();
        }

        /// <summary>
        /// График результатов.
        /// </summary>
        private void ChartMenuItem_Click(object sender, EventArgs e)
        {
            ChartForm chart = new ChartForm();
            chart.Show();
        }

        /// <summary>
        /// Сохраняет исходные данные и результаты (если они имеются) в файл.
        /// </summary>
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileDialog.Filter = "Текстовый файл|*.txt";

            if (SaveAsFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = SaveAsFileDialog.FileName;

            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false, Encoding.Default))
                {
                    sw.WriteLine("Интервал от {0} до {1}", RangeFrom, RangeTo);
                    sw.WriteLine("Количество разбиений: {0}", StepNumber);
                    sw.WriteLine("Начальное условие: {0}", InitialCondition);

                    sw.WriteLine();

                    sw.WriteLine("Сопротивление резистора: {0}", Resistance);
                    sw.WriteLine("Ёмкость: {0}", Capacity.ToString());
                    sw.WriteLine("Напряжение: {0}", Voltage);

                    sw.WriteLine();

                    if (Data.t != null && Data.q != null)
                    {
                        string tText, qText;
                        for (int i = 0; i < Data.t.Length; i++)
                        {
                            tText = string.Format("t[{0}] = {1:f8}", i, Data.t[i]);
                            qText = string.Format("q[{0}] = {1}", i, Data.q[i]);

                            sw.WriteLine(string.Format("{0,-30} {1,-30}", tText, qText));
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Читает исходные данные и вычисленные результаты (если они имеются) из файла.
        /// </summary>
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Текстовый файл|*.txt";

            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = OpenFileDialog.FileName;

            try
            {
                using (StreamReader sr = new StreamReader(filename, Encoding.Default))
                {
                    string text = sr.ReadToEnd();

                    /* [0-9]*\,?[0-9]*([eE][-+]?[0-9]+)? получает целые, нецелые числа и 
                     * числа, представленные в научном формате
                     * Примеры: 1; 25; 0,2552; 9,5134E-06
                     */

                    RangeFromTextBox.Text = Regex.Match(text, @"Интервал от ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();
                    RangeToTextBox.Text = Regex.Match(text, @"до ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();
                    StepNumberTextBox.Text = Regex.Match(text, @"Количество разбиений: ([0-9]+)").Groups[1].ToString();
                    InitialConditionTextBox.Text = Regex.Match(text, @"Начальное условие: ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();
                    ResistanceTextBox.Text = Regex.Match(text, @"Сопротивление резистора: ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();
                    CapacityTextBox.Text = Regex.Match(text, @"Ёмкость: ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();
                    VoltageTextBox.Text = Regex.Match(text, @"Напряжение: ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)").Groups[1].ToString();

                    MatchCollection tMatches = Regex.Matches(text, @"t\[([0-9]+)\] = ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)");
                    MatchCollection qMatches = Regex.Matches(text, @"q\[([0-9]+)\] = ([0-9]*\,?[0-9]*([eE][-+]?[0-9]+)?)");

                    if (tMatches.Count != qMatches.Count)
                        throw new Exception();
                    if (tMatches.Count == 0 || qMatches.Count == 0)
                        return;

                    int elements = tMatches.Count;

                    Data.t = new double[elements];
                    foreach (Match match in tMatches) 
                    {
                        int index = int.Parse(match.Groups[1].ToString());
                        double value = double.Parse(match.Groups[2].ToString());
                        Data.t[index] = value;
                    }

                    Data.q = new double[elements];
                    foreach (Match match in qMatches)
                    {
                        int index = int.Parse(match.Groups[1].ToString());
                        double value = double.Parse(match.Groups[2].ToString());
                        Data.q[index] = value;
                    }
                }

                ResultsMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
