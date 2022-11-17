namespace WinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Btn_KlickMich.Text = "Klick mich stärker";
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;

            Btn_KlickMich.Text = "Button wurde angeklickt";

            (sender as Button).BackColor = Color.Red;
        }
    }
}