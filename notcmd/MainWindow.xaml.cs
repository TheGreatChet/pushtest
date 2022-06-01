using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace notcmd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(MoveToDebug(), UriKind.RelativeOrAbsolute));
        }

        string MoveToDebug()
        {
            string name = "";
            //То шо вытащить путь фотки
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true) name = fileDialog.FileName;

            //System.Diagnostics
            //Открывает cmd, выполняет команду, Env.CurDir юзает текущую папку debug
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C copy /b " + name + " " + Environment.CurrentDirectory + "\\";
            process.Start();

            //Эта хуета заставялет ждать секунду, был баг с тем, что умирал при попытке подряд два изображения выбрать
            Task.Delay(1000).Wait();

            return Environment.CurrentDirectory + "\\" + name.Split('\\').Last();
        }
    }
}
