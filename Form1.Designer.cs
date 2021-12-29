
namespace DzienNaWyscigach
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.JanekButton = new System.Windows.Forms.RadioButton();
            this.BartekButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImieGracza = new System.Windows.Forms.Label();
            this.ZakladArka = new System.Windows.Forms.Label();
            this.ZakladBartka = new System.Windows.Forms.Label();
            this.ZakladJanka = new System.Windows.Forms.Label();
            this.MinZaklad = new System.Windows.Forms.Label();
            this.DogChoice = new System.Windows.Forms.NumericUpDown();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Wyscig = new System.Windows.Forms.Button();
            this.BetButton = new System.Windows.Forms.Button();
            this.ArekButton = new System.Windows.Forms.RadioButton();
            this.Kon4 = new System.Windows.Forms.PictureBox();
            this.Kon3 = new System.Windows.Forms.PictureBox();
            this.Kon2 = new System.Windows.Forms.PictureBox();
            this.Kon1 = new System.Windows.Forms.PictureBox();
            this.Tor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tor)).BeginInit();
            this.SuspendLayout();
            // 
            // JanekButton
            // 
            this.JanekButton.AutoSize = true;
            this.JanekButton.Location = new System.Drawing.Point(16, 53);
            this.JanekButton.Name = "JanekButton";
            this.JanekButton.Size = new System.Drawing.Size(54, 17);
            this.JanekButton.TabIndex = 0;
            this.JanekButton.TabStop = true;
            this.JanekButton.Text = "Janek";
            this.JanekButton.UseVisualStyleBackColor = true;
            this.JanekButton.CheckedChanged += new System.EventHandler(this.JanekButton_CheckedChanged);
            // 
            // BartekButton
            // 
            this.BartekButton.AutoSize = true;
            this.BartekButton.Location = new System.Drawing.Point(16, 86);
            this.BartekButton.Name = "BartekButton";
            this.BartekButton.Size = new System.Drawing.Size(56, 17);
            this.BartekButton.TabIndex = 1;
            this.BartekButton.TabStop = true;
            this.BartekButton.Text = "Bartek";
            this.BartekButton.UseVisualStyleBackColor = true;
            this.BartekButton.CheckedChanged += new System.EventHandler(this.BartekButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ImieGracza);
            this.groupBox1.Controls.Add(this.ZakladArka);
            this.groupBox1.Controls.Add(this.ZakladBartka);
            this.groupBox1.Controls.Add(this.ZakladJanka);
            this.groupBox1.Controls.Add(this.MinZaklad);
            this.groupBox1.Controls.Add(this.DogChoice);
            this.groupBox1.Controls.Add(this.BetAmount);
            this.groupBox1.Controls.Add(this.Wyscig);
            this.groupBox1.Controls.Add(this.BetButton);
            this.groupBox1.Controls.Add(this.ArekButton);
            this.groupBox1.Controls.Add(this.BartekButton);
            this.groupBox1.Controls.Add(this.JanekButton);
            this.groupBox1.Location = new System.Drawing.Point(97, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "na psa numer: ";
            // 
            // ImieGracza
            // 
            this.ImieGracza.AutoSize = true;
            this.ImieGracza.Location = new System.Drawing.Point(28, 173);
            this.ImieGracza.Name = "ImieGracza";
            this.ImieGracza.Size = new System.Drawing.Size(60, 13);
            this.ImieGracza.TabIndex = 12;
            this.ImieGracza.Text = "ImieGracza";
            // 
            // ZakladArka
            // 
            this.ZakladArka.AutoSize = true;
            this.ZakladArka.Location = new System.Drawing.Point(321, 124);
            this.ZakladArka.Name = "ZakladArka";
            this.ZakladArka.Size = new System.Drawing.Size(65, 13);
            this.ZakladArka.TabIndex = 11;
            this.ZakladArka.Text = "Zaklad Arka";
            // 
            // ZakladBartka
            // 
            this.ZakladBartka.AutoSize = true;
            this.ZakladBartka.Location = new System.Drawing.Point(321, 86);
            this.ZakladBartka.Name = "ZakladBartka";
            this.ZakladBartka.Size = new System.Drawing.Size(74, 13);
            this.ZakladBartka.TabIndex = 10;
            this.ZakladBartka.Text = "Zaklad Bartka";
            // 
            // ZakladJanka
            // 
            this.ZakladJanka.AutoSize = true;
            this.ZakladJanka.Location = new System.Drawing.Point(321, 54);
            this.ZakladJanka.Name = "ZakladJanka";
            this.ZakladJanka.Size = new System.Drawing.Size(72, 13);
            this.ZakladJanka.TabIndex = 9;
            this.ZakladJanka.Text = "Zaklad Janka";
            // 
            // MinZaklad
            // 
            this.MinZaklad.AutoSize = true;
            this.MinZaklad.Location = new System.Drawing.Point(13, 22);
            this.MinZaklad.Name = "MinZaklad";
            this.MinZaklad.Size = new System.Drawing.Size(127, 13);
            this.MinZaklad.TabIndex = 8;
            this.MinZaklad.Text = "Minimalny zakład wynosi:";
            // 
            // DogChoice
            // 
            this.DogChoice.Location = new System.Drawing.Point(435, 174);
            this.DogChoice.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogChoice.Name = "DogChoice";
            this.DogChoice.Size = new System.Drawing.Size(81, 20);
            this.DogChoice.TabIndex = 7;
            this.DogChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BetAmount
            // 
            this.BetAmount.Location = new System.Drawing.Point(239, 179);
            this.BetAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(81, 20);
            this.BetAmount.TabIndex = 6;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Wyscig
            // 
            this.Wyscig.Location = new System.Drawing.Point(617, 167);
            this.Wyscig.Name = "Wyscig";
            this.Wyscig.Size = new System.Drawing.Size(91, 40);
            this.Wyscig.TabIndex = 5;
            this.Wyscig.Text = "Start";
            this.Wyscig.UseVisualStyleBackColor = true;
            this.Wyscig.Click += new System.EventHandler(this.Wyscig_Click);
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(99, 159);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(91, 40);
            this.BetButton.TabIndex = 4;
            this.BetButton.Text = "stawia";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // ArekButton
            // 
            this.ArekButton.AutoSize = true;
            this.ArekButton.Location = new System.Drawing.Point(16, 124);
            this.ArekButton.Name = "ArekButton";
            this.ArekButton.Size = new System.Drawing.Size(47, 17);
            this.ArekButton.TabIndex = 2;
            this.ArekButton.TabStop = true;
            this.ArekButton.Text = "Arek";
            this.ArekButton.UseVisualStyleBackColor = true;
            this.ArekButton.CheckedChanged += new System.EventHandler(this.ArekButton_CheckedChanged);
            // 
            // Kon4
            // 
            this.Kon4.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.Kon4.Location = new System.Drawing.Point(131, 235);
            this.Kon4.Name = "Kon4";
            this.Kon4.Size = new System.Drawing.Size(89, 37);
            this.Kon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kon4.TabIndex = 7;
            this.Kon4.TabStop = false;
            // 
            // Kon3
            // 
            this.Kon3.Image = global::DzienNaWyscigach.Properties.Resources.dog;
            this.Kon3.Location = new System.Drawing.Point(131, 179);
            this.Kon3.Name = "Kon3";
            this.Kon3.Size = new System.Drawing.Size(89, 37);
            this.Kon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kon3.TabIndex = 6;
            this.Kon3.TabStop = false;
            // 
            // Kon2
            // 
            this.Kon2.Image = global::DzienNaWyscigach.Properties.Resources.konGrafika1;
            this.Kon2.Location = new System.Drawing.Point(131, 121);
            this.Kon2.Name = "Kon2";
            this.Kon2.Size = new System.Drawing.Size(89, 29);
            this.Kon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kon2.TabIndex = 5;
            this.Kon2.TabStop = false;
            // 
            // Kon1
            // 
            this.Kon1.Image = global::DzienNaWyscigach.Properties.Resources._32_328764_rider_equestrian_silhouette_running_running_horse_vector_png;
            this.Kon1.Location = new System.Drawing.Point(131, 56);
            this.Kon1.Name = "Kon1";
            this.Kon1.Size = new System.Drawing.Size(89, 32);
            this.Kon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kon1.TabIndex = 4;
            this.Kon1.TabStop = false;
            // 
            // Tor
            // 
            this.Tor.Image = global::DzienNaWyscigach.Properties.Resources.racetrack;
            this.Tor.Location = new System.Drawing.Point(131, 31);
            this.Tor.Name = "Tor";
            this.Tor.Size = new System.Drawing.Size(696, 272);
            this.Tor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tor.TabIndex = 2;
            this.Tor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 571);
            this.Controls.Add(this.Kon4);
            this.Controls.Add(this.Kon3);
            this.Controls.Add(this.Kon2);
            this.Controls.Add(this.Kon1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton JanekButton;
        private System.Windows.Forms.RadioButton BartekButton;
        private System.Windows.Forms.PictureBox Tor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinZaklad;
        private System.Windows.Forms.NumericUpDown DogChoice;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.Button Wyscig;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.RadioButton ArekButton;
        private System.Windows.Forms.PictureBox Kon1;
        private System.Windows.Forms.PictureBox Kon2;
        private System.Windows.Forms.PictureBox Kon3;
        private System.Windows.Forms.PictureBox Kon4;
        private System.Windows.Forms.Label ZakladArka;
        private System.Windows.Forms.Label ZakladBartka;
        private System.Windows.Forms.Label ZakladJanka;
        private System.Windows.Forms.Label ImieGracza;
        private System.Windows.Forms.Label label1;
    }
}

