using System.Windows.Controls;
using CVCloudApp.UI.ViewModels;

namespace CVCloudApp.UI.Views;

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
