using System;
using System.Collections.Generic;
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
using System.IO;
using System.Collections.ObjectModel;

namespace Magyar_Tavak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCombobox1();
            LoadCombobox2();
        }
        public void LoadCombobox1()
        {
            StreamReader sr = new("telepulesgps.txt");
            string sor = sr.ReadLine();
            List<string> telepulesek = new List<string>();
            List<string> lenght = new List<string>();
            List<string> widht = new List<string>();
            string[] sor2 = sor.Split("\t");
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                sor2 = sor.Split("\t");
                telepulesek.Add(sor2[1]);
                lenght.Add(sor2[2]);
                widht.Add(sor2[3]);
            }
            sr.Close();
            telepulesek.Sort();
            foreach (var item in telepulesek)
            {
                Telepulesek.Items.Add(item);
            }
        }
        public void LoadCombobox2()
        {
            StreamReader sr = new("alloviz.txt");
            string sor = sr.ReadLine();
            List<string> name = new List<string>();
            List<string> type = new List<string>();
            List<string> area = new List<string>();
            List<string> watercollector = new List<string>();
            string[] sor2 = sor.Split("\t");
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                sor2 = sor.Split("\t");
                name.Add(sor2[1]);
                type.Add(sor2[2]);
                area.Add(sor2[3]);
                watercollector.Add(sor2[4]);
            }
            sr.Close();
            name.Sort();
            foreach (var item in name)
            {
                Tavak.Items.Add(item);
            }
        }
    }
}
