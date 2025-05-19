using System;
using System.Data;
using System.Numerics;
using System.Text.Json;
using System.Windows.Forms.Design;
using System.Xml.Serialization;

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
        private void savetoxml()
        {
            List<Osoba> people = new List<Osoba>();
            foreach (DataGridViewRow row in wyswietlanie.Rows)
            {
                if (!row.IsNewRow)
                {
                  try
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        string firstname = row.Cells[1].Value.ToString();
                        string lastname = row.Cells[2].Value.ToString();
                        int age = Convert.ToInt32(row.Cells[3].Value);
                        string position = row.Cells[4].Value.ToString();
                        people.Add(new Osoba(id, firstname, lastname, age, position));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("B³¹d"+ex.Message);
                    }
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));
            using (TextWriter writer = new StreamWriter("employees.xml"))
            {
                serializer.Serialize(writer, people);
            }

            MessageBox.Show("Dane zapisane do XML.");
        }
        private void readfromxml()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));
                using (TextReader reader = new StreamReader("employees.xml"))
                {
                    List<Osoba> people = (List<Osoba>)serializer.Deserialize(reader);
                    wyswietlanie.Rows.Clear();
                    foreach (var person in people)
                    {
                        wyswietlanie.Rows.Add(person.ID, person.FirstName, person.LastName, person.Age, person.Position);
                    }
                }
                MessageBox.Show("Dane wczytane z XML.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message);
            }
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
        private void savetojjson()
        {
            List<Osoba> people = new List<Osoba>();
            foreach (DataGridViewRow row in wyswietlanie.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        string firstname = row.Cells[1].Value.ToString();
                        string lastname = row.Cells[2].Value.ToString();
                        int age = Convert.ToInt32(row.Cells[3].Value);
                        string position = row.Cells[4].Value.ToString();
                        people.Add(new Osoba(id, firstname, lastname, age, position));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("B³¹d" + ex.Message);
                    }
                }
            }

            string jsonString = JsonSerializer.Serialize(people);
            File.WriteAllText("employees.json", jsonString);
            MessageBox.Show("Dane zapisane do JSON.");
        }

        private void readfromjson()
        {
            try
            {
                string jsonString = File.ReadAllText("employees.json");
                List<Osoba> people = JsonSerializer.Deserialize<List<Osoba>>(jsonString);
                wyswietlanie.Rows.Clear();
                foreach (var person in people)
                {
                    wyswietlanie.Rows.Add(person.ID, person.FirstName, person.LastName, person.Age, person.Position);
                }
                MessageBox.Show("Dane wczytane z JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            savetojjson();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            readfromjson();
        }
    }
    [Serializable]
    public class Osoba
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public Osoba() { }
        public Osoba(int id, string firstname, string lastname, int age, string position)
            {
            ID = id;
            FirstName = firstname;
            LastName = lastname;    
            Age = age;
            Position = position;

        }
    }
}
