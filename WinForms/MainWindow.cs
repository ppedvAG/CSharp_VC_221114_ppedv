namespace WinForms
{
    //Bsp-Enum
    enum TestEnum { Zustand1, Zustand2}

    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Konstruktor f�r das Form (Fenster)
        public MainWindow()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Neuzuweisung einer Property eines Buttons
            Btn_KlickMich.Text = "Klick mich st�rker";

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                //Bef�llung der ComboBox mit Enum-Elementen
                Cbb_Auswahl.Items.Add((TestEnum)i);
            }
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'OK# reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.DarkOrange;
            
            Btn_KlickMich.Text = "Button wurde angeklickt";

            //Neuzuweisung einer Eigenschaft sender (Ausl�ser) des Events
            (sender as Button).BackColor = Color.Red;

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //�bertrag des Elements in das Label
                Lbl_Output.Text = Cbb_Auswahl.SelectedItem.ToString();
        }

        private void schlie�enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox
            DialogResult result = MessageBox.Show("M�chtest du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Pr�fung des geklickten Buttons
            if (result == DialogResult.Yes)
                //Schlie�end des Fensters
                this.Close();

            //Schlie�end der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form form = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            form.Text = "Neues Fenster";
            //�ffnen des Forms als gleichberechtigtes Fenster
            form.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form form = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            form.Text = "Neues Dialog-Fenster";
            //�ffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und �berpr�fung des zur�ckgegebenen DialogResults (s.u.)
            if (form.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "OK wurde angeklickt";

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults des DialogFensters (wird von ShowDialog zur�ckgegeben)
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}