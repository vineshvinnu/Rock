using System;
using System.Windows.Forms;

namespace RockPaperScissorsWinForms
{
    public partial class Form1 : Form
    {
        private int userScore = 0;
        private int computerScore = 0;
        // Declare controls as private fields
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnReset;
        private PictureBox picUser;
        private PictureBox picComputer;
        private Label lblResult;
        private Label lblUserScore;
        private Label lblComputerScore;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("scissors");
        }

       

        private void PlayGame(string userChoice)
        {
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoice = choices[rand.Next(choices.Length)];

            picUser.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(userChoice);
            picComputer.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(computerChoice);

            string result;
            if (userChoice == computerChoice)
                result = "It's a draw!";
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                result = "You win!";
                userScore++;
            }
            else
            {
                result = "Computer wins!";
                computerScore++;
            }

            lblResult.Text = result;
            lblUserScore.Text = $"You: {userScore}";
            lblComputerScore.Text = $"Computer: {computerScore}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            userScore = 0;
            computerScore = 0;
            lblUserScore.Text = "You: 0";
            lblComputerScore.Text = "Computer: 0";
            lblResult.Text = "Result";
            picUser.Image = null;
            picComputer.Image = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Rock, Paper, Scissors!\nChoose an option to begin.", "Welcome");
        }
    }
}