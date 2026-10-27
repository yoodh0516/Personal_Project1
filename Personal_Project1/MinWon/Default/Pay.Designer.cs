namespace Personal_Project1.MinWon {
    partial class Pay {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label3 = new Label();
            Payment = new Button();
            btnHome = new Button();
            btnBack = new Button();
            lbNumber = new Label();
            page_count_minuse = new Button();
            page_count_pluse = new Button();
            label4 = new Label();
            lb_price = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 218);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "결제방법";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(480, 218);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 0;
            label2.Text = "결제 세부";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "신용/체크카드", "모바일 페이", "현금" });
            comboBox1.Location = new Point(120, 250);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 45);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(480, 250);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 115);
            listBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(120, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 5;
            label3.Text = "출력 부수 선택";
            // 
            // Payment
            // 
            Payment.BackColor = Color.Chartreuse;
            Payment.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Payment.Location = new Point(573, 680);
            Payment.Margin = new Padding(2);
            Payment.Name = "Payment";
            Payment.Size = new Size(250, 90);
            Payment.TabIndex = 7;
            Payment.Text = "결제";
            Payment.UseVisualStyleBackColor = false;
            Payment.Click += Payment_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(11, 680);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 90);
            btnHome.TabIndex = 12;
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
            btnBack.TabIndex = 10;
            btnBack.Text = "뒤로가기";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbNumber
            // 
            lbNumber.AutoSize = true;
            lbNumber.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumber.Location = new Point(206, 137);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(32, 37);
            lbNumber.TabIndex = 13;
            lbNumber.Text = "1";
            // 
            // page_count_minuse
            // 
            page_count_minuse.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            page_count_minuse.Location = new Point(120, 120);
            page_count_minuse.Name = "page_count_minuse";
            page_count_minuse.Size = new Size(80, 70);
            page_count_minuse.TabIndex = 14;
            page_count_minuse.Text = "[ - ]";
            page_count_minuse.UseVisualStyleBackColor = true;
            page_count_minuse.Click += page_count_minuse_Click;
            // 
            // page_count_pluse
            // 
            page_count_pluse.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            page_count_pluse.Location = new Point(244, 120);
            page_count_pluse.Name = "page_count_pluse";
            page_count_pluse.Size = new Size(80, 70);
            page_count_pluse.TabIndex = 15;
            page_count_pluse.Text = "[ + ]";
            page_count_pluse.UseVisualStyleBackColor = true;
            page_count_pluse.Click += page_count_pluse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(173, 9);
            label4.Name = "label4";
            label4.Size = new Size(488, 45);
            label4.TabIndex = 16;
            label4.Text = "결제 상세 내역을 확인해 주세요.";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.BackColor = Color.Transparent;
            lb_price.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_price.Location = new Point(226, 550);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(334, 50);
            lb_price.TabIndex = 17;
            lb_price.Text = "총 결제 금액 : - 원";
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 761);
            Controls.Add(lb_price);
            Controls.Add(label4);
            Controls.Add(page_count_pluse);
            Controls.Add(page_count_minuse);
            Controls.Add(lbNumber);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(Payment);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Pay";
            Text = "Pay";
            Load += Pay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label3;
        private Button Payment;
        private Button btnHome;
        private Button btnBack;
        private Label lbNumber;
        private Button page_count_minuse;
        private Button page_count_pluse;
        private Label label4;
        private Label lb_price;
    }
}