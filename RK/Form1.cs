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
        // Объявление переменных, хранящих исходные данные.
        private double rangeFrom;
        private double rangeTo;
        private double stepSize;
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

        public double StepSize
        {
            get { return stepSize; }
            private set
            {
                if (value <= 0 || value > RangeTo)
                    throw new Exception("Величина шага должна быть больше 0 и не больше значения конца интервала");
                stepSize = value;
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
        public bool StepSizeChecked { get; private set; } = false;
        public bool InitialConditionChecked { get; private set; } = false;
        public bool ResistanceChecked { get; private set; } = false;
        public bool CapacityChecked { get; private set; } = false;
        public bool VoltageChecked { get; private set; } = false;

        public Form1()
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

            StepSize = 0.001;
            StepSizeTextBox.Text = StepSize.ToString();
            StepSizeChecked = true;

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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!RangeFromChecked || !RangeToChecked || !StepSizeChecked || !InitialConditionChecked ||
                !ResistanceChecked || !CapacityChecked || !VoltageChecked)
            {
                MessageBox.Show("Проверьте правильность ввода исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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
        /// Проверяет значение в StepSizeTextBox. Если нужно, указывает на наличие ошибки.
        /// </summary>
        private void StepSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorProviderStepSize.SetIconPadding(StepSizeTextBox, -20);

            try
            {
                StepSize = double.Parse(StepSizeTextBox.Text);

                ErrorProviderStepSize.Clear();
                StepSizeChecked = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Величина шага должна быть больше 0 и не больше значения конца интервала")
                    ErrorProviderStepSize.SetError(StepSizeTextBox, ex.Message);
                else
                    ErrorProviderStepSize.SetError(StepSizeTextBox, "Ошибка ввода");

                StepSizeChecked = false;
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
    }
}
