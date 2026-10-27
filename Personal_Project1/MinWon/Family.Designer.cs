namespace Personal_Project1 {
    partial class Family {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Family));
            family_Relation_Nomal = new Button();
            family_Relation_Detail = new Button();
            jumin_Num_Show = new Button();
            jumin_num_Hide = new Button();
            btnHome = new Button();
            btnBack = new Button();
            btnNext = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // family_Relation_Nomal
            // 
            family_Relation_Nomal.BackColor = Color.White;
            family_Relation_Nomal.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            family_Relation_Nomal.ForeColor = SystemColors.ControlText;
            family_Relation_Nomal.Location = new Point(114, 234);
            family_Relation_Nomal.Name = "family_Relation_Nomal";
            family_Relation_Nomal.Size = new Size(300, 120);
            family_Relation_Nomal.TabIndex = 0;
            family_Relation_Nomal.Text = "가족관계 증명서(일반)";
            family_Relation_Nomal.UseVisualStyleBackColor = false;
            family_Relation_Nomal.Click += family_Relation_Nomal_Click;
            // 
            // family_Relation_Detail
            // 
            family_Relation_Detail.BackColor = Color.White;
            family_Relation_Detail.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            family_Relation_Detail.Location = new Point(420, 234);
            family_Relation_Detail.Name = "family_Relation_Detail";
            family_Relation_Detail.Size = new Size(300, 120);
            family_Relation_Detail.TabIndex = 1;
            family_Relation_Detail.Text = "가족관계 증명서(상세)";
            family_Relation_Detail.UseVisualStyleBackColor = false;
            family_Relation_Detail.Click += family_Relation_Detail_Click;
            // 
            // jumin_Num_Show
            // 
            jumin_Num_Show.BackColor = Color.White;
            jumin_Num_Show.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            jumin_Num_Show.Location = new Point(114, 454);
            jumin_Num_Show.Name = "jumin_Num_Show";
            jumin_Num_Show.Size = new Size(300, 120);
            jumin_Num_Show.TabIndex = 2;
            jumin_Num_Show.Text = "주민등록번호\r\n전체 공개";
            jumin_Num_Show.UseVisualStyleBackColor = false;
            jumin_Num_Show.Click += jumin_Num_Show_Click;
            // 
            // jumin_num_Hide
            // 
            jumin_num_Hide.BackColor = Color.White;
            jumin_num_Hide.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            jumin_num_Hide.Location = new Point(420, 454);
            jumin_num_Hide.Name = "jumin_num_Hide";
            jumin_num_Hide.Size = new Size(300, 120);
            jumin_num_Hide.TabIndex = 3;
            jumin_num_Hide.Text = "주민등록번호\r\n뒷자리 비공개";
            jumin_num_Hide.UseVisualStyleBackColor = false;
            jumin_num_Hide.Click += jumin_num_Hide_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(11, 680);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 90);
            btnHome.TabIndex = 7;
            btnHome.Text = "홈으로";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(292, 680);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(250, 90);
            btnBack.TabIndex = 8;
            btnBack.Text = "뒤로가기";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Chartreuse;
            btnNext.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(573, 680);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(250, 90);
            btnNext.TabIndex = 9;
            btnNext.Text = "확인";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(691, 45);
            label1.TabIndex = 10;
            label1.Text = "원하시는 증명서 종류와 옵션을 선택해 주세요.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(114, 186);
            label2.Name = "label2";
            label2.Size = new Size(276, 37);
            label2.TabIndex = 11;
            label2.Text = "[1. 증명서 종류 선택]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(114, 406);
            label3.Name = "label3";
            label3.Size = new Size(357, 37);
            label3.TabIndex = 12;
            label3.Text = "[2. 주민등록번호 공개 여부]";
            // 
            // Family
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 761);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(jumin_num_Hide);
            Controls.Add(jumin_Num_Show);
            Controls.Add(family_Relation_Detail);
            Controls.Add(family_Relation_Nomal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Family";
            Text = "Family";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button family_Relation_Nomal;
        private Button family_Relation_Detail;
        private Button jumin_Num_Show;
        private Button jumin_num_Hide;
        private Button btnHome;
        private Button btnBack;
        private Button btnNext;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}