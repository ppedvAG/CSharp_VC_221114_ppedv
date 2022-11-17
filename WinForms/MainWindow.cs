namespace WinForms
{
    enum TestEnum { Zustand1, Zustand2}

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Btn_KlickMich.Text = "Klick mich stärker";

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                Cbb_Auswahl.Items.Add((TestEnum)i);
            }
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;

            Btn_KlickMich.Text = "Button wurde angeklickt";

            (sender as Button).BackColor = Color.Red;

            Lbl_Output.Text = Cbb_Auswahl.SelectedItem.ToString();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Möchtest du das Programm wirklich beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainWindow();

            form.Text = "Neues Fenster";

            form.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainWindow();

            form.Text = "Neues Dialog-Fenster";

            if (form.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "OK wurde angeklickt";

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}