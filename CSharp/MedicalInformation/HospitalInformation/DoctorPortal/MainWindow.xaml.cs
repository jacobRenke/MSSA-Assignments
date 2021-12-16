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

namespace DoctorPortal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient p1;
        public Patient p2;
        public Patient p3;
        public Patient p4;

        public List<Patient> patients = new List<Patient>();

        public List<Patient> Patients { get { return patients; } set { patients = Patients; } }

        public MainWindow()
        {
            InitializeComponent();
            p1 = new Patient();
            p2 = new Patient();
            p3 = new Patient();
            p4 = new Patient();

            patients.Add(p1);
            patients.Add(p2);
            patients.Add(p3);
            patients.Add(p4);

            DataContext = this;
        }

        public class Patient
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public Patient(string name = "John", int age = 42)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
