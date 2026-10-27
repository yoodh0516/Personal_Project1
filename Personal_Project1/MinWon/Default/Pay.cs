using System.Diagnostics;

namespace Personal_Project1.MinWon {
    public partial class Pay : Form {
        public Pay() {
            InitializeComponent();
        }
        public Pay(string info, Form1 form1, PrintPage printPage) {
            InitializeComponent();
            this.info = info;
            this.form1 = form1;
            this.printPage = printPage;
        }

        string info;
        Form1 form1;
        PrintPage printPage;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0) {
                listBox1.Items.Add("일시불");
                listBox1.Items.Add("3개월 할부");
                listBox1.Items.Add("6개월 할부");
                listBox1.SelectedIndex = 0;
            } else if (comboBox1.SelectedIndex == 1) {
                listBox1.Items.Add("N페이");
                listBox1.Items.Add("해피페이");
                listBox1.Items.Add("주유페이");
                listBox1.SelectedIndex = 0;
            } else if (comboBox1.SelectedIndex == 2) {
                listBox1.Items.Add("현금 결제");
                listBox1.SelectedIndex = 0;
            }
        }

        private void Payment_Click(object sender, EventArgs e) {
            Printer printer = new Printer(comboBox1.Text);

            if (comboBox1.Text == "") {
                MessageBox.Show("결제 수단을 선택하세요.");
            } else if (lbNumber.Text == "-") {
                MessageBox.Show("출력하는 장수를 선택하세요");
            } else {
                printer.ShowDialog();
                if (form1.SelectMenu == 0) {
                    for (int i = 1; i <= int.Parse(lbNumber.Text); i++) {
                        string folderPath = @"C:\MINWON";
                        string fileName = $"DeungBon{i}.txt";
                        string filePath = Path.Combine(folderPath, fileName);
                        if (!Directory.Exists(folderPath)) {
                            Directory.CreateDirectory(folderPath);
                        }
                        File.WriteAllText(filePath, info);
                    }
                    MessageBox.Show("출력이 완료 되었습니다.", "출력 완료");
                    form1.Show();
                    Close();
                } else if (form1.SelectMenu == 1) {
                    for (int i = 1; i <= int.Parse(lbNumber.Text); i++) {
                        string folderPath = @"C:\MINWON";
                        string fileName = $"FamilyRelation{i}.txt";
                        string filePath = Path.Combine(folderPath, fileName);
                        if (!Directory.Exists(folderPath)) {
                            Directory.CreateDirectory(folderPath);
                        }
                        File.WriteAllText(filePath, info);
                    }
                    MessageBox.Show("출력이 완료 되었습니다.", "출력 완료");
                    form1.Show();
                    Close();
                }

            }
        }
        private void btnBack_Click(object sender, EventArgs e) {
            printPage.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            close();
        }
        private void close() {
            if (form1.SelectMenu == 0) {
                printPage.jumin.identity.Close();
                printPage.jumin.Close();
                printPage.Close();
                form1.Show();
                this.Close();
            } else if (form1.SelectMenu == 1) {
                printPage.family.identity.Close();
                printPage.family.Close();
                printPage.Close();
                form1.Show();
                this.Close();
            } else {
                MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
            }
        }

        int DeungB_price = 300;
        int FamilyR_price = 500;
        byte page_count = 1;
        private void page_count_pluse_Click(object sender, EventArgs e) {
            if (page_count < 9) {
                page_count++;
                lbNumber.Text = page_count.ToString();
                if (form1.SelectMenu == 0) {
                    lb_price.Text = $"총 결제 금액 : {DeungB_price * page_count} 원";
                } else if (form1.SelectMenu == 1) {
                    lb_price.Text = $"총 결제 금액 : {FamilyR_price * page_count} 원";
                } else {
                    MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
                }
            } else {
                MessageBox.Show("출력 부수 선택은 1 ~ 9 까지만 선택 가능합니다.");
            }
        }

        private void page_count_minuse_Click(object sender, EventArgs e) {
            if (page_count > 1) {
                page_count--;
                lbNumber.Text = page_count.ToString();
                if (form1.SelectMenu == 0) {
                    lb_price.Text = $"총 결제 금액 : {DeungB_price * page_count} 원";
                } else if (form1.SelectMenu == 1) {
                    lb_price.Text = $"총 결제 금액 : {FamilyR_price * page_count} 원";
                } else {
                    MessageBox.Show("예상치 못한 오류가 발생 했습니다.\n메뉴 선택 오류", "오류");
                }
            } else {
                MessageBox.Show("출력 부수 선택은 1 ~ 9 까지만 선택 가능합니다.");
            }
        }

        private void Pay_Load(object sender, EventArgs e) {
            if (form1.SelectMenu == 0) {
                lb_price.Text = $"총 결제 금액 : {DeungB_price} 원";
            } else if (form1.SelectMenu == 1) {
                lb_price.Text = $"총 결제 금액 : {FamilyR_price} 원";
            } else {
                lb_price.Text = $"총 결제 금액 : - 원";
            }
        }
    }
}
