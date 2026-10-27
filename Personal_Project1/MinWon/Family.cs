using Personal_Project1.MinWon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project1 {
    public partial class Family : Form {
        public Family() {
            InitializeComponent();
        }
        public Family(string jumin_num, Form1 form1, Identity identity) {
            InitializeComponent();
            this.jumin_num = jumin_num;
            this.form1 = form1;
            this.identity = identity;
        }
        string jumin_num;
        Form1 form1;
        public Identity identity;

        private void btnNext_Click(object sender, EventArgs e) {
            if (family_Relation == 0 || jumin_num_show == 0) {
                MessageBox.Show("출력 유형과 주민번호 표시 여부를 선택하세요.", "오류");
            } else {
                PrintPage printPage = new PrintPage(family_paper(), form1, this);
                printPage.StartPosition = FormStartPosition.Manual;
                printPage.Location = this.Location;
                printPage.Show();
                this.Hide();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e) {
            identity.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e) {
            identity.Close();
            form1.Show();
            this.Close();
        }

        List<string> family_jumin_num = new List<string>();
        private string family_paper() {
            family_jumin_num.Clear();
            family_jumin_num.Add(jumin_num_show == 1 ? jumin_num : jumin_num.Split("-")[0] + "*******");
            family_jumin_num.Add(jumin_num_show == 1 ? "1234567" : "*******");
            family_jumin_num.Add(jumin_num_show == 1 ? "9876543" : "*******");
            family_jumin_num.Add(jumin_num_show == 1 ? "1346792" : "*******");
            family_jumin_num.Add(jumin_num_show == 1 ? "2468135" : "*******");
            string info;

            if (family_Relation == 1) {
                info = $@"------------------------------------------------------------------------------
                            가 족 관 계 증 명 서 (일 반)
------------------------------------------------------------------------------

[등록기준지] 충청남도 천안시 서북구 불당대로 123

------------------------------------------------------------------------------
 구 분  |   성 명   |  출생연월일  | 주민등록번호  | 성별 | 본(Origin)
------------------------------------------------------------------------------
 본 인  | 홍 길 동  |  1980.01.01  | {family_jumin_num[0]} |  남  | 남양(南陽)
 부     | 홍 판 서  |  1950.05.05  | 600826-{family_jumin_num[1]} |  남  | 남양(南陽)
 모     | 김 춘 댁  |  1952.10.10  | 630113-{family_jumin_num[2]} |  여  | 김해(金海)
 배우자 | 성 춘 향  |  1982.03.03  | 870505-{family_jumin_num[3]} |  여  | 창녕(昌寧)
 자 녀  | 홍 길 순  |  2010.07.07  | 200315-{family_jumin_num[4]} |  여  | 남양(南陽)
------------------------------------------------------------------------------

* 가족관계증명서(일반)에는 본인과 부모, 현재의 배우자 및 자녀에 
  관한 특정 필수 정보만 표기됩니다.

                               위와 같이 증명합니다.

                               발급일자 : {DateTime.Now.ToString("yyyy년 MM월 dd일")}
                               천 안 시 서 북 구 청 장  (인)
------------------------------------------------------------------------------";
            } else {
                family_jumin_num.Add(jumin_num_show == 1 ? "3579518" : "*******");
                info = $@"------------------------------------------------------------------------------
                            가 족 관 계 증 명 서(상 세)
------------------------------------------------------------------------------

[등록기준지] 충청남도 천안시 서북구 불당대로 123

------------------------------------------------------------------------------
 구 분  |   성 명   |  출생연월일  | 주민등록번호  | 성별 | 본(Origin)
------------------------------------------------------------------------------
 본 인  | 홍 길 동  |  1980.01.01  | {family_jumin_num[0]} |  남  | 남양(南陽)
  - [상세사항] 2010.05.05 배우자 성춘향과 혼인신고
  - [상세사항] 2008.12.12 전배우자(이몽룡)와 이혼신고 

 부     | 홍 판 서  |  1950.05.05  | 600826-{family_jumin_num[1]} |  남  | 남양(南陽)
 모     | 김 춘 댁  |  1952.10.10  | 630113-{family_jumin_num[2]} |  여  | 김해(金海)
 배우자 | 성 춘 향  |  1982.03.03  | 870505-{family_jumin_num[3]} |  여  | 창녕(昌寧)
 자 녀  | 홍 길 순  |  2010.07.07  | 200315-{family_jumin_num[4]} |  여  | 남양(南陽)
 자 녀  | 홍 몽 룡  |  2005.08.08  | 150830-{family_jumin_num[5]} |  남  | 남양(南陽)
  - [상세사항] 전배우자와의 관계에서 출생
------------------------------------------------------------------------------

* 가족관계증명서(상세)에는 혼인/이혼, 입양/파양 등 가족관계등록부에 
  기록된 모든 상세 변동 이력이 포함되어 표기됩니다.

                               위와 같이 증명합니다.

                               발급일자 : {DateTime.Now.ToString("yyyy년 MM월 dd일")}
                               천 안 시 서 북 구 청 장  (인)
------------------------------------------------------------------------------";
            }
            return info;
        }

        byte family_Relation = 0; //1 = 일반, 2 = 상세
        byte jumin_num_show = 0; //1 = 전체 공개, 2 = 뒷자리 숨김
        private void family_Relation_Nomal_Click(object sender, EventArgs e) {
            family_Relation = 1;
            family_Relation_Nomal.BackColor = Color.Chartreuse;
            family_Relation_Detail.BackColor = Color.White;
        }
        private void family_Relation_Detail_Click(object sender, EventArgs e) {
            family_Relation = 2;
            family_Relation_Detail.BackColor = Color.Chartreuse;
            family_Relation_Nomal.BackColor = Color.White;
        }
        private void jumin_Num_Show_Click(object sender, EventArgs e) {
            jumin_num_show = 1;
            jumin_Num_Show.BackColor = Color.Chartreuse;
            jumin_num_Hide.BackColor = Color.White;
        }
        private void jumin_num_Hide_Click(object sender, EventArgs e) {
            jumin_num_show = 2;
            jumin_num_Hide.BackColor = Color.Chartreuse;
            jumin_Num_Show.BackColor = Color.White;
        }
    }
}
