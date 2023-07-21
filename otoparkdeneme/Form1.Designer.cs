namespace otoparkdeneme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtboxKapasite = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnİade = new System.Windows.Forms.Button();
            this.btnSatış = new System.Windows.Forms.Button();
            this.chkboxStandarmı = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKapasite = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSonuç = new System.Windows.Forms.Label();
            this.btnOlutur = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otopark Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otopark Kapasite";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Location = new System.Drawing.Point(275, 19);
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(277, 27);
            this.txtBoxAd.TabIndex = 2;
            // 
            // txtboxKapasite
            // 
            this.txtboxKapasite.Location = new System.Drawing.Point(275, 97);
            this.txtboxKapasite.Name = "txtboxKapasite";
            this.txtboxKapasite.Size = new System.Drawing.Size(277, 27);
            this.txtboxKapasite.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnİade);
            this.groupBox1.Controls.Add(this.btnSatış);
            this.groupBox1.Controls.Add(this.chkboxStandarmı);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İade";
            // 
            // btnİade
            // 
            this.btnİade.Enabled = false;
            this.btnİade.Location = new System.Drawing.Point(206, 97);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(172, 74);
            this.btnİade.TabIndex = 7;
            this.btnİade.Text = "İade";
            this.btnİade.UseVisualStyleBackColor = true;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            // 
            // btnSatış
            // 
            this.btnSatış.Enabled = false;
            this.btnSatış.Location = new System.Drawing.Point(18, 97);
            this.btnSatış.Name = "btnSatış";
            this.btnSatış.Size = new System.Drawing.Size(172, 74);
            this.btnSatış.TabIndex = 6;
            this.btnSatış.Text = "Satış";
            this.btnSatış.UseVisualStyleBackColor = true;
            this.btnSatış.Click += new System.EventHandler(this.btnSatış_Click);
            // 
            // chkboxStandarmı
            // 
            this.chkboxStandarmı.AutoSize = true;
            this.chkboxStandarmı.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkboxStandarmı.Location = new System.Drawing.Point(18, 46);
            this.chkboxStandarmı.Name = "chkboxStandarmı";
            this.chkboxStandarmı.Size = new System.Drawing.Size(149, 35);
            this.chkboxStandarmı.TabIndex = 6;
            this.chkboxStandarmı.Text = "StandartMı";
            this.chkboxStandarmı.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKapasite);
            this.groupBox2.Controls.Add(this.btnBakiye);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(472, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgi";
            // 
            // btnKapasite
            // 
            this.btnKapasite.Enabled = false;
            this.btnKapasite.Location = new System.Drawing.Point(196, 97);
            this.btnKapasite.Name = "btnKapasite";
            this.btnKapasite.Size = new System.Drawing.Size(172, 74);
            this.btnKapasite.TabIndex = 9;
            this.btnKapasite.Text = "Kapasite";
            this.btnKapasite.UseVisualStyleBackColor = true;
            this.btnKapasite.Click += new System.EventHandler(this.btnKapasite_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.Enabled = false;
            this.btnBakiye.Location = new System.Drawing.Point(18, 97);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(172, 74);
            this.btnBakiye.TabIndex = 8;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSonuç);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(164, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 131);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sonuç";
            // 
            // lblSonuç
            // 
            this.lblSonuç.AutoSize = true;
            this.lblSonuç.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuç.Location = new System.Drawing.Point(63, 65);
            this.lblSonuç.Name = "lblSonuç";
            this.lblSonuç.Size = new System.Drawing.Size(0, 41);
            this.lblSonuç.TabIndex = 11;
            // 
            // btnOlutur
            // 
            this.btnOlutur.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOlutur.Location = new System.Drawing.Point(591, 38);
            this.btnOlutur.Name = "btnOlutur";
            this.btnOlutur.Size = new System.Drawing.Size(172, 95);
            this.btnOlutur.TabIndex = 10;
            this.btnOlutur.Text = "Otopark Oluştur";
            this.btnOlutur.UseVisualStyleBackColor = true;
            this.btnOlutur.Click += new System.EventHandler(this.btnOlutur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 521);
            this.Controls.Add(this.btnOlutur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxKapasite);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxAd;
        private TextBox txtboxKapasite;
        private GroupBox groupBox1;
        private Button btnİade;
        private Button btnSatış;
        private CheckBox chkboxStandarmı;
        private GroupBox groupBox2;
        private Button btnKapasite;
        private Button btnBakiye;
        private GroupBox groupBox3;
        private Label lblSonuç;
        private Button btnOlutur;
    }
}