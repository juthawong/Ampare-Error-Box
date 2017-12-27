using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampare_Error_Box
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {

                Application.Exit();
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
}
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
            MessageBox.Show(textBox2.Text, textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            timer1.Interval = random.Next(1, 260) * 700;
            MessageBox.Show(textBox2.Text, textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
