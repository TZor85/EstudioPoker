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

    }
}