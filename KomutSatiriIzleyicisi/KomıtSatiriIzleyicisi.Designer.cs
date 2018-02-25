namespace KomutSatiriIzleyicisi
{
    partial class KomıtSatiriIzleyicisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KomıtSatiriIzleyicisi));
            this.Başlat = new System.Windows.Forms.Button();
            this.Çıktı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TekSatırda = new System.Windows.Forms.CheckBox();
            this.Punto_Artır = new System.Windows.Forms.Button();
            this.Punto_Azalt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Girdi_Başlar = new System.Windows.Forms.ComboBox();
            this.Girdi_İçerir = new System.Windows.Forms.ComboBox();
            this.Girdi_Hariç = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Grup = new System.Windows.Forms.GroupBox();
            this.Etkin = new System.Windows.Forms.CheckBox();
            this.Girdi_Uygulama = new System.Windows.Forms.ComboBox();
            this.Grup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Başlat
            // 
            this.Başlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Başlat.Location = new System.Drawing.Point(717, 3);
            this.Başlat.Name = "Başlat";
            this.Başlat.Size = new System.Drawing.Size(75, 23);
            this.Başlat.TabIndex = 1;
            this.Başlat.Text = "Başlat";
            this.Başlat.UseVisualStyleBackColor = true;
            this.Başlat.Click += new System.EventHandler(this.Başlat_Click);
            // 
            // Çıktı
            // 
            this.Çıktı.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Çıktı.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Çıktı.Location = new System.Drawing.Point(15, 137);
            this.Çıktı.Multiline = true;
            this.Çıktı.Name = "Çıktı";
            this.Çıktı.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Çıktı.Size = new System.Drawing.Size(777, 249);
            this.Çıktı.TabIndex = 9;
            this.Çıktı.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uygulama";
            // 
            // TekSatırda
            // 
            this.TekSatırda.AutoSize = true;
            this.TekSatırda.Checked = true;
            this.TekSatırda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TekSatırda.Location = new System.Drawing.Point(80, 30);
            this.TekSatırda.Name = "TekSatırda";
            this.TekSatırda.Size = new System.Drawing.Size(78, 17);
            this.TekSatırda.TabIndex = 3;
            this.TekSatırda.Text = "TekSatırda";
            this.TekSatırda.UseVisualStyleBackColor = true;
            this.TekSatırda.CheckedChanged += new System.EventHandler(this.TekSatırda_CheckedChanged);
            // 
            // Punto_Artır
            // 
            this.Punto_Artır.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Punto_Artır.Location = new System.Drawing.Point(729, 30);
            this.Punto_Artır.Name = "Punto_Artır";
            this.Punto_Artır.Size = new System.Drawing.Size(27, 20);
            this.Punto_Artır.TabIndex = 4;
            this.Punto_Artır.Text = "+";
            this.Punto_Artır.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Punto_Artır.UseVisualStyleBackColor = true;
            this.Punto_Artır.Click += new System.EventHandler(this.Punto_Artır_Click_1);
            // 
            // Punto_Azalt
            // 
            this.Punto_Azalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Punto_Azalt.Location = new System.Drawing.Point(759, 30);
            this.Punto_Azalt.Name = "Punto_Azalt";
            this.Punto_Azalt.Size = new System.Drawing.Size(27, 20);
            this.Punto_Azalt.TabIndex = 5;
            this.Punto_Azalt.Text = "-";
            this.Punto_Azalt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Punto_Azalt.UseVisualStyleBackColor = true;
            this.Punto_Azalt.Click += new System.EventHandler(this.Punto_Azalt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "İçerir";
            // 
            // Girdi_Başlar
            // 
            this.Girdi_Başlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Başlar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Girdi_Başlar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Girdi_Başlar.FormattingEnabled = true;
            this.Girdi_Başlar.Location = new System.Drawing.Point(65, 19);
            this.Girdi_Başlar.Name = "Girdi_Başlar";
            this.Girdi_Başlar.Size = new System.Drawing.Size(706, 21);
            this.Girdi_Başlar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.Girdi_Başlar, "Birden fazla girdiyi @ karakteri ile ayır");
            // 
            // Girdi_İçerir
            // 
            this.Girdi_İçerir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_İçerir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Girdi_İçerir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Girdi_İçerir.FormattingEnabled = true;
            this.Girdi_İçerir.Location = new System.Drawing.Point(65, 46);
            this.Girdi_İçerir.Name = "Girdi_İçerir";
            this.Girdi_İçerir.Size = new System.Drawing.Size(706, 21);
            this.Girdi_İçerir.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Girdi_İçerir, "Birden fazla girdiyi @ karakteri ile ayır");
            // 
            // Girdi_Hariç
            // 
            this.Girdi_Hariç.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Hariç.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Girdi_Hariç.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Girdi_Hariç.FormattingEnabled = true;
            this.Girdi_Hariç.Location = new System.Drawing.Point(65, 73);
            this.Girdi_Hariç.Name = "Girdi_Hariç";
            this.Girdi_Hariç.Size = new System.Drawing.Size(706, 21);
            this.Girdi_Hariç.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Girdi_Hariç, "Birden fazla girdiyi @ karakteri ile ayır");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hariç";
            // 
            // Grup
            // 
            this.Grup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grup.Controls.Add(this.Girdi_Hariç);
            this.Grup.Controls.Add(this.label5);
            this.Grup.Controls.Add(this.Girdi_İçerir);
            this.Grup.Controls.Add(this.Girdi_Başlar);
            this.Grup.Controls.Add(this.label3);
            this.Grup.Controls.Add(this.label4);
            this.Grup.Location = new System.Drawing.Point(15, 31);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(777, 100);
            this.Grup.TabIndex = 6;
            this.Grup.TabStop = false;
            // 
            // Etkin
            // 
            this.Etkin.AutoSize = true;
            this.Etkin.Checked = true;
            this.Etkin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Etkin.Location = new System.Drawing.Point(20, 30);
            this.Etkin.Name = "Etkin";
            this.Etkin.Size = new System.Drawing.Size(50, 17);
            this.Etkin.TabIndex = 2;
            this.Etkin.Text = "Etkin";
            this.Etkin.UseVisualStyleBackColor = true;
            this.Etkin.CheckedChanged += new System.EventHandler(this.Etkin_CheckedChanged);
            // 
            // Girdi_Uygulama
            // 
            this.Girdi_Uygulama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Girdi_Uygulama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Girdi_Uygulama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Girdi_Uygulama.FormattingEnabled = true;
            this.Girdi_Uygulama.Location = new System.Drawing.Point(80, 5);
            this.Girdi_Uygulama.Name = "Girdi_Uygulama";
            this.Girdi_Uygulama.Size = new System.Drawing.Size(631, 21);
            this.Girdi_Uygulama.TabIndex = 0;
            // 
            // KomıtSatiriIzleyicisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 398);
            this.Controls.Add(this.Girdi_Uygulama);
            this.Controls.Add(this.Punto_Artır);
            this.Controls.Add(this.Punto_Azalt);
            this.Controls.Add(this.Etkin);
            this.Controls.Add(this.TekSatırda);
            this.Controls.Add(this.Grup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Çıktı);
            this.Controls.Add(this.Başlat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KomıtSatiriIzleyicisi";
            this.Opacity = 0D;
            this.Text = "Komut Satırı İzleyicisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KomıtSatiriIzleyicisi_FormClosed);
            this.Load += new System.EventHandler(this.KomıtSatiriIzleyicisi_Load);
            this.Grup.ResumeLayout(false);
            this.Grup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Başlat;
        private System.Windows.Forms.TextBox Çıktı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TekSatırda;
        private System.Windows.Forms.Button Punto_Artır;
        private System.Windows.Forms.Button Punto_Azalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Grup;
        private System.Windows.Forms.CheckBox Etkin;
        private System.Windows.Forms.ComboBox Girdi_Uygulama;
        private System.Windows.Forms.ComboBox Girdi_Başlar;
        private System.Windows.Forms.ComboBox Girdi_İçerir;
        private System.Windows.Forms.ComboBox Girdi_Hariç;
    }
}

