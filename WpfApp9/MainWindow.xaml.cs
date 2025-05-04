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

namespace WpfApp9;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int buttonCount = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        buttonCount++;
        Button newButton = new Button
        {
            Content = "Кнопка " + buttonCount,
        };
        Canvas.SetLeft(newButton, e.GetPosition(myCanvas).X);
        Canvas.SetTop(newButton, e.GetPosition(myCanvas).Y);
        myCanvas.Children.Add(newButton);
    }
}