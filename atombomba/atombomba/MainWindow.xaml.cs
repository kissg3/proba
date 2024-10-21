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

namespace atombomba
{public Random fok = new Random();
             public  int fok1 = fok.Next(40, 100);
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            
            

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Random energy= new Random();
            
            if (indule.Content=="")
            {
            indule.Content += "elindult";
               
            hofok.Content += Convert.ToString(fok1)+"Celsius";
                int energy1 = energy.Next(0,20);
                energia.Content += Convert.ToString(energy1)+"GW";

            }
           
        }

        private void hut_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < fok1; i++)
            {

            }
        }
    }
}
