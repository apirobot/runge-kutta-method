namespace RK
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuTool = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputDataLabel = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.RangeFromLabel = new System.Windows.Forms.Label();
            this.RangeFromTextBox = new System.Windows.Forms.TextBox();
            this.RangeToLabel = new System.Windows.Forms.Label();
            this.RangeToTextBox = new System.Windows.Forms.TextBox();
            this.StepNumberLabel = new System.Windows.Forms.Label();
            this.StepNumberTextBox = new System.Windows.Forms.TextBox();
            this.InitialConditionLabel = new System.Windows.Forms.Label();
            this.InitialConditionTextBox = new System.Windows.Forms.TextBox();
            this.AssignedValuesLabel = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.ResistanceLabel = new System.Windows.Forms.Label();
            this.ResistanceTextBox = new System.Windows.Forms.TextBox();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.VoltageLabel = new System.Windows.Forms.Label();
            this.VoltageTextBox = new System.Windows.Forms.TextBox();
            this.TableForButtons = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DefaultValues = new System.Windows.Forms.Button();
            this.ErrorProviderRangeFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderRangeTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderStepNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderInitialCondition = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderResistance = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderCapacity = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderVoltage = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuTool.SuspendLayout();
            this.TableForButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderStepNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInitialCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderResistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTool
            // 
            this.MenuTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ResultsMenuItem,
            this.HelpMenuItem,
            this.AboutMenuItem});
            this.MenuTool.Location = new System.Drawing.Point(0, 0);
            this.MenuTool.Name = "MenuTool";
            this.MenuTool.Size = new System.Drawing.Size(369, 24);
            this.MenuTool.TabIndex = 0;
            this.MenuTool.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(132, 22);
            this.OpenMenuItem.Text = "Открыть";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveMenuItem.Text = "Сохранить";
            // 
            // ResultsMenuItem
            // 
            this.ResultsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableMenuItem,
            this.ChartMenuItem});
            this.ResultsMenuItem.Enabled = false;
            this.ResultsMenuItem.Name = "ResultsMenuItem";
            this.ResultsMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ResultsMenuItem.Text = "Результаты";
            // 
            // TableMenuItem
            // 
            this.TableMenuItem.Name = "TableMenuItem";
            this.TableMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TableMenuItem.Text = "Таблица";
            this.TableMenuItem.Click += new System.EventHandler(this.TableMenuItem_Click);
            // 
            // ChartMenuItem
            // 
            this.ChartMenuItem.Name = "ChartMenuItem";
            this.ChartMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ChartMenuItem.Text = "График";
            this.ChartMenuItem.Click += new System.EventHandler(this.ChartMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpMenuItem.Text = "Помощь";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutMenuItem.Text = "О программе";
            // 
            // InputDataLabel
            // 
            this.InputDataLabel.AutoSize = true;
            this.InputDataLabel.Location = new System.Drawing.Point(12, 40);
            this.InputDataLabel.Name = "InputDataLabel";
            this.InputDataLabel.Size = new System.Drawing.Size(142, 13);
            this.InputDataLabel.TabIndex = 1;
            this.InputDataLabel.Text = "Введите исходные данные";
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(15, 65);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(337, 2);
            this.Line.TabIndex = 2;
            // 
            // RangeFromLabel
            // 
            this.RangeFromLabel.AutoSize = true;
            this.RangeFromLabel.Location = new System.Drawing.Point(12, 80);
            this.RangeFromLabel.Name = "RangeFromLabel";
            this.RangeFromLabel.Size = new System.Drawing.Size(70, 13);
            this.RangeFromLabel.TabIndex = 3;
            this.RangeFromLabel.Text = "Интервал от";
            // 
            // RangeFromTextBox
            // 
            this.RangeFromTextBox.Location = new System.Drawing.Point(170, 78);
            this.RangeFromTextBox.Name = "RangeFromTextBox";
            this.RangeFromTextBox.Size = new System.Drawing.Size(70, 20);
            this.RangeFromTextBox.TabIndex = 4;
            this.RangeFromTextBox.TextChanged += new System.EventHandler(this.RangeFromTextBox_TextChanged);
            // 
            // RangeToLabel
            // 
            this.RangeToLabel.AutoSize = true;
            this.RangeToLabel.Location = new System.Drawing.Point(250, 80);
            this.RangeToLabel.Name = "RangeToLabel";
            this.RangeToLabel.Size = new System.Drawing.Size(19, 13);
            this.RangeToLabel.TabIndex = 5;
            this.RangeToLabel.Text = "до";
            // 
            // RangeToTextBox
            // 
            this.RangeToTextBox.Location = new System.Drawing.Point(280, 78);
            this.RangeToTextBox.Name = "RangeToTextBox";
            this.RangeToTextBox.Size = new System.Drawing.Size(70, 20);
            this.RangeToTextBox.TabIndex = 6;
            this.RangeToTextBox.TextChanged += new System.EventHandler(this.RangeToTextBox_TextChanged);
            // 
            // StepNumberLabel
            // 
            this.StepNumberLabel.AutoSize = true;
            this.StepNumberLabel.Location = new System.Drawing.Point(12, 110);
            this.StepNumberLabel.Name = "StepNumberLabel";
            this.StepNumberLabel.Size = new System.Drawing.Size(123, 13);
            this.StepNumberLabel.TabIndex = 7;
            this.StepNumberLabel.Text = "Количество разбиений";
            // 
            // StepNumberTextBox
            // 
            this.StepNumberTextBox.Location = new System.Drawing.Point(170, 108);
            this.StepNumberTextBox.Name = "StepNumberTextBox";
            this.StepNumberTextBox.Size = new System.Drawing.Size(70, 20);
            this.StepNumberTextBox.TabIndex = 8;
            this.StepNumberTextBox.TextChanged += new System.EventHandler(this.StepNumberTextBox_TextChanged);
            // 
            // InitialConditionLabel
            // 
            this.InitialConditionLabel.AutoSize = true;
            this.InitialConditionLabel.Location = new System.Drawing.Point(12, 140);
            this.InitialConditionLabel.Name = "InitialConditionLabel";
            this.InitialConditionLabel.Size = new System.Drawing.Size(106, 13);
            this.InitialConditionLabel.TabIndex = 9;
            this.InitialConditionLabel.Text = "Начальное условие";
            // 
            // InitialConditionTextBox
            // 
            this.InitialConditionTextBox.Location = new System.Drawing.Point(170, 138);
            this.InitialConditionTextBox.Name = "InitialConditionTextBox";
            this.InitialConditionTextBox.Size = new System.Drawing.Size(70, 20);
            this.InitialConditionTextBox.TabIndex = 10;
            this.InitialConditionTextBox.TextChanged += new System.EventHandler(this.InitialConditionTextBox_TextChanged);
            // 
            // AssignedValuesLabel
            // 
            this.AssignedValuesLabel.AutoSize = true;
            this.AssignedValuesLabel.Location = new System.Drawing.Point(12, 200);
            this.AssignedValuesLabel.Name = "AssignedValuesLabel";
            this.AssignedValuesLabel.Size = new System.Drawing.Size(164, 13);
            this.AssignedValuesLabel.TabIndex = 11;
            this.AssignedValuesLabel.Text = "Исходные значения уравнения";
            // 
            // Line2
            // 
            this.Line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line2.Location = new System.Drawing.Point(15, 225);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(337, 2);
            this.Line2.TabIndex = 12;
            // 
            // ResistanceLabel
            // 
            this.ResistanceLabel.AutoSize = true;
            this.ResistanceLabel.Location = new System.Drawing.Point(12, 240);
            this.ResistanceLabel.Name = "ResistanceLabel";
            this.ResistanceLabel.Size = new System.Drawing.Size(24, 13);
            this.ResistanceLabel.TabIndex = 13;
            this.ResistanceLabel.Text = "R =";
            // 
            // ResistanceTextBox
            // 
            this.ResistanceTextBox.Location = new System.Drawing.Point(40, 238);
            this.ResistanceTextBox.Name = "ResistanceTextBox";
            this.ResistanceTextBox.Size = new System.Drawing.Size(70, 20);
            this.ResistanceTextBox.TabIndex = 14;
            this.ResistanceTextBox.TextChanged += new System.EventHandler(this.ResistanceTextBox_TextChanged);
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(135, 240);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(23, 13);
            this.CapacityLabel.TabIndex = 15;
            this.CapacityLabel.Text = "C =";
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(165, 238);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(70, 20);
            this.CapacityTextBox.TabIndex = 16;
            this.CapacityTextBox.TextChanged += new System.EventHandler(this.CapacityTextBox_TextChanged);
            // 
            // VoltageLabel
            // 
            this.VoltageLabel.AutoSize = true;
            this.VoltageLabel.Location = new System.Drawing.Point(250, 240);
            this.VoltageLabel.Name = "VoltageLabel";
            this.VoltageLabel.Size = new System.Drawing.Size(23, 13);
            this.VoltageLabel.TabIndex = 17;
            this.VoltageLabel.Text = "V =";
            // 
            // VoltageTextBox
            // 
            this.VoltageTextBox.Location = new System.Drawing.Point(280, 238);
            this.VoltageTextBox.Name = "VoltageTextBox";
            this.VoltageTextBox.Size = new System.Drawing.Size(70, 20);
            this.VoltageTextBox.TabIndex = 18;
            this.VoltageTextBox.TextChanged += new System.EventHandler(this.VoltageTextBox_TextChanged);
            // 
            // TableForButtons
            // 
            this.TableForButtons.ColumnCount = 2;
            this.TableForButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForButtons.Controls.Add(this.CalculateButton, 0, 0);
            this.TableForButtons.Controls.Add(this.DefaultValues, 1, 0);
            this.TableForButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableForButtons.Location = new System.Drawing.Point(0, 281);
            this.TableForButtons.Name = "TableForButtons";
            this.TableForButtons.RowCount = 1;
            this.TableForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableForButtons.Size = new System.Drawing.Size(369, 40);
            this.TableForButtons.TabIndex = 19;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateButton.Location = new System.Drawing.Point(3, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(178, 34);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DefaultValues
            // 
            this.DefaultValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultValues.Location = new System.Drawing.Point(187, 3);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(179, 34);
            this.DefaultValues.TabIndex = 1;
            this.DefaultValues.Text = "Значения по умолчанию";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);
            // 
            // ErrorProviderRangeFrom
            // 
            this.ErrorProviderRangeFrom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderRangeFrom.ContainerControl = this;
            this.ErrorProviderRangeFrom.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderRangeFrom.Icon")));
            // 
            // ErrorProviderRangeTo
            // 
            this.ErrorProviderRangeTo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderRangeTo.ContainerControl = this;
            this.ErrorProviderRangeTo.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderRangeTo.Icon")));
            // 
            // ErrorProviderStepNumber
            // 
            this.ErrorProviderStepNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderStepNumber.ContainerControl = this;
            this.ErrorProviderStepNumber.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderStepNumber.Icon")));
            // 
            // ErrorProviderInitialCondition
            // 
            this.ErrorProviderInitialCondition.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderInitialCondition.ContainerControl = this;
            this.ErrorProviderInitialCondition.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderInitialCondition.Icon")));
            // 
            // ErrorProviderResistance
            // 
            this.ErrorProviderResistance.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderResistance.ContainerControl = this;
            this.ErrorProviderResistance.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderResistance.Icon")));
            // 
            // ErrorProviderCapacity
            // 
            this.ErrorProviderCapacity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderCapacity.ContainerControl = this;
            this.ErrorProviderCapacity.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderCapacity.Icon")));
            // 
            // ErrorProviderVoltage
            // 
            this.ErrorProviderVoltage.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProviderVoltage.ContainerControl = this;
            this.ErrorProviderVoltage.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProviderVoltage.Icon")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 321);
            this.Controls.Add(this.TableForButtons);
            this.Controls.Add(this.VoltageTextBox);
            this.Controls.Add(this.VoltageLabel);
            this.Controls.Add(this.CapacityTextBox);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.ResistanceTextBox);
            this.Controls.Add(this.ResistanceLabel);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.AssignedValuesLabel);
            this.Controls.Add(this.InitialConditionTextBox);
            this.Controls.Add(this.InitialConditionLabel);
            this.Controls.Add(this.StepNumberTextBox);
            this.Controls.Add(this.StepNumberLabel);
            this.Controls.Add(this.RangeToTextBox);
            this.Controls.Add(this.RangeToLabel);
            this.Controls.Add(this.RangeFromTextBox);
            this.Controls.Add(this.RangeFromLabel);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.InputDataLabel);
            this.Controls.Add(this.MenuTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuTool;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ввод исходных данных";
            this.MenuTool.ResumeLayout(false);
            this.MenuTool.PerformLayout();
            this.TableForButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderStepNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderInitialCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderResistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTool;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Label InputDataLabel;
        private System.Windows.Forms.ToolStripMenuItem TableMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartMenuItem;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label RangeFromLabel;
        private System.Windows.Forms.TextBox RangeFromTextBox;
        private System.Windows.Forms.Label RangeToLabel;
        private System.Windows.Forms.TextBox RangeToTextBox;
        private System.Windows.Forms.Label StepNumberLabel;
        private System.Windows.Forms.TextBox StepNumberTextBox;
        private System.Windows.Forms.Label InitialConditionLabel;
        private System.Windows.Forms.TextBox InitialConditionTextBox;
        private System.Windows.Forms.Label AssignedValuesLabel;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label ResistanceLabel;
        private System.Windows.Forms.TextBox ResistanceTextBox;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.Label VoltageLabel;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.TableLayoutPanel TableForButtons;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.ErrorProvider ErrorProviderRangeFrom;
        private System.Windows.Forms.ErrorProvider ErrorProviderRangeTo;
        private System.Windows.Forms.ErrorProvider ErrorProviderStepNumber;
        private System.Windows.Forms.ErrorProvider ErrorProviderInitialCondition;
        private System.Windows.Forms.ErrorProvider ErrorProviderResistance;
        private System.Windows.Forms.ErrorProvider ErrorProviderCapacity;
        private System.Windows.Forms.ErrorProvider ErrorProviderVoltage;
    }
}

