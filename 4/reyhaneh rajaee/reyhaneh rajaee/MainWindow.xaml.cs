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

namespace reyhaneh_rajaee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int x = 5;
            int y = 4;
            int m, z, w, t;
            m = (y * 2) / 6;
           
            w = x + m;
            t = w + z;


            Console.WriteLine(t);
            Console.Read();
        
        }
    }
}
