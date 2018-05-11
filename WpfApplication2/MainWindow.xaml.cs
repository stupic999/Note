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

namespace WpfApplication2
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Save();          
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            Open();
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to Save?", "Save or Not", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Save();
            }
            else
            {
                Textarea.Text = "";
            }
        }

        // 储存文件
        void Save()
        {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

                Nullable<bool> result = dlg.ShowDialog();

                if (result == true)
                {
                    System.IO.File.WriteAllText(dlg.FileName, Textarea.Text);
                }
        }

        // 打开文件
        void Open()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                Textarea.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void SaveAsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
