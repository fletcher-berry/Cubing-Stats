namespace CubingStats
{
    partial class StatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimesTable = new System.Windows.Forms.TableLayoutPanel();
            this.SortedTimesTable = new System.Windows.Forms.TableLayoutPanel();
            this.ImportTimesButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.TimeIndicator = new System.Windows.Forms.Label();
            this.RankIndicator = new System.Windows.Forms.Label();
            this.TimeInput = new System.Windows.Forms.TextBox();
            this.RankInput = new System.Windows.Forms.TextBox();
            this.CalcTimeButton = new System.Windows.Forms.Button();
            this.CalcRankButton = new System.Windows.Forms.Button();
            this.SummaryTable = new System.Windows.Forms.TableLayoutPanel();
            this.MedianIndicator = new System.Windows.Forms.Label();
            this.AverageIndicator = new System.Windows.Forms.Label();
            this.MeanIndicator = new System.Windows.Forms.Label();
            this.MeanLabel = new System.Windows.Forms.Label();
            this.MedianLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountIndicator = new System.Windows.Forms.Label();
            this.ConsecutiveInput = new System.Windows.Forms.TextBox();
            this.ConsecutiveButton = new System.Windows.Forms.Button();
            this.ConsecutiveLabel = new System.Windows.Forms.Label();
            this.Ao5Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ao100Label = new System.Windows.Forms.Label();
            this.StdDevLabel = new System.Windows.Forms.Label();
            this.Ao12Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowAo12ChartButton = new System.Windows.Forms.Button();
            this.ShowAo100ChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimesTable
            // 
            this.TimesTable.AutoScroll = true;
            this.TimesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TimesTable.ColumnCount = 2;
            this.TimesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TimesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TimesTable.Location = new System.Drawing.Point(15, 70);
            this.TimesTable.Name = "TimesTable";
            this.TimesTable.RowCount = 7;
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TimesTable.Size = new System.Drawing.Size(192, 365);
            this.TimesTable.TabIndex = 1;
            // 
            // SortedTimesTable
            // 
            this.SortedTimesTable.AutoScroll = true;
            this.SortedTimesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SortedTimesTable.ColumnCount = 2;
            this.SortedTimesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.46148F));
            this.SortedTimesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.53852F));
            this.SortedTimesTable.Location = new System.Drawing.Point(255, 70);
            this.SortedTimesTable.Name = "SortedTimesTable";
            this.SortedTimesTable.RowCount = 5;
            this.SortedTimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortedTimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortedTimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortedTimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortedTimesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortedTimesTable.Size = new System.Drawing.Size(193, 365);
            this.SortedTimesTable.TabIndex = 2;
            // 
            // ImportTimesButton
            // 
            this.ImportTimesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportTimesButton.Location = new System.Drawing.Point(491, 18);
            this.ImportTimesButton.Name = "ImportTimesButton";
            this.ImportTimesButton.Size = new System.Drawing.Size(187, 45);
            this.ImportTimesButton.TabIndex = 3;
            this.ImportTimesButton.Text = "import times";
            this.ImportTimesButton.UseVisualStyleBackColor = true;
            this.ImportTimesButton.Click += new System.EventHandler(this.ImportTimesButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.Location = new System.Drawing.Point(96, 18);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(81, 31);
            this.FileNameLabel.TabIndex = 4;
            this.FileNameLabel.Text = "name";
            // 
            // TimeIndicator
            // 
            this.TimeIndicator.AutoSize = true;
            this.TimeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIndicator.Location = new System.Drawing.Point(467, 104);
            this.TimeIndicator.Name = "TimeIndicator";
            this.TimeIndicator.Size = new System.Drawing.Size(81, 29);
            this.TimeIndicator.TabIndex = 5;
            this.TimeIndicator.Text = "Time: ";
            // 
            // RankIndicator
            // 
            this.RankIndicator.AutoSize = true;
            this.RankIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankIndicator.Location = new System.Drawing.Point(467, 163);
            this.RankIndicator.Name = "RankIndicator";
            this.RankIndicator.Size = new System.Drawing.Size(93, 29);
            this.RankIndicator.TabIndex = 7;
            this.RankIndicator.Text = "% rank:";
            // 
            // TimeInput
            // 
            this.TimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInput.Location = new System.Drawing.Point(566, 104);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(112, 34);
            this.TimeInput.TabIndex = 8;
            // 
            // RankInput
            // 
            this.RankInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankInput.Location = new System.Drawing.Point(566, 163);
            this.RankInput.Name = "RankInput";
            this.RankInput.Size = new System.Drawing.Size(112, 34);
            this.RankInput.TabIndex = 9;
            // 
            // CalcTimeButton
            // 
            this.CalcTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTimeButton.Location = new System.Drawing.Point(481, 222);
            this.CalcTimeButton.Name = "CalcTimeButton";
            this.CalcTimeButton.Size = new System.Drawing.Size(197, 42);
            this.CalcTimeButton.TabIndex = 10;
            this.CalcTimeButton.Text = "Calc time";
            this.CalcTimeButton.UseVisualStyleBackColor = true;
            this.CalcTimeButton.Click += new System.EventHandler(this.CalcTimeButton_Click);
            // 
            // CalcRankButton
            // 
            this.CalcRankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcRankButton.Location = new System.Drawing.Point(481, 291);
            this.CalcRankButton.Name = "CalcRankButton";
            this.CalcRankButton.Size = new System.Drawing.Size(197, 42);
            this.CalcRankButton.TabIndex = 11;
            this.CalcRankButton.Text = "Calc rank";
            this.CalcRankButton.UseVisualStyleBackColor = true;
            this.CalcRankButton.Click += new System.EventHandler(this.CalcRankButton_Click);
            // 
            // SummaryTable
            // 
            this.SummaryTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SummaryTable.ColumnCount = 5;
            this.SummaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SummaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SummaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SummaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SummaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SummaryTable.Location = new System.Drawing.Point(15, 460);
            this.SummaryTable.Name = "SummaryTable";
            this.SummaryTable.RowCount = 2;
            this.SummaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SummaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SummaryTable.Size = new System.Drawing.Size(433, 69);
            this.SummaryTable.TabIndex = 12;
            // 
            // MedianIndicator
            // 
            this.MedianIndicator.AutoSize = true;
            this.MedianIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedianIndicator.Location = new System.Drawing.Point(467, 500);
            this.MedianIndicator.Name = "MedianIndicator";
            this.MedianIndicator.Size = new System.Drawing.Size(99, 29);
            this.MedianIndicator.TabIndex = 13;
            this.MedianIndicator.Text = "Median:";
            // 
            // AverageIndicator
            // 
            this.AverageIndicator.AutoSize = true;
            this.AverageIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageIndicator.Location = new System.Drawing.Point(469, 450);
            this.AverageIndicator.Name = "AverageIndicator";
            this.AverageIndicator.Size = new System.Drawing.Size(108, 29);
            this.AverageIndicator.TabIndex = 14;
            this.AverageIndicator.Text = "Average:";
            // 
            // MeanIndicator
            // 
            this.MeanIndicator.AutoSize = true;
            this.MeanIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeanIndicator.Location = new System.Drawing.Point(469, 400);
            this.MeanIndicator.Name = "MeanIndicator";
            this.MeanIndicator.Size = new System.Drawing.Size(79, 29);
            this.MeanIndicator.TabIndex = 15;
            this.MeanIndicator.Text = "Mean:";
            // 
            // MeanLabel
            // 
            this.MeanLabel.AutoSize = true;
            this.MeanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeanLabel.Location = new System.Drawing.Point(576, 400);
            this.MeanLabel.Name = "MeanLabel";
            this.MeanLabel.Size = new System.Drawing.Size(74, 29);
            this.MeanLabel.TabIndex = 16;
            this.MeanLabel.Text = "Value";
            // 
            // MedianLabel
            // 
            this.MedianLabel.AutoSize = true;
            this.MedianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedianLabel.Location = new System.Drawing.Point(576, 500);
            this.MedianLabel.Name = "MedianLabel";
            this.MedianLabel.Size = new System.Drawing.Size(74, 29);
            this.MedianLabel.TabIndex = 17;
            this.MedianLabel.Text = "Value";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageLabel.Location = new System.Drawing.Point(576, 450);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(74, 29);
            this.AverageLabel.TabIndex = 18;
            this.AverageLabel.Text = "Value";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(574, 349);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(74, 29);
            this.CountLabel.TabIndex = 20;
            this.CountLabel.Text = "Value";
            // 
            // CountIndicator
            // 
            this.CountIndicator.AutoSize = true;
            this.CountIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountIndicator.Location = new System.Drawing.Point(467, 349);
            this.CountIndicator.Name = "CountIndicator";
            this.CountIndicator.Size = new System.Drawing.Size(82, 29);
            this.CountIndicator.TabIndex = 19;
            this.CountIndicator.Text = "Count:";
            // 
            // ConsecutiveInput
            // 
            this.ConsecutiveInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsecutiveInput.Location = new System.Drawing.Point(185, 558);
            this.ConsecutiveInput.Name = "ConsecutiveInput";
            this.ConsecutiveInput.Size = new System.Drawing.Size(112, 34);
            this.ConsecutiveInput.TabIndex = 22;
            // 
            // ConsecutiveButton
            // 
            this.ConsecutiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsecutiveButton.Location = new System.Drawing.Point(15, 558);
            this.ConsecutiveButton.Name = "ConsecutiveButton";
            this.ConsecutiveButton.Size = new System.Drawing.Size(164, 34);
            this.ConsecutiveButton.TabIndex = 23;
            this.ConsecutiveButton.Text = "Consecutive Times";
            this.ConsecutiveButton.UseVisualStyleBackColor = true;
            this.ConsecutiveButton.Click += new System.EventHandler(this.ConsecutiveButton_Click);
            // 
            // ConsecutiveLabel
            // 
            this.ConsecutiveLabel.AutoSize = true;
            this.ConsecutiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsecutiveLabel.Location = new System.Drawing.Point(303, 561);
            this.ConsecutiveLabel.Name = "ConsecutiveLabel";
            this.ConsecutiveLabel.Size = new System.Drawing.Size(82, 29);
            this.ConsecutiveLabel.TabIndex = 24;
            this.ConsecutiveLabel.Text = "Count:";
            // 
            // Ao5Label
            // 
            this.Ao5Label.AutoSize = true;
            this.Ao5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ao5Label.Location = new System.Drawing.Point(574, 577);
            this.Ao5Label.Name = "Ao5Label";
            this.Ao5Label.Size = new System.Drawing.Size(74, 29);
            this.Ao5Label.TabIndex = 32;
            this.Ao5Label.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "AO5:";
            // 
            // Ao100Label
            // 
            this.Ao100Label.AutoSize = true;
            this.Ao100Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ao100Label.Location = new System.Drawing.Point(576, 678);
            this.Ao100Label.Name = "Ao100Label";
            this.Ao100Label.Size = new System.Drawing.Size(74, 29);
            this.Ao100Label.TabIndex = 30;
            this.Ao100Label.Text = "Value";
            // 
            // StdDevLabel
            // 
            this.StdDevLabel.AutoSize = true;
            this.StdDevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdDevLabel.Location = new System.Drawing.Point(290, 742);
            this.StdDevLabel.Name = "StdDevLabel";
            this.StdDevLabel.Size = new System.Drawing.Size(74, 29);
            this.StdDevLabel.TabIndex = 29;
            this.StdDevLabel.Text = "Value";
            // 
            // Ao12Label
            // 
            this.Ao12Label.AutoSize = true;
            this.Ao12Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ao12Label.Location = new System.Drawing.Point(576, 628);
            this.Ao12Label.Name = "Ao12Label";
            this.Ao12Label.Size = new System.Drawing.Size(74, 29);
            this.Ao12Label.TabIndex = 28;
            this.Ao12Label.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "AO12:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "AO100:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 742);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Standard deviation:";
            // 
            // ShowAo12ChartButton
            // 
            this.ShowAo12ChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAo12ChartButton.Location = new System.Drawing.Point(122, 628);
            this.ShowAo12ChartButton.Name = "ShowAo12ChartButton";
            this.ShowAo12ChartButton.Size = new System.Drawing.Size(162, 45);
            this.ShowAo12ChartButton.TabIndex = 33;
            this.ShowAo12ChartButton.Text = "AO12 chart";
            this.ShowAo12ChartButton.UseVisualStyleBackColor = true;
            this.ShowAo12ChartButton.Click += new System.EventHandler(this.ShowAo12ChartButton_Click);
            // 
            // ShowAo100ChartButton
            // 
            this.ShowAo100ChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAo100ChartButton.Location = new System.Drawing.Point(122, 679);
            this.ShowAo100ChartButton.Name = "ShowAo100ChartButton";
            this.ShowAo100ChartButton.Size = new System.Drawing.Size(162, 45);
            this.ShowAo100ChartButton.TabIndex = 34;
            this.ShowAo100ChartButton.Text = "AO100 chart";
            this.ShowAo100ChartButton.UseVisualStyleBackColor = true;
            this.ShowAo100ChartButton.Click += new System.EventHandler(this.ShowAo100ChartButton_Click);
            // 
            // StatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowAo100ChartButton);
            this.Controls.Add(this.ShowAo12ChartButton);
            this.Controls.Add(this.Ao5Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ao100Label);
            this.Controls.Add(this.StdDevLabel);
            this.Controls.Add(this.Ao12Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConsecutiveLabel);
            this.Controls.Add(this.ConsecutiveButton);
            this.Controls.Add(this.ConsecutiveInput);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountIndicator);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.MedianLabel);
            this.Controls.Add(this.MeanLabel);
            this.Controls.Add(this.MeanIndicator);
            this.Controls.Add(this.AverageIndicator);
            this.Controls.Add(this.MedianIndicator);
            this.Controls.Add(this.SummaryTable);
            this.Controls.Add(this.CalcRankButton);
            this.Controls.Add(this.CalcTimeButton);
            this.Controls.Add(this.RankInput);
            this.Controls.Add(this.TimeInput);
            this.Controls.Add(this.RankIndicator);
            this.Controls.Add(this.TimeIndicator);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.ImportTimesButton);
            this.Controls.Add(this.SortedTimesTable);
            this.Controls.Add(this.TimesTable);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(700, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TimesTable;
        private System.Windows.Forms.TableLayoutPanel SortedTimesTable;
        private System.Windows.Forms.Button ImportTimesButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label TimeIndicator;
        private System.Windows.Forms.Label RankIndicator;
        private System.Windows.Forms.TextBox TimeInput;
        private System.Windows.Forms.TextBox RankInput;
        private System.Windows.Forms.Button CalcTimeButton;
        private System.Windows.Forms.Button CalcRankButton;
        private System.Windows.Forms.TableLayoutPanel SummaryTable;
        private System.Windows.Forms.Label MedianIndicator;
        private System.Windows.Forms.Label AverageIndicator;
        private System.Windows.Forms.Label MeanIndicator;
        private System.Windows.Forms.Label MeanLabel;
        private System.Windows.Forms.Label MedianLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label CountIndicator;
        private System.Windows.Forms.TextBox ConsecutiveInput;
        private System.Windows.Forms.Button ConsecutiveButton;
        private System.Windows.Forms.Label ConsecutiveLabel;
        private System.Windows.Forms.Label Ao5Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ao100Label;
        private System.Windows.Forms.Label StdDevLabel;
        private System.Windows.Forms.Label Ao12Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowAo12ChartButton;
        private System.Windows.Forms.Button ShowAo100ChartButton;
    }
}
