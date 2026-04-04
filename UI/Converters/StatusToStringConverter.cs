using System;
using System.Globalization;
using System.Windows.Data;
using CVCloudApp.Core;

namespace CVCloudApp.UI.Converters;

/// <summary>Converts a SessionStatus to a human-readable display label.</summary>
public class StatusToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not SessionStatus status)
            return string.Empty;

        return status switch
        {
            SessionStatus.Idle       => "Idle",
            SessionStatus.Connecting => "Connecting…",
            SessionStatus.Connected  => "Connected",
            SessionStatus.Running    => "Running",
            SessionStatus.Error      => "Error",
            _                        => string.Empty,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
