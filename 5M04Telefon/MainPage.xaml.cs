namespace _5M04Telefon
{
    public partial class MainPage : ContentPage
    {
        private string numer = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCallClicked(object sender, EventArgs e)
        {
            lblWynik.Text = "dzwonię pod " + numer;
        }
        private void btn1Clicked(object sender, EventArgs e)
        {
            numer += "1";
            lblNumer.Text = numer;
        }
        private void btn2Clicked(object sender, EventArgs e)
        {
            numer += "2";
            lblNumer.Text = numer;
        }
        private void btn3Clicked(object sender, EventArgs e)
        {
            numer += "3";
            lblNumer.Text = numer;
        }
        private void btnNumberClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            numer += btn.Text;
            lblNumer.Text = numer;
        }
        private void btnDelClicked(object sender, EventArgs e)
        {
            if (numer.Length == 0)
                return;
            numer = numer.Remove(numer.Length - 1);
            lblNumer.Text = numer;
        }


    }

}
