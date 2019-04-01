using System;
using System.IO;
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

namespace TotalCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Files
    {
        public Files()
        {
            
        }
        public void GettingFiles()
        {
            //creating a DirectoryInfo object
            DirectoryInfo mydir = new DirectoryInfo(@"C:\");
      

            // getting the files in the directory, their names and size
            FileInfo[] f = mydir.GetFiles();
            
        }
        public void GettingFiles1()
        {
            //creating a DirectoryInfo object
            
            DirectoryInfo mydir1 = new DirectoryInfo(@"D:\");

            // getting the files in the directory, their names and size
            
            FileInfo[] f1 = mydir1.GetFiles();
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
