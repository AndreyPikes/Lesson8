using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {
        private TrueFalse database;

        public Main()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetReadyToWorkWithBase()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            cbTrue.Enabled = true;
            nudNumber.Enabled = true;
        }

        private void UpdateQuestionData()
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            lblQuestionCount.Text = nudNumber.Maximum.ToString();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("Земля круглая?", true);
                database.Save();
                nudNumber.Maximum = 1;
                nudNumber.Minimum = 1;
                nudNumber.Value = 1;
                GetReadyToWorkWithBase();
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();

                if (database.Count != 0)
                {
                    nudNumber.Maximum = database.Count;
                    nudNumber.Minimum = 1;
                    nudNumber.Value = 1;
                    GetReadyToWorkWithBase();
                }
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateQuestionData();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.Add($"#{database.Count + 1}", true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database.Count > 1)
            {
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Value = 1;
                nudNumber.Maximum = database.Count;
                UpdateQuestionData();
            }
            else MessageBox.Show("Вы не можете удалить последний вопрос!", "Внимание!", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(saveFileDialog.FileName);
            }
        }
    }
}
