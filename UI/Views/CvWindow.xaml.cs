using System.Windows;
using LabsVision.UI.ViewModels;

namespace LabsVision.UI.Views;

/// <summary>Floating CV preview window — sets DataContext only, no logic.</summary>
public partial class CvWindow : Window
{
    public CvWindow(CvWindowViewModel vm)
    {
        InitializeComponent();
        DataContext = vm;
    }
}
