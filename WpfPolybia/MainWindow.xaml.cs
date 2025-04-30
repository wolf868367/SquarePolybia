using SquarePolybiaLib;
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

namespace WpfPolybia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PolybiusSquare ps = new PolybiusSquare();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if (rbRu.IsChecked == true)
           {
                if (rbEncrypt.IsChecked == true) lbEncryptor.Content = ps.EncryptRu(tbEncryptor.Text);
                if (rbDecrypt.IsChecked == true) lbEncryptor.Content = ps.DecryptRu(tbEncryptor.Text);
            }
           if (rbEng.IsChecked == true)
           {
                if (rbEncrypt.IsChecked == true) lbEncryptor.Content = ps.Encrypt(tbEncryptor.Text);
                if (rbDecrypt.IsChecked == true) lbEncryptor.Content = ps.Decrypt(tbEncryptor.Text);
            }
        }
    }
}