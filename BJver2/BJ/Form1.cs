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



        int PlayerCardValue = 0;
        int PlayerCardAceValue = 0;
        int PlayerWinValue = 0;

        int DealerCardValue = 0;
        int DealerCardAceValue = 0;
        int DealerWinValue = 0;



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
            bid1.BackColor = Color.Transparent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _textBoxPlayerPoints.Text = "0";
            textBoxWallet.Text = player.balance.ToString();
            dealer.CheckActiveDeck(deck);


        }
        /// <summary>
        /// Gets a valid bet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
         /// QUIT
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void _exitBotton_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
        /// <summary>
        /// Give player a card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pickCard_Click(object sender, EventArgs e)
        {
            if (validBet)
            {
                player.GetCard(dealer.GiveCard());
                Update();
                PlayerCardValue = StaticMethods.CountValue(player.ShowPlayerHand());
                if (PlayerCardValue > 21)
                {
                    Loose();
                }
            }
        }

        /// <summary>
        /// Player stands and let dealer get cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _stand_Click(object sender, EventArgs e)
        {
            if (DealerCardValue < 17 && validBet)
            {
                DealerCardValue = 0;
                while (Rules.GiveDealerCard(DealerCardValue))
                {
                    dealer.GetCardToDealer();
                    DealerCardValue = StaticMethods.CountValue(dealer.ShowDealerHand());
                }
                Update();
                if (!Rules.NotOver21(DealerCardValue))
                {
                    Win();
                }
                else if (PlayerWinValue == 21 && DealerWinValue == 21)
                {
                    Draw();
                }
                else if (PlayerWinValue > DealerWinValue)
                {
                    Win();
                }
                else
                {
                    Loose();
                }
            }
            Update();
        }
        /// <summary>
        /// Loose msg
        /// </summary>
        private void Loose()
        {
            MessageBox.Show("YOU LOOSE!!");
            ClearVisualCards();
            if (player.balance < 1)
            {
                MessageBox.Show("OUT OF CASH!!");
                Environment.Exit(-1);
            }
        }
        /// <summary>
        /// Win msg
        /// </summary>
        private void Win()
        {
            player.balance += bet;
            player.balance += bet;
            MessageBox.Show("YOU WIN!!");
            ClearVisualCards();
        }
        private void Draw()
        {
            player.balance += bet;
            MessageBox.Show("DRAW!!");
            ClearVisualCards();
        }
        /// <summary>
        /// Cleans Board
        /// </summary>
        public void ClearVisualCards()
        {
            bet = 0;
            running = false; ;
            validBet = false;
            PlayerCardValue = 0;
            DealerCardValue = 0;
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            _betReadBox.Text = "";
            Update();
        }
        /// <summary>
        /// Updates all boards textboxes and stuff
        /// </summary>
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

            PlayerWinValue = Rules.SetWinValue(PlayerCardAceValue, PlayerCardValue, player);
            DealerWinValue = Rules.SetWinValue(DealerCardAceValue, DealerCardValue, dealer);

            _textBoxDealerPoints.Text = Rules.GetBestValue(DealerCardAceValue, DealerCardValue, dealer).ToString();
            _textBoxPlayerPoints.Text = Rules.GetBestValue(PlayerCardAceValue, PlayerCardValue, player).ToString();
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
