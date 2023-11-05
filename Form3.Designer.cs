namespace kutuphane
{
    partial class emn_vr_frm
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
            emanet_edilebilir_kitaplar = new ListBox();
            ktp_ad_emn = new TextBox();
            label1 = new Label();
            emn_vr_ara_btn = new Button();
            ktb_brk_lb = new Label();
            brk_no_txt = new TextBox();
            hrf_lbl = new Label();
            hrf_ara_txt = new TextBox();
            SuspendLayout();
            // 
            // emanet_edilebilir_kitaplar
            // 
            emanet_edilebilir_kitaplar.FormattingEnabled = true;
            emanet_edilebilir_kitaplar.ItemHeight = 20;
            emanet_edilebilir_kitaplar.Location = new Point(350, 63);
            emanet_edilebilir_kitaplar.Name = "emanet_edilebilir_kitaplar";
            emanet_edilebilir_kitaplar.Size = new Size(443, 424);
            emanet_edilebilir_kitaplar.TabIndex = 0;
            // 
            // ktp_ad_emn
            // 
            ktp_ad_emn.Location = new Point(175, 63);
            ktp_ad_emn.Name = "ktp_ad_emn";
            ktp_ad_emn.Size = new Size(157, 27);
            ktp_ad_emn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 70);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Kitabın adı";
            // 
            // emn_vr_ara_btn
            // 
            emn_vr_ara_btn.Location = new Point(175, 350);
            emn_vr_ara_btn.Name = "emn_vr_ara_btn";
            emn_vr_ara_btn.Size = new Size(94, 29);
            emn_vr_ara_btn.TabIndex = 3;
            emn_vr_ara_btn.Text = "ARA";
            emn_vr_ara_btn.UseVisualStyleBackColor = true;
            // 
            // ktb_brk_lb
            // 
            ktb_brk_lb.AutoSize = true;
            ktb_brk_lb.Location = new Point(45, 157);
            ktb_brk_lb.Name = "ktb_brk_lb";
            ktb_brk_lb.Size = new Size(115, 20);
            ktb_brk_lb.TabIndex = 5;
            ktb_brk_lb.Text = "Kitabın barkodu";
            // 
            // brk_no_txt
            // 
            brk_no_txt.Location = new Point(175, 150);
            brk_no_txt.Name = "brk_no_txt";
            brk_no_txt.Size = new Size(157, 27);
            brk_no_txt.TabIndex = 4;
            // 
            // hrf_lbl
            // 
            hrf_lbl.AutoSize = true;
            hrf_lbl.Location = new Point(63, 233);
            hrf_lbl.Name = "hrf_lbl";
            hrf_lbl.Size = new Size(97, 20);
            hrf_lbl.TabIndex = 7;
            hrf_lbl.Text = "Harf ile sırala";
            // 
            // hrf_ara_txt
            // 
            hrf_ara_txt.Location = new Point(175, 230);
            hrf_ara_txt.Name = "hrf_ara_txt";
            hrf_ara_txt.Size = new Size(157, 27);
            hrf_ara_txt.TabIndex = 6;
            hrf_ara_txt.TextChanged += textBox1_TextChanged;
            // 
            // emn_vr_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 495);
            Controls.Add(hrf_lbl);
            Controls.Add(hrf_ara_txt);
            Controls.Add(ktb_brk_lb);
            Controls.Add(brk_no_txt);
            Controls.Add(emn_vr_ara_btn);
            Controls.Add(label1);
            Controls.Add(ktp_ad_emn);
            Controls.Add(emanet_edilebilir_kitaplar);
            Name = "emn_vr_frm";
            Text = "emanet ver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox emanet_edilebilir_kitaplar;
        private TextBox ktp_ad_emn;
        private Label label1;
        private Button emn_vr_ara_btn;
        private Label ktb_brk_lb;
        private TextBox brk_no_txt;
        private Label hrf_lbl;
        private TextBox hrf_ara_txt;
    }
}