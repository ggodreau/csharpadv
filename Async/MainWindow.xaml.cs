using System;
using System.IO;
using System.Net;
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

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var sr = new StreamWriter("C:\\Users\\user\\Documents\\udemy\\csharpadv\\out.txt"))
            {
                sr.Write(html);
            }
        }

        private void myButt_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml("http://msdn.microsoft.com");
            Console.WriteLine("clicked my butt!");
            myLabel.Content = "finished downloading!";
        }
    }
}
