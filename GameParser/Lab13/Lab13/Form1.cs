using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab13
{
    public partial class Form1 : Form
    {
        List<Wojownik> wojownikList = new List<Wojownik>();

        public Form1()
        {
            InitializeComponent();
            Gildia();
            Wczytaj();
        
        }

        public void Gildia()
        {
            XElement Wojownicy =
            new XElement("Gildia",
                new XElement("Wojownik",
                    new XAttribute("Plec", "M"),
                    new XElement("Imie", "Joe"),
                    new XElement("Sila", "10"),
                    new XElement("Zdrowie", "50"),
                    new XElement("Przeciwnik", "sd")),
                new XElement("Wojownik",
                    new XAttribute("Plec", "M"),
                    new XElement("Imie", "Ewan"),
                    new XElement("Sila", "11"),
                    new XElement("Zdrowie", "55"),
                    new XElement("Przeciwnik", "sd")),
                new XElement("Wojownik",
                    new XAttribute("Plec", "M"),
                    new XElement("Imie", "Joe"),
                    new XElement("Sila", "12"),
                    new XElement("Zdrowie", "60"),
                    new XElement("Przeciwnik", "sd"))
            );

            Wojownicy.Save("Wojownicy.xml");
        }

        public void Wczytaj()
        {
            XDocument element = XDocument.Load("Wojownicy.xml");

            var wojownikV = from w in element.Descendants("Wojownik")
                       select w.Value;

            wojownikList = element.Descendants("Wojownik").Select(wxml => new Wojownik
            {
                plec = wxml.Attribute("Plec").Value,
                imie = wxml.Element("Imie").Value,
                sila = (int)wxml.Element("Sila"),
                zdrowie = (int)wxml.Element("Zdrowie"),
                przeciwnik = wxml.Element("Przeciwnik").Value
            }).ToList();

            wojownikBindingSource.DataSource = wojownikList;
            dataGridView1.DataSource = wojownikBindingSource;
        }

        public void Zapisz()
        {
            XElement Wojownicy =
            new XElement("Gildia",
                from w in wojownikList
                select new XElement("Wojownik",
                    new XAttribute("Plec", w.plec),
                    new XElement("Imie", w.imie),
                    new XElement("Sila", w.sila),
                    new XElement("Zdrowie", w.zdrowie),
                    new XElement("Przeciwnik", w.przeciwnik))
            );

            Wojownicy.Save("Wojownicy.xml");
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wczytaj();
            MessageBox.Show("Plik został wczytany.");
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapisz();
            MessageBox.Show("Plik został zapisany.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                Wojownik wojownik = new Wojownik
                {
                    plec = comboBox2.Text,
                    imie = textBox1.Text,
                    sila = Int32.Parse(textBox2.Text),
                    zdrowie = Int32.Parse(textBox3.Text),
                    przeciwnik = textBox4.Text,
                };

                

                wojownikList.Add(wojownik);

                Zapisz();

                ((CurrencyManager)BindingContext[wojownikBindingSource]).Refresh();
            }  
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                comboBox2.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
