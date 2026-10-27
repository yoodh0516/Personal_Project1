using System.Security.Principal;

namespace Personal_Project1 {
    public partial class Identity : Form {
        public Identity() {
            InitializeComponent();
        }
        public Identity(Form1 form1) {
            InitializeComponent();
            this.form1 = form1;
        }
        Form1 form1;
        public Jumin jumin;
        public Family family;

        private void btnNext_Click(object sender, EventArgs e) {
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 7) {
                string jumin_num = textBox1.Text + "-" + textBox2.Text;

                if(form1.SelectMenu == 0) {
                    jumin = new Jumin(jumin_num, form1, this);
                    jumin.StartPosition = FormStartPosition.Manual;
                    jumin.Location = this.Location;
                    jumin.Show();
                    this.Hide();
                } else if (form1.SelectMenu == 1) {
                    family = new Family(jumin_num, form1, this);
                    family.StartPosition = FormStartPosition.Manual;
                    family.Location = this.Location;
                    family.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
                    this.Close();
                }
            } else {
                MessageBox.Show("주민번호를 다시 입력해주세요.", "오류");
            }
        }
        private void btnBack_Click(object sender, EventArgs e) {
            form1.Show();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e) {
            form1.Show();
            this.Close();
        }

        private void num_insert(byte num) {
            if (textBox1.TextLength < 6) {
                textBox1.Text += num.ToString();
            } else if (textBox2.TextLength < 7) {
                textBox2.Text += num.ToString();
            }
        }
        private void num1_Click(object sender, EventArgs e) {
            num_insert(1);
        }
        private void num2_Click(object sender, EventArgs e) {
            num_insert(2);
        }
        private void num3_Click(object sender, EventArgs e) {
            num_insert(3);
        }
        private void num4_Click(object sender, EventArgs e) {
            num_insert(4);
        }
        private void num5_Click(object sender, EventArgs e) {
            num_insert(5);
        }
        private void num6_Click(object sender, EventArgs e) {
            num_insert(6);
        }
        private void num7_Click(object sender, EventArgs e) {
            num_insert(7);
        }
        private void num8_Click(object sender, EventArgs e) {
            num_insert(8);
        }
        private void num9_Click(object sender, EventArgs e) {
            num_insert(9);
        }
        private void num0_Click(object sender, EventArgs e) {
            num_insert(0);
        }
        private void backSpace_Click(object sender, EventArgs e) {
            if (textBox2.TextLength > 0)
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            else if (textBox1.TextLength > 0) {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void delete_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
