using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personal_Project1.MinWon {
    public partial class Printer : Form {
        public Printer() {
            InitializeComponent();
        }
        public Printer(string text) {
            InitializeComponent();
            this.text = text;
        }
        string text;

        private void timer1_Tick(object sender, EventArgs e) {
            progressBar1.Value += 1;
            if(progressBar1.Value >= progressBar1.Maximum) {
                timer1.Stop();
                this.Dispose();
            }
        }

        private void Printer_Load(object sender, EventArgs e) {
            textBox1.Text = text + " 결제를 진행해 주세요.";
            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
