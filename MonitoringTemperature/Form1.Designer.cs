
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
            // frmMonitoringTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
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
    }
}

