using Personal_Project1.MinWon;

namespace Personal_Project1 {
    public partial class Jumin : Form {
        public Jumin() {
            InitializeComponent();
        }
        public Jumin(string jumin_num, Form1 form1, Identity identity) {
            InitializeComponent();
            this.jumin_num = jumin_num;
            this.form1 = form1;
            this.identity = identity;
        }
        string jumin_num;
        Form1 form1;
        public Identity identity;

        string info;

        private void btnNext_Click(object sender, EventArgs e) {
            PrintPage printPage = new PrintPage(DB(), form1, this);
            printPage.StartPosition = FormStartPosition.Manual;
            printPage.Location = this.Location;
            printPage.Show();
            this.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e) {
            identity.Show();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e) {
            close();
        }
        private void close() {
            identity.Close();
            form1.Show();
            this.Close();
        }

        private string DB() {
            List<string> reason = new List<string>();
            List<string> reason2 = new List<string>();
            List<string> address = new List<string>() { "충청남도 천안시 동남구 신부동 456", "충청남도 천안시 서북구 불당대로 123, 101동 202호" };
            List<string> change = new List<string>();
            List<string> jumin = new List<string>();
            List<string> name = new List<string>();
            List<string> relation = new List<string>();
            Random random = new Random();
            string reportInc, roommate;

            //1. 세대 구성 사유
            reason.Add(rdoReasonInc.Checked ? "* 2018.05.10 / 세대 구성 (사유: 혼인)" : "");
            reason.Add(rdoReasonInc.Checked ? "* 2021.08.20 / 전입 (사유: 직장변경)" : "");

            if (rdoChangeInc.Checked) {
                reason2.Add(chkChangeFamily.Checked ? " / 사유: 세대구성" : "");
                reason2.Add(chkChangeMember.Checked ? " / 사유: 혼인합가" : "");
                reason2.Add(chkChangeMember.Checked ? " / 사유: 출생" : "");
                reason2.Add(chkChangeMember.Checked ? " / 사유: 학업" : "");
            } else {
                reason2.Add("");
                reason2.Add("");
                reason2.Add("");
                reason2.Add("");
            }

            reportInc = rdoReportInc.Checked ? "신고일: 2021.08.21" : "";

            if (rdoChangeInc.Checked) {
                change.Add(chkChangeFamily.Checked ? "(사유: 혼인)" : "");
                change.Add(chkChangeMember.Checked ? "(사유: 직장변경)" : "");
            } else {
                change.Add("");
                change.Add("");
            }

            name.Add("홍길동");//본인
            name.Add(rdoNameInc.Checked ? "김영희" : "김*희");
            name.Add(rdoNameInc.Checked ? "홍철수" : "홍*수");
            name.Add(rdoNameInc.Checked ? "이민수" : "이*수");

            if (rdoJuminInc.Checked) {
                jumin.Add(chkJuminFamily.Checked ? (jumin_num) : jumin_num.Split("-")[0] + "-*******");
                jumin.Add(chkJuminMember.Checked ? "2345678" : "*******");
                jumin.Add(chkJuminMember.Checked ? "3456789" : "*******");
                jumin.Add(chkJuminMember.Checked ? "1987654" : "*******");
            } else {
                jumin.Add("*******");
                jumin.Add("*******");
                jumin.Add("*******");
                jumin.Add("*******");
            }

            relation.Add(rdoRelationInc.Checked ? "[본인]" : "[세대주]");
            relation.Add(rdoRelationInc.Checked ? "[배우자]" : "[세대원]");
            relation.Add(rdoRelationInc.Checked ? "[자녀]" : "[세대원]");
            relation.Add(rdoRelationInc.Checked ? "[동거인]" : "[동거인]");

            if (rdoRoommateInc.Checked) {
                roommate = $"4. {relation[3]} {name[3]}\r\n" +
                    $"   - 주민등록번호 : 901212-{jumin[3]}\r\n" +
                    $"   - 등록 상태 : 전입 (발생일: 2025.02.10{reason2[3]})";
            } else {
                roommate = "";
            }//7. 동거인

            info = $@"------------------------------------------------------------------------------
                                주 민 등 록 표 (등 본)                        
------------------------------------------------------------------------------
[발급번호] {DateTime.Now.ToString("yyyy")}-{random.Next(0, 9999):d4}-{random.Next(0, 9999):d4}-{random.Next(0, 9999):d4}
[발급일자] {DateTime.Now.ToString("yyyy년 MM월 dd일")}

■ 세대주 성명 : 홍길동 (洪吉童)
■ 현 주소 : 충청남도 천안시 서북구 불당대로 123, 101동 202호

------------------------------------------------------------------------------
[주소 변동 사항] (세대 구성 사유, 일자, 발생일/신고일, 변동사유 포함)
------------------------------------------------------------------------------

{reason[0]} {change[0]}
  - {address[0]}
{reason[1]} {change[1]}{reportInc}
  - {address[1]}

------------------------------------------------------------------------------
[세대원 정보] (이름, 주민번호 뒷자리, 세대주와의 관계, 동거인 포함)
------------------------------------------------------------------------------
1. {relation[0]} {name[0]}
   - 주민등록번호 : {jumin[0]}
   - 등록 상태 : 거주 (발생일: 1985.01.01{reason2[0]})

2. {relation[1]} {name[1]}
   - 주민등록번호 : 870505-{jumin[1]}
   - 등록 상태 : 전입 (발생일: 2018.05.10{reason2[1]})

3. {relation[2]} {name[2]}
   - 주민등록번호 : 200315-{jumin[2]}
   - 등록 상태 : 출생 (발생일: 2020.03.15{reason2[2]})

{roommate}

------------------------------------------------------------------------------
                        위와 같이 주민등록표 등본을 발급합니다.                  
                                    천 안 시 장 (인)                             
------------------------------------------------------------------------------";

            return info;
        }

