using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace Laboratorium9
{


    public class Student
    {
        private string imie, nazwisko, wydzial;
        private int nrindeksu;





        public string Imie
        {
            get => imie;
            set => imie = value;
        }

        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = value;
        }

        public int Nrindeksu
        {
            get => nrindeksu;
            set => nrindeksu = value;
        }

        public string Wydzial
        {
            get => wydzial;
            set => wydzial = value;
        }


        Student(string _im, string _naz, int _nr, string _wydz)
        {
            imie = _im;
            nazwisko = _naz;
            nrindeksu = _nr;
            wydzial = _wydz;
        }

        public Student()
        {
            imie = "";
            nazwisko = "";
            nrindeksu = 0;
            wydzial = "";
        }

       



    }
    public partial class MainWindow : Window
    {

        public List<Student> lista { get; set; }

        public MainWindow()
        {
            lista = new List<Student>()
            {
                new Student(){Imie="Marcin", Nazwisko="Kuchenka", Nrindeksu=662485, Wydzial="WIMiI"}

            };


            InitializeComponent();

            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Imie", Binding = new Binding("Imie") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("Nazwisko") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Nrindeksu", Binding = new Binding("Nrindeksu") });
            Tabela.Columns.Add(new DataGridTextColumn() { Header = "Wydzial", Binding = new Binding("Wydzial") });

            Tabela.AutoGenerateColumns = false;
            Tabela.ItemsSource = lista;

        }

        private void DodajB_Click(object sender, RoutedEventArgs e)
        {
            var dodawanie = new OknoStudent();
            if (dodawanie.ShowDialog() == true)
            {
                lista.Add(dodawanie.student);
                Tabela.Items.Refresh();
            }
        }

        private void UsunB_Click(object sender, RoutedEventArgs e)
        {
            if (Tabela.SelectedItem is Student)
            {
                lista.Remove((Student)Tabela.SelectedItem);
            }
            Tabela.Items.Refresh();
        }

        private void ZapiszB_Click(object sender, RoutedEventArgs e)
        {


            // var nazwa = @"sciezka do pliku";
            // nazwa można dać zamiast data.txt


            /*
            FileStream zapis = new FileStream("data.txt", FileMode.Create);
            
            StreamWriter plik = new StreamWriter(zapis);
            
            for (int i = 0; i < lista.Count; i++)
            {
                plik.WriteLine("[[Student]]");
                plik.WriteLine("[Imie]");
                plik.WriteLine(lista[i].Imie);
                plik.WriteLine("[Nazwisko]");
                plik.WriteLine(lista[i].Nazwisko);
                plik.WriteLine("[NrIndeksu]");
                plik.WriteLine(lista[i].Nrindeksu);
                plik.WriteLine("[Wydzial]");
                plik.WriteLine(lista[i].Wydzial);
                plik.WriteLine("[[]]");
            }

            plik.Close();
            
           //zad4
           for (int i = 0; i < lista.Count; i++)
           {
               Save(lista[i], plik);
           }
           plik.Close();

            */
            //Domowe
            var sciezka = new SaveFileDialog();
            sciezka.InitialDirectory = Directory.GetCurrentDirectory();
            sciezka.Filter = "txt files (*.txt)|*.txt";
            sciezka.ShowDialog();

            if (sciezka.FileName != "")
            {
                FileStream zapis = new FileStream(sciezka.FileName, FileMode.Create);
                StreamWriter plik = new StreamWriter(zapis);

                try
                {
                    foreach (var a in lista)
                    {
                        Save(a, plik);
                    }
                    MessageBox.Show("Zapisano");
                }
                catch (Exception b)
                {
                    MessageBox.Show($"Wystapil blad {sciezka.FileName}\n\n{b.Message}");
                }
                plik.Close();
            }


        }

        private void WczytajB_Click(object sender, RoutedEventArgs e)
        {
            /*
            // var nazwa = @"sciezka do pliku";
            // nazwa można dać zamiast data.txt
            FileStream wczytaj = new FileStream("data.txt", FileMode.Open);
            StreamReader plik = new StreamReader(wczytaj);
            
            Student student = null;
            while (!plik.EndOfStream)
            {
                var ln = plik.ReadLine();
                if (ln == "[[Student]]")
                {
                    student = new Student();
                }
                else if (ln == "[Imie]")
                {
                    ln = plik.ReadLine();
                    student.Imie = ln;
                }
                else if (ln == "[Nazwisko]")
                {
                    ln = plik.ReadLine();
                    student.Nazwisko = ln;
                }
                else if (ln == "[NrIndeksu]")
                {
                    ln = plik.ReadLine();
                    student.Nrindeksu = int.Parse(ln);
                }
                else if (ln == "[Wydzial]")
                {
                    ln = plik.ReadLine();
                    student.Wydzial = ln;
                }
                else
                {
                    lista.Add(student);
                    Tabela.Items.Refresh();
                }
            }
            
            //zad4
            while (!plik.EndOfStream)
            {
                lista.Add(Load<Student>(plik));
                Tabela.Items.Refresh();
            }
            plik.Close();
            */

            var sciezka = new OpenFileDialog();
            sciezka.InitialDirectory = Directory.GetCurrentDirectory();
            sciezka.Filter = "txt files (*.txt)|*.txt";
            sciezka.ShowDialog();
            if (File.Exists(sciezka.FileName))
            {
                FileStream wczytaj = new FileStream(sciezka.FileName, FileMode.Open);
                StreamReader plik = new StreamReader(wczytaj);
                try
                {
                    while (!plik.EndOfStream)
                    {
                        Student newStudent = Load<Student>(plik);

                        bool contains = false;
                        lista.ForEach(a => { if (a.Nrindeksu == newStudent.Nrindeksu) { contains = true; } });
                        if (!contains)
                        {
                            lista.Add(newStudent);
                        }
                    }

                    Tabela.Items.Refresh();
                    MessageBox.Show("Wczytano pomyślnie");
                }
                catch (Exception b)
                {
                    MessageBox.Show($"Błąd odczytu {sciezka.FileName}\n\n{b.Message}");
                }
                plik.Close();
            }




        }


        private void Save<T>(T objekt, StreamWriter plik)
            {
                Type t = objekt.GetType();
                plik.WriteLine($"[[{t.FullName}]]");
                foreach (var p in t.GetProperties())
                {
                    plik.WriteLine($"[{p.Name}]");
                    plik.WriteLine(p.GetValue(objekt));
                }
                plik.WriteLine($"[[]]");
            }


            T Load<T>(StreamReader plik) where T : new()
            {
                T ob = default(T);
                Type tab = null;
                PropertyInfo property = null;
                while (!plik.EndOfStream)
                {
                    var ln = plik.ReadLine();
                    if (ln == "[[]]")
                    { return ob; }
                    else if (ln.StartsWith("[["))
                    {
                        tab = Type.GetType(ln.Trim('[', ']'));
                        if (typeof(T).IsAssignableFrom(tab))
                            ob = (T)Activator.CreateInstance(tab);
                    }
                    else if (ln.StartsWith("[") && ob != null)
                        property = tab.GetProperty(ln.Trim('[', ']'));
                    else if (ob != null && property != null)
                        property.SetValue(ob, Convert.ChangeType(ln, property.PropertyType));
                }
                return default(T);
            }


        private void ZapiszXMLB_Click(object sender, RoutedEventArgs e)
        {
            /*
            FileStream sciezka = new FileStream("./data.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
            xml.Serialize(sciezka, lista);
            sciezka.Close();
            */

            var sciezka = new SaveFileDialog();
            sciezka.InitialDirectory = Directory.GetCurrentDirectory();
            sciezka.Filter = "xml files (*.xml)|*.xml";
            sciezka.ShowDialog();

            if (sciezka.FileName != "")
            {
                FileStream plik = new FileStream(sciezka.FileName, FileMode.Create);
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                    xml.Serialize(plik, lista);
                    MessageBox.Show("Zapisano pomyślnie");
                }
                catch (Exception b)
                {
                    MessageBox.Show($"Błąd zapisu {sciezka.FileName}\n\n{b.Message}");
                }
                plik.Close();
            }


        }

        private void WczytajXMLB_Click(object sender, RoutedEventArgs e)
        {
            var sciezka = new OpenFileDialog();
            sciezka.InitialDirectory = Directory.GetCurrentDirectory();
            sciezka.Filter = "xml files (*.xml)|*.xml";
            sciezka.ShowDialog();
            if (File.Exists(sciezka.FileName))
            {
                FileStream plik = new FileStream(sciezka.FileName, FileMode.Open);
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                    List<Student> newList = (List<Student>)xml.Deserialize(plik);
                    lista.Clear();
                    lista.AddRange(newList);
                    Tabela.Items.Refresh();

                    MessageBox.Show("Wczytano plik");
                }
                catch (Exception exc)
                {
                    MessageBox.Show($"Wystapil blad {sciezka.FileName}\n\n{exc.Message}");
                }
                plik.Close();
            }
        }



    }
}
