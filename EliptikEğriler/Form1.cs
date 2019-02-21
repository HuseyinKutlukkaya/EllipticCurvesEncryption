using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliptikEğriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList alfabe = new ArrayList()
{"A","B", "C", "Ç", "D","Æ","*","E", "F", "G","Ğ", "H","I", "İ", "J","K","L","M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü","V", "Y","Z",
            "a","b", "c", "ç", "d","e","2", "f", "g","1","ğ", "h","ı","3", "i","0", "j","k","l","m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü","v", "y","z"
            ,"4","5","6","7","8","9",".",",",";"," ","~","â","(",")","™","æ","x","X","\n","\r","=","\t","/","-","!","%","?","<",">","@","-","_","w","W","+","Q","q"};
        ArrayList alfabeIndex = new ArrayList();
        ArrayList Yenialfabe = new ArrayList();
     ArrayList YenialfabeIndex = new ArrayList();
        List<int> liste = new List<int>();
        ArrayList temp =new ArrayList();
        double BaslangicX,BaslangicY;
        int a, b;
        int Anahtar;
        string text;
        bool ustundemi = false;
   
        private void Form1_Load(object sender, EventArgs e)
        {
                a = 2 ;
                b = 2;
                BaslangicX = 0;
                BaslangicY = 4.12;
                Anahtar = 2;
                Ustundemi();
        }
        private void btn_coz_Click(object sender, EventArgs e)
        {
            alfabeIndex.Clear();
            temp.Clear();
            lbAlfabe.Items.Clear();
            Yenialfabe.Clear();
            YenialfabeIndex.Clear();
            tbCozulmus.Text = tbEgriselSifre.Text = "";
          
            if (tbA.Text == "" || tbB.Text == "" || tbMetin.Text == "" || tbX.Text == "" || tbAnahtar.Text == "" )
            {
                MessageBox.Show("Textboxlar boş olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
            a = Convert.ToInt32(tbA.Text);
            b = Convert.ToInt32(tbB.Text);
       
           BaslangicX = Convert.ToDouble(tbX.Text);
           BaslangicY = Convert.ToDouble(tbY.Text);
            Anahtar= Convert.ToInt32(tbAnahtar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Giriş Değerleriniz Kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!ustundemi )
            {
                MessageBox.Show("Seçilen nokta eğri üzerinde olmalıdır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Anahtar<=1)
            {
                MessageBox.Show("Anahtar 1 den büyük olmak zorundadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

      
        
            BaslangiciOlustur();
            if (alfabeIndex.Count != alfabe.Count)
                return;

            text = tbMetin.Text;
       
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0)
                {
                    if (!text.Substring(0, i).Contains(text[i].ToString()))//hiç kullanılmadıysa
                    {
                        tbEgriselSifre.Text += "("+alfabeIndex[alfabe.IndexOf(text[i].ToString())].ToString() + ").";

                    }
                    else if(!Yenialfabe.Contains(text[i].ToString()))//1 defa
                    {
                        string Kordinat = alfabeIndex[alfabe.IndexOf(text[i].ToString())].ToString();
                        double x1 = BaslangicX, y1 = BaslangicY;
                        double x2 =Convert.ToDouble(Kordinat.Substring(0, Kordinat.IndexOf(" "))), y2 = Convert.ToDouble(Kordinat.Substring( Kordinat.IndexOf(" ")));
                        double x3 = 0, y3 = 0;
                        double m = (y1 - y2) / (x1 - x2);
                        x3 = m * m - x2 - x1;
                        y3 = m * (x1 - x3) - y1;
                        Yenialfabe.Add(text[i].ToString());
                        YenialfabeIndex.Add(x3.ToString() + " " + y3.ToString());
                        tbEgriselSifre.Text += "("+YenialfabeIndex[YenialfabeIndex.Count - 1].ToString()+").";
                    }
                    else//1+
                    {
                        string karakter = text[i].ToString();
                        string Kordinat = YenialfabeIndex[ Yenialfabe.LastIndexOf( karakter)].ToString();
                        double x1 = BaslangicX, y1 = BaslangicY;
                        double x2 = Convert.ToDouble(Kordinat.Substring(0, Kordinat.IndexOf(" "))), y2 = Convert.ToDouble(Kordinat.Substring(Kordinat.IndexOf(" ")));
                        double x3 = 0, y3 = 0;
                        double m = (y1 - y2) / (x1 - x2);
                        x3 = m * m - x2 - x1;
                        y3 = m * (x1 - x3) - y1;
                        Yenialfabe.Add(text[i].ToString());
                        YenialfabeIndex.Add(x3.ToString() + " " + y3.ToString());
                        tbEgriselSifre.Text +="("+ YenialfabeIndex[YenialfabeIndex.Count - 1].ToString() + ").";



                    }
                }
                else//ilk karakter
                {

                    tbEgriselSifre.Text +="("+ alfabeIndex[alfabe.IndexOf(text[i].ToString())].ToString() + ").";

                    
                }
            }

            tbEgriselSifre.Text = tbEgriselSifre.Text.Substring(0, tbEgriselSifre.Text.Length - 1);


            temp.AddRange(tbEgriselSifre.Text.Replace("(", "").Replace(")", "").Replace("\n", "").Split('.'));
            for (int i = 0; i < temp.Count; i++)
            {
                if (alfabeIndex.Contains(temp[i].ToString())   )//hiç kullanılmadıysa
                {
                    tbCozulmus.Text += alfabe[alfabeIndex.IndexOf(temp[i].ToString())].ToString();

                }
                else if (!alfabeIndex.Contains(temp[i].ToString()) )//1+ defa
                {
                    try
                    {
                        bool D = false;
                        string Kordinat = temp[i].ToString();

                        double x1 = BaslangicX, y1 = BaslangicY;
                        double x2 = Convert.ToDouble(Kordinat.Substring(0, Kordinat.IndexOf(" "))), y2 = -1 * Convert.ToDouble(Kordinat.Substring(Kordinat.IndexOf(" ")));
                        double x3 = 0, y3 = 0;
                        double m = (y1 - y2) / (x1 - x2);
                        x3 = m * m - x2 - x1;
                        y3 = m * (x1 - x3) - y1;
                        y3 *= -1;

                        

                        for (int j = 0; j <  Yenialfabe.Count; j++)
                        {
                          double  x = Convert.ToDouble(YenialfabeIndex[j].ToString().Substring(0, YenialfabeIndex[j].ToString().IndexOf(" ")));
                        double    y = Convert.ToDouble(YenialfabeIndex[j].ToString().Substring(YenialfabeIndex[j].ToString().IndexOf(" ")));
                            if (Math.Round(x, 4) == Math.Round(x3, 4) && Math.Round(y, 4) == Math.Round(y3, 4))
                            {
                                tbCozulmus.Text += Yenialfabe[j].ToString();
                                D = true;
                                break;
                            }
                        }
                        if (!D)
                        {
                        
                           
                            for (int j = 0; j < alfabe.Count; j++)
                            {
                               double x = Convert.ToDouble( alfabeIndex[j].ToString().Substring(0, alfabeIndex[j].ToString().IndexOf(" ")));
                               double y = Convert.ToDouble(alfabeIndex[j].ToString().Substring(alfabeIndex[j].ToString().IndexOf(" ")));
                                if (Math.Round(x,4)== Math.Round(x3, 4)&& Math.Round(y, 4) == Math.Round(y3, 4))
                                {
                                    tbCozulmus.Text += alfabe[j].ToString();
                                    break;
                                }
                            }
                           

                        }

                    }
                    catch (Exception ex)
                    {
                        alfabeIndex.Clear();
                        temp.Clear();
                        lbAlfabe.Items.Clear();
                        Yenialfabe.Clear();
                        YenialfabeIndex.Clear();
                        tbCozulmus.Text = tbEgriselSifre.Text = "";
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lütfen farklı değerler ile tekrar deneyiniz.", "BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                        return;
                    }

                }

            }
            MessageBox.Show("İşlem Bitti.","BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void BaslangiciOlustur()
        {
            lbAlfabe.Items.Add("Anahtar="+BaslangicX.ToString() + "<>" + BaslangicY.ToString());
            double x1 = BaslangicX, y1 = BaslangicY;
            double x2 = 0, y2 = 0, x3 = 0, y3 = 0; ;
            double m = (3 * x1 * x1 + a) / (2 * y1);


            x3 = m * m - 2 * x1;

            y3 = m * (x1 - x3) - y1;


            x2 = x3;
            y2 = y3;
        
            lbAlfabe.Items.Add("Anahtar=" + x3.ToString() + " " + y3.ToString());
            for (int i = 1; i < Anahtar; i++)
            {



                m = (3 * x2 * x2 + a) / (2 * y2);

                x3 = m * m - 2 * x2;

                y3 = m * (x2 - x3) - y2;


                x2 = x3;
                y2 = y3;
                lbAlfabe.Items.Add("Anahtar=" + x3.ToString() + " " + y3.ToString());



            }
            BaslangicX = x2;
            BaslangicY = y2;

          AlfabeyiCikar();
        }

        private void tbP_KeyPress(object sender, KeyPressEventArgs e)
        {
         
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar != '-')
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            Ustundemi();

        }
        void Ustundemi()
        {
            if (tbX.Text.Replace(" ", "") == "")
                return;
            try
            {
                a = Convert.ToInt32(tbA.Text);
                b = Convert.ToInt32(tbB.Text);
            
                BaslangicX = Convert.ToDouble(tbX.Text);
            }
            catch (Exception)
            {
                ustundemi = false;
                return;
            }

            tbY.Text = Math.Sqrt(Math.Pow(BaslangicX, 3) + BaslangicX * a + b).ToString();
            if (Math.Pow(BaslangicX, 3) + BaslangicX * a + b < 0)
                ustundemi = false;
            else
                ustundemi = true;
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            Ustundemi();
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            Ustundemi();

        }

    

        void AlfabeyiCikar()
        {
            
            double x1 = BaslangicX, y1 = BaslangicY;
            double x2 = 0, y2 = 0, x3 = 0, y3 = 0; ;
            double m = (3 * x1 * x1 + a) / (2 * y1);


            x3 = m * m - 2 * x1;

            y3 = m * (x1 - x3) - y1;


            x2 = x3;
            y2 = y3;
        
            alfabeIndex.Add(x3.ToString() + " " + y3.ToString());
            lbAlfabe.Items.Add(alfabe[alfabeIndex.Count-1]+"= "+x3.ToString() + " " + y3.ToString());//alfabe başlanıç
            for (int i = 1; i < alfabe.Count; i++)
            {



                m = (3 * x2 * x2 + a) / (2 * y2);

                x3 = m * m - 2 * x2;

                y3 = m * (x2 - x3) - y2;


                x2 = x3;
                y2 = y3;
              
                alfabeIndex.Add( x3.ToString() + " " +  y3.ToString());
                lbAlfabe.Items.Add(alfabe[alfabeIndex.Count - 1] + "= " + x3.ToString() + " " + y3.ToString());



            }



        }
     
      
    }
}
