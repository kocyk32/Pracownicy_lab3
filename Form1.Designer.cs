namespace pracownicy
{
    partial class Form1
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
            wyswietlanie = new DataGridView();
            bDodaj = new Button();
            bUsun = new Button();
            bZapis = new Button();
            bOdczyt = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)wyswietlanie).BeginInit();
            SuspendLayout();
            // 
            // wyswietlanie
            // 
            wyswietlanie.BackgroundColor = SystemColors.Control;
            wyswietlanie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wyswietlanie.GridColor = SystemColors.ButtonFace;
            wyswietlanie.Location = new Point(200, 12);
            wyswietlanie.Name = "wyswietlanie";
            wyswietlanie.Size = new Size(544, 332);
            wyswietlanie.TabIndex = 0;
            wyswietlanie.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bDodaj
            // 
            bDodaj.BackColor = Color.FromArgb(192, 255, 192);
            bDodaj.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bDodaj.Location = new Point(27, 12);
            bDodaj.Name = "bDodaj";
            bDodaj.Size = new Size(155, 86);
            bDodaj.TabIndex = 1;
            bDodaj.Text = "Dodaj";
            bDodaj.UseVisualStyleBackColor = false;
            bDodaj.Click += button1_Click;
            // 
            // bUsun
            // 
            bUsun.BackColor = Color.FromArgb(255, 128, 128);
            bUsun.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bUsun.Location = new Point(27, 104);
            bUsun.Name = "bUsun";
            bUsun.Size = new Size(155, 92);
            bUsun.TabIndex = 2;
            bUsun.Text = "Usuń";
            bUsun.UseVisualStyleBackColor = false;
            bUsun.Click += button2_Click;
            // 
            // bZapis
            // 
            bZapis.BackColor = Color.FromArgb(192, 192, 255);
            bZapis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bZapis.Location = new Point(27, 202);
            bZapis.Name = "bZapis";
            bZapis.Size = new Size(75, 62);
            bZapis.TabIndex = 3;
            bZapis.Text = "Zapis do .csv";
            bZapis.UseVisualStyleBackColor = false;
            bZapis.Click += button3_Click;
            // 
            // bOdczyt
            // 
            bOdczyt.BackColor = Color.FromArgb(192, 192, 255);
            bOdczyt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bOdczyt.Location = new Point(108, 202);
            bOdczyt.Name = "bOdczyt";
            bOdczyt.Size = new Size(74, 63);
            bOdczyt.TabIndex = 4;
            bOdczyt.Text = "Odczyt z .csv";
            bOdczyt.UseVisualStyleBackColor = false;
            bOdczyt.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(108, 270);
            button1.Name = "button1";
            button1.Size = new Size(74, 63);
            button1.TabIndex = 6;
            button1.Text = "Odczyt JSON";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(27, 270);
            button2.Name = "button2";
            button2.Size = new Size(75, 62);
            button2.TabIndex = 5;
            button2.Text = "Zapis JSON";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 394);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(bOdczyt);
            Controls.Add(bZapis);
            Controls.Add(bUsun);
            Controls.Add(bDodaj);
            Controls.Add(wyswietlanie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wyswietlanie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView wyswietlanie;
        private Button bDodaj;
        private Button bUsun;
        private Button bZapis;
        private Button bOdczyt;
        private Button button1;
        private Button button2;
    }
}
