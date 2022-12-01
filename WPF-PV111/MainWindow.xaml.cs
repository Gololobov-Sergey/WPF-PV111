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

namespace WPF_PV111
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool move = true;
        public MainWindow()
        {
            InitializeComponent();

            //var button1 = new Button { Content = "1", Width = 100};
            //var button2 = new Button { Content = "2", Width = 100 };
            //var button3 = new Button { Content = "3", Width = 100 };
            //var button4 = new Button { Content = "4", Width = 100 };
            //var button5 = new Button { Content = "5", Width = 100 };

            //var wp= new WrapPanel { Orientation=Orientation.Horizontal };
            //wp.Children.Add(button1);
            //wp.Children.Add(button2);
            //wp.Children.Add(button3);
            //wp.Children.Add(button4);
            //wp.Children.Add(button5);

            //var grid = new Grid();
            //grid.Children.Add(wp);

            //this.Content= grid;


            //var txt = new TextBox { Width = 150 };
            //var lab = new Label { Content = "_Name", Target = txt };
            //var grid = new Grid();
            //grid.Children.Add(txt);
            //grid.Children.Add(lab);
            //this.Content = grid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var b = (Button)sender;
            b.FontSize = 20;
            b.Content = move ? "X" : "0";
            move = !move;
            b.IsEnabled = false;
        }

        //private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        //{

        //    LeftPanel.Visibility = (Width > 500) ? Visibility.Visible : Visibility.Collapsed;

        //}

        //private void _MouseDown(object sender, MouseButtonEventArgs e)
        //{
            
        //    txt1.Text = txt1.Text + " sender: " + sender.ToString() +"\n";
        //    txt1.Text += "source: " + e.Source.ToString()+ "\n\n";
        //}

        //private void RepeatButton_Click(object sender, RoutedEventArgs e)
        //{
        //    txt1.Text += "D";
        //}

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            txtBlock.Text += e.Key.ToString();

            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyboardDevice.Modifiers & ModifierKeys.Control) == ModifierKeys.Control &&
                (e.KeyboardDevice.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt &&
                e.Key == Key.P)
            {
                MessageBox.Show("Print");
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtBlock.Text += e.ChangedButton.ToString();
            //if(e.ChangedButton == MouseButton.XButton1)
            //{
            //    MessageBox.Show("X1");
            //}
        }
    }
}
