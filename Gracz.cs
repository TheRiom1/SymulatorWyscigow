using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienNaWyscigach
{

    public class Gracz
    {
        
        public string Name;  //imie gracza
        public Zaklad MojZaklad;  //instancja klasy Zaklad, przechowuje dane o zakladzie
        public int Gotowka; //ilosc pieniedzy posiadanych przez gracza

        public RadioButton MyRadioButton; //pole wyboru (kontrolka GUI na formularzu)
        public Label MyLabel; //pole tektowe (kontrolka GUI na formularzu

        //konstruktor przyjmujacy 5 parametrow
        public Gracz(string Name, Zaklad MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        {
            this.Name = Name;
            this.MojZaklad = MyBet;
            this.Gotowka = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }

        //metoda ustawiająca opis zakladu
        public void UpdateLabels()
        {
            if (MojZaklad == null)
            {
                MyLabel.Text = String.Format("{0} nie obstawił zakładu", Name);
            }
            else
            {
                MyLabel.Text = MojZaklad.GetDescription();
            }
            MyRadioButton.Text = Name + " ma " + Gotowka + " złotych";
        }

        //czyszczenie zakladu
        public void CzyszczenieZakladu()
        {
            MojZaklad.IloscGotowki = 0;
        }
    
        //obstawianie zakladu
        public bool ObstawZaklad(int Amount, int Dog)
        {
            //jesli gracz ma wystarczajaca ilosc pieniedzy - ustala nowy zaklad i przechowuje go w polu MojZaklad
            //jesli nie - zwraca falsz
            if (Amount <= Gotowka)
            {
                MojZaklad = new Zaklad(Amount, Dog, this);  //slowo kluczowe this sluzy do przekazania referencji obiektu Gracz
                return true;
            }
            MessageBox.Show("Masz za mało pieniędzy!");
            return false;
        }

        //wypłaca należna zwycięzcy kwotę
        public void Wyplata(int Winner)
        {
            Gotowka += MojZaklad.PayOut(Winner);
        }
    }
}
