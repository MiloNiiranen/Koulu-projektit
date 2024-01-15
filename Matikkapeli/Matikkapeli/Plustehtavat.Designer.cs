namespace Matikkapeli
{
    partial class Plustehtavat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            Ajastin = new Label();
            vastausTextBox = new TextBox();
            laskulabel = new Label();
            tarkistusnappi = new Button();
            Takaisinnappi = new Button();
            kysymystenmäärä = new Label();
            tehtäviätehty = new Label();
            merkki = new Label();
            labelParasaikaPlus = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Ajastin
            // 
            Ajastin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Ajastin.Location = new Point(464, 15);
            Ajastin.Margin = new Padding(4, 0, 4, 0);
            Ajastin.Name = "Ajastin";
            Ajastin.Size = new Size(143, 50);
            Ajastin.TabIndex = 0;
            Ajastin.Text = "00.00";
            // 
            // vastausTextBox
            // 
            vastausTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox.Location = new Point(520, 328);
            vastausTextBox.Margin = new Padding(4, 5, 4, 5);
            vastausTextBox.Name = "vastausTextBox";
            vastausTextBox.Size = new Size(44, 39);
            vastausTextBox.TabIndex = 2;
            // 
            // laskulabel
            // 
            laskulabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel.Location = new Point(400, 328);
            laskulabel.Margin = new Padding(4, 0, 4, 0);
            laskulabel.Name = "laskulabel";
            laskulabel.Size = new Size(111, 38);
            laskulabel.TabIndex = 3;
            laskulabel.Text = "00 + 00=";
            // 
            // tarkistusnappi
            // 
            tarkistusnappi.Location = new Point(464, 443);
            tarkistusnappi.Margin = new Padding(4, 5, 4, 5);
            tarkistusnappi.Name = "tarkistusnappi";
            tarkistusnappi.Size = new Size(149, 55);
            tarkistusnappi.TabIndex = 4;
            tarkistusnappi.Text = "Tarkista";
            tarkistusnappi.UseVisualStyleBackColor = true;
            tarkistusnappi.Click += tarkistusnappi_Click;
            // 
            // Takaisinnappi
            // 
            Takaisinnappi.Location = new Point(17, 15);
            Takaisinnappi.Margin = new Padding(4, 5, 4, 5);
            Takaisinnappi.Name = "Takaisinnappi";
            Takaisinnappi.Size = new Size(164, 50);
            Takaisinnappi.TabIndex = 5;
            Takaisinnappi.Text = " <-- Päävalikko";
            Takaisinnappi.UseVisualStyleBackColor = true;
            Takaisinnappi.Click += Takaisinnappi_Click;
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(1014, 50);
            kysymystenmäärä.Margin = new Padding(4, 0, 4, 0);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(54, 45);
            kysymystenmäärä.TabIndex = 6;
            kysymystenmäärä.Text = "10";
            // 
            // tehtäviätehty
            // 
            tehtäviätehty.AutoSize = true;
            tehtäviätehty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty.Location = new Point(937, 50);
            tehtäviätehty.Margin = new Padding(4, 0, 4, 0);
            tehtäviätehty.Name = "tehtäviätehty";
            tehtäviätehty.Size = new Size(37, 45);
            tehtäviätehty.TabIndex = 7;
            tehtäviätehty.Text = "0";
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(980, 50);
            merkki.Margin = new Padding(4, 0, 4, 0);
            merkki.Name = "merkki";
            merkki.Size = new Size(28, 45);
            merkki.TabIndex = 8;
            merkki.Text = "|";
            // 
            // labelParasaikaPlus
            // 
            labelParasaikaPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParasaikaPlus.Location = new Point(17, 342);
            labelParasaikaPlus.Margin = new Padding(4, 0, 4, 0);
            labelParasaikaPlus.Name = "labelParasaikaPlus";
            labelParasaikaPlus.Size = new Size(219, 35);
            labelParasaikaPlus.TabIndex = 9;
            labelParasaikaPlus.Text = "Paras aika: ";
            // 
            // Plustehtavat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 750);
            Controls.Add(labelParasaikaPlus);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty);
            Controls.Add(kysymystenmäärä);
            Controls.Add(Takaisinnappi);
            Controls.Add(tarkistusnappi);
            Controls.Add(laskulabel);
            Controls.Add(vastausTextBox);
            Controls.Add(Ajastin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Plustehtavat";
            Text = "Plus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label Ajastin;
        private TextBox vastausTextBox;
        private Label laskulabel;
        private Button tarkistusnappi;
        private Button Takaisinnappi;
        private Label kysymystenmäärä;
        private Label tehtäviätehty;
        private Label merkki;
        private Label labelParasaikaPlus;
    }
}