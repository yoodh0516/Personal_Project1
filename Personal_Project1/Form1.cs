using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personal_Project1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private byte menu;
        public byte SelectMenu { get { return menu; } }

        private void jumin_Click(object sender, EventArgs e) {
            menu = 0;
            identity_verification();
        }
        private void button1_Click(object sender, EventArgs e) {
            menu = 1;
            identity_verification();
        }

        private void identity_verification() {
            Identity identity = new Identity(this);
            identity.StartPosition = FormStartPosition.Manual;
            identity.Location = this.Location;
            this.Hide();
            identity.Show();
        }
    }
}
