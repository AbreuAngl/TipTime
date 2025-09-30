namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //ValorTotalEntry.Text = "0";
            PorcentagemSlider.Value = 15;
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
            try
            {
                if (!string.IsNullOrWhiteSpace(ValorTotalEntry.Text))
                {
                    double porcentagem = PorcentagemSlider.Value;
                    PorcentagemGorjeta.Text = porcentagem.ToString("f");
                    double ValorTotal = double.Parse(ValorTotalEntry.Text);
                    double gorjeta = ValorTotal * (porcentagem / 100);
                    ValorGorjetaLabel.Text = gorjeta.ToString("c");
                    ValorTotalLabel.Text = $"R$ {ValorTotal}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DisplayAlert("Erro", "Digite um valor numerico", "Ok");         
            }



        }
    }
}
