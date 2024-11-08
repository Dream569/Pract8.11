namespace Pract8
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Image LMG = new Image();
            LMG.Source = ImageSource.FromFile("dotnet_bot.svg");
            sl1.Children.Add(LMG);
            button1.ImageSource = ImageSource.FromFile("dotnet_bot.svg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            EntryCell p = new EntryCell();
            p.Placeholder = "Введите телефон";
            p.Keyboard = Keyboard.Numeric;
            Phone.Add(p);
        }

        private void dateBr_DateSelected(object sender, DateChangedEventArgs e)
        {
            int ag = DateTime.Now.Year - dateBr.Date.Year;
            if (DateTime.Now.Month < dateBr.Date.Month ||
                (DateTime.Now.Month == dateBr.Date.Month &&
                DateTime.Now.Day < dateBr.Date.Day))
                ag--;
            Age.Text = "Возраст - " + ag.ToString();
            foreach(var item in table)
            {

            }
        }
    }

}
