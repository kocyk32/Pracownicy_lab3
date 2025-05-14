using System.Data;
using System.Numerics;
using System.Windows.Forms.Design;

namespace pracownicy
{
    public partial class Form1 : Form
    {
        private int currentID = 1;
        public string imie;
        public string nazwisko;
        public int wiek;
        public string stanowisko;


        public void adduser()
        {
            wyswietlanie.Rows.Add(new object[] { currentID, imie, nazwisko, wiek, stanowisko });
            currentID++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            savetocsv();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(this);
            newform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeUser();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            readfromcsv();
        }

        private void readfromcsv()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    DefaultExt = "csv"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        bool firstLine = true;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (firstLine)
                            {
                                firstLine = false;
                                continue;
                            }
                            var values = line.Split(',');
                            wyswietlanie.Rows.Add(values);
                        }
                    }

                    MessageBox.Show("Dane zosta³y pomyœlnie za³adowane.", "Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void removeUser()
        {
            if (wyswietlanie.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in wyswietlanie.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        wyswietlanie.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz wiersz, który chcesz usun¹æ!", "Wyst¹pi³ b³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void savetocsv()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    DefaultExt = "csv",
                    FileName = "pracownicy.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        var columnNames = wyswietlanie.Columns.Cast<DataGridViewColumn>()
                                            .Select(column => column.HeaderText)
                                            .ToArray();
                        writer.WriteLine(string.Join(",", columnNames));
                        foreach (DataGridViewRow row in wyswietlanie.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cellValues = row.Cells.Cast<DataGridViewCell>()
                                                       .Select(cell => cell.Value.ToString())
                                                       .ToArray();
                                writer.WriteLine(string.Join(",", cellValues));
                            }
                        }
                    }
                    MessageBox.Show("Dane zosta³y pomyœlnie zapisane.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Form1()
        {
            InitializeComponent();
            wyswietlanie.Columns.Add("ID", "ID");
            wyswietlanie.Columns.Add("Imiê", "Imiê");
            wyswietlanie.Columns.Add("Nazwisko", "Nazwisko");
            wyswietlanie.Columns.Add("Wiek", "Wiek");
            wyswietlanie.Columns.Add("Stanowisko", "Stanowisko");
            wyswietlanie.ReadOnly = true;
            Controls.Add(wyswietlanie);
        }
    }
}
