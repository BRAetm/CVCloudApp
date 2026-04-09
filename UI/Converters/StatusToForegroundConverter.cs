using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using LabsVision.Core;

namespace LabsVision.UI.Converters;

/// <summary>Converts a SessionStatus to a foreground Brush for the status badge text.</summary>
public class StatusToForegroundConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not SessionStatus status)
            return Brushes.White;

        return status switch
        {
            SessionStatus.Idle       => new SolidColorBrush(Color.FromRgb(0xAA, 0xAA, 0xAA)),
            SessionStatus.Connecting => new SolidColorBrush(Color.FromRgb(0xFF, 0xD7, 0x00)),
            SessionStatus.Connected  => new SolidColorBrush(Color.FromRgb(0x00, 0xE6, 0x76)),
            SessionStatus.Running    => new SolidColorBrush(Color.FromRgb(0x29, 0xB6, 0xF6)),
            SessionStatus.Error      => new SolidColorBrush(Color.FromRgb(0xFF, 0x52, 0x52)),
            _                        => Brushes.White,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
