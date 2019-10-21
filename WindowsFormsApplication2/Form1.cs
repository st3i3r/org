using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel.Contains(Home.Instance))
            {
                panel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
                Home.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel.Contains(Sale.Instance))
            {
                panel.Controls.Add(Sale.Instance);
                Sale.Instance.Dock = DockStyle.Fill;
                Sale.Instance.BringToFront();
            }
            else
                Sale.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Controls.Add(Home.Instance);
            Home.Instance.Dock = DockStyle.Fill;
            Home.Instance.BringToFront();
        }
    }
}
