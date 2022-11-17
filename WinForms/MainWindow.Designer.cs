namespace WinForms
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_KlickMich = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cbb_Auswahl = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            this.Btn_KlickMich.Location = new System.Drawing.Point(29, 126);
            this.Btn_KlickMich.Name = "Btn_KlickMich";
            this.Btn_KlickMich.Size = new System.Drawing.Size(246, 89);
            this.Btn_KlickMich.TabIndex = 0;
            this.Btn_KlickMich.Text = "Klick Mich";
            this.Btn_KlickMich.UseVisualStyleBackColor = true;
            this.Btn_KlickMich.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(29, 383);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(195, 32);
            this.Lbl_Output.TabIndex = 2;
            this.Lbl_Output.Text = "Ich bin ein String";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(438, 389);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 36);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cbb_Auswahl
            // 
            this.Cbb_Auswahl.FormattingEnabled = true;
            this.Cbb_Auswahl.Location = new System.Drawing.Point(341, 106);
            this.Cbb_Auswahl.Name = "Cbb_Auswahl";
            this.Cbb_Auswahl.Size = new System.Drawing.Size(242, 40);
            this.Cbb_Auswahl.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerDialogToolStripMenuItem,
            this.neuesFensterToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // neuerDialogToolStripMenuItem
            // 
            this.neuerDialogToolStripMenuItem.Name = "neuerDialogToolStripMenuItem";
            this.neuerDialogToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.neuerDialogToolStripMenuItem.Text = "Neuer Dialog";
            this.neuerDialogToolStripMenuItem.Click += new System.EventHandler(this.neuerDialogToolStripMenuItem_Click);
            // 
            // neuesFensterToolStripMenuItem
            // 
            this.neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            this.neuesFensterToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            this.neuesFensterToolStripMenuItem.Click += new System.EventHandler(this.neuesFensterToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(493, 313);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(150, 46);
            this.Btn_Ok.TabIndex = 6;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Cbb_Auswahl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_KlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_KlickMich;
        private Button button1;
        private Label Lbl_Output;
        private CheckBox checkBox1;
        private ComboBox Cbb_Auswahl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem neuerDialogToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private Button Btn_Ok;
    }
}