        private void allCheckedTrue() {
            rdoReasonInc.Checked = true;
            rdoReportInc.Checked = true;
            rdoChangeInc.Checked = true;
            chkChangeFamily.Checked = true;
            chkChangeMember.Checked = true;
            rdoNameInc.Checked = true;
            rdoJuminInc.Checked = true;
            chkJuminFamily.Checked = true;
            chkJuminMember.Checked = true;
            rdoRelationInc.Checked = true;
            rdoRoommateInc.Checked = true;
        }
        private void allCheckedFalse() {
            rdoReasonExc.Checked = true;
            rdoReportExc.Checked = true;
            rdoChangeExc.Checked = true;
            chkChangeFamily.Checked = false;
            chkChangeMember.Checked = false;
            rdoNameExc.Checked = true;
            rdoJuminExc.Checked = true;
            chkJuminFamily.Checked = false;
            chkJuminMember.Checked = false;
            rdoRelationExc.Checked = true;
            rdoRoommateExc.Checked = true;
        }
        private void rdoChangeExc_CheckedChanged(object sender, EventArgs e) {
            chkChangeFamily.Checked = false;
            chkChangeMember.Checked = false;
        }
        private void rdoJuminExc_CheckedChanged(object sender, EventArgs e) {
            chkJuminFamily.Checked = false;
            chkJuminMember.Checked = false;
        }
        private void rdoChangeInc_CheckedChanged(object sender, EventArgs e) {
            chkChangeFamily.Checked = true;
            chkChangeMember.Checked = true;
        }
        private void rdoJuminInc_CheckedChanged(object sender, EventArgs e) {
            chkJuminFamily.Checked = true;
            chkJuminMember.Checked = true;
        }
        private void btnIncludeAll_Click_1(object sender, EventArgs e) {
            allCheckedTrue();
        }
        private void btnCancelAll_Click_1(object sender, EventArgs e) {
            allCheckedFalse();
        }

        private void btnTypeCourt_Click(object sender, EventArgs e) {
            //법원: 전체포함
            allCheckedTrue();
        }
        private void btnTypeEducation_Click(object sender, EventArgs e) {
            //교육기관: 주민번호 뒷자리, 세대주와의 관계만 포함
            allCheckedFalse();
            rdoJuminInc.Checked = true;
            chkJuminFamily.Checked = true;
            chkJuminMember.Checked = true;
            rdoRelationInc.Checked = true;
        }
        private void btnTypePublic_Click(object sender, EventArgs e) {
            //공공기관: 주민번호 뒷자리, 세대주와의 관계 또는 전체 포함
            allCheckedFalse();
            rdoJuminInc.Checked = true;
            chkJuminFamily.Checked = true;
            chkJuminMember.Checked = true;
            rdoRelationInc.Checked = true;
        }
        private void btnTypeRealEstate_Click(object sender, EventArgs e) {
            //1~4번(주소 변동 및 구성 사유 관련), 6번(주민번호 뒷자리) 포함
            allCheckedTrue();
            rdoNameExc.Checked = true;
            rdoRelationExc.Checked = true;
            rdoRoommateExc.Checked = true;
        }
        private void btnTypeFinance_Click(object sender, EventArgs e) {
            //6번(주민번호 뒷자리)만 포함
            allCheckedFalse();
            rdoJuminInc.Checked = true;
            chkJuminFamily.Checked = true;
            chkJuminMember.Checked = true;
        }

        private void Jumin_Load(object sender, EventArgs e) {
            allCheckedFalse();
        }
    }
}
