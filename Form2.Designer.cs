namespace kutuphane
{
    partial class ktp_ekl_form
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
            ktp_ad_kyt_lb = new Label();
            yzr_ad_lb = new Label();
            yay_ev_lb = new Label();
            ktp_tur_lb = new Label();
            ktp_ad_txt = new TextBox();
            yzr_ad_txt = new TextBox();
            yayın_evi_txt = new TextBox();
            ktp_tür_cb = new ComboBox();
            ktp_kyt_btn = new Button();
            gri_btn = new Button();
            SuspendLayout();
            // 
            // ktp_ad_kyt_lb
            // 
            ktp_ad_kyt_lb.AutoSize = true;
            ktp_ad_kyt_lb.Location = new Point(90, 61);
            ktp_ad_kyt_lb.Margin = new Padding(7, 0, 7, 0);
            ktp_ad_kyt_lb.Name = "ktp_ad_kyt_lb";
            ktp_ad_kyt_lb.Size = new Size(170, 46);
            ktp_ad_kyt_lb.TabIndex = 0;
            ktp_ad_kyt_lb.Text = "KİTAP ADI";
            ktp_ad_kyt_lb.Click += label1_Click;
            // 
            // yzr_ad_lb
            // 
            yzr_ad_lb.AutoSize = true;
            yzr_ad_lb.Location = new Point(42, 168);
            yzr_ad_lb.Margin = new Padding(7, 0, 7, 0);
            yzr_ad_lb.Name = "yzr_ad_lb";
            yzr_ad_lb.Size = new Size(218, 46);
            yzr_ad_lb.TabIndex = 1;
            yzr_ad_lb.Text = "YAZARIN ADI";
            // 
            // yay_ev_lb
            // 
            yay_ev_lb.AutoSize = true;
            yay_ev_lb.Location = new Point(655, 59);
            yay_ev_lb.Margin = new Padding(7, 0, 7, 0);
            yay_ev_lb.Name = "yay_ev_lb";
            yay_ev_lb.Size = new Size(174, 46);
            yay_ev_lb.TabIndex = 2;
            yay_ev_lb.Text = "YAYIN EVİ ";
            // 
            // ktp_tur_lb
            // 
            ktp_tur_lb.AutoSize = true;
            ktp_tur_lb.Location = new Point(630, 161);
            ktp_tur_lb.Margin = new Padding(7, 0, 7, 0);
            ktp_tur_lb.Name = "ktp_tur_lb";
            ktp_tur_lb.Size = new Size(199, 46);
            ktp_tur_lb.TabIndex = 3;
            ktp_tur_lb.Text = "KİTAP TÜRÜ";
            // 
            // ktp_ad_txt
            // 
            ktp_ad_txt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ktp_ad_txt.Location = new Point(291, 56);
            ktp_ad_txt.Name = "ktp_ad_txt";
            ktp_ad_txt.Size = new Size(230, 43);
            ktp_ad_txt.TabIndex = 4;
            // 
            // yzr_ad_txt
            // 
            yzr_ad_txt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            yzr_ad_txt.Location = new Point(291, 161);
            yzr_ad_txt.Name = "yzr_ad_txt";
            yzr_ad_txt.Size = new Size(230, 43);
            yzr_ad_txt.TabIndex = 5;
            // 
            // yayın_evi_txt
            // 
            yayın_evi_txt.Location = new Point(871, 56);
            yayın_evi_txt.Name = "yayın_evi_txt";
            yayın_evi_txt.Size = new Size(230, 51);
            yayın_evi_txt.TabIndex = 6;
            // 
            // ktp_tür_cb
            // 
            ktp_tür_cb.FormattingEnabled = true;
            ktp_tür_cb.Items.AddRange(new object[] { "roman", "hikaye", "şiir", "diger" });
            ktp_tür_cb.Location = new Point(871, 161);
            ktp_tür_cb.Name = "ktp_tür_cb";
            ktp_tür_cb.Size = new Size(151, 53);
            ktp_tür_cb.TabIndex = 7;
            // 
            // ktp_kyt_btn
            // 
            ktp_kyt_btn.Location = new Point(630, 269);
            ktp_kyt_btn.Name = "ktp_kyt_btn";
            ktp_kyt_btn.Size = new Size(223, 99);
            ktp_kyt_btn.TabIndex = 8;
            ktp_kyt_btn.Text = "Kaydet";
            ktp_kyt_btn.UseVisualStyleBackColor = true;
            // 
            // gri_btn
            // 
            gri_btn.Location = new Point(330, 269);
            gri_btn.Name = "gri_btn";
            gri_btn.Size = new Size(223, 99);
            gri_btn.TabIndex = 9;
            gri_btn.Text = "Geri git";
            gri_btn.UseVisualStyleBackColor = true;
            // 
            // ktp_ekl_form
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 442);
            Controls.Add(gri_btn);
            Controls.Add(ktp_kyt_btn);
            Controls.Add(ktp_tür_cb);
            Controls.Add(yayın_evi_txt);
            Controls.Add(yzr_ad_txt);
            Controls.Add(ktp_ad_txt);
            Controls.Add(ktp_tur_lb);
            Controls.Add(yay_ev_lb);
            Controls.Add(yzr_ad_lb);
            Controls.Add(ktp_ad_kyt_lb);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 7, 7, 7);
            Name = "ktp_ekl_form";
            Text = "kitap ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ktp_ad_kyt_lb;
        private Label yzr_ad_lb;
        private Label yay_ev_lb;
        private Label ktp_tur_lb;
        private TextBox ktp_ad_txt;
        private TextBox yzr_ad_txt;
        private TextBox yayın_evi_txt;
        private ComboBox ktp_tür_cb;
        private Button ktp_kyt_btn;
        private Button gri_btn;
    }
}