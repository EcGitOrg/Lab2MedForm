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
        Player player = new Player();
        Dealer dealer = new Dealer();
        int bet = 0;
        bool running = false;
        bool validBet = false;
        int DealerTotalCardValue = 0;
        int PlayerCardValue = 0;


        public Form1()
        {
            BackgroundImage = Properties.Resources.BlackJack_image4;
            InitializeComponent();
            label1.Font = new Font("", 80);
            label1.Text = "🃉";
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
                validBet = true;
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
            if (validBet)
            {
                player.GetCard(dealer.GiveCard());
                Update();
                PlayerCardValue = StaticMethods.CountValue(player.ShowPlayerHand());
                if (PlayerCardValue > 21) { Loose(); }
            }
        }


        private void _stand_Click(object sender, EventArgs e)
        {
            if (DealerTotalCardValue < 17 && validBet)
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
            MessageBox.Show("YOU LOOSE!!");
            ClearVisualCards();
            if (player.balance < 1) { MessageBox.Show("OUT OF CASH!!"); Environment.Exit(-1); }
        }
        private void Win()
        {
            MessageBox.Show("YOU WIN!!");
            ClearVisualCards();
        }
        private new void Update()
        {

            int CardNr = 0;
            foreach (var item in player.PlayerHand)
            {
                //  ♡  ♢  ♠  ♣
                if (item._Color == "♡" || item._Color == "♢") { ForeColor = Color.Red; }
                if (item._Color == "♠" || item._Color == "♣") { ForeColor = Color.Black; }
                Card card = player.GetCard(CardNr);
                if (CardNr == 0)
                    _playerPrintsCard1.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}      {card._Color}{card.Type}";
                if (CardNr == 1)
                    _playerPrintsCard2.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}      {card._Color}{card.Type}";
                if (CardNr == 2)
                    _playerPrintsCard3.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}     {card._Color }{card.Type}";
                if (CardNr == 3)
                    _playerPrintsCard4.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}     {card._Color}{card.Type}";
                if (CardNr == 4)
                    _playerPrintsCard5.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}     {card._Color}{card.Type}";
                if (CardNr == 5)
                    _playerPrintsCard6.Text = $"{card.Type}{card._Color} {nl()} {nl()} {nl()}      {card._Color}{card.Type}";
                CardNr++;
            }
            ForeColor = Color.Black;

            _dealerPrint.Text = dealer.GetCardText();
            textBoxWallet.Text = player.balance.ToString();
            _textBoxDealerPoints.Text = StaticMethods.CountValue(dealer.ShowDealerHand()).ToString();
            _textBoxPlayerPoints.Text = StaticMethods.CountValue(player.ShowPlayerHand()).ToString();
        }
        public void ClearVisualCards()
        {
            bet = 0;
            running = false; ;
            validBet = false;
            PlayerCardValue = 0;
            DealerTotalCardValue = 0;
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            _betReadBox.Text = "";
            Update();

            _playerPrintsCard1.Text = "";
            _playerPrintsCard2.Text = "";
            _playerPrintsCard3.Text = "";
            _playerPrintsCard4.Text = "";
            _playerPrintsCard5.Text = "";
            _playerPrintsCard6.Text = "";
        }
        public string nl()
        {
            return Environment.NewLine;
        }


    }
}
