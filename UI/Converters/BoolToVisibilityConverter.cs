using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LabsVision.UI.Converters;

/// <summary>Converts bool to Visibility. Pass parameter="Invert" to flip the mapping.</summary>
public class BoolToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool flag = value switch
        {
            bool b   => b,
            int i    => i != 0,
            string s => !string.IsNullOrEmpty(s),
            null     => false,
            _        => true,
        };
        if (parameter is string p && p == "Invert") flag = !flag;
        return flag ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        value is Visibility v && v == Visibility.Visible;
}
