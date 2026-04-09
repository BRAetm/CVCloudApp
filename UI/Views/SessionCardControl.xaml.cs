using System.Windows.Controls;
using LabsVision.UI.ViewModels;

namespace LabsVision.UI.Views;

/// <summary>Session card UserControl — DataContext set externally, no logic here.</summary>
public partial class SessionCardControl : UserControl
{
    public SessionCardControl()
    {
        InitializeComponent();
    }

    // Delegates to ViewModel — no business logic in code-behind
    private void ScriptCombo_DropDownOpened(object sender, System.EventArgs e)
    {
        if (DataContext is SessionCardViewModel vm)
            vm.RefreshScripts();
    }
}
