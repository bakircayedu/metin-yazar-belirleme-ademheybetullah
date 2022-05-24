using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazariBelirleme
{
    public partial class Form1 : Form
    {
        HashTable hashTable = new HashTable(30);
        public Form1()
        {
            InitializeComponent();
        }
        string metin = "";
        StackLL CumleLer = new StackLL();
        StackLL Kelimeler = new StackLL();
        Heap Heap = new Heap();
        public bool dosyaOkundu,stackeAktarildi = false;
        private void btnMetinSeç_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Text Dosyası |*.txt";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = dosya.FileName;
                var fileStream = dosya.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    metin = reader.ReadToEnd();
                    dosyaOkundu = true;
                }
            }
            else
            {
                MessageBox.Show("Dosya Seçilemedi!!");
            }
            
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            if (dosyaOkundu)
            {
                string[] kelimeler;
                int kelimeSayisi = 0;
                int cumleNumarasi = 0;
                int toplamkelimeSayisi = 0;
                string[] cumleler = metin.Split('.');
                for (int i = 0; i < cumleler.Length ; i++)
                {
                    cumleNumarasi++;
                    kelimeler = cumleler[i].Split(' ');
                    kelimeSayisi = kelimeler.Length;
                    KelimeStackEkle(Kelimeler, EkleriSil(kelimeler), cumleNumarasi);
                    txtMetinBilgileri.Text += (i + 1) + ". Cümledeki kelime sayısı: " + kelimeSayisi + "\r\n";
                    CumleLer.Push(cumleler[i]);
                    toplamkelimeSayisi += kelimeSayisi;
                }
                txtMetinBilgileri.Text += "Toplam Kelime Sayısı: " + toplamkelimeSayisi + "\r\n" +
                    "Toplam Cümle Sayısı : " + CumleLer.count
                    + "\r\n" + "Ortalama Kelime Sayısı: " + toplamkelimeSayisi / CumleLer.count;
                stackeAktarildi = true;
            }
            else
            {
                MessageBox.Show("Önce Dosyayı Seçiniz");
            }
            
        }
        public void KelimeStackEkle(StackLL stackLL, string[] kelimeler, int cumleNum)
        {
            bool kelimeVar = false;
            Node temp;
            foreach (var item in kelimeler)
            {
                kelimeVar = false;
                temp = stackLL.Head;
                Kelime kelime = new Kelime();
                Kelime arananKelime = new Kelime();
                while (temp != null)
                {
                    arananKelime = (Kelime)temp.Data;
                    if (item == arananKelime.kelime)
                    {
                        arananKelime.Frekans++;
                        kelimeVar = true;
                        break;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                if (!kelimeVar)
                {

                    kelime.kelime = item;
                    kelime.Frekans = 1;
                    kelime.KelimeSiraNo = Array.IndexOf(kelimeler, item) + 1;
                    kelime.CumleSiraNo = cumleNum;
                    stackLL.Push(kelime);
                    
                }
            }
        }
        public string[] EkleriSil(string[] kelimeler)
        {
            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int j = 0; j < kelimeler[i].Length; j++)
                {
                    if (Char.IsPunctuation(kelimeler[i], j))
                    {
                        kelimeler[i] = kelimeler[i].Substring(0, j);
                        break;
                    }
                }

            }

            return kelimeler;
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            if (stackeAktarildi)
            {
                while (!Kelimeler.IsEmpty())
                {
                    Kelime kelime = (Kelime)Kelimeler.Pop();
                    Heap.Insert(kelime);
                }
            }
            else
            {
                MessageBox.Show("Önce kelimeler stack yapısına aktarılmalı");
            }
            
        }

        private void btnKelimeleriGetir_Click(object sender, EventArgs e)
        {
            if (TextBoxKontrol())
            {
                int istenenKelimeSayisi = Convert.ToInt32(txtIstenenKelimeSayisi.Text);
                dgwCokKullanilanKelimeler.DataSource = KelimeleriGetir(Heap, istenenKelimeSayisi);
            }
        }
        public bool TextBoxKontrol()
        {
            try
            {
                int.Parse(txtIstenenKelimeSayisi.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz!");
                return false;
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Heap.currentSize; i++)
            {
                Kelime kelime = Heap.heapKelimeler[i].kelime;
                hashTable.TabloyaEkle(kelime.KelimeSiraNo, kelime);
            }
        }

        private void btnKelimeAra_Click(object sender, EventArgs e)
        {
            int key = KeyOlustur(Convert.ToInt32(txtKelimeNo.Text), Convert.ToInt32(txtCumleno.Text));
            Kelime bulunan = hashTable.KelimeArama(key);
            if (bulunan == null)
                MessageBox.Show("Kelime Bulunamadı. Bu kelime daha önce kullanılmış olabilir.");
            else
                txtArananKelime.Text = bulunan.kelime;

        }
        public int KeyOlustur(int kelimeNo, int cumleNo)
        {
            string a = kelimeNo.ToString();
            string b = cumleNo.ToString();
            string strKey = b+a;
            int key = Convert.ToInt32(strKey);
            return key;

        }

        public Kelime[] KelimeleriGetir(Heap heap , int kelimeSayisi)
        {
            Kelime[] istenenKelimeler = new Kelime[kelimeSayisi];
            for (int i = 0; i < kelimeSayisi; i++)
            {
                istenenKelimeler[i] = heap.heapKelimeler[i].kelime;
            }
            return heap.Sort(istenenKelimeler);
        }
    }
}
