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

namespace Gugudan;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        GenerateGugudan();
    }

    private void GenerateGugudan()
    {
        StringBuilder gugudanText = new StringBuilder();
        for (int i = 2; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                gugudanText.AppendLine($"{i} x {j} = {i * j}");
            }
            gugudanText.AppendLine();
        }
        GugudanTextBlock.Text = gugudanText.ToString();
    }
}