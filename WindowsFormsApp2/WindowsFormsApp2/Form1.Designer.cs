namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btncikarma = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnsifir = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lblislem = new System.Windows.Forms.Label();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btntoplama
            // 
            this.btntoplama.Location = new System.Drawing.Point(240, 101);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(174, 47);
            this.btntoplama.TabIndex = 2;
            this.btntoplama.Text = "+";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btncikarma
            // 
            this.btncikarma.Location = new System.Drawing.Point(424, 101);
            this.btncikarma.Name = "btncikarma";
            this.btncikarma.Size = new System.Drawing.Size(147, 47);
            this.btncikarma.TabIndex = 3;
            this.btncikarma.Text = "-";
            this.btncikarma.UseVisualStyleBackColor = true;
            this.btncikarma.Click += new System.EventHandler(this.btncikarma_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Location = new System.Drawing.Point(424, 227);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(147, 68);
            this.btnbolme.TabIndex = 4;
            this.btnbolme.Text = "/";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(424, 154);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(147, 67);
            this.btncarpma.TabIndex = 5;
            this.btncarpma.Text = "X";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(557, 39);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(14, 16);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "0";
            // 
            // btnsifir
            // 
            this.btnsifir.Location = new System.Drawing.Point(424, 301);
            this.btnsifir.Name = "btnsifir";
            this.btnsifir.Size = new System.Drawing.Size(147, 59);
            this.btnsifir.TabIndex = 7;
            this.btnsifir.Text = "AC";
            this.btnsifir.UseVisualStyleBackColor = true;
            this.btnsifir.Click += new System.EventHandler(this.btnsifir_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(300, 316);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 44);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(364, 260);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 44);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(300, 260);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 44);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(240, 260);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 44);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(364, 210);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 44);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(300, 210);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 44);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(240, 210);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 44);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(364, 160);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 44);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(300, 160);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 44);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(240, 160);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 44);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // lblislem
            // 
            this.lblislem.AutoSize = true;
            this.lblislem.Location = new System.Drawing.Point(619, 39);
            this.lblislem.Name = "lblislem";
            this.lblislem.Size = new System.Drawing.Size(0, 16);
            this.lblislem.TabIndex = 18;
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(578, 301);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(130, 59);
            this.btnsonuc.TabIndex = 19;
            this.btnsonuc.Text = "=";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 494);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.lblislem);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnsifir);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btncikarma);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Button btncikarma;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnsifir;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Label lblislem;
        private System.Windows.Forms.Button btnsonuc;
    }
}

