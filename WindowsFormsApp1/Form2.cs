using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public DateTime startTime { get { if (this.dateTimePicker1.Checked) { return this.dateTimePicker1.Value; } else { return this.dateTimePicker1.Value; } } }
        //public DateTime endTime { get { if (this.dateTimePicker1.Checked) { return this.dateTimePicker2.Value; } else { return this.dateTimePicker2.Value; } } }

        public DateTime startTime;
        public DateTime endTime;
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime = this.dateTimePicker1.Value;
            endTime = this.dateTimePicker2.Value;
            this.Hide();
        }
    }
}
