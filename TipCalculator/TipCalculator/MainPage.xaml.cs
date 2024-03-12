namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButton15Percentage_Clicked(System.Object sender, System.EventArgs e)
        {
            Slider.Value = 15;
        }

        private void OnButton20Percentage_Clicked(System.Object sender, System.EventArgs e)
        {
            Slider.Value = 20;

        }

        private void OnRoundDownButton_Clicked(System.Object sender, System.EventArgs e)
        {

            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(entry.Text.ToString());
            double percent = Math.Floor(Slider.Value);
            double totalResult = roundedResult + amount;


            TipValue.Text = roundedResult.ToString() + "R$";
            TotalValue.Text = totalResult.ToString() + "R$";
            TipPercentageValue.Text = percent.ToString() + '%';

        }

        private void RoundUpButton_Clicked(System.Object sender, System.EventArgs e)
        {

            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(entry.Text.ToString());
            double percent = Math.Ceiling(Slider.Value);
            double totalResult = roundedResult + amount;


            TipValue.Text = roundedResult.ToString() + "R$";
            TotalValue.Text = totalResult.ToString() + "R$";
            TipPercentageValue.Text = percent.ToString() + '%';

        }
        private double CalculateTip()
        {

            double amount = Convert.ToDouble(entry.Text.ToString());
            double percent = Slider.Value;
 

            double result = amount * (percent / 100);
            return result;
            



        }
    }

}
