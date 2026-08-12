namespace Bhaskara
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcularBhaskara_Clicked(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(entryA.Text);
            float b = Convert.ToSingle(entryB.Text);
            float c = Convert.ToSingle(entryC.Text);

            float delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                labelX1.Text = "Não existem raízes reais";
            }
            else
            {

                float x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);

                labelX1.Text = x1.ToString();
                labelX2.Text = x2.ToString();
            }
        }
    }
}
