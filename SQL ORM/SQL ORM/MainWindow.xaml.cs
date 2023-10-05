using System.Windows;

namespace SQL_ORM;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public object ActiveViewModel { get; set; }
    public MainWindow()
    {
        InitializeComponent();
    }
}
