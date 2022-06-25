//Ziyatdinov Kamil 220 group "Monitoring temperature" 25.06.2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringTemperature
{
    public partial class frmMonitoringTemperature : Form
    {
        public frmMonitoringTemperature()
        {
            InitializeComponent();
        }

        private void tbTemperatureName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTimeName_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadTemp_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();

            load.Filter = "txt files (*.txt)|*.txt";

            if (load.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadTemp(load.FileName);

                    MessageBox.Show("File loaded", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Incorrect file!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTemp(string path)
        {
            using (var reader = new StreamReader(path))
            {
                tbDateTime.Text = reader.ReadLine();
                string s;

                while ((s = reader.ReadLine()) != null)
                {
                    tbTempList.Text = s;
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            tbReport.Text = null;

            if (tbKindOfFish.Text != "" && ((tbMaxTemp.Text != "" && tbMaxTempTime.Text != "") 
                || (tbMinTemp.Text != "" && tbMinTempTime.Text != "")) && tbDateTime.Text != ""
                && tbTempList.Text != "")
            {
                try
                {
                    int maxTemp = int.Parse(tbMaxTemp.Text);
                    int minTemp = int.Parse(tbMinTemp.Text);
                    int maxTempTime = int.Parse(tbMaxTempTime.Text);
                    int minTempTime = int.Parse(tbMinTempTime.Text);
                    int maxTime = 0;
                    int minTime = 0;
                    DateTime time = DateTime.Parse(tbDateTime.Text);
                    int[] temps = ToIntArray(tbTempList.Text);
                    
                    if (minTemp < maxTemp)
                    {
                        for (int i = 0; i < temps.Length; ++i)
                        {
                            if (temps[i] > maxTemp)
                            {
                                maxTime += 10;
                            }

                            if (temps[i] < minTemp)
                            {
                                minTime += 10;
                            }
                        }

                        dgvReport.RowCount = (maxTime + minTime) / 10;

                        if (maxTime > maxTempTime)
                        {
                            tbReport.Text = $"Порог максимальной температуры превышен на {maxTime} минут, ";

                            ReportFilling(temps, maxTemp, time, true, 0);
                        }
                        else
                        {
                            maxTime = 0;
                        }

                        if (minTime > minTempTime)
                        {
                            tbReport.Text += $"Порог минимальной температуры превышен на {minTime} минут";

                            ReportFilling(temps, minTemp, time, false, maxTime / 10);
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Min temperature more than max temperature!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
                catch
                {
                    MessageBox.Show("Invalid input!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Not all fields are filled!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[] ToIntArray(string str)
        {
            string[] array = str.Split();
            int[] tempList = new int[array.Length];

            for (int i = 0; i < array.Length; ++i)
            {
                tempList[i] = int.Parse(array[i]);
            }

            return tempList;
        }

        private void ReportFilling(int[] temps, int normTemp, DateTime time, bool isMaxTemp, int count)
        {
            for (int i = 0; i < temps.Length; ++i)
            {
                if (isMaxTemp)
                {
                    if (temps[i] > normTemp)
                    {
                        StringFilling(temps[i], normTemp, time, count, i);
                        count++;
                    }
                }
                else
                {
                    if (temps[i] < normTemp)
                    {
                        StringFilling(temps[i], normTemp, time, count, i);
                        count++;
                    }
                }
            }
        }

        private void StringFilling(int temp, int normTemp, DateTime time, int count, int i)
        {
            dgvReport.Rows[count].Cells[0].Value = time.AddMinutes((double)i * 10);
            dgvReport.Rows[count].Cells[1].Value = temp;
            dgvReport.Rows[count].Cells[2].Value = normTemp;
            dgvReport.Rows[count].Cells[3].Value = temp - normTemp;
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
           if (dgvReport.Rows[0].Cells[0].Value != null)
           {
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "txt files (*.txt)|*.txt";
                save.FilterIndex = 2;
                save.RestoreDirectory = true;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    SaveReport(save.FileName);

                    MessageBox.Show("File saved", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Report not filled!", "Success!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveReport(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(tbReport.Text);
                writer.WriteLine("Время                Факт Норма Отклонение от нормы");

                for (int i = 0; i < dgvReport.RowCount; ++i)
                {
                    writer.WriteLine(StringFormatting(i));
                }
            }
        }

        private string StringFormatting(int i)
        {
            return $"{dgvReport.Rows[i].Cells[0].Value}   {dgvReport.Rows[i].Cells[1].Value}   " +
                $"{dgvReport.Rows[i].Cells[2].Value}     {dgvReport.Rows[i].Cells[3].Value}";
        }
    }
   

}
