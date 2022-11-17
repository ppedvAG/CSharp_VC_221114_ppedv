namespace WinForms
{
    //Bsp-Enum
    enum TestEnum { Zustand1, Zustand2}

    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Konstruktor für das Form (Fenster)
        public MainWindow()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Neuzuweisung einer Property eines Buttons
            Btn_KlickMich.Text = "Klick mich stärker";

            for (int i = 0; i < Enum.GetValues(typeof(TestEnum)).Length; i++)
            {
                //Befüllung der ComboBox mit Enum-Elementen
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

            //Neuzuweisung einer Eigenschaft sender (Auslöser) des Events
            (sender as Button).BackColor = Color.Red;

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //Übertrag des Elements in das Label
                Lbl_Output.Text = Cbb_Auswahl.SelectedItem.ToString();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox
            DialogResult result = MessageBox.Show("Möchtest du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Prüfung des geklickten Buttons
            if (result == DialogResult.Yes)
                //Schließend des Fensters
                this.Close();

            //Schließend der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form form = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            form.Text = "Neues Fenster";
            //Öffnen des Forms als gleichberechtigtes Fenster
            form.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form form = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            form.Text = "Neues Dialog-Fenster";
            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Überprüfung des zurückgegebenen DialogResults (s.u.)
            if (form.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "OK wurde angeklickt";

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults des DialogFensters (wird von ShowDialog zurückgegeben)
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}