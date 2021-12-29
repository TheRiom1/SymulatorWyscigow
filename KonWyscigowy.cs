using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DzienNaWyscigach
{
    public class KonWyscigowy
    {
        public int PozycjaStart; //miejsce w ktorym zaczyna sie PictureBox
        public int DlugoscToru; //długość trasy wyscigu
        public PictureBox MyPictureBox = null; //Obiekt picturebox przechowujacy grafike
        public int Location = 0; //polozenie na torze wyscigowym
        public Random MyRandom; //instancja klasy random
     
        public bool Run()
        {
            Random MyRandom = new Random();
            int movement = MyRandom.Next(1, 4);
            
            Point p = MyPictureBox.Location; //pobieram aktualna pozycje obrazka
            p.X += movement; //losowe przesuniecie obrazka
            MyPictureBox.Location = p; //aktualizacja pozycji
            int position = p.X;
            if (position >= DlugoscToru) //gdy przekroczono linie mety, obiekt wygral wyscig
            {
                return true;
            }
            else return false;
          
        }
        public void UstawPozStartowa()
        {
            Location = 0; //zerowanie polozenia
            MyPictureBox.Left = PozycjaStart; //ustawienie obrazka na pozycji startowej
        }
    }
}
