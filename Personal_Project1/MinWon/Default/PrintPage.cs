using System.Drawing.Printing;

namespace Personal_Project1.MinWon {
    public partial class PrintPage : Form {
        public PrintPage() {
            InitializeComponent();
        }
        public PrintPage(string info, Form1 form1, Jumin jumin) {
            InitializeComponent();
            this.info = info;
            this.form1 = form1;
            this.jumin = jumin;
        }
        public PrintPage(string info, Form1 form1, Family family) {
            InitializeComponent();
            this.info = info;
            this.form1 = form1;
            this.family = family;
        }
        string info;
        Form1 form1;
        public Jumin jumin;
        public Family family;

        private void PrintPage_Load(object sender, EventArgs e) {
            textBox1.Text = info;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            Pay pay = new Pay(info, form1, this);
            pay.StartPosition = FormStartPosition.Manual;
            pay.Location = this.Location;
            pay.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            if (form1.SelectMenu == 0) {
                jumin.Show();
                this.Close();
            } else if (form1.SelectMenu == 1) {
                family.Show();
                this.Close();
            } else {
                MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
            }
                
        }

        private void btnHome_Click(object sender, EventArgs e) {
            close();//함수
        }
        private void close() {
            if (form1.SelectMenu == 0) {
                jumin.identity.Close();
                jumin.Close();
                form1.Show();
                this.Close();
            } else if (form1.SelectMenu == 1) {
                family.identity.Close();
                family.Close();
                form1.Show();
                this.Close();
            } else {
                MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
            }
        }
    }
}