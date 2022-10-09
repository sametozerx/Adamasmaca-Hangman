using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class Form1 : Form
    {
        bool english = false;
        string kelime = "";
        bool kategorisecili = false;
        Label[] labels= new Label[0];
        Button[] butons;
        string[] harfler = new string[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "W", "Y", "Z" };
        int hata = 0;
       
        public Form1()
        {

            this.Size = new Size(1500, 900);
            this.MaximumSize = new Size(1500, 900);
            this.MinimumSize = new Size(1500, 900);

            
            InitializeComponent();
            Buttonekle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void Labelekle(string[] dizi)
        {

            Random rndm = new Random();
            kelime = dizi[rndm.Next(dizi.Length)];
            labels = new Label[kelime.Length];

           int x = 650, y = 130;

            switch (kelime.Length)
            {
                case 1:
                    x = 775;
                    y = 130;

                    break;
                case 2:
                    x = 755;
                    y = 130;

                    break;
                case 3:
                    x = 735;
                    y = 130;

                    break;
                case 4:
                    x = 715;
                    y = 130;

                    break;
                case 5:
                    x = 695;
                    y = 130;

                    break;
                case 6:
                    x = 675;
                    y = 130;

                    break;

                case 7:
                    x = 655;
                    y = 130;

                    break;

                case 8:
                    x = 635;
                    y = 130;

                    break;

                case 9:
                    x = 615;
                    y = 130;
                    break;
                
                case 10:
                    x = 595;
                    y = 130;

                    break;
                deafult:
                    x = 595;
                    y = 130;

                    break;




            }
            

            for (int i = 0; i < kelime.Length; i++)
            {

                labels[i] = new Label();
                labels[i].Name = "lbl_" + kelime[i];
                labels[i].Text = "_";
                labels[i].Size = new Size(40, 40);
                labels[i].Location = new Point(x, y);
                labels[i].Font = new Font("Arial", 24, FontStyle.Bold);
                this.Controls.Add(labels[i]);
                x += 40;

            }



        }

        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {


          
                if (e.KeyCode == Keys.Enter)
                {
                button1.PerformClick();
                }
            
        }

        private void Buttonekle() {
            

            int x = 0, y = 400;
            butons = new Button[harfler.Length];

            for (int i = 0; i < harfler.Length; i++)
            {
                butons[i] = new Button();
                butons[i].Name = "button_" + harfler[i];
                butons[i].Text = harfler[i].ToString();
                butons[i].Size = new Size(70, 55);
                butons[i].Click += new EventHandler(button_click);
                butons[i].Font = new Font("Arial", 15, FontStyle.Bold);
                butons[i].BackColor = Color.White;

                if (i % 10 == 0)
                {
                    x = 100;
                    y += 65;
                }
                else
                {
                    x += 80;
                }
                butons[i].Location = new Point(x, y);
                this.Controls.Add(butons[i]);

            }

        }
        Label lbl = new Label();
        private void button_click(object sender, EventArgs e)
        {

            if (kategorisecili==false)
            {

                if (english == false)
                {
                    MessageBox.Show("Kategori seçiniz.");
                }
                else
                {
                    MessageBox.Show("Choose category.");
                }

            }
            else
            {
                Button buton = (Button)sender;
                buton.Enabled = false;
                buton.BackColor = Color.DimGray;
                bool tahmin = false;


                if (hata < 5)
                {
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if (buton.Text == kelime[i].ToString())
                        {
                            labels[i].Text = buton.Text;
                            tahmin = true;
                        }
                    }
                }

                int win = kelime.Length;
                for (int i = 0; i < kelime.Length; i++)
                {

                    if (labels[i].Text != "_") { win--; }


                }

                if (win == 0)
                {
                    DialogResult dialogResult;
                    if (english == false)
                    {

                        dialogResult = MessageBox.Show("Kazandınız, tekrar oynamak ister misiniz?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dialogResult = MessageBox.Show("You win, want to play again?", "", MessageBoxButtons.YesNo);
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < labels.Length; i++)
                        {
                            this.Controls.Remove(labels[i]);
                        }
                        for (int i = 0; i < harfler.Length; i++)
                        {
                            butons[i].Enabled = true;
                            butons[i].BackColor = Color.White;
                        }
                        if (english == true)
                        {
                            for (int j = 0; j < harfler.Length; j++)
                            {
                                switch (butons[j].Text)
                                {
                                    case "Ç":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ğ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "İ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ö":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;

                                }



                            }
                        }
                        hata = -1;

                        ackafa.Visible = true;
                        acvucut.Visible = true;
                        acsolkol.Visible = true;
                        acsagkol.Visible = true;
                        acsolbacak.Visible = true;
                        acsagbacak.Visible = true;
                        olufull.Visible = false;
                        button2.PerformClick();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        Application.Exit();

                    }
                }



                if (hata == 5)
                {
                    acsagbacak.Visible = false;
                    olufull.Visible = true;
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        labels[i].Text = kelime[i].ToString();
                    }
                    DialogResult dialogResult;
                    if (english == false)
                    {

                        dialogResult = MessageBox.Show("Kaybettiniz, tekrar oynamak ister misiniz?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dialogResult = MessageBox.Show("You lost, want to play again?", "", MessageBoxButtons.YesNo);
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < labels.Length; i++)
                        {
                            this.Controls.Remove(labels[i]);
                        }
                        for (int i = 0; i < harfler.Length; i++)
                        {
                            butons[i].Enabled = true;
                            butons[i].BackColor = Color.White;
                        }
                        if (english == true)
                        {
                            for (int j = 0; j < harfler.Length; j++)
                            {
                                switch (butons[j].Text)
                                {
                                    case "Ç":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ğ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "İ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ö":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                }



                            }
                        }
                        hata = -1;

                        ackafa.Visible = true;
                        acvucut.Visible = true;
                        acsolkol.Visible = true;
                        acsagkol.Visible = true;
                        acsolbacak.Visible = true;
                        acsagbacak.Visible = true;
                        olufull.Visible = false;
                        button2.PerformClick();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        Application.Exit();

                    }
                }


                if (tahmin == false)
                {
                    hata++;
                    adamas();
                }




            }

        }
        
        private void adamas()
        {
            switch (hata)
            {
                case 1:
                    ackafa.Visible = false;
                    break;
                case 2:
                    acvucut.Visible = false;
                    break;
                case 3:
                    acsolkol.Visible = false;
                    break;
                case 4:
                    acsagkol.Visible = false;
                    break;
                case 5:
                    acsolbacak.Visible = false;
                    break;
              
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (kategorisecili == false)
            {
                if (english == false)
                {
                    MessageBox.Show("Kategori seçiniz.");
                }
                else
                {
                    MessageBox.Show("Choose category.");
                }

            }
            else
            {

                if (textBox1.Text.ToUpper() == kelime)
                {
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        labels[i].Text = kelime[i].ToString();
                    }

                    DialogResult dialogResult;
                    if (english == false)
                    {

                        dialogResult = MessageBox.Show("Kazandınız, tekrar oynamak ister misiniz?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dialogResult = MessageBox.Show("You win, want to play again?", "", MessageBoxButtons.YesNo);
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < labels.Length; i++)
                        {
                            this.Controls.Remove(labels[i]);
                        }
                        for (int i = 0; i < harfler.Length; i++)
                        {
                            butons[i].Enabled = true;
                            butons[i].BackColor = Color.White;

                        }
                        if (english == true)
                        {
                            for (int j = 0; j < harfler.Length; j++)
                            {
                                switch (butons[j].Text)
                                {
                                    case "Ç":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ğ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "İ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ö":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;

                                }



                            }
                        }
                        hata = 0;

                        ackafa.Visible = true;
                        acvucut.Visible = true;
                        acsolkol.Visible = true;
                        acsagkol.Visible = true;
                        acsolbacak.Visible = true;
                        acsagbacak.Visible = true;
                        olufull.Visible = false;
                        button2.PerformClick();



                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        Application.Exit();

                    }


                }
                else
                {
                    ackafa.Visible = false;
                    acvucut.Visible = false;
                    acsolkol.Visible = false;
                    acsagkol.Visible = false;
                    acsolbacak.Visible = false;
                    acsagbacak.Visible = false;
                    olufull.Visible = true;

                    for (int i = 0; i < kelime.Length; i++)
                    {
                        labels[i].Text = kelime[i].ToString();
                    }
                    DialogResult dialogResult;
                    if (english == false)
                    {

                        dialogResult = MessageBox.Show("Kaybettiniz, tekrar oynamak ister misiniz?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dialogResult = MessageBox.Show("You lost, want to play again?", "", MessageBoxButtons.YesNo);
                    }

                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < labels.Length; i++)
                        {
                            this.Controls.Remove(labels[i]);
                        }
                        for (int i = 0; i < harfler.Length; i++)
                        {
                            butons[i].Enabled = true;
                            butons[i].BackColor = Color.White;
                        }
                        if (english == true)
                        {
                            for (int j = 0; j < harfler.Length; j++)
                            {
                                switch (butons[j].Text)
                                {
                                    case "Ç":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ğ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "İ":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;
                                    case "Ö":
                                        butons[j].Enabled = false;
                                        butons[j].BackColor = Color.Black;
                                        break;

                                }



                            }
                        }
                        hata = 0;

                        ackafa.Visible = true;
                        acvucut.Visible = true;
                        acsolkol.Visible = true;
                        acsagkol.Visible = true;
                        acsolbacak.Visible = true;
                        acsagbacak.Visible = true;
                        olufull.Visible = false;
                        button2.PerformClick();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        Application.Exit();

                    }
                }

                textBox1.Text = "";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (english == false)
            {

                if (comboBox1.Text == "Hayvanlar")
                {
                    kategorisecili = true;
                }
                else if (comboBox1.Text == "Şehirler")
                {
                    kategorisecili = true;

                }
                else if (comboBox1.Text == "Meyveler ve Sebzeler")
                {
                    kategorisecili = true;
                }
                else
                {
                    kategorisecili = false;
                }




                if (labels.Length != 0)
                {
                    for (int i = 0; i < labels.Length; i++)
                    {
                        this.Controls.Remove(labels[i]);
                    }
                }

                string kategori = comboBox1.Text;

                switch (kategori)
                {
                    case "Hayvanlar":

                        string[] hayvanlar = new string[] { "İNEK","KOYUN","MAYMUN","AT","KÖPEK","YILAN","KEDİ","PAPAĞAN","TAVŞAN","KAPLUMBAĞA","KURBAĞA","KERTENKELE","KAPLAN","ASLAN","TAVUK","TİLKİ","KURT","ZEBRA","PANDA","FİL","DOMUZ" };
                        Labelekle(hayvanlar);

                        break;

                    case "Şehirler":
                        string[] sehirler = new string[] {"İSTANBUL" ,"ANKARA", "BURSA","İZMİR","ANTAYLA","KONYA","ADANA","GAZİANTEP","ŞANLIURFA","KOCAELİ","HATAY","BOLU"};
                        Labelekle(sehirler);

                        break;

                    case "Meyveler ve Sebzeler":
                        string[] bitkiler = new string[] { "ELMA", "ARMUT","NAR","ŞEFTALİ","KAYISI","DOMATES","PATATES","KİRAZ","TURP","HAVUÇ","SALATALIK","PORTAKAL","MISIR","PATLICAN","ISPANAK" };
                        Labelekle(bitkiler);

                        break;
                    default:
                        MessageBox.Show("Kategori Seçiniz!");
                        break;

                }

            }
            if(english==true)
            {
                if (comboBox1.Text == "Animals")
                {
                    kategorisecili = true;
                }
                else if (comboBox1.Text == "Cities")
                {
                    kategorisecili = true;

                }
                else if (comboBox1.Text == "Fruit and Vegetables")
                {
                    kategorisecili = true;
                }
                else
                {
                    kategorisecili = false;
                }




                if (labels.Length != 0)
                {
                    for (int i = 0; i < labels.Length; i++)
                    {
                        this.Controls.Remove(labels[i]);
                    }
                }

                string kategori = comboBox1.Text;

                switch (kategori)
                {
                    case "Animals":

                        string[] hayvanlar = new string[] { "COW", "SHEEP", "MONKEY", "HORSE", "DOG", "SNAKE", "CAT", "PARROT", "RABBIT", "TURTLE", "FROG", "TIGER", "LION", "CHICKEN", "FOX", "WOLF", "ZEBRA", "PANDA", "ELEPHANT", "PIG" };
                        Labelekle(hayvanlar);

                        break;

                    case "Cities":
                        string[] sehirler = new string[] { "TOKYO","LONDRA","NEWYORK","ISTANBUL","BERLIN","PARIS" ,"MOSCOW","DUBAI", "SINGAPORE" ,"BARCELONA","MADRID","ROME","CHICAGO","AMSTERDAM","TORONTO", "WASHINGTON" };
                        Labelekle(sehirler);

                        break;

                    case "Fruit and Vegetables":
                        string[] bitkiler = new string[] { "APPLE", "PEAR","PEACH","APRICOT","TOMATO","POTATO","CHERRY","RADISH","CARROT","CUCUMBER","ORANGE","CORN ","SPINACH"};
                        Labelekle(bitkiler);

                        break;
                    default:
                        MessageBox.Show("Choose Category!");
                        break;

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Hangman";
            textBox1.CharacterCasing = CharacterCasing.Upper;
            button3.Enabled = false;
            english = true;
            label1.Text = "Enter Your Guess";
            label1.Location = new Point(700,248);
            label2.Text = "Choose Category";
            button2.Text = "Bring the word";
            button1.Text = "I found the word";

            comboBox1.Items[comboBox1.FindStringExact("Hayvanlar")] = "Animals";
            comboBox1.Items[comboBox1.FindStringExact("Şehirler")] = "Cities";
            comboBox1.Items[comboBox1.FindStringExact("Meyveler ve Sebzeler")] = "Fruit and Vegetables";

            for(int j = 0; j < harfler.Length; j++)
            {
                switch (butons[j].Text)
                {
                    case "Ç":
                        butons[j].Enabled = false;
                        butons[j].BackColor = Color.Black;
                        break;
                    case "Ğ":
                        butons[j].Enabled = false;
                        butons[j].BackColor = Color.Black;
                        break;
                    case "İ":
                        butons[j].Enabled = false;
                        butons[j].BackColor = Color.Black;
                        break;
                    case "Ö":
                        butons[j].Enabled = false;
                        butons[j].BackColor = Color.Black;
                        break;

                }



            }


            for(int j = 0; j < harfler.Length; j++)
            {
                if(butons[j].Text == "Ş")
                {
                    butons[j].Text = "X";
                }
                if (butons[j].Text == "Ü")
                {
                    butons[j].Text = "Q";
                }
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
