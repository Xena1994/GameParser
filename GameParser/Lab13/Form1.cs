using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Reflection;



namespace Lab13
{
    public partial class Form1 : Form
    {
        private static string fileName = "gildia.xml";
        private List<Wojownik> gildia = new List<Wojownik>();

        public List<Wojownik> Gildia
        {
            get { return gildia; }
            set { gildia = value; }
        }
        private XElement getGildia()
        {
            return new XElement("Gildia",
                Gildia.Select(w => new XElement("Wojownik",
                    new XAttribute("Plec", w.Plec),
                    new XElement("Imie", w.Imie),
                    new XElement("Sila", w.Sila),
                    new XElement("Zdrowie", w.Zdrowie),
                    new XElement("Potwor", w.Potwor)
                ))
                );
        }

        private void loadDataSources(object data)
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = data;
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "Imie";
            comboBox2.DataSource = dataGridView3.DataSource;

        }
        public Form1()
        {
            InitializeComponent();
            DefineXMLDocument();
            initializeWojownicy();
            wczytajZXMLToolStripMenuItem.Click += wczytajListeZPlikuXML;
            zapiszDoXMLToolStripMenuItem.Click += zapiszListeDoPlikuXML;
            plecCB.DataSource = new List<string>() { "Mezczyzna", "Kobieta" };
            Dodaj.Click += dodajWojownika;
            Aktualizuj.Click += edytujWojownika;

            Aktualizuj.BackColor = Color.DarkBlue;
            Aktualizuj.ForeColor = Color.White;

            Usuń.BackColor = Color.Red;
            Usuń.ForeColor = Color.White;

            Usuń.Click += usunWojownika;
            loadDataSources(Gildia);
            dataGridView3.SelectionChanged += wypelnijPolaWartosciami;
            comboBox2.SelectedIndexChanged += wypelnijPolaWartosciami;
            //sortowanie ->7
            sortowanieCB.DisplayMember = "Name";
            sortowanieCB.DataSource = typeof(Wojownik).GetProperties().Select(p => p.Name).ToList();
            sortowanieCB.SelectedIndexChanged += sortuj;
            sortowanieCB.SelectedIndex = 0;
            rosnacoRB.Select();
            rosnacoRB.CheckedChanged += sortuj;
            malejacoRB.CheckedChanged += sortuj;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            sortowanieCB.DropDownStyle = ComboBoxStyle.DropDownList;

            PokazGildieBT.Click += zapiszListeDoPlikuXML;
            PokazGildieBT.Click += pokazImionaWszystkich;

            PlecISilaBT.Click += zapiszListeDoPlikuXML;
            PlecISilaBT.Click += pokazODanejPlciSilePowyzej;

            UsunBT.Click += zapiszListeDoPlikuXML;
            UsunBT.Click += usunRannych;

            DodajBT.Click += zapiszListeDoPlikuXML;
            DodajBT.Click += dodajWojownikaPoWojownikuOImieniu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void DefineXMLDocument()
        {
            XElement xGildia = new XElement("Gildia",
                new XElement("Wojownik",
                    new XAttribute("Plec", "Mezczyzna"),
                    new XElement("Imie", "Legolas"),
                    new XElement("Sila", "7"),
                    new XElement("Zdrowie", "20"),
                    new XElement("Potwor", "Eragon")
                    ),
                new XElement("Wojownik",
                    new XAttribute("Plec", "Kobieta"),
                    new XElement("Imie", "Xena"),
                    new XElement("Sila", "5"),
                    new XElement("Zdrowie", "17"),
                    new XElement("Potwor", "Cerber")
                    ),
                new XElement("Wojownik",
                    new XAttribute("Plec", "Mezczyzna"),
                    new XElement("Imie", "Aragorn"),
                    new XElement("Sila", "3"),
                    new XElement("Zdrowie", "10"),
                    new XElement("Potwor", "Sauron")
                    )
             );
            xGildia.Save(fileName);
        }
        public void initializeWojownicy()
        {
            gildia = new List<Wojownik>();
            gildia.Add(new Wojownik()
            {
                Plec = "Mezczyzna",
                Imie = "Herkules",
                Sila = 3,
                Zdrowie = 10,
                Potwor = "Tytany"
            });
            gildia.Add(new Wojownik()
            {
                Plec = "Mezczyzna",
                Imie = "Meriln",
                Sila = 2,
                Zdrowie = 10,
                Potwor = "Sauron"
            });
            gildia.Add(new Wojownik()
            {
                Plec = "Kobieta",
                Imie = "Mulan",
                Sila = 2,
                Zdrowie = 10,
                Potwor = "Smok"
            });
        }


        private void wczytajListeZPlikuXML(object sender, EventArgs e)
        {
            Gildia = XElement.Load(fileName).Elements()
                .Select(x => new Wojownik()
                {
                    Plec = (string)x.Attribute("Plec"),
                    Imie = (string)x.Element("Imie"),
                    Sila = (int)x.Element("Sila"),
                    Zdrowie = (int)x.Element("Zdrowie"),
                    Potwor = (string)x.Element("Potwor")
                }
                ).ToList();
            loadDataSources(Gildia);
        }
        private void zapiszListeDoPlikuXML(object sender, EventArgs e)
        {
            new XElement(fileName,
                Gildia.Select(w => new XElement("Wojownik",
                    new XAttribute("Plec", w.Plec),
                    new XElement("Imie", w.Imie),
                    new XElement("Sila", w.Sila),
                    new XElement("Zdrowie", w.Zdrowie),
                    new XElement("Potwor", w.Potwor)
                ))).Save(fileName);
        }
        private void dodajWojownika(object sender, EventArgs e)
        {
            if (Gildia.Any(el => el.Imie == imieTB.Text))
            {
                MessageBox.Show($"W gildii istnieje wojownik o takim imieniu {imieTB.Text}!");
            }
            else
            {
                Gildia.Add(new Wojownik()
                {
                    Imie = imieTB.Text,
                    Sila = int.Parse(silaTB.Text),
                    Zdrowie = int.Parse(zdrowieTB.Text),
                    Plec = (string)plecCB.SelectedValue,
                    Potwor = potworTB.Text
                });
                loadDataSources(Gildia);
            }
        }

        private void edytujWojownika(object sender, EventArgs e)
        {
            Wojownik wojownik = (Wojownik)comboBox2.SelectedItem;
            wojownik.Imie = imieTB.Text;
            wojownik.Sila = int.Parse(silaTB.Text);
            wojownik.Zdrowie = int.Parse(zdrowieTB.Text);
            wojownik.Plec = (string)plecCB.SelectedValue;
            wojownik.Potwor = potworTB.Text;
            loadDataSources(Gildia);
        }

        private void usunWojownika(object sender, EventArgs e)
        {
            Gildia.Remove((Wojownik)comboBox2.SelectedValue);
            loadDataSources(Gildia);
        }

        private void wypelnijPolaWartosciami(object sender, EventArgs e)
        {
            Wojownik w = comboBox2.SelectedItem as Wojownik;
            if (w != null)
            {
                imieTB.Text = w.Imie;
                silaTB.Text = w.Sila.ToString();
                zdrowieTB.Text = w.Zdrowie.ToString();
                plecCB.SelectedItem = w.Plec;
                potworTB.Text = w.Potwor;
            }
        }

        private void sortuj(object sender, EventArgs e)
        {
            if (rosnacoRB.Checked)
                Gildia = Gildia.OrderBy(w => typeof(Wojownik).GetProperty((string)sortowanieCB.SelectedValue).GetValue(w)).ToList();

            else
                Gildia = Gildia.OrderByDescending(w => w.GetType().GetProperty((string)sortowanieCB.SelectedValue).GetValue(w)).ToList();

            loadDataSources(Gildia);
        }

        private void pokazImionaWszystkich(object sender, EventArgs e)
        {
            var plik = XElement.Load("gildia.xml");
            var imiona = plik.Descendants("Imie").Select(el => el.Value).ToList();
            string temp = "";
            foreach (string x in imiona)
                temp += x + "\n";
            MessageBox.Show(temp);
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
           Gildia = xe.Elements()
               .Select(x => new Wojownik()
               {
                   Plec = (string)x.Attribute("Plec"),
                   Imie = (string)x.Element("Imie"),
                   Sila = (int)x.Element("Sila"),
                   Zdrowie = (int)x.Element("Zdrowie"),
                   Potwor = (string)x.Element("Potwor")
               }
               ).ToList();
            loadDataSources(Gildia);
        }
        private void dodajWojownikaPoWojownikuOImieniu(object sender, EventArgs e)
        {
            XElement xe = XElement.Load(fileName);
            xe.Changed += (obj, args) => MessageBox.Show("Dodaję nowego wojownika po wzkazanym wojowniku!");
            Wojownik wojownikOImieniu = (comboBox2.SelectedItem as Wojownik);
            XElement nowyWojownik = new XElement("Wojownik",
                    new XAttribute("Plec", (string)plecCB.SelectedValue),
                    new XElement("Imie", imieTB.Text),
                    new XElement("Sila", Int32.Parse(silaTB.Text)),
                    new XElement("Zdrowie", Int32.Parse(zdrowieTB.Text)),
                    new XElement("Potwor", potworTB.Text)
                );
            if (Gildia.Any(el => el.Imie == nowyWojownik.Element("Imie").Value))
            {
                MessageBox.Show("W gildii istnieje wojownik o takim imieniu!");
            }
            else
            {
                xe.Descendants("Wojownik")
                    .Where(w => w.Element("Imie").Value == wojownikOImieniu.Imie).First()
                    .AddAfterSelf(nowyWojownik);


                // XML -> List<Wojownik>
                /*   Gildia = xe.Elements()
                       .Select(x => new Wojownik()
                       {
                           Plec = (string)x.Attribute("Plec"),
                           Imie = (string)x.Element("Imie"),
                           Sila = (int)x.Element("Sila"),
                           Zdrowie = (int)x.Element("Zdrowie"),
                           Potwor = (string)x.Element("Potwor")
                       }
                       ).ToList();*/
                ((CurrencyManager)BindingContext[Gildia]).Refresh();
                loadDataSources(Gildia);
            }
        }


    }
}
      

