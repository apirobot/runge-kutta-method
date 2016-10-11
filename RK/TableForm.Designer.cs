namespace RK
{
    partial class TableForm
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
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.TableResultsLabel = new System.Windows.Forms.Label();
            this.Line3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(15, 65);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(355, 199);
            this.ResultsListBox.TabIndex = 0;
            // 
            // TableResultsLabel
            // 
            this.TableResultsLabel.AutoSize = true;
            this.TableResultsLabel.Location = new System.Drawing.Point(12, 20);
            this.TableResultsLabel.Name = "TableResultsLabel";
            this.TableResultsLabel.Size = new System.Drawing.Size(213, 13);
            this.TableResultsLabel.TabIndex = 1;
            this.TableResultsLabel.Text = "Результаты вычислений в виде таблицы";
            // 
            // Line3
            // 
            this.Line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line3.Location = new System.Drawing.Point(15, 45);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(355, 2);
            this.Line3.TabIndex = 2;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(205, 275);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(295, 275);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 4;
            this.ChartButton.Text = "График";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.TableResultsLabel);
            this.Controls.Add(this.ResultsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TableForm";
            this.Text = "Таблица результатов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Label TableResultsLabel;
        private System.Windows.Forms.Label Line3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ChartButton;
    }
}