using CarkiFelek.Properties;
using EasyModbus;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CarkiFelek
{
    public partial class Form1 : Form
    {
        ModbusClient plc = new ModbusClient("192.168.0.50", 502);
        private static PlcOkunacakVeri degerler = new PlcOkunacakVeri();
        public static bool[] mb;
        public static bool oyuncu1Sirada = true, TextDurum = true;
        public static int[] mbI = new int[4];
        public static int oyuncu1Puan = 0, oyuncuPuan = 0;
        public static int oyuncu2Puan = 0;
        public static int turSayisi = 0;
        public static string ZorlukSeviyesi { get; set; }
        public static string Tur { get; set; }
        int i;
        private Form1 form;
        /*
         zorluk veri ile tur verisi gelmiyor

         */
        public Form1()
        {

            form = this;
            InitializeComponent();
            timer1.Interval = 50; // 3 saniye (3000 milisaniye)
            timer2.Interval = 80;
            timer3.Interval = 200;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            VeriOkuma();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Resim();


        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            Renk();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            //TurSayisiOlustur(Tur);
           // ZorlukSeviyesiBelirleme(ZorlukSeviyesi);
            try
            {
                plc.Connect();
                if (plc.Connected)
                {

                    VeriOkuma();
                    // Ýlk yüklemede baðlantý durumunu kontrol et
                }
                else
                {
                    MessageBox.Show("PLC Baðlantý Hatasý !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            SistemiBaslat();
            timer2.Start();
            timer3.Enabled = true;
            timer3.Start();

        }
        private void Durdur_Click(object sender, EventArgs e)
        {
            SistemiDurdur();
            timer2.Stop();
            timer3.Stop();
        }
        private void SistemiBaslat()
        {
            TextDurum = false;
           
            textBox1.Clear();
            try
            {
                if (plc.Connected)
                {
                    // Coil adresine yazmak (örneðin, 1. coil adresine true yazmak)
                    plc.WriteSingleCoil(0, false); // 0, coil adresidir (Modbus'ta 1 tabanlý olduðundan 1. coil 0'dýr)
                    plc.WriteSingleCoil(1, true);
                    switch (ZorlukSeviyesi)
                    {
                        case "1": plc.WriteSingleRegister(1, Convert.ToInt32(10)); break;
                        case "2": plc.WriteSingleRegister(1, Convert.ToInt32(50)); break;
                        case "3": plc.WriteSingleRegister(1, Convert.ToInt32(100)); break;
                        case "4": plc.WriteSingleRegister(1, Convert.ToInt32(150)); break;
                        case "5": plc.WriteSingleRegister(1, Convert.ToInt32(200)); break;
                        default: plc.WriteSingleRegister(1, Convert.ToInt32(100)); break;
                    }
                }
                else
                {
                    MessageBox.Show("PLC Baðlantýsý Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yazma sýrasýnda bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int syc = 0;
        private void SistemiDurdur()
        {
            // MessageBox.Show($"{turSayisi}, {Zorluk}");
            syc++;
            int tur = Convert.ToInt32(Tur);

            switch (tur)
            {
                case 1: turSayisi = 2; break;
                case 2: turSayisi = 5; break;
                case 3: turSayisi = 10; break;
                default: turSayisi = 2; break;
                   
            }
            try
            {
                if (plc.Connected)
                {
                    // PLC'ye durdurma sinyali gönderiliyor
                    plc.WriteSingleCoil(0, true); // 0, coil adresidir (Modbus'ta 1 tabanlý olduðundan 1. coil 0'dýr)
                    if (syc == (turSayisi*2) )
                    {
                        MessageBox.Show("oyun bitti");
                        syc = 0;

                        oyuncu1Puan = 0;
                        oyuncu2Puan = 0;
                    }
                    else
                    {
                        VeriOkuma();
                        timer2.Stop();
                        timer3.Stop();
                        PuanHesapla(mbI[0]);
                    }

                    // mbI[0] deðerini güncelle


                }
                else
                {
                    MessageBox.Show("PLC Baðlantýsý Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yazma sýrasýnda bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VeriOkuma()
        {
            try
            {

                // Bit okuma iþlemi
                // previousMb = mb; // Mevcut bitleri önceki bitler olarak sakla
                mb = plc.ReadCoils(0, 2);
                mbI = plc.ReadHoldingRegisters(0, 10);
                plc.Connect();
                // Deðiþiklik olup olmadýðýný kontrol et ve gerekiyorsa güncelle
                if (plc.Connected)
                {
                    // MessageBox.Show("deneme2");
                    degerler.durdur = mb[0];
                    degerler.start = mb[1];
                    degerler.sayac = mbI[0];

                }
                else
                {
                    //  MessageBox.Show($"Baðlantý sýrasýnda bir hata oluþtu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("deneme3");
                }
                if (TextDurum)
                {
                    textBox1.Clear();
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 24); // 14, metin boyutudur
                    textBox1.AppendText($"{mbI[0]}");
                }
                else
                {
                    TextDurum = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Veri okuma sýrasýnda bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Resim()
        {
            i += 1;
            switch (i)
            {
                case 1: pictureBox1.Image = Resources.cark11; break;
                case 2: pictureBox1.Image = Resources.cark21; break;
                case 3: pictureBox1.Image = Resources.cark31; break;
                case 4: pictureBox1.Image = Resources.cark4; break;
                default: i = 0; break;
            }
        }
        private void Renk()
        {
            i += 1;
            switch (i)
            {
                case 1: groupBox1.BackColor = Color.Violet; form.BackColor = Color.Purple; break;
                case 2: groupBox1.BackColor = Color.Pink; form.BackColor = Color.Crimson; break;
                case 3: groupBox1.BackColor = Color.MediumPurple; form.BackColor = Color.DarkSlateBlue; break;
                case 4: groupBox1.BackColor = Color.LimeGreen; form.BackColor = Color.LawnGreen; break;
                case 5: groupBox1.BackColor = Color.PeachPuff; form.BackColor = Color.Orange; break;
                case 6: groupBox1.BackColor = Color.Salmon; form.BackColor = Color.OrangeRed; break;
                default: i = 0; break;
            }
        }
        private void PuanHesapla(int sayi)
        {

            if (oyuncu1Sirada)
            {
                oyuncuPuan = sayi;
                oyuncu1Puan = oyuncu1Puan + oyuncuPuan;
                O1Puan.Text = $"{oyuncu1Puan}";
                oyuncu1Sirada = false; // Sýra oyuncu 2'ye geçiyor
            }
            else
            {
                oyuncuPuan = sayi;
                oyuncu2Puan = oyuncu2Puan + oyuncuPuan;
                O2Puan.Text = $"{oyuncu2Puan}";
                oyuncu1Sirada = true; // Sýra tekrar oyuncu 1'e geçiyor

            }


        }

        private void zorlukSeviyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void turSayýsýToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Form3 form3 = new Form3();
            form3.Show();
           
           

        }
      

    }
}


