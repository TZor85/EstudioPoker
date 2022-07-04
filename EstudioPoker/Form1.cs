namespace EstudioPoker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            var card1 = CardSelector();
            var card2 = CardSelector();

            while (card2 == card1)
            {
                card2 = CardSelector();
            }

            primeraCarta.Load($"../../../images/{card1}.png");
            segundaCarta.Load($"../../../images/{card2}.png");
        }

        private string CardSelector()
        {
            var chars = "23456789TJQKA";
            var color = "cdhs";
            var random = new Random();
            var number = new string(Enumerable.Repeat(chars, 1).Select(s => s[random.Next(s.Length)]).ToArray());
            var colorNumber = new string(Enumerable.Repeat(color, 1).Select(s => s[random.Next(s.Length)]).ToArray());

            return number + colorNumber;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbBBvsLimp_Heads_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

      

        private void rbBBvsOR_Heads_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

        private void rbBBvsAllin_Heads_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

        private void ChangeStacksHeadsUp()
        {
            rbStack3.Text = "15 BBs";
            rbStack4.Text = "14-12 BBs";
            rbStack5.Text = "12-10 BBs";
            rbStack6.Text = "10-8 BBs";
            rbStack7.Text = "8-6 BBs";
            rbStack8.Text = "6-5 BBs";

            rbStack6.Visible = true;
            rbStack7.Visible = true;
            rbStack8.Visible = true;
        }

        private void ChangeStack3Handed()
        {
            rbStack3.Text = "12.5 BBs";
            rbStack4.Text = "10 BBs";
            rbStack5.Text = "8 BBs";

            rbStack6.Visible = false;
            rbStack7.Visible = false;
            rbStack8.Visible = false;
        }

        private void rbBtnOr_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStack3Handed();
        }

        private void rbSBOR_Heads_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

        private void rbBBvsLimp_Heads_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

        private void rbBBvsOR_Heads_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }

        private void rbBBvsAllin_Heads_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStacksHeadsUp();
        }
    }
}