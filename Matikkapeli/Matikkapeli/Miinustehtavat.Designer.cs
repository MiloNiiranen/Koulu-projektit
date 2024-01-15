namespace Matikkapeli
{
    partial class Miinustehtavat
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
            Takaisinnappi2 = new Button();
            Ajastinlabel2 = new Label();
            merkki = new Label();
            tehtäviätehty2 = new Label();
            kysymystenmäärä = new Label();
            laskulabel2 = new Label();
            vastausTextBox2 = new TextBox();
            tarkistusnappi2 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            labelParasaikaMiinus = new Label();
            SuspendLayout();
            // 
            // Takaisinnappi2
            // 
            Takaisinnappi2.Location = new Point(13, 13);
            Takaisinnappi2.Margin = new Padding(4, 5, 4, 5);
            Takaisinnappi2.Name = "Takaisinnappi2";
            Takaisinnappi2.Size = new Size(164, 50);
            Takaisinnappi2.TabIndex = 6;
            Takaisinnappi2.Text = " <-- Päävalikko";
            Takaisinnappi2.UseVisualStyleBackColor = true;
            Takaisinnappi2.Click += Takaisinnappi_Click;
            // 
            // Ajastinlabel2
            // 
            Ajastinlabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Ajastinlabel2.Location = new Point(464, 15);
            Ajastinlabel2.Margin = new Padding(4, 0, 4, 0);
            Ajastinlabel2.Name = "Ajastinlabel2";
            Ajastinlabel2.Size = new Size(143, 50);
            Ajastinlabel2.TabIndex = 7;
            Ajastinlabel2.Text = "00.00";
            // 
            // merkki
            // 
            merkki.AutoSize = true;
            merkki.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            merkki.Location = new Point(980, 50);
            merkki.Margin = new Padding(4, 0, 4, 0);
            merkki.Name = "merkki";
            merkki.Size = new Size(28, 45);
            merkki.TabIndex = 11;
            merkki.Text = "|";
            // 
            // tehtäviätehty2
            // 
            tehtäviätehty2.AutoSize = true;
            tehtäviätehty2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tehtäviätehty2.Location = new Point(937, 50);
            tehtäviätehty2.Margin = new Padding(4, 0, 4, 0);
            tehtäviätehty2.Name = "tehtäviätehty2";
            tehtäviätehty2.Size = new Size(37, 45);
            tehtäviätehty2.TabIndex = 10;
            tehtäviätehty2.Text = "0";
            // 
            // kysymystenmäärä
            // 
            kysymystenmäärä.AutoSize = true;
            kysymystenmäärä.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kysymystenmäärä.Location = new Point(1014, 50);
            kysymystenmäärä.Margin = new Padding(4, 0, 4, 0);
            kysymystenmäärä.Name = "kysymystenmäärä";
            kysymystenmäärä.Size = new Size(54, 45);
            kysymystenmäärä.TabIndex = 9;
            kysymystenmäärä.Text = "10";
            // 
            // laskulabel2
            // 
            laskulabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laskulabel2.Location = new Point(400, 328);
            laskulabel2.Margin = new Padding(4, 0, 4, 0);
            laskulabel2.Name = "laskulabel2";
            laskulabel2.Size = new Size(111, 38);
            laskulabel2.TabIndex = 12;
            laskulabel2.Text = "00 - 00=";
            // 
            // vastausTextBox2
            // 
            vastausTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vastausTextBox2.Location = new Point(519, 328);
            vastausTextBox2.Margin = new Padding(4, 5, 4, 5);
            vastausTextBox2.Name = "vastausTextBox2";
            vastausTextBox2.Size = new Size(44, 39);
            vastausTextBox2.TabIndex = 13;
            // 
            // tarkistusnappi2
            // 
            tarkistusnappi2.Location = new Point(464, 443);
            tarkistusnappi2.Margin = new Padding(4, 5, 4, 5);
            tarkistusnappi2.Name = "tarkistusnappi2";
            tarkistusnappi2.Size = new Size(149, 55);
            tarkistusnappi2.TabIndex = 4;
            tarkistusnappi2.Text = "Tarkista";
            tarkistusnappi2.UseVisualStyleBackColor = true;
            tarkistusnappi2.Click += tarkistusnappi_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // labelParasaikaMiinus
            // 
            labelParasaikaMiinus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParasaikaMiinus.Location = new Point(17, 342);
            labelParasaikaMiinus.Margin = new Padding(4, 0, 4, 0);
            labelParasaikaMiinus.Name = "labelParasaikaMiinus";
            labelParasaikaMiinus.Size = new Size(246, 35);
            labelParasaikaMiinus.TabIndex = 14;
            labelParasaikaMiinus.Text = "Paras aika: ";
            // 
            // Miinustehtavat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 750);
            Controls.Add(labelParasaikaMiinus);
            Controls.Add(tarkistusnappi2);
            Controls.Add(vastausTextBox2);
            Controls.Add(laskulabel2);
            Controls.Add(merkki);
            Controls.Add(tehtäviätehty2);
            Controls.Add(kysymystenmäärä);
            Controls.Add(Ajastinlabel2);
            Controls.Add(Takaisinnappi2);
            Name = "Miinustehtavat";
            Text = "Miinustehtavat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Takaisinnappi2;
        private Label Ajastinlabel2;
        private Label merkki;
        private Label tehtäviätehty2;
        private Label kysymystenmäärä;
        private Label laskulabel2;
        private TextBox vastausTextBox2;
        private Button tarkistusnappi2;
        private System.Windows.Forms.Timer timer2;
        private Label labelParasaikaMiinus;
    }
}