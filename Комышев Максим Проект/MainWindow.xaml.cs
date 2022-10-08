using EasyCaptcha.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
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

namespace Комышев_Максим_вариант_7 {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            Head.Background = new SolidColorBrush(Color.FromRgb(255, 204, 153));
            EnterBtn.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
            Captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);

        }


        private void EnterBtn_Click(object sender, RoutedEventArgs e) {
            var answ = Captcha.CaptchaText; //проверка правильности введение captcha
            if (answ == Captcha.CaptchaText) {

            } else {
                MessageBox.Show("Вы не прошли проверку");
                
            }
            using (TradeEntities unling = new TradeEntities()) {
                var table = unling.User;
                
                foreach (var item in table) {
                    if (item.UserLogin == Login.Text) {
                        if (item.UserPassword == Password.Password) {
                            MessageBox.Show("you're welcome");


                            if (item.UserRole == 1) {
                                Window1 w = new Window1();
                                MessageBox.Show("Вы вошил как Клиент");
                                w.Show();
                                this.Close();
                            } else if (item.UserRole == 2) {
                                Window2 w = new Window2();
                                MessageBox.Show("Вы вошли как Модератор");
                                w.Show();
                                this.Close();
                            } else if (item.UserRole == 3) {
                                Window3 w = new Window3();
                                MessageBox.Show("Вы вошли как Администратор");
                                w.Show();
                                this.Close();
                            }
                        }

                    } 
                    
                    
                    

                }

                
            }

            
        }
        private void resetbtn_Click(object sender, RoutedEventArgs e) {
            Captcha.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 4);
        }









    }
}
