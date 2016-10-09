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
        // Проверка на правильность ввода исходных данных
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
            RangeFromTextBox.Text = 0.ToString();
            RangeFromChecked = true;

            RangeToTextBox.Text = 0.05.ToString();
            RangeToChecked = true;

            StepSizeTextBox.Text = 0.001.ToString();
            StepSizeChecked = true;

            InitialConditionTextBox.Text = 0.ToString();
            InitialConditionChecked = true;

            ResistanceTextBox.Text = 1000.ToString();
            ResistanceChecked = true;

            CapacityTextBox.Text = Math.Pow(10, -5).ToString();
            CapacityChecked = true;

            VoltageTextBox.Text = 10.ToString();
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
                double rangeFrom = double.Parse(RangeFromTextBox.Text);
                double rangeTo;
                if (rangeFrom < 0)
                    throw new Exception("Значение должно быть не меньше 0");
                if (double.TryParse(RangeToTextBox.Text, out rangeTo))
                    if (rangeTo - rangeFrom <= 0)
                        throw new Exception("Разность между конечным и начальным значениями интервала должна быть больше 0");

                ErrorProviderRangeFrom.Clear();
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
                double rangeFrom;
                double rangeTo = double.Parse(RangeToTextBox.Text);
                if (rangeTo <= 0)
                    throw new Exception("Значение должно быть больше 0");
                if (double.TryParse(RangeFromTextBox.Text, out rangeFrom))
                    if (rangeTo - rangeFrom <= 0)
                        throw new Exception("Разность между конечным и начальным значениями интервала должна быть больше 0");

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
                double stepSize = double.Parse(StepSizeTextBox.Text);
                double rangeTo = double.Parse(RangeToTextBox.Text);
                if (stepSize <= 0 || stepSize > rangeTo)
                    throw new Exception("Величина шага должна быть больше 0 и не больше значения конца интервала");

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
                double initialCondition = double.Parse(InitialConditionTextBox.Text);

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
                double resistance = double.Parse(ResistanceTextBox.Text);
                if (resistance <= 0)
                    throw new Exception("Значение должно быть больше 0");

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
                double capacity = double.Parse(CapacityTextBox.Text);
                if (capacity <= 0)
                    throw new Exception("Значение должно быть больше 0");

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
                double voltage = double.Parse(VoltageTextBox.Text);
                if (voltage < 0)
                    throw new Exception("Значение должно быть не меньше 0");

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
