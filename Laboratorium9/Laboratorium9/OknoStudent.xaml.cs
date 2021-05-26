using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laboratorium9
{

    public partial class OknoStudent : Window
    {

        public Student student;


        public OknoStudent(Student student = null)
        {

            InitializeComponent();

            if (student != null)
            {
                ImieT.Text = student.Imie;
                NazwiskoT.Text = student.Nazwisko;
                NrT.Text = student.Nrindeksu.ToString();
                WydzialT.Text = student.Wydzial;
            }
            this.student = student ?? new Student();
        }

        private void PotwierdzenieB_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(ImieT.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(NazwiskoT.Text, @"^\p{Lu}\p{Ll}{1,30}$") ||
                !Regex.IsMatch(WydzialT.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(NrT.Text, @"^[0-9]{4,10}$"))
            {
                MessageBox.Show("Podano zle dane");
                return;
            }
            student.Imie = ImieT.Text;
            student.Nazwisko = NazwiskoT.Text;
            student.Nrindeksu = int.Parse(NrT.Text);
            student.Wydzial = WydzialT.Text;
            this.DialogResult = true;
        }
    }
}
