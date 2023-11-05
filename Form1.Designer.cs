namespace kutuphane
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            kt_ek = new Button();
            ktp_lis = new Button();
            emn_ver = new Button();
            emn_lis = new Button();
            üye_ekl = new Button();
            üyl_lis = new Button();
            SuspendLayout();
            // 
            // kt_ek
            // 
            kt_ek.Location = new Point(60, 54);
            kt_ek.Name = "kt_ek";
            kt_ek.Size = new Size(218, 135);
            kt_ek.TabIndex = 0;
            kt_ek.Text = "KİTAP EKLE";
            kt_ek.UseVisualStyleBackColor = true;
            kt_ek.Click += kt_ek_Click;
            // 
            // ktp_lis
            // 
            ktp_lis.Location = new Point(60, 254);
            ktp_lis.Name = "ktp_lis";
            ktp_lis.Size = new Size(218, 135);
            ktp_lis.TabIndex = 1;
            ktp_lis.Text = "KİTAPLARI LİSTELE";
            ktp_lis.UseVisualStyleBackColor = true;
            // 
            // emn_ver
            // 
            emn_ver.BackColor = SystemColors.ButtonHighlight;
            emn_ver.Location = new Point(358, 54);
            emn_ver.Name = "emn_ver";
            emn_ver.Size = new Size(218, 135);
            emn_ver.TabIndex = 2;
            emn_ver.Text = "EMANET VER";
            emn_ver.UseVisualStyleBackColor = false;
            // 
            // emn_lis
            // 
            emn_lis.Location = new Point(358, 254);
            emn_lis.Name = "emn_lis";
            emn_lis.Size = new Size(218, 135);
            emn_lis.TabIndex = 3;
            emn_lis.Text = "EMANETLERİ LİSTELE";
            emn_lis.UseVisualStyleBackColor = true;
            // 
            // üye_ekl
            // 
            üye_ekl.Location = new Point(652, 54);
            üye_ekl.Name = "üye_ekl";
            üye_ekl.Size = new Size(218, 135);
            üye_ekl.TabIndex = 4;
            üye_ekl.Text = "ÜYE EKLE";
            üye_ekl.UseVisualStyleBackColor = true;
            üye_ekl.Click += button5_Click;
            // 
            // üyl_lis
            // 
            üyl_lis.Location = new Point(652, 254);
            üyl_lis.Name = "üyl_lis";
            üyl_lis.Size = new Size(218, 135);
            üyl_lis.TabIndex = 5;
            üyl_lis.Text = "ÜYELERİ LİSTELE";
            üyl_lis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 699);
            Controls.Add(üyl_lis);
            Controls.Add(üye_ekl);
            Controls.Add(emn_lis);
            Controls.Add(emn_ver);
            Controls.Add(ktp_lis);
            Controls.Add(kt_ek);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kütüphane";
            ResumeLayout(false);
        }

        #endregion

        private Button kt_ek;
        private Button ktp_lis;
        private Button emn_ver;
        private Button emn_lis;
        private Button üye_ekl;
        private Button üyl_lis;
    }
}