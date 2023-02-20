namespace Roulette
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            RouletteGameControler.Start();
        }

        private void OnBtnNewGameClick(object sender, EventArgs e)
        {
            RouletteGameControler.NewGame();
        }

        private void OnBtnSpinClick(object sender, EventArgs e)
        {
            RouletteGameControler.Spin();
        }
    }
}