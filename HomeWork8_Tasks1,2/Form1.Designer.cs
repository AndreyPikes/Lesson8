
namespace HomeWork8_Tasks1_2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCopyData = new System.Windows.Forms.TextBox();
            this.numericUpDownData = new System.Windows.Forms.NumericUpDown();
            this.tbxDataTime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxCopyData);
            this.panel1.Controls.Add(this.numericUpDownData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Все свойства структуры DateTime:";
            // 
            // tbxCopyData
            // 
            this.tbxCopyData.Location = new System.Drawing.Point(166, 11);
            this.tbxCopyData.Name = "tbxCopyData";
            this.tbxCopyData.Size = new System.Drawing.Size(195, 23);
            this.tbxCopyData.TabIndex = 1;
            // 
            // numericUpDownData
            // 
            this.numericUpDownData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownData.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownData.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownData.Name = "numericUpDownData";
            this.numericUpDownData.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownData.TabIndex = 0;
            this.numericUpDownData.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbxDataTime
            // 
            this.tbxDataTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDataTime.Location = new System.Drawing.Point(0, 62);
            this.tbxDataTime.Multiline = true;
            this.tbxDataTime.Name = "tbxDataTime";
            this.tbxDataTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDataTime.Size = new System.Drawing.Size(384, 99);
            this.tbxDataTime.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tbxDataTime);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задания 1 и 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownData;
        private System.Windows.Forms.TextBox tbxCopyData;
        private System.Windows.Forms.TextBox tbxDataTime;
        private System.Windows.Forms.Label label1;
    }
}

