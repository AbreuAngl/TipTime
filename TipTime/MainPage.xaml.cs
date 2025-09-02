namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Por15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Por20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }

        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double total = double.Parse(ValorTotalEntry.Text);
            int porcentagem = int.Parse(PorcentagemSlider.Text);
            int gorjeta = int.Parse(PorcentagemGorjeta.Text);
            gorjeta = total * (porcentagem / 100);



        }
    }
}
