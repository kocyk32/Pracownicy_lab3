namespace pracownicy
{
    partial class Form2
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
            tImie = new TextBox();
            tNazwisko = new TextBox();
            tWiek = new TextBox();
            cStanowisko = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bZatwierdz = new Button();
            bAnuluj = new Button();
            SuspendLayout();
            // 
            // tImie
            // 
            tImie.Location = new Point(28, 44);
            tImie.Name = "tImie";
            tImie.Size = new Size(100, 23);
            tImie.TabIndex = 0;
            tImie.TextChanged += textBox1_TextChanged;
            // 
            // tNazwisko
            // 
            tNazwisko.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tNazwisko.Location = new Point(147, 46);
            tNazwisko.Name = "tNazwisko";
            tNazwisko.Size = new Size(100, 21);
            tNazwisko.TabIndex = 1;
            tNazwisko.TextChanged += textBox2_TextChanged;
            // 
            // tWiek
            // 
            tWiek.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tWiek.Location = new Point(147, 128);
            tWiek.Name = "tWiek";
            tWiek.Size = new Size(100, 21);
            tWiek.TabIndex = 2;
            tWiek.TextChanged += textBox3_TextChanged;
            // 
            // cStanowisko
            // 
            cStanowisko.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cStanowisko.FormattingEnabled = true;
            cStanowisko.Location = new Point(28, 126);
            cStanowisko.Name = "cStanowisko";
            cStanowisko.Size = new Size(100, 23);
            cStanowisko.TabIndex = 3;
            cStanowisko.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 

            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            label4.Click += label4_Click;
            // 
            // bZatwierdz
            // 
            bZatwierdz.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bZatwierdz.Location = new Point(28, 182);
            bZatwierdz.Name = "bZatwierdz";
            bZatwierdz.Size = new Size(100, 23);
            bZatwierdz.TabIndex = 8;
            bZatwierdz.Text = "Zatwierdź";
            bZatwierdz.UseVisualStyleBackColor = true;
            bZatwierdz.Click += button1_Click;
            // 
            // bAnuluj
            // 
            bAnuluj.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bAnuluj.Location = new Point(147, 182);
            bAnuluj.Name = "bAnuluj";
            bAnuluj.Size = new Size(100, 23);
            bAnuluj.TabIndex = 9;
            bAnuluj.Text = "Anuluj";
            bAnuluj.UseVisualStyleBackColor = true;
            bAnuluj.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 217);
            Controls.Add(bAnuluj);
            Controls.Add(bZatwierdz);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cStanowisko);
            Controls.Add(tWiek);
            Controls.Add(tNazwisko);
            Controls.Add(tImie);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tImie;
        private TextBox tNazwisko;
        private TextBox tWiek;
        private ComboBox cStanowisko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bZatwierdz;
        private Button bAnuluj;
    }
}