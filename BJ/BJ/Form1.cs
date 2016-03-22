using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ
{
    public partial class Form1 : Form
    {

        Deck deck = new Deck();
        Player player = new Player(100);
        Dealer dealer = new Dealer();
        int bet = 0;
        bool running = false;
        int DealerTotalCardValue = 0;
        int PlayerCardValue = 0;
      

        public Form1()
        {
            BackgroundImage = Properties.Resources.BlackJack_image4;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _textBoxPlayerPoints.Text = "0";
            textBoxWallet.Text = player.balance.ToString();
            dealer.CheckActiveDeck(deck);
           
        }

        private void _betButton_Click(object sender, EventArgs e)
        {
            bet = 0;

            int.TryParse(_betReadBox.Text, out bet);
            if (bet > player.balance) { MessageBox.Show("You don't have enough CASH!"); }


            if (!running && bet > 0 && bet <= player.balance)
            {
                dealer.CheckActiveDeck(deck);

                player.balance -= bet;

                textBoxWallet.Text = player.balance.ToString();
                dealer.GiveCards(player, dealer);
                running = true;
            }


            Update();
        }


        private void _exitBotton_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void _pickCard_Click(object sender, EventArgs e)
        {
            if (bet > 0 && bet < player.balance)
            {
                player.GetCard(dealer.GiveCard());
                Update();
                PlayerCardValue = StaticMethods.CountValue(player.ShowPlayerHand());
                if (PlayerCardValue > 21) { Loose(); } // dealerwin
            }
        }
  

        private void _stand_Click(object sender, EventArgs e)
        {
            if (DealerTotalCardValue < 17 && bet > 0 && bet < player.balance)
            {
                DealerTotalCardValue = 0;
                while (Rules.GiveDealerCard(DealerTotalCardValue))
                {
                    dealer.GetCardToDealer();
                    DealerTotalCardValue = StaticMethods.CountValue(dealer.ShowDealerHand());
                }
                Update();

                if (!Rules.NotOver21(DealerTotalCardValue))
                {
                    player.balance += bet;
                    player.balance += bet; 
                    Win();
                }
               else if (StaticMethods.CountValue(player.PlayerHand) > StaticMethods.CountValue(dealer.DealerHand))
                {
                    player.balance += bet;
                    player.balance += bet;
                    Win();
                }
                else
                {
                    Loose();
                }
                
            }
            Update();
        }
        private void Loose()
        {       
            PlayerCardValue = 0;
            DealerTotalCardValue = 0;
            MessageBox.Show("YOU LOOSE!!"); bet = 0; running = false; ;
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            _betReadBox.Text = "";
            Update();
            if(player.balance < 1) { MessageBox.Show("OUT OF CASH!!");Environment.Exit(-1); }
        }
        private void Win()
        {
            PlayerCardValue = 0;
            DealerTotalCardValue = 0;
            MessageBox.Show("YOU WIN!!");
            bet = 0;
            running = false; ;
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            _betReadBox.Text = "";
            Update();
        }
        private new void Update()
        {
            _playerPrint.Text = player.GetCardText();
            _dealerPrint.Text = dealer.GetCardText();
            textBoxWallet.Text = player.balance.ToString();
            _textBoxDealerPoints.Text = StaticMethods.CountValue(dealer.ShowDealerHand()).ToString();
            _textBoxPlayerPoints.Text = StaticMethods.CountValue(player.ShowPlayerHand()).ToString();
        }

    }
}
