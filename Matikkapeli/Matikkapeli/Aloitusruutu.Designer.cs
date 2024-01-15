namespace Matikkapeli
{
    partial class Aloitusruutu
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
            label1 = new Label();
            label2 = new Label();
            Plusnappi = new Button();
            Miinusnappi = new Button();
            Kertonappi = new Button();
            jakonappi = new Button();
            menuStrip1 = new MenuStrip();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(276, 50);
            label1.Name = "label1";
            label1.Size = new Size(383, 46);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa Matikka Peliin";
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(228, 131);
            label2.Name = "label2";
            label2.Size = new Size(356, 23);
            label2.TabIndex = 1;
            label2.Text = "Valitse mitä laskutyyppiä haluat harjoitella";
            // 
            // Plusnappi
            // 
            Plusnappi.BackColor = Color.Red;
            Plusnappi.BackgroundImageLayout = ImageLayout.None;
            Plusnappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Plusnappi.ForeColor = SystemColors.ActiveCaptionText;
            Plusnappi.Location = new Point(333, 187);
            Plusnappi.Name = "Plusnappi";
            Plusnappi.Size = new Size(156, 41);
            Plusnappi.TabIndex = 2;
            Plusnappi.Text = "Plus +";
            Plusnappi.UseVisualStyleBackColor = false;
            Plusnappi.Click += Plusnappi_Click;
            // 
            // Miinusnappi
            // 
            Miinusnappi.BackColor = Color.DodgerBlue;
            Miinusnappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Miinusnappi.Location = new Point(333, 234);
            Miinusnappi.Name = "Miinusnappi";
            Miinusnappi.Size = new Size(156, 41);
            Miinusnappi.TabIndex = 3;
            Miinusnappi.Text = "Miinus -";
            Miinusnappi.UseVisualStyleBackColor = false;
            Miinusnappi.Click += Miinusnappi_Click;
            // 
            // Kertonappi
            // 
            Kertonappi.BackColor = Color.Yellow;
            Kertonappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Kertonappi.Location = new Point(333, 281);
            Kertonappi.Name = "Kertonappi";
            Kertonappi.Size = new Size(156, 41);
            Kertonappi.TabIndex = 4;
            Kertonappi.Text = "Kerto x";
            Kertonappi.UseVisualStyleBackColor = false;
            Kertonappi.Click += Kertonappi_Click;
            // 
            // jakonappi
            // 
            jakonappi.BackColor = Color.FromArgb(0, 192, 0);
            jakonappi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            jakonappi.Location = new Point(333, 328);
            jakonappi.Name = "jakonappi";
            jakonappi.Size = new Size(156, 41);
            jakonappi.TabIndex = 5;
            jakonappi.Text = "Jako /";
            jakonappi.UseVisualStyleBackColor = false;
            jakonappi.Click += jakonappi_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // Aloitusruutu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 550);
            Controls.Add(jakonappi);
            Controls.Add(Kertonappi);
            Controls.Add(Miinusnappi);
            Controls.Add(Plusnappi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Aloitusruutu";
            Text = "Aloitus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Plusnappi;
        private Button Miinusnappi;
        private Button Kertonappi;
        private Button jakonappi;
        private MenuStrip menuStrip1;
    }
}