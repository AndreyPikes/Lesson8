using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8_Tasks1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxCopyData.Text = numericUpDownData.Value.ToString();

            Type typeDateTime = typeof(DateTime);
            PropertyInfo[] propertyInfoDateTime = typeDateTime.GetProperties();

            foreach (var e in propertyInfoDateTime)
            {
                tbxDataTime.Text += $"- {e.Name} {Environment.NewLine}";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tbxCopyData.Text = numericUpDownData.Value.ToString();
        }
    }
}
