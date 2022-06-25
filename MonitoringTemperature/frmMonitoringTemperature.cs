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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
