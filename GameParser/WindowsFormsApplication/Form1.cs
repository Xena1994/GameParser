using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private List<Wojownik> wojownicy = new List<Wojownik>();

        public List<Wojownik> Wojownicy
        {
            get { return wojownicy; }
            set { wojownicy = value; }
        }
        private static string fileName = "gildia.xml";

        private void loadDataSources(object data)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            comboBox1.DataSource = null; 
            comboBox1.DisplayMember = "Imie"; 
            comboBox1.DataSource = dataGridView1.DataSource;
            
        }

        public Form1()
        {
            InitializeComponent();
            DefineXMLDocument();
            initializeWojownicy();
            wczytajListeZPlikuToolStripMenuItem.Click += wczytajListeZPlikuXML;
            zapiszListęDoPlikuXMLToolStripMenuItem.Click += zapiszListeDoPlikuXML;
            dodajWojownikaButton.Click += dodajWojownika;
            edytujWojownikaButton.Click += edytujWojownika;
            usunWojownikaButton.Click += usunWojownika;
            loadDataSources(Wojownicy);
            //Wojownicy 
            dataGridView1.SelectionChanged += wypelnijPolaWartosciami;
            comboBox1.SelectedIndexChanged += wypelnijPolaWartosciami;
            plecCB.DataSource = new List<string>() { "Mezczyzna", "Kobieta" };
            sortowanieCB.DisplayMember = "Name";
            sortowanieCB.DataSource = typeof(Wojownik).GetProperties().Select(p => p.Name).ToList();
            sortowanieCB.SelectedIndexChanged += sortuj;
            sortowanieCB.SelectedIndex = 0;
            rosnacoRB.Select();
            rosnacoRB.CheckedChanged += sortuj;
            malejacoRB.CheckedChanged += sortuj;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            sortowanieCB.DropDownStyle = ComboBoxStyle.DropDownList; // wartości bez edycji
            // Akcje
            imionaWszystkichButton.Click += zapiszListeDoPlikuXML;
            imionaWszystkichButton.Click += pokazImionaWszystkich;

            plciStarszychButton.Click += zapiszListeDoPlikuXML;
            plciStarszychButton.Click += pokazODanejPlciSilePowyzej;

            usunCiezkoRannychButton.Click += zapiszListeDoPlikuXML;
            usunCiezkoRannychButton.Click += usunRannych;

            usunCiezkoRannychButton.Click += zapiszListeDoPlikuXML;
            dodajWojownikaPoWskazanymButton.Click += dodajWojownikaPoWojownikuOImieniu;

        }

        public void DefineXMLDocument()
        {
            XElement xe = new XElement("Gildia",
                new XElement("Wojownik",
                    new XAttribute("Plec", "Mezczyzna"),
                    new XElement("Imie", "Aragorn"),
                    new XElement("Sila", "7"),
                    new XElement("Zdrowie", "20"),
                    new XElement("Nnpku", "Sauron")
                    ),
                new XElement("Wojownik",
                    new XAttribute("Plec", "Kobieta"),
                    new XElement("Imie", "Mulan"),
                    new XElement("Sila", "5"),
                    new XElement("Zdrowie", "17"),
                    new XElement("Nnpku", "Duch cara")
                    ),
                new XElement("Wojownik",
                    new XAttribute("Plec", "Mezczyzna"),
                    new XElement("Imie", "Gerald"),
                    new XElement("Sila", "3"),
                    new XElement("Zdrowie", "10"),
                    new XElement("Nnpku", "Strzyga")
                    )
             );
            xe.Save(fileName);
        }

      
        public void initializeWojownicy()
        {
            wojownicy = new List<Wojownik>();
            wojownicy.Add(new Wojownik()
            {
                Imie = "Herkules",
                Plec = "Mezczyzna",
                Sila = 5,
                Zdrowie = 20,
                Nnpku = "Tytany"
            });
            wojownicy.Add(new Wojownik()
            {
                Imie = "Xena",
                Plec = "Kobieta",
                Sila = 4,
                Zdrowie = 17,
                Nnpku = "Hades"
            });
            wojownicy.Add(new Wojownik()
            {
                Imie = "Legolas",
                Plec = "Mezczyzna",
                Sila = 3,
                Zdrowie = 12,
                Nnpku = "Sauron"
            });
        }
            
            

        private void wczytajListeZPlikuXML(object sender, EventArgs e)
        {
            Wojownicy = XElement.Load(fileName).Elements()
                .Select(x => new Wojownik()
                {
                    Plec = (string)x.Attribute("Plec"),
                    Imie = (string)x.Element("Imie"),
                    Sila = (int)x.Element("Sila"),
                    Zdrowie = (int)x.Element("Zdrowie"),
                    Nnpku = (string)x.Element("Nnpku")
                }
                ).ToList();
            loadDataSources(Wojownicy);
        }

        private void zapiszListeDoPlikuXML(object sender, EventArgs e)
        {
            new XElement(fileName,
                Wojownicy.Select(w => new XElement("Wojownik",
                    new XAttribute("Plec", w.Plec),
                    new XElement("Imie", w.Imie),
                    new XElement("Sila", w.Sila),
                    new XElement("Zdrowie", w.Zdrowie),
                    new XElement("Nnpku", w.Nnpku)
                ))).Save(fileName);
        }

        private void wypelnijPolaWartosciami(object sender, EventArgs e)
        {
            Wojownik w = comboBox1.SelectedItem as Wojownik;
            if (w != null)
            {
                imieTB.Text = w.Imie;
                silaTB.Text = w.Sila.ToString();
                zdrowieTB.Text = w.Zdrowie.ToString();
                plecCB.SelectedItem = w.Plec;
            }
        }

        private void dodajWojownika(object sender, EventArgs e)
        {
            Wojownicy.Add(new Wojownik()
            {
                Imie = imieTB.Text,
                Sila = Int32.Parse(silaTB.Text),
                Zdrowie = Int32.Parse(zdrowieTB.Text),
                Plec = (string)plecCB.SelectedValue,
                Nnpku = "nieokreślony"
            });
            loadDataSources(Wojownicy);
        }

        private void edytujWojownika(object sender, EventArgs e)
        {
            foreach (var w in Wojownicy.Where(w => w == (Wojownik)comboBox1.SelectedValue))
            {
                w.Imie = imieTB.Text;
                w.Sila = Int32.Parse(silaTB.Text);
                w.Zdrowie = Int32.Parse(zdrowieTB.Text);
                w.Plec = (string)plecCB.SelectedValue;
            }
            loadDataSources(Wojownicy);
        }

        private void usunWojownika(object sender, EventArgs e)
        {
            Wojownicy.RemoveAll(w => w == (Wojownik)comboBox1.SelectedValue);
            loadDataSources(Wojownicy);
        }

        private void sortuj(object sender, EventArgs e)
        {
            if (rosnacoRB.Checked)
                Wojownicy = Wojownicy.OrderBy(w => typeof(Wojownik).GetProperty((string)sortowanieCB.SelectedValue).GetValue(w)).ToList();
            
            else
                Wojownicy = Wojownicy.OrderByDescending(w => w.GetType().GetProperty((string)sortowanieCB.SelectedValue).GetValue(w)).ToList();
            
            loadDataSources(Wojownicy);
        }
        private void pokazImionaWszystkich(object sender, EventArgs e)
        {
            XElement xe = getGildia();
            //XElement xe = XElement.Load(fileName);
            var lista = from w in xe.Descendants("Wojownik")
                        .SelectMany(w => w.Descendants("Imie"))
                        select w.Value;

            string ls = "Lista imion:\r\n";
            foreach (var imie in lista)
            {
                ls += imie + "\r\n";
            }
            MessageBox.Show(ls);
        }

        private void pokazODanejPlciSilePowyzej(object sender, EventArgs e)
        {
            XElement xe = getGildia();
            var lista = from w in xe.Descendants("Wojownik")
                        where w.Attribute("Plec").Value == (string)plecCB.SelectedValue
                            && Int32.Parse(w.Descendants("Sila").First().Value) > Int32.Parse(silaTB.Text)
                        select w.Descendants("Imie").First().Value;
            string ls = "Lista imion:\r\n";
            foreach (var imie in lista)
            {
                ls += imie + "\r\n";
            }
            MessageBox.Show(ls);
        }

        private void usunRannych(object sender, EventArgs e)
        {
            XElement xe = getGildia();
            var listaDoUsuniecia = from w in xe.Descendants("Wojownik")
                                   where Int32.Parse(w.Descendants("Zdrowie").First().Value) < Int32.Parse(zdrowieTB.Text)
                                   select w;
            listaDoUsuniecia.Remove();

            // XML -> List<Wojownik>
            Wojownicy = xe.Elements()
               .Select(x => new Wojownik()
               {
                   Plec = (string)x.Attribute("Plec"),
                   Imie = (string)x.Element("Imie"),
                   Sila = (int)x.Element("Sila"),
                   Zdrowie = (int)x.Element("Zdrowie"),
                   Nnpku = (string)x.Element("Nnpku")
               }
               ).ToList();
            loadDataSources(Wojownicy);
        }

        private void dodajWojownikaPoWojownikuOImieniu(object sender, EventArgs e)
        {
            XElement xe = XElement.Load(fileName);
            Wojownik wojownikOImieniu = (comboBox1.SelectedItem as Wojownik);
            XElement nowyWojownik = new XElement("Wojownik",
                    new XAttribute("Plec", (string)plecCB.SelectedValue),
                    new XElement("Imie", imieTB.Text),
                    new XElement("Sila", Int32.Parse(silaTB.Text)),
                    new XElement("Zdrowie", Int32.Parse(zdrowieTB.Text)),
                    new XElement("Nnpku", "nieokreslony")
                );
            xe.Descendants("Wojownik")
                .Where(w => w.Element("Imie").Value == wojownikOImieniu.Imie).First()
                .AddAfterSelf(nowyWojownik);
            // xe.Save("2.xml");

            // XML -> List<Wojownik>
            Wojownicy = xe.Elements()
                .Select(x => new Wojownik()
                {
                    Plec = (string)x.Attribute("Plec"),
                    Imie = (string)x.Element("Imie"),
                    Sila = (int)x.Element("Sila"),
                    Zdrowie = (int)x.Element("Zdrowie"),
                    Nnpku = (string)x.Element("Nnpku")
                }
                ).ToList();
            loadDataSources(Wojownicy);
        }

        public static void ostaniWojownikEventHandler(object sender, XObjectChangeEventArgs cea)
        {
            string tresc = $"Zmiana obiektu typu {sender.GetType().Name}, typ zmiany {cea.ObjectChange.ToString()}";
            MessageBox.Show(tresc);
        }  

        private XElement getGildia()
        {
            return new XElement("Gildia",
                Wojownicy.Select(w => new XElement("Wojownik",
                    new XAttribute("Plec", w.Plec),
                    new XElement("Imie", w.Imie),
                    new XElement("Sila", w.Sila),
                    new XElement("Zdrowie", w.Zdrowie),
                    new XElement("Nnpku", w.Nnpku)
                ))
                );
        }
      
        
    }
}
