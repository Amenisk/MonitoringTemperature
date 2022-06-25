
namespace MonitoringTemperature
{
    partial class frmMonitoringTemperature
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFish = new System.Windows.Forms.TextBox();
            this.tbKindOfFish = new System.Windows.Forms.TextBox();
            this.tbTemperatureName = new System.Windows.Forms.TextBox();
            this.tbTimeName = new System.Windows.Forms.TextBox();
            this.tbMaxTempName = new System.Windows.Forms.TextBox();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.tbMaxTempTime = new System.Windows.Forms.TextBox();
            this.tbMinTempTime = new System.Windows.Forms.TextBox();
            this.tbMinTempName = new System.Windows.Forms.TextBox();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.tbDateTimeName = new System.Windows.Forms.TextBox();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.tbTempListName = new System.Windows.Forms.TextBox();
            this.tbTempList = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviationFromNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.tbReportName = new System.Windows.Forms.TextBox();
            this.btnLoadTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFish
            // 
            this.tbFish.Location = new System.Drawing.Point(114, 37);
            this.tbFish.Name = "tbFish";
            this.tbFish.Size = new System.Drawing.Size(114, 23);
            this.tbFish.TabIndex = 0;
            // 
            // tbKindOfFish
            // 
            this.tbKindOfFish.Location = new System.Drawing.Point(33, 37);
            this.tbKindOfFish.Name = "tbKindOfFish";
            this.tbKindOfFish.ReadOnly = true;
            this.tbKindOfFish.Size = new System.Drawing.Size(82, 23);
            this.tbKindOfFish.TabIndex = 1;
            this.tbKindOfFish.Text = "Вид рыбы";
            // 
            // tbTemperatureName
            // 
            this.tbTemperatureName.Location = new System.Drawing.Point(114, 66);
            this.tbTemperatureName.Name = "tbTemperatureName";
            this.tbTemperatureName.ReadOnly = true;
            this.tbTemperatureName.Size = new System.Drawing.Size(114, 23);
            this.tbTemperatureName.TabIndex = 2;
            this.tbTemperatureName.Text = "Температура";
            this.tbTemperatureName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTemperatureName.TextChanged += new System.EventHandler(this.tbTemperatureName_TextChanged);
            // 
            // tbTimeName
            // 
            this.tbTimeName.Location = new System.Drawing.Point(225, 66);
            this.tbTimeName.Name = "tbTimeName";
            this.tbTimeName.ReadOnly = true;
            this.tbTimeName.Size = new System.Drawing.Size(114, 23);
            this.tbTimeName.TabIndex = 3;
            this.tbTimeName.Text = "Время";
            this.tbTimeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMaxTempName
            // 
            this.tbMaxTempName.Location = new System.Drawing.Point(33, 95);
            this.tbMaxTempName.Name = "tbMaxTempName";
            this.tbMaxTempName.ReadOnly = true;
            this.tbMaxTempName.Size = new System.Drawing.Size(82, 23);
            this.tbMaxTempName.TabIndex = 5;
            this.tbMaxTempName.Text = "Max";
            this.tbMaxTempName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Location = new System.Drawing.Point(114, 95);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(114, 23);
            this.tbMaxTemp.TabIndex = 4;
            // 
            // tbMaxTempTime
            // 
            this.tbMaxTempTime.Location = new System.Drawing.Point(225, 95);
            this.tbMaxTempTime.Name = "tbMaxTempTime";
            this.tbMaxTempTime.Size = new System.Drawing.Size(114, 23);
            this.tbMaxTempTime.TabIndex = 6;
            // 
            // tbMinTempTime
            // 
            this.tbMinTempTime.Location = new System.Drawing.Point(225, 124);
            this.tbMinTempTime.Name = "tbMinTempTime";
            this.tbMinTempTime.Size = new System.Drawing.Size(114, 23);
            this.tbMinTempTime.TabIndex = 9;
            // 
            // tbMinTempName
            // 
            this.tbMinTempName.Location = new System.Drawing.Point(33, 124);
            this.tbMinTempName.Name = "tbMinTempName";
            this.tbMinTempName.ReadOnly = true;
            this.tbMinTempName.Size = new System.Drawing.Size(82, 23);
            this.tbMinTempName.TabIndex = 8;
            this.tbMinTempName.Text = "Min";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Location = new System.Drawing.Point(114, 124);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(114, 23);
            this.tbMinTemp.TabIndex = 7;
            // 
            // tbDateTimeName
            // 
            this.tbDateTimeName.Location = new System.Drawing.Point(33, 153);
            this.tbDateTimeName.Name = "tbDateTimeName";
            this.tbDateTimeName.ReadOnly = true;
            this.tbDateTimeName.Size = new System.Drawing.Size(82, 23);
            this.tbDateTimeName.TabIndex = 11;
            this.tbDateTimeName.Text = "Дата";
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(114, 153);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(114, 23);
            this.tbDateTime.TabIndex = 10;
            // 
            // tbTempListName
            // 
            this.tbTempListName.Location = new System.Drawing.Point(33, 182);
            this.tbTempListName.Name = "tbTempListName";
            this.tbTempListName.ReadOnly = true;
            this.tbTempListName.Size = new System.Drawing.Size(82, 23);
            this.tbTempListName.TabIndex = 13;
            this.tbTempListName.Text = "Температура";
            // 
            // tbTempList
            // 
            this.tbTempList.Location = new System.Drawing.Point(114, 182);
            this.tbTempList.Multiline = true;
            this.tbTempList.Name = "tbTempList";
            this.tbTempList.Size = new System.Drawing.Size(362, 51);
            this.tbTempList.TabIndex = 12;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(33, 275);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(163, 28);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.FactTemp,
            this.NormTemp,
            this.DeviationFromNorm});
            this.dgvReport.Location = new System.Drawing.Point(0, 73);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.Height = 25;
            this.dgvReport.Size = new System.Drawing.Size(445, 320);
            this.dgvReport.TabIndex = 15;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            // 
            // FactTemp
            // 
            this.FactTemp.HeaderText = "Факт";
            this.FactTemp.Name = "FactTemp";
            // 
            // NormTemp
            // 
            this.NormTemp.HeaderText = "Норма";
            this.NormTemp.Name = "NormTemp";
            // 
            // DeviationFromNorm
            // 
            this.DeviationFromNorm.HeaderText = "Отклонение от нормы";
            this.DeviationFromNorm.Name = "DeviationFromNorm";
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.tbReport);
            this.pnlReport.Controls.Add(this.tbReportName);
            this.pnlReport.Controls.Add(this.dgvReport);
            this.pnlReport.Location = new System.Drawing.Point(552, 22);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(445, 393);
            this.pnlReport.TabIndex = 16;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(0, 35);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(445, 40);
            this.tbReport.TabIndex = 17;
            // 
            // tbReportName
            // 
            this.tbReportName.BackColor = System.Drawing.Color.White;
            this.tbReportName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReportName.Location = new System.Drawing.Point(0, 0);
            this.tbReportName.Name = "tbReportName";
            this.tbReportName.ReadOnly = true;
            this.tbReportName.Size = new System.Drawing.Size(445, 39);
            this.tbReportName.TabIndex = 16;
            this.tbReportName.Text = "Отчет";
            // 
            // btnLoadTemp
            // 
            this.btnLoadTemp.Location = new System.Drawing.Point(225, 275);
            this.btnLoadTemp.Name = "btnLoadTemp";
            this.btnLoadTemp.Size = new System.Drawing.Size(158, 28);
            this.btnLoadTemp.TabIndex = 17;
            this.btnLoadTemp.Text = "Загрузить температуру";
            this.btnLoadTemp.UseVisualStyleBackColor = true;
            this.btnLoadTemp.Click += new System.EventHandler(this.btnLoadTemp_Click);
            // 
            // frmMonitoringTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 527);
            this.Controls.Add(this.btnLoadTemp);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.tbTempListName);
            this.Controls.Add(this.tbTempList);
            this.Controls.Add(this.tbDateTimeName);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.tbMinTempTime);
            this.Controls.Add(this.tbMinTempName);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.tbMaxTempTime);
            this.Controls.Add(this.tbMaxTempName);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.tbTimeName);
            this.Controls.Add(this.tbTemperatureName);
            this.Controls.Add(this.tbKindOfFish);
            this.Controls.Add(this.tbFish);
            this.Name = "frmMonitoringTemperature";
            this.Text = "Monitoring temperature app";
            this.Load += new System.EventHandler(this.tbTimeName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFish;
        private System.Windows.Forms.TextBox tbKindOfFish;
        private System.Windows.Forms.TextBox tbTemperatureName;
        private System.Windows.Forms.TextBox tbTimeName;
        private System.Windows.Forms.TextBox tbMaxTempName;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.TextBox tbMaxTempTime;
        private System.Windows.Forms.TextBox tbMinTempTime;
        private System.Windows.Forms.TextBox tbMinTempName;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.TextBox tbDateTimeName;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.TextBox tbTempListName;
        private System.Windows.Forms.TextBox tbTempList;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviationFromNorm;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.TextBox tbReportName;
        private System.Windows.Forms.Button btnLoadTemp;
    }
}

