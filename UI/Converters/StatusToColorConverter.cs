using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using CVCloudApp.Core;

namespace CVCloudApp.UI.Converters;

/// <summary>Converts a SessionStatus to a background Brush for the status badge.</summary>
public class StatusToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not SessionStatus status)
            return Brushes.Transparent;

        return status switch
        {
            SessionStatus.Idle       => new SolidColorBrush(Color.FromRgb(0x2D, 0x2D, 0x2D)),
            SessionStatus.Connecting => new SolidColorBrush(Color.FromRgb(0x3A, 0x30, 0x00)),
            SessionStatus.Connected  => new SolidColorBrush(Color.FromRgb(0x00, 0x3A, 0x1F)),
            SessionStatus.Running    => new SolidColorBrush(Color.FromRgb(0x00, 0x2B, 0x4A)),
            SessionStatus.Error      => new SolidColorBrush(Color.FromRgb(0x4A, 0x00, 0x00)),
            _                        => Brushes.Transparent,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
