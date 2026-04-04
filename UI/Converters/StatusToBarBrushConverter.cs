using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using CVCloudApp.Core;

namespace CVCloudApp.UI.Converters;

/// <summary>Converts SessionStatus to the 4px left-edge indicator bar color.</summary>
public class StatusToBarBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not SessionStatus status)
            return Brushes.Gray;

        return status switch
        {
            SessionStatus.Idle       => new SolidColorBrush(Color.FromRgb(0x55, 0x55, 0x55)),
            SessionStatus.Connecting => new SolidColorBrush(Color.FromRgb(0x29, 0xB6, 0xF6)),
            SessionStatus.Connected  => new SolidColorBrush(Color.FromRgb(0x00, 0xE5, 0xFF)),
            SessionStatus.Running    => new SolidColorBrush(Color.FromRgb(0x00, 0xE6, 0x76)),
            SessionStatus.Error      => new SolidColorBrush(Color.FromRgb(0xFF, 0x52, 0x52)),
            _                        => Brushes.Gray,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
