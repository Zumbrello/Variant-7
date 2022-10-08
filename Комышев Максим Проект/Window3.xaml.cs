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
using System.Windows.Shapes;

namespace Комышев_Максим_вариант_7 {
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window {
        public Window3() {
            InitializeComponent();
            ExitBtn.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
            Head.Background = new SolidColorBrush(Color.FromRgb(255, 204, 153));
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e) {
            var W = new MainWindow();
            this.Close();
            W.Show();
        }
    }
    
}
