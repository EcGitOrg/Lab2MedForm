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
           //BackgroundImage = Properties.Resources.BlackJack_image4;
            InitializeComponent();
            label1.Font = new Font("", 80);
            label2.Font = new Font("", 80);

            //var pos = this.PointToScreen(label1.Location);
            //pos = BackgroundImage.PointToClient(pos);
            //label1.Parent = pictureBox1;
            //label1.Location = pos;
            //label1.BackColor = Color.Transparent;
            //  label1.ForeColor = Color.Black;
          
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            _exitBotton.BackColor = Color.Transparent;
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
          
            string VisualCardHandPlayer = "";
            string VisualCardHandDealer = "";
            int CardNr = 0;
            foreach (var item in player.PlayerHand)
            {           
                string VisualCard = StaticMethods.GetFormCard(item);
                VisualCardHandPlayer += VisualCard;
                Card card = player.GetCard(CardNr);            
            }
            foreach (var item in dealer.DealerHand)
            {
                string VisualCard = StaticMethods.GetFormCard(item);
                VisualCardHandDealer += VisualCard;
                Card card = player.GetCard(CardNr);
            }

            label1.Text = VisualCardHandPlayer;
            label2.Text = VisualCardHandDealer;

           
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

     
        }
        public string nl()
        {
            return Environment.NewLine;
        }

        private void bid1_Click(object sender, EventArgs e)
        {
            bet += 1; Update();
        }

        private void bid5_Click(object sender, EventArgs e)
        {
            bet += 5; Update();
        }

        private void bid10_Click(object sender, EventArgs e)
        {
            bet += 10; Update();
        }

        private void bid25_Click(object sender, EventArgs e)
        {
            bet += 25; Update();
        }

        private void bid100_Click(object sender, EventArgs e)
        {
            bet += 100; Update();
        }
    }
}
