using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace random_file
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int luku = System.Int32.Parse(textBox1.Text);
            byte[] array = new byte[1*1024*luku];
            Random random = new Random();
            random.NextBytes(array);
            textBox2.Text = ByteArrayToString(array);

        }
        public static string ByteArrayToString(byte[] ba)
        {
            //string hex = BitConverter.ToString(ba);
            //return hex.Replace("-", "");

            StringBuilder sb = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }
    }
}
