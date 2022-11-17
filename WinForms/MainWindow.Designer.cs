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
            this.SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            this.Btn_KlickMich.Location = new System.Drawing.Point(12, 12);
            this.Btn_KlickMich.Name = "Btn_KlickMich";
            this.Btn_KlickMich.Size = new System.Drawing.Size(246, 89);
            this.Btn_KlickMich.TabIndex = 0;
            this.Btn_KlickMich.Text = "Klick Mich";
            this.Btn_KlickMich.UseVisualStyleBackColor = true;
            this.Btn_KlickMich.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_KlickMich);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_KlickMich;
    }
}