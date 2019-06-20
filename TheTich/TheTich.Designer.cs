namespace TheTich
{
    partial class TheTich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_DonVi = new System.Windows.Forms.ComboBox();
            this.btn_TheTich = new System.Windows.Forms.Button();
            this.txt_TheTich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ChieuCao = new System.Windows.Forms.TextBox();
            this.txt_ChieuRong = new System.Windows.Forms.TextBox();
            this.txt_ChieuDai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.cbx_DonVi);
            this.groupBox1.Controls.Add(this.btn_TheTich);
            this.groupBox1.Controls.Add(this.txt_TheTich);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ChieuCao);
            this.groupBox1.Controls.Add(this.txt_ChieuRong);
            this.groupBox1.Controls.Add(this.txt_ChieuDai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể tích";
            // 
            // cbx_DonVi
            // 
            this.cbx_DonVi.FormattingEnabled = true;
            this.cbx_DonVi.Location = new System.Drawing.Point(375, 88);
            this.cbx_DonVi.Name = "cbx_DonVi";
            this.cbx_DonVi.Size = new System.Drawing.Size(60, 21);
            this.cbx_DonVi.TabIndex = 9;
            // 
            // btn_TheTich
            // 
            this.btn_TheTich.Location = new System.Drawing.Point(239, 222);
            this.btn_TheTich.Name = "btn_TheTich";
            this.btn_TheTich.Size = new System.Drawing.Size(75, 23);
            this.btn_TheTich.TabIndex = 8;
            this.btn_TheTich.Text = "Tính";
            this.btn_TheTich.UseVisualStyleBackColor = true;
            this.btn_TheTich.Click += new System.EventHandler(this.btn_TheTich_Click);
            // 
            // txt_TheTich
            // 
            this.txt_TheTich.Enabled = false;
            this.txt_TheTich.Location = new System.Drawing.Point(139, 177);
            this.txt_TheTich.Name = "txt_TheTich";
            this.txt_TheTich.Size = new System.Drawing.Size(110, 21);
            this.txt_TheTich.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thể tích";
            // 
            // txt_ChieuCao
            // 
            this.txt_ChieuCao.Location = new System.Drawing.Point(139, 130);
            this.txt_ChieuCao.Name = "txt_ChieuCao";
            this.txt_ChieuCao.Size = new System.Drawing.Size(110, 21);
            this.txt_ChieuCao.TabIndex = 5;
            // 
            // txt_ChieuRong
            // 
            this.txt_ChieuRong.Location = new System.Drawing.Point(139, 88);
            this.txt_ChieuRong.Name = "txt_ChieuRong";
            this.txt_ChieuRong.Size = new System.Drawing.Size(110, 21);
            this.txt_ChieuRong.TabIndex = 4;
            // 
            // txt_ChieuDai
            // 
            this.txt_ChieuDai.Location = new System.Drawing.Point(139, 39);
            this.txt_ChieuDai.Name = "txt_ChieuDai";
            this.txt_ChieuDai.Size = new System.Drawing.Size(110, 21);
            this.txt_ChieuDai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chiều cao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều rộng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiều dài";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(333, 222);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đơn vị";
            // 
            // TheTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "TheTich";
            this.Text = "Hình hộp chữ nhật";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TheTich;
        private System.Windows.Forms.TextBox txt_TheTich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ChieuCao;
        private System.Windows.Forms.TextBox txt_ChieuRong;
        private System.Windows.Forms.TextBox txt_ChieuDai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbx_DonVi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label5;
    }
}

