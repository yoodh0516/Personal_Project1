namespace Personal_Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            jumin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // jumin
            // 
            jumin.BackColor = Color.DodgerBlue;
            jumin.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            jumin.ForeColor = Color.White;
            jumin.Location = new Point(217, 258);
            jumin.Margin = new Padding(2);
            jumin.Name = "jumin";
            jumin.Size = new Size(400, 150);
            jumin.TabIndex = 0;
            jumin.Text = "주민등록표 등본 발급";
            jumin.UseVisualStyleBackColor = false;
            jumin.Click += jumin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 40);
            label1.Name = "label1";
            label1.Size = new Size(463, 65);
            label1.TabIndex = 1;
            label1.Text = "무인 민원 발급 창구";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(185, 186);
            label2.Name = "label2";
            label2.Size = new Size(464, 37);
            label2.TabIndex = 2;
            label2.Text = "원하시는 발급 서류를 터치해 주세요.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(273, 731);
            label3.Name = "label3";
            label3.Size = new Size(288, 21);
            label3.TabIndex = 3;
            label3.Text = "본 기기는 테스트용 시뮬레이터입니다.";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(217, 413);
            button1.Name = "button1";
            button1.Size = new Size(400, 150);
            button1.TabIndex = 4;
            button1.Text = "가족관계증명서 발급";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 761);
            Controls.Add(button1);
            Controls.Add(jumin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button jumin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
