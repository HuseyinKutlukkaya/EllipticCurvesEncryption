namespace EliptikEğriler
{
    partial class Form1
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
            this.btn_coz = new System.Windows.Forms.Button();
            this.tbAnahtar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCozulmus = new System.Windows.Forms.TextBox();
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbAlfabe = new System.Windows.Forms.ListBox();
            this.tbEgriselSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_coz
            // 
            this.btn_coz.Location = new System.Drawing.Point(562, 197);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(111, 40);
            this.btn_coz.TabIndex = 0;
            this.btn_coz.Text = "ŞİFRELE";
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // tbAnahtar
            // 
            this.tbAnahtar.Location = new System.Drawing.Point(106, 114);
            this.tbAnahtar.Name = "tbAnahtar";
            this.tbAnahtar.Size = new System.Drawing.Size(100, 20);
            this.tbAnahtar.TabIndex = 1;
            this.tbAnahtar.Text = "10";
            this.tbAnahtar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anahtar";
            // 
            // tbCozulmus
            // 
            this.tbCozulmus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCozulmus.Location = new System.Drawing.Point(24, 570);
            this.tbCozulmus.Multiline = true;
            this.tbCozulmus.Name = "tbCozulmus";
            this.tbCozulmus.ReadOnly = true;
            this.tbCozulmus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCozulmus.Size = new System.Drawing.Size(523, 164);
            this.tbCozulmus.TabIndex = 31;
            // 
            // tbMetin
            // 
            this.tbMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMetin.Location = new System.Drawing.Point(24, 197);
            this.tbMetin.Multiline = true;
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMetin.Size = new System.Drawing.Size(523, 188);
            this.tbMetin.TabIndex = 29;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(254, 50);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(159, 20);
            this.tbB.TabIndex = 28;
            this.tbB.Text = "2";
            this.tbB.TextChanged += new System.EventHandler(this.tbB_TextChanged);
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(50, 49);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(160, 20);
            this.tbA.TabIndex = 27;
            this.tbA.Text = "2";
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(214, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "x+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "x^3+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(216, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Baslangic Kordinatları";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(424, 120);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(41, 20);
            this.tbX.TabIndex = 37;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(475, 118);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(120, 20);
            this.tbY.TabIndex = 39;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // lbAlfabe
            // 
            this.lbAlfabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbAlfabe.FormattingEnabled = true;
            this.lbAlfabe.ItemHeight = 18;
            this.lbAlfabe.Location = new System.Drawing.Point(692, 28);
            this.lbAlfabe.Name = "lbAlfabe";
            this.lbAlfabe.Size = new System.Drawing.Size(369, 706);
            this.lbAlfabe.TabIndex = 40;
            // 
            // tbEgriselSifre
            // 
            this.tbEgriselSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEgriselSifre.Location = new System.Drawing.Point(24, 391);
            this.tbEgriselSifre.Multiline = true;
            this.tbEgriselSifre.Name = "tbEgriselSifre";
            this.tbEgriselSifre.ReadOnly = true;
            this.tbEgriselSifre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEgriselSifre.Size = new System.Drawing.Size(523, 173);
            this.tbEgriselSifre.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 761);
            this.Controls.Add(this.tbEgriselSifre);
            this.Controls.Add(this.lbAlfabe);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbCozulmus);
            this.Controls.Add(this.tbMetin);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnahtar);
            this.Controls.Add(this.btn_coz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Eliptik Eğriler Hüseyin Kutlukkaya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.TextBox tbAnahtar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCozulmus;
        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.ListBox lbAlfabe;
        private System.Windows.Forms.TextBox tbEgriselSifre;
    }
}

