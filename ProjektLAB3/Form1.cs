using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjektLAB3
{

    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private string _csvFilePath = "employees.csv";
        private string _xmlFilePath = "OsobaData.xml";

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Imiê";
            dataGridView1.Columns[1].Name = "Nazwisko";
            dataGridView1.Columns[2].Name = "Wiek";
            dataGridView1.Columns[3].Name = "Stanowisko";
            dataGridView1.Columns[4].Name = "ID";

            if (File.Exists(_csvFilePath))
            {
                var lines = File.ReadAllLines(_csvFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    dataGridView1.Rows.Add(parts);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                int randomId = _random.Next(1, 10000);
                dataGridView1.Rows.Add(form2.FirstName, form2.LastName, form2.Age, form2.Position, randomId);
            }
        }

        public DataGridViewRowCollection GetDataGrindViewRows()
        {
            return dataGridView1.Rows;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Selected)
                    {
                        dataGridView1.Rows.Remove(row);
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lines = dataGridView1.Rows.Cast<DataGridViewRow>()
            .Where(row => !row.IsNewRow)
            .Select(row => string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value)));
            File.WriteAllLines(_csvFilePath, lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var lines = File.ReadAllLines(_csvFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                dataGridView1.Rows.Add(parts);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Osoba> osoby = new List<Osoba>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Osoba osoba = new Osoba()
                    {
                        Imie = row.Cells["Imiê"].Value.ToString(),
                        Nazwisko = row.Cells["Nazwisko"].Value.ToString(),
                        Wiek = int.Parse(row.Cells["Wiek"].Value.ToString()),
                        Stanowisko = row.Cells["Stanowisko"].Value.ToString(),
                        ID = int.Parse(row.Cells["ID"].Value.ToString())
                    };

                    osoby.Add(osoba);
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Osoba>));

            using (Stream stream = new FileStream(_xmlFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                serializer.Serialize(stream, osoby);
            }

            MessageBox.Show("Dane zosta³y zserializowane do pliku OsobaData.xml");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(_xmlFilePath))
            {
                System.Diagnostics.Process.Start("notepad.exe", _xmlFilePath);
            }
            else
            {
                MessageBox.Show("Plik OsobaData.xml nie istnieje.");
            }
        }
    }
}
