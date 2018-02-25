using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArgeMup.HazirKod;
using System.IO;

//dahaçok karmaşıklaştırmayı değiştir

namespace KomutSatiriIzleyicisi
{
    public partial class KomıtSatiriIzleyicisi : Form
    {
        Process Uygulama;
        string[] l_Başlar, l_İçerir, l_Hariç;
        bool BaşlarVeİçerirKıstaslarıBoş;
        Ayarlar_ Ayarlar;
        PencereVeTepsiIkonuKontrolu_ PeTeİk;
        string pak;

        public KomıtSatiriIzleyicisi()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }
        private void KomıtSatiriIzleyicisi_Load(object sender, EventArgs e)
        {
            bool sonuç = false;
            yenidendene:
            Ayarlar = new Ayarlar_(out sonuç);
            if (!sonuç) { File.Move(Ayarlar.AyarlarDosyasıYolunuAl(), Ayarlar.AyarlarDosyasıYolunuAl() + "_Bozuk_"); goto yenidendene; }

            PeTeİk = new PencereVeTepsiIkonuKontrolu_(this, Ayarlar, false, "", 100, 50, 300, 300);
            PeTeİk.TepsiİkonunuBaşlat();

            string satır;
            pak = Path.GetDirectoryName(Ayarlar.AyarlarDosyasıYolunuAl()) + "\\";

            if (File.Exists(pak + "Girdi_Uygulama.txt"))
            {
                using (StreamReader sr = new StreamReader(pak + "Girdi_Uygulama.txt"))
                {
                    while ((satır = sr.ReadLine()) != null) { Girdi_Uygulama.Items.Add(satır); }
                }
            }

            if (File.Exists(pak + "Girdi_Başlar.txt"))
            {
                using (StreamReader sr = new StreamReader(pak + "Girdi_Başlar.txt"))
                {
                    while ((satır = sr.ReadLine()) != null) { Girdi_Başlar.Items.Add(satır); }
                }
            }

            if (File.Exists(pak + "Girdi_İçerir.txt"))
            {
                using (StreamReader sr = new StreamReader(pak + "Girdi_İçerir.txt"))
                {
                    while ((satır = sr.ReadLine()) != null) { Girdi_İçerir.Items.Add(satır); }
                }
            }

            if (File.Exists(pak + "Girdi_Hariç.txt"))
            {
                using (StreamReader sr = new StreamReader(pak + "Girdi_Hariç.txt"))
                {
                    while ((satır = sr.ReadLine()) != null) { Girdi_Hariç.Items.Add(satır); }
                }
            }

            if (Ayarlar.Oku("Etkin", true.ToString()) == true.ToString()) Etkin.Checked = true;
            else Etkin.Checked = false;

            if (Ayarlar.Oku("TekSatırda", true.ToString()) == true.ToString()) TekSatırda.Checked = true;
            else TekSatırda.Checked = false;

            Çıktı.Font = new Font(Çıktı.Font.FontFamily, Convert.ToSingle(Ayarlar.Oku("Çıktı", "12")));

            Girdi_Uygulama.Text = Ayarlar.Oku("Girdi_Uygulama_i");
            Girdi_Başlar.Text = Ayarlar.Oku("Girdi_Başlar_i");
            Girdi_İçerir.Text = Ayarlar.Oku("Girdi_İçerir_i");
            Girdi_Hariç.Text = Ayarlar.Oku("Girdi_Hariç_i");
        }
        private void KomıtSatiriIzleyicisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter sr = new StreamWriter(pak + "Girdi_Uygulama.txt", false))
            {
                foreach (string biri in Girdi_Uygulama.Items) sr.WriteLine(biri);
            }

            using (StreamWriter sr = new StreamWriter(pak + "Girdi_Başlar.txt", false))
            {
                foreach (string biri in Girdi_Başlar.Items) sr.WriteLine(biri);
            }

            using (StreamWriter sr = new StreamWriter(pak + "Girdi_İçerir.txt", false))
            {
                foreach (string biri in Girdi_İçerir.Items) sr.WriteLine(biri);
            }

            using (StreamWriter sr = new StreamWriter(pak + "Girdi_Hariç.txt", false))
            {
                foreach (string biri in Girdi_Hariç.Items) sr.WriteLine(biri);
            }

            Ayarlar.Yaz("Etkin", Etkin.Checked.ToString());
            Ayarlar.Yaz("TekSatırda", TekSatırda.Checked.ToString());
            Ayarlar.Yaz("Çıktı", Çıktı.Font.Size.ToString());

            Ayarlar.Yaz("Girdi_Uygulama_i", Girdi_Uygulama.Text);
            Ayarlar.Yaz("Girdi_Başlar_i", Girdi_Başlar.Text);
            Ayarlar.Yaz("Girdi_İçerir_i", Girdi_İçerir.Text);
            Ayarlar.Yaz("Girdi_Hariç_i", Girdi_Hariç.Text);

            if (Uygulama != null) Uygulama.Dispose();
        }

        private void Başlat_Click(object sender, EventArgs e)
        {
            if (Uygulama != null)
            {
                try
                {
                    Uygulama.Kill();
                    Uygulama.Close();
                }
                catch (Exception) { }

                try
                {
                    Uygulama.Dispose();
                }
                catch (Exception) { }

                Uygulama = null;

                Başlat.Text = "Başlat";
                return;
            }

            int i = 0;
            List<string> l_ = Girdi_Başlar.Text.Split('@').ToList();
            for (; i < l_.Count; i++)
            {
                l_[i] = l_[i].ToLower();
                if (string.IsNullOrEmpty(l_[i])) { l_.RemoveAt(i); i--; }
            }
            l_Başlar = l_.ToArray();

            i = 0;
            l_ = Girdi_İçerir.Text.Split('@').ToList();
            for (; i < l_.Count; i++)
            {
                l_[i] = l_[i].ToLower();
                if (string.IsNullOrEmpty(l_[i])) { l_.RemoveAt(i); i--; }
            }
            l_İçerir = l_.ToArray();

            i = 0;
            l_ = Girdi_Hariç.Text.Split('@').ToList();
            for (; i < l_.Count; i++)
            {
                l_[i] = l_[i].ToLower();
                if (string.IsNullOrEmpty(l_[i])) { l_.RemoveAt(i); i--; }
            }
            l_Hariç = l_.ToArray();

            if (l_Başlar.Length + l_İçerir.Length == 0) BaşlarVeİçerirKıstaslarıBoş = true;
            else BaşlarVeİçerirKıstaslarıBoş = false;

            Uygulama = new Process();
            string kök = Girdi_Uygulama.Text + " ";
            kök = kök.Substring(0, kök.IndexOf(' '));
            Uygulama.StartInfo.FileName = kök;

            kök = Girdi_Uygulama.Text.Remove(0, kök.Length).Trim();
            Uygulama.StartInfo.Arguments = kök;
            
            Uygulama.StartInfo.CreateNoWindow = true;
            Uygulama.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Uygulama.StartInfo.UseShellExecute = false;

            Uygulama.StartInfo.RedirectStandardError = true;
            Uygulama.StartInfo.RedirectStandardOutput = true;
            Uygulama.ErrorDataReceived += Uygulama_OutputDataReceived;
            Uygulama.Exited += Uygulama_Exited;
            Uygulama.OutputDataReceived += Uygulama_OutputDataReceived;
            Uygulama.EnableRaisingEvents = true;

            try
            {
                Uygulama.Start();
            }
            catch (Exception ex)
            {
                Çıktı.AppendText(Environment.NewLine + ex.ToString() + Environment.NewLine);
                Başlat_Click(null, null);
                return;
            }

            Uygulama.BeginOutputReadLine();
            Uygulama.BeginErrorReadLine();

            bool Var = false;
            foreach (string biri in Girdi_Uygulama.Items)
            {
                if (Girdi_Uygulama.Text.ToLower() == biri.ToLower()) { Var = true; break; }
            }
            if (!Var) Girdi_Uygulama.Items.Add(Girdi_Uygulama.Text);

            Var = false;
            foreach (string biri in Girdi_Başlar.Items)
            {
                if (Girdi_Başlar.Text.ToLower() == biri.ToLower()) { Var = true; break; }
            }
            if (!Var) Girdi_Başlar.Items.Add(Girdi_Başlar.Text);

            Var = false;
            foreach (string biri in Girdi_İçerir.Items)
            {
                if (Girdi_İçerir.Text.ToLower() == biri.ToLower()) { Var = true; break; }
            }
            if (!Var) Girdi_İçerir.Items.Add(Girdi_İçerir.Text);

            Var = false;
            foreach (string biri in Girdi_Hariç.Items)
            {
                if (Girdi_Hariç.Text.ToLower() == biri.ToLower()) { Var = true; break; }
            }
            if (!Var) Girdi_Hariç.Items.Add(Girdi_Hariç.Text);

            Başlat.Text = "Durdur";
        }
        private void Uygulama_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.Data)) return;

                if (!Etkin.Checked) goto HerTürlüDevam;

                string Girdi = e.Data.ToLower();

                if (BaşlarVeİçerirKıstaslarıBoş) goto Devam;
                else
                {
                    foreach (string biri in l_İçerir)
                    {
                        if (Girdi.Contains(biri)) goto Devam;
                    }

                    foreach (string biri in l_Başlar)
                    {
                        if (Girdi.StartsWith(biri)) goto Devam;
                    }

                    return;
                }

                Devam:
                foreach (string biri in l_Hariç)
                {
                    if (Girdi.Contains(biri)) return;
                }

                HerTürlüDevam:
                Çıktı.AppendText(e.Data + Environment.NewLine);
            }
            catch (Exception) { }
        }
        private void Uygulama_Exited(object sender, EventArgs e)
        {
            Başlat_Click(null, null);
            Çıktı.AppendText("Uygulama Kapandı");
        }

        private void Punto_Artır_Click_1(object sender, EventArgs e)
        {
            Çıktı.Font = new Font(Çıktı.Font.FontFamily, Çıktı.Font.Size + 1);
        }
        private void Punto_Azalt_Click(object sender, EventArgs e)
        {
            Çıktı.Font = new Font(Çıktı.Font.FontFamily, Çıktı.Font.Size - 1);
        }

        private void Etkin_CheckedChanged(object sender, EventArgs e)
        {
            Grup.Enabled = Etkin.Checked;
        }
        private void TekSatırda_CheckedChanged(object sender, EventArgs e)
        {
            Çıktı.WordWrap = !TekSatırda.Checked;
        }

        void Combox_SelIndex_Duzenle(string Adı, ComboBox cb)
        {
            if (cb.Items.Count < 1) return;
            string oku = Ayarlar.Oku(Adı);

            int no = 0;
            if (!int.TryParse(oku, out no)) return;
            if (no >= cb.Items.Count) return;

            cb.SelectedIndex = no;
        }
    }
}
