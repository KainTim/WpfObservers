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

namespace WpfObservers;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

  private void btnAddClock_Click(object sender, RoutedEventArgs e)
  {
    
    new Window.Show();
  }

  private void btnStartTimer_Click(object sender, RoutedEventArgs e)
  {

  }
}
