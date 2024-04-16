using CsvHelper;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Ac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetDataSource();
            }
            catch {
                MessageBox.Show("Parece que el archivo CSV está en un formato incorrecto o no existe, por favor, asegurate de que está bien y que el nombre del fichero es 'input.csv'.", "Error");
            }
            
            SetYears();
            if (File.Exists("../../../output.xml"))
                File.Delete("../../../output.xml");
            SaveToXml();
            PopulateComboBoxFromXml();
        }

        private void dataGridCSVOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridCSVOutput.Rows[e.RowIndex];
                Consum selectedConsum = new Consum
                {
                    Any = Convert.ToInt32(selectedRow.Cells["Any"].Value),
                    CodComarca = Convert.ToInt32(selectedRow.Cells["Codi Comarca"].Value),
                    Comarca = selectedRow.Cells["Comarca"].Value.ToString(),
                    Poblacio = Convert.ToInt32(selectedRow.Cells["Població"].Value),
                    XarxaDomestica = Convert.ToInt32(selectedRow.Cells["Domèstic xarxa"].Value),
                    ActivitatsEconomiques = Convert.ToInt32(selectedRow.Cells["Activitats econòmiques i fonts pròpies"].Value),
                    Total = Convert.ToInt32(selectedRow.Cells["Total"].Value),
                    ConsumPerCapita = Convert.ToSingle(selectedRow.Cells["Consum domèstic per càpita"].Value)
                };
                UpdateStats(selectedConsum);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxAny.SelectedItem = null;
            comboBoxComarca.SelectedItem = null;
            textBoxClear.Text = string.Empty;
            textBoxClear2.Text = string.Empty;
            textBoxClear3.Text = string.Empty;
            textBoxClear4.Text = string.Empty;
            textBoxClear5.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Regex intpattern = new Regex(@"^[0-9]{1,9}$");
            Regex floatpattern = new Regex(@"^[.][0-9]+$|^[0-9]*[.]{0,2}[0-9]*$");
            if (!intpattern.IsMatch(textBoxClear.Text) || !intpattern.IsMatch(textBoxClear2.Text) ||
                !intpattern.IsMatch(textBoxClear3.Text) || !intpattern.IsMatch(textBoxClear4.Text) ||
                !floatpattern.IsMatch(textBoxClear5.Text) || textBoxClear5.Text == string.Empty)
            {
                MessageBox.Show("Uno de los valores introducidos no concuerda con su tipo o los campos están vacíos.", "Error");
            }
            else if (comboBoxAny.SelectedItem == null || comboBoxComarca.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar los datos de la lista.", "Error");
            }
            else
            {
                Consum fieldsObject = new Consum();
                fieldsObject.Any = int.Parse(comboBoxAny.Text);
                fieldsObject.CodComarca = getComarcaCode(comboBoxComarca.Text);
                fieldsObject.Comarca = comboBoxComarca.Text;
                fieldsObject.Poblacio = int.Parse(textBoxClear.Text);
                fieldsObject.XarxaDomestica = int.Parse(textBoxClear2.Text);
                fieldsObject.ActivitatsEconomiques = int.Parse(textBoxClear3.Text);
                fieldsObject.Total = int.Parse(textBoxClear4.Text);
                fieldsObject.ConsumPerCapita = float.Parse(textBoxClear5.Text);

                appendToCSV(fieldsObject);
                SetDataSource();
            }
        }

        List<Consum> ReadCsv()
        {
            List<Consum> resultList = new List<Consum>();
            using StreamReader reader = new StreamReader("../../../input.csv");
            using CsvReader csvreader = new CsvReader(reader, CultureInfo.InvariantCulture);
            csvreader.Read();
            csvreader.ReadHeader();
            while (csvreader.Read())
            {
                var record = new Consum
                {
                    Any = csvreader.GetField<int>("Any"),
                    CodComarca = csvreader.GetField<int>("Codi comarca"),
                    Comarca = csvreader.GetField<string>("Comarca"),
                    Poblacio = csvreader.GetField<int>("Població"),
                    XarxaDomestica = csvreader.GetField<int>("Domèstic xarxa"),
                    ActivitatsEconomiques = csvreader.GetField<int>("Activitats econòmiques i fonts pròpies"),
                    Total = csvreader.GetField<int>("Total"),
                    ConsumPerCapita = csvreader.GetField<float>("Consum domèstic per càpita")
                };
                resultList.Add(record);
            }
            return resultList;
        }

        void SetYears()
        {
            // Changing year value range.
            List<Consum> recordsList = ReadCsv();
            Consum lowestYear = recordsList.OrderBy(c => c.Any).First();
            int maxRange = 2050;
            for (int i = lowestYear.Any; i < maxRange + 1; i++)
            {
                comboBoxAny.Items.Add(i.ToString());
            }
        }

        void PopulateComboBoxFromXml()
        {
            comboBoxComarca.Items.Clear();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("../../../output.xml");
                XmlNodeList comarcaNodes = xmlDoc.SelectNodes("//ComarcaItem");
                foreach (XmlNode comarcaNode in comarcaNodes)
                {
                    string comarca = comarcaNode.SelectSingleNode("Comarca").InnerText;
                    comboBoxComarca.Items.Add(comarca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading XML file: " + ex.Message, "Error");
            }
        }

        void SaveToXml()
        {
            List<Consum> recordsList = ReadCsv();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };

            HashSet<int> uniqueCodComarcas = new HashSet<int>();

            using (XmlWriter output = XmlWriter.Create("../../../output.xml", settings))
            {
                output.WriteStartDocument();

                output.WriteStartElement("Comarcas");
                foreach (Consum record in recordsList)
                {
                    if (!uniqueCodComarcas.Contains(record.CodComarca))
                    {
                        output.WriteStartElement("ComarcaItem");
                        output.WriteElementString("CodComarca", record.CodComarca.ToString());
                        output.WriteElementString("Comarca", record.Comarca.ToString());
                        output.WriteEndElement();
                        uniqueCodComarcas.Add(record.CodComarca);
                    }
                }
                output.WriteEndElement();
            }
        }


        private int getComarcaCode(string comarca)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../output.xml");
            XmlNodeList comarcaNodes = xmlDoc.SelectNodes("//ComarcaItem");
            foreach (XmlNode comarcaNode in comarcaNodes)
            {
                string comarcaf = comarcaNode.SelectSingleNode("Comarca").InnerText;
                if (comarcaf == comarca)
                    return int.Parse(comarcaNode.SelectSingleNode("CodComarca").InnerText);
            }
            return -1;
        }

        private void appendToCSV(Consum fields)
        {
            StreamWriter sw = new("../../../input.csv", append: true );
            sw.Write("\n" + fields.Any + "," + fields.CodComarca + ",\"" + fields.Comarca + "\"," + fields.Poblacio + "," + fields.XarxaDomestica + "," + fields.ActivitatsEconomiques + "," + fields.Total + "," + fields.ConsumPerCapita);
            sw.Close();
        }

        private void UpdateStats(Consum selected)
        {
            List<Consum> csvdata = ReadCsv();

            textBox20kAbove.Text = selected.Poblacio > 20000 ? "Sí" : "No";

            textBoxAvg.Text = (selected.XarxaDomestica / selected.Poblacio).ToString();

            textBoxLowerDom.Text = FindRecordWithLowestConsumPerCapita(csvdata).ConsumPerCapita == selected.ConsumPerCapita ? "Sí" : "No";

            textBoxHigherDom.Text = FindRecordWithHighestConsumPerCapita(csvdata).ConsumPerCapita == selected.ConsumPerCapita ? "Si" : "No";
        }

        private Consum FindRecordWithHighestConsumPerCapita(List<Consum> consums)
        {
            Consum highestConsumPerCapitaRecord = consums.OrderByDescending(x => x.ConsumPerCapita).First();
            return highestConsumPerCapitaRecord;
        }

        private Consum FindRecordWithLowestConsumPerCapita(List<Consum> consums)
        {
            Consum lowestConsumPerCapitaRecord = consums.OrderBy(x => x.ConsumPerCapita).First();

            return lowestConsumPerCapitaRecord;
        }

        private void SetDataSource()
        {
            List<Consum> resultList = ReadCsv();
            DataTable dt = new();

            dt.Columns.Add("Any", typeof(int));
            dt.Columns.Add("Codi comarca", typeof(int));
            dt.Columns.Add("Comarca", typeof(string));
            dt.Columns.Add("Població", typeof(int));
            dt.Columns.Add("Domèstic xarxa", typeof(int));
            dt.Columns.Add("Activitats econòmiques i fonts pròpies", typeof(int));
            dt.Columns.Add("Total", typeof(int));
            dt.Columns.Add("Consum domèstic per càpita", typeof(float));

            foreach (Consum value in resultList)
            {
                dt.Rows.Add(value.Any, value.CodComarca, value.Comarca, value.Poblacio, value.XarxaDomestica, value.ActivitatsEconomiques, value.Total, value.ConsumPerCapita);
            }

            dataGridCSVOutput.DataSource = dt;
        }
    }
}
