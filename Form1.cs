using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienNaWyscigach
{
    public partial class Form1 : Form
    {
        //Tworze dwie tablice, pierwsza z obiektami typu kon wyscigowy, druga z obiektami gracze
        KonWyscigowy[] konie = new KonWyscigowy[4]; 
        Gracz[] gracze = new Gracz[3];


        public Form1()
        {
            InitializeComponent();
            UstawienieToru();
        }

        //metoda pozwalajaca na ustawienie wartosci oraz obietkow na torze
        private void UstawienieToru() { 
            //wyswietlanie na formularzu informacji o zakladach
            MinZaklad.Text = string.Format("Minimalny zakład wynosi: " + (int)BetAmount.Minimum + " zł a maksymalny: " + (int)BetAmount.Maximum + " zł");

            int pozycjaStartowa = Kon1.Left; //startowa pozycja odpowiada miejscu, w ktorym rozpoczyna sie PictureBox
            int dlugoscToru = Tor.Size.Width; //szerokosc w pikselach obiektu PictureBox zawierajacego grafike toru

            konie[0] = new KonWyscigowy()
            {
                MyPictureBox = Kon1,
                DlugoscToru = dlugoscToru,
                PozycjaStart = pozycjaStartowa
            };
            konie[1] = new KonWyscigowy()
            {
                MyPictureBox = Kon2,
                DlugoscToru = dlugoscToru,
                PozycjaStart = pozycjaStartowa
            };
            konie[2] = new KonWyscigowy()
            {
                MyPictureBox = Kon3,
                DlugoscToru = dlugoscToru,
                PozycjaStart = pozycjaStartowa
            };
            konie[3] = new KonWyscigowy()
            {
                MyPictureBox = Kon4,
                DlugoscToru = dlugoscToru,
                PozycjaStart = pozycjaStartowa
            };

            gracze[0] = new Gracz("Janek", null, 50, JanekButton, ZakladJanka);
            gracze[1] = new Gracz("Bartek", null, 75, BartekButton, ZakladBartka);
            gracze[2] = new Gracz("Arek", null, 45, ArekButton, ZakladArka);

            foreach (Gracz guy in gracze)
            {
                guy.UpdateLabels();
            }
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        //wybor osoby za pomoca przycisku RadioButton powoduje wyswietlenie odpowiedniego tekstu na ekranie
        private void JanekButton_CheckedChanged(object sender, EventArgs e)
        {
            ImieGracza.Text = "Janek";
        }

        private void BartekButton_CheckedChanged(object sender, EventArgs e)
        {
            ImieGracza.Text = "Bartek";
        }

        private void ArekButton_CheckedChanged(object sender, EventArgs e)
        {
            ImieGracza.Text = "Bartek";
        }

        //przycisk odpowiadajacy za obstawienie zakladu wywoluje metode ButtonChecked, ktora odswieza przyciski wyboru oraz wywoluje metode PlaceBet klasy Guy
        private void BetButton_Click(object sender, EventArgs e)
        {
            
            if (JanekButton.Checked)
            {
                ButtonChecked(0);
            }
            if (BartekButton.Checked)
            {
                ButtonChecked(1);
            }
            if (ArekButton.Checked)
            {
                ButtonChecked(2);
            }



        }
        private void ButtonChecked(int num)
        {
            gracze[num].ObstawZaklad((int)BetAmount.Value, (int)DogChoice.Value);
            gracze[num].UpdateLabels();

        }
        //uruchomienie wyscigu
        private void Wyscig_Click(object sender, EventArgs e)
        {
            int Winner;
            bool noWinner = true;
            

            while(noWinner)
            {
                for (int i = 0; i < konie.Length; i++)
                {
                    Thread.Sleep(1);
                    //run zwraca true jesli pies jest zwyciezca
                    if (konie[i].Run())
                    {
                        noWinner = false;
                        //zwracam numer psa,ktory jest o jeden wiekszy od indeksu w tablicy
                        Winner = i + 1;
                        //wyswietlam informacje o zwyciezcy
                        MessageBox.Show("Zwyciezyl pies: " + Winner);

                        //
                        foreach (Gracz guy in gracze)
                        {
                            if (guy.MojZaklad != null)
                            {
                                guy.Wyplata(Winner);
                                guy.MojZaklad = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (KonWyscigowy dog in konie)
                        {
                            dog.UstawPozStartowa();
                        }
                    }
                    
                }
            }
        }

    
        
    }
}
