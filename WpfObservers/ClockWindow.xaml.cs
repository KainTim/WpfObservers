using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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

using ObserverLib;

namespace WpfObservers;

/// <summary>
/// Interaction logic for ClockWindow.xaml
/// </summary>
public partial class ClockWindow : Window, Observer
{
  public ClockWindow(ClockSubject subject)
  {
    InitializeComponent();
    Subject = subject;
    Subject.Attach(this);
  }
  public ClockSubject Subject { get; }

  internal void UpdateClock()
  {
    Dispatcher.Invoke(() => lblClock.Content = Subject.Time.ToString("HH:mm:ss"));
  }

  private void Window_Closed(object sender, EventArgs e)
  {
    Subject.Detach(this);
  }

  private void btnExit_Click(object sender, RoutedEventArgs e)
  {
    Subject.Detach(this);
    this.Close();
  }

  public void Update() {
    UpdateClock();
  }
}
