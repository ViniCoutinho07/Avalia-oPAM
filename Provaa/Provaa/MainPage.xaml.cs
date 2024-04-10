namespace Provaa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private int n;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Rolar_Selecionador(object sender, EventArgs e)
        {
            int ind = Rolar.SelectedIndex;

            switch (ind)
            {
                case 0:
                    n = 4; break;
                case 1:
                    n = 6; break;
                case 2:
                    n = 10; break;
                case 3:
                    n = 20; break;
                case 4:
                    n = 100; break;
            }
        }
    }

}
